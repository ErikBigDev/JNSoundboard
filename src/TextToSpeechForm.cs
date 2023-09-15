﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;
using static JNSoundboard.AddEditHotkeyForm;

namespace JNSoundboard
{
    public partial class TextToSpeechForm : Form
    {
        MainForm mainForm;
        SpeechSynthesizer synth;

        public TextToSpeechForm()
        {
            InitializeComponent();
        }

        private void TTS_Load(object sender, EventArgs e)
        {
            mainForm = Application.OpenForms[0] as MainForm;
        }

        private void btnBrowseFolderLoc_Click(object sender, EventArgs e)
        {
            var diag = new FolderBrowserDialog();

            if (diag.ShowDialog() == DialogResult.OK)
            {
                tbWhereSave.Text = diag.SelectedPath;
            }
        }

        private void btnCreateWAV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbText.Text) && !string.IsNullOrWhiteSpace(tbWhereSave.Text) && Directory.Exists(tbWhereSave.Text))
            {
                string path = tbWhereSave.Text + "\\" + Helper.cleanFileName(tbText.Text.Replace(" ", "") + ".wav");

                synth = new SpeechSynthesizer();
                synth.SetOutputToWaveFile(path);

                PromptBuilder builder = new PromptBuilder();
                builder.AppendText(tbText.Text);

                synth.Speak(builder);

                synth.Dispose();
                synth = null;

                MessageBox.Show("File saved to " + path);
            }
            else
            {
                MessageBox.Show("No text in text box and/or where to save box... or the where to save folder does not exist");
            }
        }

        private void btnCreateWAVAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbText.Text) && !string.IsNullOrWhiteSpace(tbKeys.Text) && !string.IsNullOrWhiteSpace(tbWhereSave.Text) && Directory.Exists(tbWhereSave.Text))
            {
                Keys[] convertedKeys;
                string error;

                if (Helper.keysArrayFromString(tbKeys.Text, out convertedKeys, out error))
                {
                    if (convertedKeys.Length > 0)
                    {
                        var newSH = new XMLSettings.SoundHotkey(convertedKeys, "", new string[] { tbWhereSave.Text + "\\" + Helper.cleanFileName(tbText.Text.Replace(" ", "") + ".wav") });

                        synth = new SpeechSynthesizer();
                        synth.SetOutputToWaveFile(newSH.SoundLocations[0]);

                        PromptBuilder builder = new PromptBuilder();
                        builder.AppendText(tbText.Text);

                        synth.Speak(builder);

                        synth.Dispose();
                        synth = null;

                        mainForm.soundHotkeys.Add(newSH);

                        var newItem = new ListViewItem(tbKeys.Text);
                        newItem.SubItems.Add(""); //window title
                        newItem.SubItems.Add(newSH.SoundLocations[0]);

                        mainForm.lvKeySounds.Items.Add(newItem);

                        mainForm.lvKeySounds.ListViewItemSorter = new ListViewItemComparer(0);
                        mainForm.lvKeySounds.Sort();

                        mainForm.soundHotkeys.Sort(delegate (XMLSettings.SoundHotkey x, XMLSettings.SoundHotkey y)
                        {
                            if (x.Keys == null && y.Keys == null) return 0;
                            else if (x.Keys == null) return -1;
                            else if (y.Keys == null) return 1;
                            else return Helper.keysToString(x.Keys).CompareTo(Helper.keysToString(y.Keys));
                        });

                        MessageBox.Show("File saved to " + newSH.SoundLocations[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Keys string incorrectly made. Check for spelling errors");
                }
            }
            else
            {
                MessageBox.Show("No text in text box, keys box, and/or where to save box... or the where to save folder does not exist");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbKeys_Enter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void tbKeys_Leave(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        int lastAmountPressed = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int amountPressed = 0;

            if (Keyboard.IsKeyDown(Keys.Escape))
            {
                lastAmountPressed = 50;

                tbKeys.Text = "";
            }
            else
            {
                var pressedKeys = new List<Keys>();

                foreach (Keys key in Enum.GetValues(typeof(Keys)))
                {
                    if (Keyboard.IsKeyDown(key))
                    {
                        amountPressed++;
                        pressedKeys.Add(key);
                    }
                }

                if (amountPressed > lastAmountPressed)
                {
                    tbKeys.Text = Helper.keysToString(pressedKeys.ToArray());
                }

                lastAmountPressed = amountPressed;
            }
        }
    }
}
