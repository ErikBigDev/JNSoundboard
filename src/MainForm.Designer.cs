namespace JNSoundboard
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            cbPlaybackDevices = new ComboBox();
            cbEnable = new CheckBox();
            mainTimer = new System.Windows.Forms.Timer(components);
            btnSave = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lvKeySounds = new ListView();
            chKeys = new ColumnHeader();
            chWindow = new ColumnHeader();
            chSoundLoc = new ColumnHeader();
            btnLoad = new Button();
            btnReloadDevices = new Button();
            btnClear = new Button();
            btnSaveAs = new Button();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            texttospeechToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdateToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            cbLoopbackDevices = new ComboBox();
            btnPlaySelectedSound = new Button();
            btnStopAllSounds = new Button();
            notifyIcon1 = new NotifyIcon(components);
            gbPushToTalk = new GroupBox();
            btnReloadWindows = new Button();
            cbEnablePushToTalk = new CheckBox();
            cbWindows = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            tbPushToTalkKey = new TextBox();
            cbAudioDevices = new GroupBox();
            cbEnableVirtual = new CheckBox();
            cbEnableLocal = new CheckBox();
            label5 = new Label();
            cbPlaybackDevicesLocal = new ComboBox();
            pushToTalkKeyTimer = new System.Windows.Forms.Timer(components);
            volumeBar = new TrackBar();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            gbPushToTalk.SuspendLayout();
            cbAudioDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(7, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Virtual Playback";
            // 
            // cbPlaybackDevices
            // 
            cbPlaybackDevices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbPlaybackDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlaybackDevices.FormattingEnabled = true;
            cbPlaybackDevices.Location = new Point(110, 46);
            cbPlaybackDevices.Margin = new Padding(4, 3, 4, 3);
            cbPlaybackDevices.Name = "cbPlaybackDevices";
            cbPlaybackDevices.Size = new Size(279, 23);
            cbPlaybackDevices.TabIndex = 10;
            // 
            // cbEnable
            // 
            cbEnable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbEnable.AutoSize = true;
            cbEnable.Location = new Point(678, 396);
            cbEnable.Margin = new Padding(4, 3, 4, 3);
            cbEnable.Name = "cbEnable";
            cbEnable.Size = new Size(105, 19);
            cbEnable.TabIndex = 17;
            cbEnable.Text = "Enable hotkeys";
            cbEnable.UseVisualStyleBackColor = true;
            cbEnable.CheckedChanged += cbEnable_CheckedChanged;
            // 
            // mainTimer
            // 
            mainTimer.Interval = 50;
            mainTimer.Tick += mainTimer_Tick;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Location = new Point(190, 388);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 27);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.Location = new Point(699, 144);
            btnRemove.Margin = new Padding(4, 3, 4, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(88, 50);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(699, 88);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 50);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(699, 31);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lvKeySounds
            // 
            lvKeySounds.Alignment = ListViewAlignment.Default;
            lvKeySounds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvKeySounds.Columns.AddRange(new ColumnHeader[] { chKeys, chWindow, chSoundLoc });
            lvKeySounds.FullRowSelect = true;
            lvKeySounds.GridLines = true;
            lvKeySounds.Location = new Point(14, 31);
            lvKeySounds.Margin = new Padding(4, 3, 4, 3);
            lvKeySounds.MultiSelect = false;
            lvKeySounds.Name = "lvKeySounds";
            lvKeySounds.Size = new Size(677, 349);
            lvKeySounds.TabIndex = 0;
            lvKeySounds.UseCompatibleStateImageBehavior = false;
            lvKeySounds.View = View.Details;
            lvKeySounds.MouseDoubleClick += lvKeySounds_MouseDoubleClick;
            // 
            // chKeys
            // 
            chKeys.Text = "Keys";
            chKeys.Width = 150;
            // 
            // chWindow
            // 
            chWindow.Text = "Window";
            // 
            // chSoundLoc
            // 
            chSoundLoc.Text = "Sound location";
            chSoundLoc.Width = 300;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoad.Location = new Point(14, 388);
            btnLoad.Margin = new Padding(4, 3, 4, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(169, 27);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnReloadDevices
            // 
            btnReloadDevices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReloadDevices.Image = (Image)resources.GetObject("btnReloadDevices.Image");
            btnReloadDevices.Location = new Point(397, 77);
            btnReloadDevices.Margin = new Padding(4, 3, 4, 3);
            btnReloadDevices.Name = "btnReloadDevices";
            btnReloadDevices.Size = new Size(26, 25);
            btnReloadDevices.TabIndex = 12;
            btnReloadDevices.UseVisualStyleBackColor = true;
            btnReloadDevices.Click += btnReloadDevices_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new Point(699, 201);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 50);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveAs.Location = new Point(369, 388);
            btnSaveAs.Margin = new Padding(4, 3, 4, 3);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(169, 27);
            btnSaveAs.TabIndex = 9;
            btnSaveAs.Text = "Save As";
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, texttospeechToolStripMenuItem, checkForUpdateToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(798, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // texttospeechToolStripMenuItem
            // 
            texttospeechToolStripMenuItem.Name = "texttospeechToolStripMenuItem";
            texttospeechToolStripMenuItem.Size = new Size(98, 20);
            texttospeechToolStripMenuItem.Text = "Text-to-speech";
            texttospeechToolStripMenuItem.Click += texttospeechToolStripMenuItem_Click;
            // 
            // checkForUpdateToolStripMenuItem
            // 
            checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            checkForUpdateToolStripMenuItem.Size = new Size(110, 20);
            checkForUpdateToolStripMenuItem.Text = "Check for update";
            checkForUpdateToolStripMenuItem.Click += checkForUpdateToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(7, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 18;
            label2.Text = "Loopback";
            // 
            // cbLoopbackDevices
            // 
            cbLoopbackDevices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbLoopbackDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoopbackDevices.FormattingEnabled = true;
            cbLoopbackDevices.Location = new Point(110, 77);
            cbLoopbackDevices.Margin = new Padding(4, 3, 4, 3);
            cbLoopbackDevices.Name = "cbLoopbackDevices";
            cbLoopbackDevices.Size = new Size(279, 23);
            cbLoopbackDevices.TabIndex = 11;
            // 
            // btnPlaySelectedSound
            // 
            btnPlaySelectedSound.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPlaySelectedSound.Location = new Point(699, 275);
            btnPlaySelectedSound.Margin = new Padding(4, 3, 4, 3);
            btnPlaySelectedSound.Name = "btnPlaySelectedSound";
            btnPlaySelectedSound.Size = new Size(88, 50);
            btnPlaySelectedSound.TabIndex = 5;
            btnPlaySelectedSound.Text = "Play sound";
            btnPlaySelectedSound.UseVisualStyleBackColor = true;
            btnPlaySelectedSound.Click += btnPlaySound_Click;
            // 
            // btnStopAllSounds
            // 
            btnStopAllSounds.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStopAllSounds.Location = new Point(699, 331);
            btnStopAllSounds.Margin = new Padding(4, 3, 4, 3);
            btnStopAllSounds.Name = "btnStopAllSounds";
            btnStopAllSounds.Size = new Size(88, 50);
            btnStopAllSounds.TabIndex = 6;
            btnStopAllSounds.Text = "Stop all sounds";
            btnStopAllSounds.UseVisualStyleBackColor = true;
            btnStopAllSounds.Click += btnStopAllSounds_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Minimized to the tray.";
            notifyIcon1.BalloonTipTitle = "JN Soundboard";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "JN Soundboard";
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // gbPushToTalk
            // 
            gbPushToTalk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gbPushToTalk.Controls.Add(btnReloadWindows);
            gbPushToTalk.Controls.Add(cbEnablePushToTalk);
            gbPushToTalk.Controls.Add(cbWindows);
            gbPushToTalk.Controls.Add(label4);
            gbPushToTalk.Controls.Add(label3);
            gbPushToTalk.Controls.Add(tbPushToTalkKey);
            gbPushToTalk.Location = new Point(488, 444);
            gbPushToTalk.Margin = new Padding(4, 3, 4, 3);
            gbPushToTalk.Name = "gbPushToTalk";
            gbPushToTalk.Padding = new Padding(4, 3, 4, 3);
            gbPushToTalk.Size = new Size(296, 108);
            gbPushToTalk.TabIndex = 13;
            gbPushToTalk.TabStop = false;
            gbPushToTalk.Text = "Auto press push to talk key";
            // 
            // btnReloadWindows
            // 
            btnReloadWindows.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReloadWindows.Image = (Image)resources.GetObject("btnReloadWindows.Image");
            btnReloadWindows.Location = new Point(264, 52);
            btnReloadWindows.Margin = new Padding(4, 3, 4, 3);
            btnReloadWindows.Name = "btnReloadWindows";
            btnReloadWindows.Size = new Size(26, 25);
            btnReloadWindows.TabIndex = 15;
            btnReloadWindows.UseVisualStyleBackColor = true;
            btnReloadWindows.Click += btnReloadWindows_Click;
            // 
            // cbEnablePushToTalk
            // 
            cbEnablePushToTalk.AutoSize = true;
            cbEnablePushToTalk.Location = new Point(12, 83);
            cbEnablePushToTalk.Margin = new Padding(4, 3, 4, 3);
            cbEnablePushToTalk.Name = "cbEnablePushToTalk";
            cbEnablePushToTalk.Size = new Size(61, 19);
            cbEnablePushToTalk.TabIndex = 16;
            cbEnablePushToTalk.Text = "Enable";
            cbEnablePushToTalk.UseVisualStyleBackColor = true;
            cbEnablePushToTalk.CheckedChanged += cbEnablePushToTalk_CheckedChanged;
            // 
            // cbWindows
            // 
            cbWindows.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbWindows.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbWindows.FormattingEnabled = true;
            cbWindows.Location = new Point(69, 52);
            cbWindows.Margin = new Padding(4, 3, 4, 3);
            cbWindows.Name = "cbWindows";
            cbWindows.Size = new Size(187, 23);
            cbWindows.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 55);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 2;
            label4.Text = "Window";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 1;
            label3.Text = "Key";
            // 
            // tbPushToTalkKey
            // 
            tbPushToTalkKey.Location = new Point(69, 22);
            tbPushToTalkKey.Margin = new Padding(4, 3, 4, 3);
            tbPushToTalkKey.Name = "tbPushToTalkKey";
            tbPushToTalkKey.ReadOnly = true;
            tbPushToTalkKey.Size = new Size(187, 23);
            tbPushToTalkKey.TabIndex = 13;
            tbPushToTalkKey.Enter += tbPushToTalkKey_Enter;
            tbPushToTalkKey.Leave += tbPushToTalkKey_Leave;
            // 
            // cbAudioDevices
            // 
            cbAudioDevices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbAudioDevices.Controls.Add(cbEnableVirtual);
            cbAudioDevices.Controls.Add(cbEnableLocal);
            cbAudioDevices.Controls.Add(label5);
            cbAudioDevices.Controls.Add(cbPlaybackDevicesLocal);
            cbAudioDevices.Controls.Add(label1);
            cbAudioDevices.Controls.Add(label2);
            cbAudioDevices.Controls.Add(cbPlaybackDevices);
            cbAudioDevices.Controls.Add(cbLoopbackDevices);
            cbAudioDevices.Controls.Add(btnReloadDevices);
            cbAudioDevices.Location = new Point(14, 444);
            cbAudioDevices.Margin = new Padding(4, 3, 4, 3);
            cbAudioDevices.Name = "cbAudioDevices";
            cbAudioDevices.Padding = new Padding(4, 3, 4, 3);
            cbAudioDevices.Size = new Size(428, 108);
            cbAudioDevices.TabIndex = 10;
            cbAudioDevices.TabStop = false;
            cbAudioDevices.Text = "Audio devices";
            // 
            // cbEnableVirtual
            // 
            cbEnableVirtual.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbEnableVirtual.AutoSize = true;
            cbEnableVirtual.Checked = true;
            cbEnableVirtual.CheckState = CheckState.Checked;
            cbEnableVirtual.Location = new Point(398, 53);
            cbEnableVirtual.Margin = new Padding(4, 3, 4, 3);
            cbEnableVirtual.Name = "cbEnableVirtual";
            cbEnableVirtual.Size = new Size(15, 14);
            cbEnableVirtual.TabIndex = 22;
            cbEnableVirtual.UseVisualStyleBackColor = true;
            cbEnableVirtual.CheckedChanged += cbEnableVirtual_CheckedChanged;
            // 
            // cbEnableLocal
            // 
            cbEnableLocal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbEnableLocal.AutoSize = true;
            cbEnableLocal.Checked = true;
            cbEnableLocal.CheckState = CheckState.Checked;
            cbEnableLocal.Location = new Point(398, 20);
            cbEnableLocal.Margin = new Padding(4, 3, 4, 3);
            cbEnableLocal.Name = "cbEnableLocal";
            cbEnableLocal.Size = new Size(15, 14);
            cbEnableLocal.TabIndex = 21;
            cbEnableLocal.UseVisualStyleBackColor = true;
            cbEnableLocal.CheckedChanged += cbEnableLocal_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 20;
            label5.Text = "Local Playback";
            // 
            // cbPlaybackDevicesLocal
            // 
            cbPlaybackDevicesLocal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbPlaybackDevicesLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlaybackDevicesLocal.FormattingEnabled = true;
            cbPlaybackDevicesLocal.Location = new Point(110, 15);
            cbPlaybackDevicesLocal.Margin = new Padding(4, 3, 4, 3);
            cbPlaybackDevicesLocal.Name = "cbPlaybackDevicesLocal";
            cbPlaybackDevicesLocal.Size = new Size(279, 23);
            cbPlaybackDevicesLocal.TabIndex = 19;
            // 
            // pushToTalkKeyTimer
            // 
            pushToTalkKeyTimer.Tick += pushToTalkKeyTimer_Tick;
            // 
            // volumeBar
            // 
            volumeBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            volumeBar.AutoSize = false;
            volumeBar.Location = new Point(453, 444);
            volumeBar.Margin = new Padding(4, 3, 4, 3);
            volumeBar.Maximum = 100;
            volumeBar.Name = "volumeBar";
            volumeBar.Orientation = Orientation.Vertical;
            volumeBar.RightToLeft = RightToLeft.No;
            volumeBar.Size = new Size(28, 96);
            volumeBar.TabIndex = 18;
            volumeBar.TickStyle = TickStyle.None;
            volumeBar.Value = 100;
            volumeBar.Scroll += volumeBar_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(454, 535);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 567);
            Controls.Add(pictureBox1);
            Controls.Add(volumeBar);
            Controls.Add(cbAudioDevices);
            Controls.Add(gbPushToTalk);
            Controls.Add(btnStopAllSounds);
            Controls.Add(btnPlaySelectedSound);
            Controls.Add(btnSaveAs);
            Controls.Add(btnClear);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lvKeySounds);
            Controls.Add(cbEnable);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(814, 606);
            Name = "MainForm";
            Text = "JN Soundboard";
            Resize += frmMain_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbPushToTalk.ResumeLayout(false);
            gbPushToTalk.PerformLayout();
            cbAudioDevices.ResumeLayout(false);
            cbAudioDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbPlaybackDevices;
        private CheckBox cbEnable;
        internal System.Windows.Forms.Timer mainTimer;
        private Button btnSave;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        internal ListView lvKeySounds;
        private Button btnLoad;
        private Button btnReloadDevices;
        internal ColumnHeader chKeys;
        internal ColumnHeader chSoundLoc;
        private Button btnClear;
        private Button btnSaveAs;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Label label2;
        private ComboBox cbLoopbackDevices;
        private Button btnPlaySelectedSound;
        private Button btnStopAllSounds;
        private NotifyIcon notifyIcon1;
        private GroupBox gbPushToTalk;
        private CheckBox cbEnablePushToTalk;
        private ComboBox cbWindows;
        private Label label4;
        private Label label3;
        private TextBox tbPushToTalkKey;
        private GroupBox cbAudioDevices;
        private ToolStripMenuItem texttospeechToolStripMenuItem;
        private Button btnReloadWindows;
        private System.Windows.Forms.Timer pushToTalkKeyTimer;
        internal ColumnHeader chWindow;
        private ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private Label label1;
        private TrackBar volumeBar;
        private PictureBox pictureBox1;
        private ComboBox cbPlaybackDevicesLocal;
        private Label label5;
        private CheckBox cbEnableVirtual;
        private CheckBox cbEnableLocal;
    }
}

