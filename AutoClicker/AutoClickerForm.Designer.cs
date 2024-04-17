namespace AutoClicker
{
    partial class AutoClickerForm
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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.ClickIntervalHoursTextBox = new System.Windows.Forms.TextBox();
            this.ClickIntervalMinutesTextBox = new System.Windows.Forms.TextBox();
            this.ClickIntervalSecondsTextBox = new System.Windows.Forms.TextBox();
            this.ClickIntervalMilisecondsTextBox = new System.Windows.Forms.TextBox();
            this.ClickIntervalHoursLabel = new System.Windows.Forms.Label();
            this.ClickIntervalMinutesLabel = new System.Windows.Forms.Label();
            this.ClickIntervalSecondsLabel = new System.Windows.Forms.Label();
            this.ClickIntervalMilisecondsLabel = new System.Windows.Forms.Label();
            this.RandomOffsetCheckbox = new System.Windows.Forms.CheckBox();
            this.RandomOffsetMilisecondsTextBox = new System.Windows.Forms.TextBox();
            this.MouseButtonComboBox = new System.Windows.Forms.ComboBox();
            this.MouseButtonLabel = new System.Windows.Forms.Label();
            this.ClickTypeLabel = new System.Windows.Forms.Label();
            this.ClickTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ClickRepeatRadioButton = new System.Windows.Forms.RadioButton();
            this.ClickRepeatTextBox = new System.Windows.Forms.NumericUpDown();
            this.ClickRepeatTimesLabel = new System.Windows.Forms.Label();
            this.ClickRepeatUntilStoppedRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.PickLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.PickLocationButton = new System.Windows.Forms.Button();
            this.PickLocationXLabel = new System.Windows.Forms.Label();
            this.PickLocationXTextBox = new System.Windows.Forms.TextBox();
            this.PickLocationYLabel = new System.Windows.Forms.Label();
            this.PickLocationYTextBox = new System.Windows.Forms.TextBox();
            this.RandomOffsetMilisecondsLabel = new System.Windows.Forms.Label();
            this.ClickRepeatGroupBox = new System.Windows.Forms.GroupBox();
            this.ClickOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.CursorPositionGroupBox = new System.Windows.Forms.GroupBox();
            this.ClickIntervalGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClickRepeatTextBox)).BeginInit();
            this.ClickRepeatGroupBox.SuspendLayout();
            this.ClickOptionsGroupBox.SuspendLayout();
            this.CursorPositionGroupBox.SuspendLayout();
            this.ClickIntervalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 273);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(233, 50);
            this.Start.TabIndex = 500;
            this.Start.Text = "Start (F6)";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(258, 273);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(249, 50);
            this.Stop.TabIndex = 510;
            this.Stop.Text = "Stop (F6)";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.StopButtonClick);
            // 
            // ClickIntervalHoursTextBox
            // 
            this.ClickIntervalHoursTextBox.Location = new System.Drawing.Point(6, 19);
            this.ClickIntervalHoursTextBox.Name = "ClickIntervalHoursTextBox";
            this.ClickIntervalHoursTextBox.Size = new System.Drawing.Size(50, 20);
            this.ClickIntervalHoursTextBox.TabIndex = 101;
            this.ClickIntervalHoursTextBox.TextChanged += new System.EventHandler(this.ClickIntervalHoursChanged);
            // 
            // ClickIntervalMinutesTextBox
            // 
            this.ClickIntervalMinutesTextBox.Location = new System.Drawing.Point(111, 19);
            this.ClickIntervalMinutesTextBox.Name = "ClickIntervalMinutesTextBox";
            this.ClickIntervalMinutesTextBox.Size = new System.Drawing.Size(50, 20);
            this.ClickIntervalMinutesTextBox.TabIndex = 103;
            this.ClickIntervalMinutesTextBox.TextChanged += new System.EventHandler(this.ClickIntervalMinutesChanged);
            // 
            // ClickIntervalSecondsTextBox
            // 
            this.ClickIntervalSecondsTextBox.Location = new System.Drawing.Point(229, 19);
            this.ClickIntervalSecondsTextBox.Name = "ClickIntervalSecondsTextBox";
            this.ClickIntervalSecondsTextBox.Size = new System.Drawing.Size(50, 20);
            this.ClickIntervalSecondsTextBox.TabIndex = 105;
            this.ClickIntervalSecondsTextBox.TextChanged += new System.EventHandler(this.ClickIntervalSecondsChanged);
            // 
            // ClickIntervalMilisecondsTextBox
            // 
            this.ClickIntervalMilisecondsTextBox.Location = new System.Drawing.Point(344, 19);
            this.ClickIntervalMilisecondsTextBox.Name = "ClickIntervalMilisecondsTextBox";
            this.ClickIntervalMilisecondsTextBox.Size = new System.Drawing.Size(50, 20);
            this.ClickIntervalMilisecondsTextBox.TabIndex = 107;
            this.ClickIntervalMilisecondsTextBox.TextChanged += new System.EventHandler(this.ClickIntervalMiliseconds_TextChanged);
            // 
            // ClickIntervalHoursLabel
            // 
            this.ClickIntervalHoursLabel.AutoSize = true;
            this.ClickIntervalHoursLabel.Location = new System.Drawing.Point(66, 22);
            this.ClickIntervalHoursLabel.Name = "ClickIntervalHoursLabel";
            this.ClickIntervalHoursLabel.Size = new System.Drawing.Size(39, 13);
            this.ClickIntervalHoursLabel.TabIndex = 102;
            this.ClickIntervalHoursLabel.Text = "hour(s)";
            // 
            // ClickIntervalMinutesLabel
            // 
            this.ClickIntervalMinutesLabel.AutoSize = true;
            this.ClickIntervalMinutesLabel.Location = new System.Drawing.Point(174, 22);
            this.ClickIntervalMinutesLabel.Name = "ClickIntervalMinutesLabel";
            this.ClickIntervalMinutesLabel.Size = new System.Drawing.Size(49, 13);
            this.ClickIntervalMinutesLabel.TabIndex = 104;
            this.ClickIntervalMinutesLabel.Text = "minute(s)";
            // 
            // ClickIntervalSecondsLabel
            // 
            this.ClickIntervalSecondsLabel.AutoSize = true;
            this.ClickIntervalSecondsLabel.Location = new System.Drawing.Point(285, 22);
            this.ClickIntervalSecondsLabel.Name = "ClickIntervalSecondsLabel";
            this.ClickIntervalSecondsLabel.Size = new System.Drawing.Size(53, 13);
            this.ClickIntervalSecondsLabel.TabIndex = 106;
            this.ClickIntervalSecondsLabel.Text = "second(s)";
            // 
            // ClickIntervalMilisecondsLabel
            // 
            this.ClickIntervalMilisecondsLabel.AutoSize = true;
            this.ClickIntervalMilisecondsLabel.Location = new System.Drawing.Point(400, 22);
            this.ClickIntervalMilisecondsLabel.Name = "ClickIntervalMilisecondsLabel";
            this.ClickIntervalMilisecondsLabel.Size = new System.Drawing.Size(67, 13);
            this.ClickIntervalMilisecondsLabel.TabIndex = 108;
            this.ClickIntervalMilisecondsLabel.Text = "milisecond(s)";
            // 
            // RandomOffsetCheckbox
            // 
            this.RandomOffsetCheckbox.AutoSize = true;
            this.RandomOffsetCheckbox.Location = new System.Drawing.Point(6, 65);
            this.RandomOffsetCheckbox.Name = "RandomOffsetCheckbox";
            this.RandomOffsetCheckbox.Size = new System.Drawing.Size(97, 17);
            this.RandomOffsetCheckbox.TabIndex = 109;
            this.RandomOffsetCheckbox.Text = "Random Offset";
            this.RandomOffsetCheckbox.UseVisualStyleBackColor = true;
            this.RandomOffsetCheckbox.CheckedChanged += new System.EventHandler(this.RandomOffsetCheckbox_CheckedChanged);
            // 
            // RandomOffsetMilisecondsTextBox
            // 
            this.RandomOffsetMilisecondsTextBox.Location = new System.Drawing.Point(109, 62);
            this.RandomOffsetMilisecondsTextBox.Name = "RandomOffsetMilisecondsTextBox";
            this.RandomOffsetMilisecondsTextBox.Size = new System.Drawing.Size(100, 20);
            this.RandomOffsetMilisecondsTextBox.TabIndex = 110;
            this.RandomOffsetMilisecondsTextBox.TextChanged += new System.EventHandler(this.RandomOffsetMilisecondsTextBox_TextChanged);
            // 
            // MouseButtonComboBox
            // 
            this.MouseButtonComboBox.FormattingEnabled = true;
            this.MouseButtonComboBox.Location = new System.Drawing.Point(102, 27);
            this.MouseButtonComboBox.Name = "MouseButtonComboBox";
            this.MouseButtonComboBox.Size = new System.Drawing.Size(121, 21);
            this.MouseButtonComboBox.TabIndex = 202;
            this.MouseButtonComboBox.SelectedIndexChanged += new System.EventHandler(this.MouseButtonComboBox_SelectedIndexChanged);
            // 
            // MouseButtonLabel
            // 
            this.MouseButtonLabel.AutoSize = true;
            this.MouseButtonLabel.Location = new System.Drawing.Point(13, 30);
            this.MouseButtonLabel.Name = "MouseButtonLabel";
            this.MouseButtonLabel.Size = new System.Drawing.Size(73, 13);
            this.MouseButtonLabel.TabIndex = 201;
            this.MouseButtonLabel.Text = "Mouse Button";
            // 
            // ClickTypeLabel
            // 
            this.ClickTypeLabel.AutoSize = true;
            this.ClickTypeLabel.Location = new System.Drawing.Point(13, 60);
            this.ClickTypeLabel.Name = "ClickTypeLabel";
            this.ClickTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.ClickTypeLabel.TabIndex = 203;
            this.ClickTypeLabel.Text = "Click Type";
            // 
            // ClickTypeComboBox
            // 
            this.ClickTypeComboBox.FormattingEnabled = true;
            this.ClickTypeComboBox.Location = new System.Drawing.Point(102, 57);
            this.ClickTypeComboBox.Name = "ClickTypeComboBox";
            this.ClickTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClickTypeComboBox.TabIndex = 204;
            this.ClickTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ClickTypeComboBox_SelectedIndexChanged);
            // 
            // ClickRepeatRadioButton
            // 
            this.ClickRepeatRadioButton.AutoSize = true;
            this.ClickRepeatRadioButton.Location = new System.Drawing.Point(15, 28);
            this.ClickRepeatRadioButton.Name = "ClickRepeatRadioButton";
            this.ClickRepeatRadioButton.Size = new System.Drawing.Size(60, 17);
            this.ClickRepeatRadioButton.TabIndex = 301;
            this.ClickRepeatRadioButton.TabStop = true;
            this.ClickRepeatRadioButton.Text = "Repeat";
            this.ClickRepeatRadioButton.UseVisualStyleBackColor = true;
            this.ClickRepeatRadioButton.CheckedChanged += new System.EventHandler(this.ClickRepeatRadioButton_CheckedChanged);
            // 
            // ClickRepeatTextBox
            // 
            this.ClickRepeatTextBox.Location = new System.Drawing.Point(81, 28);
            this.ClickRepeatTextBox.Name = "ClickRepeatTextBox";
            this.ClickRepeatTextBox.Size = new System.Drawing.Size(120, 20);
            this.ClickRepeatTextBox.TabIndex = 302;
            this.ClickRepeatTextBox.ValueChanged += new System.EventHandler(this.ClickRepeatTextBox_ValueChanged);
            // 
            // ClickRepeatTimesLabel
            // 
            this.ClickRepeatTimesLabel.AutoSize = true;
            this.ClickRepeatTimesLabel.Location = new System.Drawing.Point(207, 32);
            this.ClickRepeatTimesLabel.Name = "ClickRepeatTimesLabel";
            this.ClickRepeatTimesLabel.Size = new System.Drawing.Size(35, 13);
            this.ClickRepeatTimesLabel.TabIndex = 303;
            this.ClickRepeatTimesLabel.Text = "Times";
            // 
            // ClickRepeatUntilStoppedRadioButton
            // 
            this.ClickRepeatUntilStoppedRadioButton.AutoSize = true;
            this.ClickRepeatUntilStoppedRadioButton.Location = new System.Drawing.Point(15, 58);
            this.ClickRepeatUntilStoppedRadioButton.Name = "ClickRepeatUntilStoppedRadioButton";
            this.ClickRepeatUntilStoppedRadioButton.Size = new System.Drawing.Size(123, 17);
            this.ClickRepeatUntilStoppedRadioButton.TabIndex = 304;
            this.ClickRepeatUntilStoppedRadioButton.TabStop = true;
            this.ClickRepeatUntilStoppedRadioButton.Text = "Repeat until stopped";
            this.ClickRepeatUntilStoppedRadioButton.UseVisualStyleBackColor = true;
            this.ClickRepeatUntilStoppedRadioButton.CheckedChanged += new System.EventHandler(this.ClickRepeatUntilStoppedRadioButton_CheckedChanged);
            // 
            // CurrentLocationRadioButton
            // 
            this.CurrentLocationRadioButton.AutoSize = true;
            this.CurrentLocationRadioButton.Location = new System.Drawing.Point(6, 22);
            this.CurrentLocationRadioButton.Name = "CurrentLocationRadioButton";
            this.CurrentLocationRadioButton.Size = new System.Drawing.Size(99, 17);
            this.CurrentLocationRadioButton.TabIndex = 401;
            this.CurrentLocationRadioButton.TabStop = true;
            this.CurrentLocationRadioButton.Text = "Current location";
            this.CurrentLocationRadioButton.UseVisualStyleBackColor = true;
            this.CurrentLocationRadioButton.CheckedChanged += new System.EventHandler(this.CurrentLocationRadioButton_CheckedChanged);
            // 
            // PickLocationRadioButton
            // 
            this.PickLocationRadioButton.AutoSize = true;
            this.PickLocationRadioButton.Location = new System.Drawing.Point(111, 23);
            this.PickLocationRadioButton.Name = "PickLocationRadioButton";
            this.PickLocationRadioButton.Size = new System.Drawing.Size(86, 17);
            this.PickLocationRadioButton.TabIndex = 402;
            this.PickLocationRadioButton.TabStop = true;
            this.PickLocationRadioButton.Text = "Pick location";
            this.PickLocationRadioButton.UseVisualStyleBackColor = true;
            this.PickLocationRadioButton.CheckedChanged += new System.EventHandler(this.PickLocationRadioButton_CheckedChanged);
            // 
            // PickLocationButton
            // 
            this.PickLocationButton.Location = new System.Drawing.Point(218, 19);
            this.PickLocationButton.Name = "PickLocationButton";
            this.PickLocationButton.Size = new System.Drawing.Size(96, 23);
            this.PickLocationButton.TabIndex = 403;
            this.PickLocationButton.Text = "Pick Location";
            this.PickLocationButton.UseVisualStyleBackColor = true;
            this.PickLocationButton.Click += new System.EventHandler(this.PickLocationButton_Click);
            // 
            // PickLocationXLabel
            // 
            this.PickLocationXLabel.AutoSize = true;
            this.PickLocationXLabel.Location = new System.Drawing.Point(320, 25);
            this.PickLocationXLabel.Name = "PickLocationXLabel";
            this.PickLocationXLabel.Size = new System.Drawing.Size(14, 13);
            this.PickLocationXLabel.TabIndex = 404;
            this.PickLocationXLabel.Text = "X";
            // 
            // PickLocationXTextBox
            // 
            this.PickLocationXTextBox.Location = new System.Drawing.Point(340, 21);
            this.PickLocationXTextBox.Name = "PickLocationXTextBox";
            this.PickLocationXTextBox.Size = new System.Drawing.Size(50, 20);
            this.PickLocationXTextBox.TabIndex = 405;
            this.PickLocationXTextBox.TextChanged += new System.EventHandler(this.PickLocationXTextBox_TextChanged);
            // 
            // PickLocationYLabel
            // 
            this.PickLocationYLabel.AutoSize = true;
            this.PickLocationYLabel.Location = new System.Drawing.Point(396, 24);
            this.PickLocationYLabel.Name = "PickLocationYLabel";
            this.PickLocationYLabel.Size = new System.Drawing.Size(14, 13);
            this.PickLocationYLabel.TabIndex = 406;
            this.PickLocationYLabel.Text = "Y";
            // 
            // PickLocationYTextBox
            // 
            this.PickLocationYTextBox.Location = new System.Drawing.Point(416, 21);
            this.PickLocationYTextBox.Name = "PickLocationYTextBox";
            this.PickLocationYTextBox.Size = new System.Drawing.Size(50, 20);
            this.PickLocationYTextBox.TabIndex = 407;
            this.PickLocationYTextBox.TextChanged += new System.EventHandler(this.PickLocationYTextBox_TextChanged);
            // 
            // RandomOffsetMilisecondsLabel
            // 
            this.RandomOffsetMilisecondsLabel.AutoSize = true;
            this.RandomOffsetMilisecondsLabel.Location = new System.Drawing.Point(215, 65);
            this.RandomOffsetMilisecondsLabel.Name = "RandomOffsetMilisecondsLabel";
            this.RandomOffsetMilisecondsLabel.Size = new System.Drawing.Size(67, 13);
            this.RandomOffsetMilisecondsLabel.TabIndex = 111;
            this.RandomOffsetMilisecondsLabel.Text = "milisecond(s)";
            // 
            // ClickRepeatGroupBox
            // 
            this.ClickRepeatGroupBox.Controls.Add(this.ClickRepeatRadioButton);
            this.ClickRepeatGroupBox.Controls.Add(this.ClickRepeatTextBox);
            this.ClickRepeatGroupBox.Controls.Add(this.ClickRepeatTimesLabel);
            this.ClickRepeatGroupBox.Controls.Add(this.ClickRepeatUntilStoppedRadioButton);
            this.ClickRepeatGroupBox.Location = new System.Drawing.Point(258, 118);
            this.ClickRepeatGroupBox.Name = "ClickRepeatGroupBox";
            this.ClickRepeatGroupBox.Size = new System.Drawing.Size(249, 88);
            this.ClickRepeatGroupBox.TabIndex = 300;
            this.ClickRepeatGroupBox.TabStop = false;
            this.ClickRepeatGroupBox.Text = "Click Repeat";
            // 
            // ClickOptionsGroupBox
            // 
            this.ClickOptionsGroupBox.Controls.Add(this.MouseButtonLabel);
            this.ClickOptionsGroupBox.Controls.Add(this.MouseButtonComboBox);
            this.ClickOptionsGroupBox.Controls.Add(this.ClickTypeLabel);
            this.ClickOptionsGroupBox.Controls.Add(this.ClickTypeComboBox);
            this.ClickOptionsGroupBox.Location = new System.Drawing.Point(12, 118);
            this.ClickOptionsGroupBox.Name = "ClickOptionsGroupBox";
            this.ClickOptionsGroupBox.Size = new System.Drawing.Size(233, 88);
            this.ClickOptionsGroupBox.TabIndex = 200;
            this.ClickOptionsGroupBox.TabStop = false;
            this.ClickOptionsGroupBox.Text = "Click Options";
            // 
            // CursorPositionGroupBox
            // 
            this.CursorPositionGroupBox.Controls.Add(this.CurrentLocationRadioButton);
            this.CursorPositionGroupBox.Controls.Add(this.PickLocationRadioButton);
            this.CursorPositionGroupBox.Controls.Add(this.PickLocationButton);
            this.CursorPositionGroupBox.Controls.Add(this.PickLocationXLabel);
            this.CursorPositionGroupBox.Controls.Add(this.PickLocationYTextBox);
            this.CursorPositionGroupBox.Controls.Add(this.PickLocationXTextBox);
            this.CursorPositionGroupBox.Controls.Add(this.PickLocationYLabel);
            this.CursorPositionGroupBox.Location = new System.Drawing.Point(12, 212);
            this.CursorPositionGroupBox.Name = "CursorPositionGroupBox";
            this.CursorPositionGroupBox.Size = new System.Drawing.Size(495, 55);
            this.CursorPositionGroupBox.TabIndex = 400;
            this.CursorPositionGroupBox.TabStop = false;
            this.CursorPositionGroupBox.Text = "Cursor Position";
            // 
            // ClickIntervalGroupBox
            // 
            this.ClickIntervalGroupBox.Controls.Add(this.ClickIntervalHoursTextBox);
            this.ClickIntervalGroupBox.Controls.Add(this.ClickIntervalHoursLabel);
            this.ClickIntervalGroupBox.Controls.Add(this.ClickIntervalMinutesTextBox);
            this.ClickIntervalGroupBox.Controls.Add(this.ClickIntervalMinutesLabel);
            this.ClickIntervalGroupBox.Controls.Add(this.RandomOffsetMilisecondsLabel);
            this.ClickIntervalGroupBox.Controls.Add(this.ClickIntervalSecondsTextBox);
            this.ClickIntervalGroupBox.Controls.Add(this.RandomOffsetMilisecondsTextBox);
            this.ClickIntervalGroupBox.Controls.Add(this.ClickIntervalSecondsLabel);
            this.ClickIntervalGroupBox.Controls.Add(this.RandomOffsetCheckbox);
            this.ClickIntervalGroupBox.Controls.Add(this.ClickIntervalMilisecondsTextBox);
            this.ClickIntervalGroupBox.Controls.Add(this.ClickIntervalMilisecondsLabel);
            this.ClickIntervalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ClickIntervalGroupBox.Name = "ClickIntervalGroupBox";
            this.ClickIntervalGroupBox.Size = new System.Drawing.Size(495, 100);
            this.ClickIntervalGroupBox.TabIndex = 100;
            this.ClickIntervalGroupBox.TabStop = false;
            this.ClickIntervalGroupBox.Text = "Click Interval";
            // 
            // AutoClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 331);
            this.Controls.Add(this.ClickIntervalGroupBox);
            this.Controls.Add(this.CursorPositionGroupBox);
            this.Controls.Add(this.ClickOptionsGroupBox);
            this.Controls.Add(this.ClickRepeatGroupBox);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "AutoClickerForm";
            this.Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)(this.ClickRepeatTextBox)).EndInit();
            this.ClickRepeatGroupBox.ResumeLayout(false);
            this.ClickRepeatGroupBox.PerformLayout();
            this.ClickOptionsGroupBox.ResumeLayout(false);
            this.ClickOptionsGroupBox.PerformLayout();
            this.CursorPositionGroupBox.ResumeLayout(false);
            this.CursorPositionGroupBox.PerformLayout();
            this.ClickIntervalGroupBox.ResumeLayout(false);
            this.ClickIntervalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox ClickIntervalHoursTextBox;
        private System.Windows.Forms.TextBox ClickIntervalMinutesTextBox;
        private System.Windows.Forms.TextBox ClickIntervalSecondsTextBox;
        private System.Windows.Forms.TextBox ClickIntervalMilisecondsTextBox;
        private System.Windows.Forms.Label ClickIntervalHoursLabel;
        private System.Windows.Forms.Label ClickIntervalMinutesLabel;
        private System.Windows.Forms.Label ClickIntervalSecondsLabel;
        private System.Windows.Forms.Label ClickIntervalMilisecondsLabel;
        private System.Windows.Forms.CheckBox RandomOffsetCheckbox;
        private System.Windows.Forms.TextBox RandomOffsetMilisecondsTextBox;
        private System.Windows.Forms.ComboBox MouseButtonComboBox;
        private System.Windows.Forms.Label MouseButtonLabel;
        private System.Windows.Forms.Label ClickTypeLabel;
        private System.Windows.Forms.ComboBox ClickTypeComboBox;
        private System.Windows.Forms.RadioButton ClickRepeatRadioButton;
        private System.Windows.Forms.NumericUpDown ClickRepeatTextBox;
        private System.Windows.Forms.Label ClickRepeatTimesLabel;
        private System.Windows.Forms.RadioButton ClickRepeatUntilStoppedRadioButton;
        private System.Windows.Forms.RadioButton CurrentLocationRadioButton;
        private System.Windows.Forms.RadioButton PickLocationRadioButton;
        private System.Windows.Forms.Button PickLocationButton;
        private System.Windows.Forms.Label PickLocationXLabel;
        private System.Windows.Forms.TextBox PickLocationXTextBox;
        private System.Windows.Forms.Label PickLocationYLabel;
        private System.Windows.Forms.TextBox PickLocationYTextBox;
        private System.Windows.Forms.Label RandomOffsetMilisecondsLabel;
        private System.Windows.Forms.GroupBox ClickRepeatGroupBox;
        private System.Windows.Forms.GroupBox ClickOptionsGroupBox;
        private System.Windows.Forms.GroupBox CursorPositionGroupBox;
        private System.Windows.Forms.GroupBox ClickIntervalGroupBox;
    }
}

