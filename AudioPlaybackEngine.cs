using System;
using System.Collections.Generic;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace JNSoundboard
{
	class AudioPlaybackEngine : IDisposable
	{
		public static readonly AudioPlaybackEngine Instance = new AudioPlaybackEngine(44100, 2);

		private WaveOutEvent virtualDevice;
		private WaveOutEvent localDevice;
		private readonly MixingSampleProvider virtualMixer;
		private readonly MixingSampleProvider localMixer;
		private IDictionary<string, CachedSound> cachedSounds = new Dictionary<string, CachedSound>();
		
		public float Volume
		{
			get { return virtualDevice != null ? virtualDevice.Volume : 0; }
			set { if(virtualDevice != null)
					virtualDevice.Volume = value;
				if(localDevice != null)
					localDevice.Volume = value;
				}
		}

		public AudioPlaybackEngine(int sampleRate = 44100, int channelCount = 2)
		{
			virtualMixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channelCount));
			virtualMixer.ReadFully = true;
			virtualMixer.MixerInputEnded += OnMixerInputEnded;

			localMixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channelCount));
			localMixer.ReadFully = true;
		}

		public event EventHandler AllInputEnded;

		private void OnMixerInputEnded(object sender, SampleProviderEventArgs e)
		{
			// check if there are any inputs left
			// OnMixerInputEnded gets invoked before the corresponding source is removed from the List so there should be exactly one source left
			if (virtualMixer.MixerInputs.Count() == 1)
			{
				AllInputEnded?.Invoke(this, EventArgs.Empty);
			}
		}

		public void Init(int localDeviceNumber, int virtualDeviceNumber)
		{
			if (virtualDevice != null) virtualDevice.Dispose();

			var output = new WaveOutEvent();
			output.DeviceNumber = virtualDeviceNumber;
			output.Init(virtualMixer);
			output.Play();

			virtualDevice = output;
			

			if (localDevice != null) localDevice.Dispose();

			output = new WaveOutEvent();
			output.DeviceNumber = localDeviceNumber;
			output.Init(localMixer);
			output.Play();
			
			localDevice = output;
		}

		public void PlaySoundVirtual(string fileName)
		{
			var input = new AudioFileReader(fileName);
			
			CachedSound cachedSound = null;

			if (!cachedSounds.TryGetValue(fileName, out cachedSound))
			{
				cachedSound = new CachedSound(fileName);
				cachedSounds.Add(fileName, cachedSound);
			}

			PlaySound(cachedSound, virtualMixer);
		}

		public void PlaySoundLocal(string fileName)
		{
			var input = new AudioFileReader(fileName);

			CachedSound cachedSound = null;

			if (!cachedSounds.TryGetValue(fileName, out cachedSound))
			{
				cachedSound = new CachedSound(fileName);
				cachedSounds.Add(fileName, cachedSound);
			}

			PlaySound(cachedSound, localMixer);
		}

		public void PlaySound(CachedSound sound, MixingSampleProvider mixingProvider)
		{
			AddMixerInput(new CachedSoundSampleProvider(sound), mixingProvider);
		}

		public void StopAllSounds()
		{
			virtualMixer.RemoveAllMixerInputs();
			localMixer.RemoveAllMixerInputs();
		}

		private ISampleProvider ConvertToRightChannelCount(ISampleProvider input)
		{
			if (input.WaveFormat.Channels == virtualMixer.WaveFormat.Channels)
			{
				return input;
			}

			if (input.WaveFormat.Channels == 1 && virtualMixer.WaveFormat.Channels == 2)
			{
				return new MonoToStereoSampleProvider(input);
			}

			throw new NotImplementedException("Not yet implemented this channel count conversion");
		}

		private void AddMixerInput(ISampleProvider input, MixingSampleProvider mixingProvider)
		{
			var resampled = new WdlResamplingSampleProvider(input, virtualMixer.WaveFormat.SampleRate);
			mixingProvider.AddMixerInput(ConvertToRightChannelCount(resampled));
		}

		public void Dispose()
		{
			if (virtualDevice != null)
			{
				virtualDevice.Dispose();
				virtualDevice = null;
			}
			if (localDevice != null)
			{
				localDevice.Dispose();
				localDevice = null;
			}
		}
	}
}
