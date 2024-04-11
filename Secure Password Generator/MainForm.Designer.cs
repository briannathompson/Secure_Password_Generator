namespace Secure_Password_Generator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            passwordTextBox = new TextBox();
            label1 = new Label();
            copyButton = new Button();
            passwordLengthTrackBar = new TrackBar();
            passwordLengthTextBox = new TextBox();
            refreshButton = new Button();
            toolTip = new ToolTip(components);
            label2 = new Label();
            passwordCopiedLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)passwordLengthTrackBar).BeginInit();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14F);
            passwordTextBox.ForeColor = SystemColors.HotTrack;
            passwordTextBox.Location = new Point(12, 39);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.ShortcutsEnabled = false;
            passwordTextBox.Size = new Size(432, 32);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 2;
            label1.Text = "Length";
            // 
            // copyButton
            // 
            copyButton.Cursor = Cursors.Hand;
            copyButton.Image = Properties.Resources.Copy;
            copyButton.Location = new Point(450, 39);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(32, 32);
            copyButton.TabIndex = 0;
            toolTip.SetToolTip(copyButton, "Copy to clipboard");
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // passwordLengthTrackBar
            // 
            passwordLengthTrackBar.Location = new Point(76, 100);
            passwordLengthTrackBar.Maximum = 40;
            passwordLengthTrackBar.Minimum = 8;
            passwordLengthTrackBar.Name = "passwordLengthTrackBar";
            passwordLengthTrackBar.Size = new Size(385, 45);
            passwordLengthTrackBar.TabIndex = 3;
            passwordLengthTrackBar.Value = 18;
            passwordLengthTrackBar.ValueChanged += passwordLengthTrackBar_ValueChanged;
            // 
            // passwordLengthTextBox
            // 
            passwordLengthTextBox.Location = new Point(467, 97);
            passwordLengthTextBox.Name = "passwordLengthTextBox";
            passwordLengthTextBox.ShortcutsEnabled = false;
            passwordLengthTextBox.Size = new Size(31, 29);
            passwordLengthTextBox.TabIndex = 5;
            passwordLengthTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // refreshButton
            // 
            refreshButton.Cursor = Cursors.Hand;
            refreshButton.Image = Properties.Resources.Refresh;
            refreshButton.Location = new Point(487, 39);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(32, 32);
            refreshButton.TabIndex = 1;
            toolTip.SetToolTip(refreshButton, "Generate new password");
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(156, 21);
            label2.TabIndex = 7;
            label2.Text = "Generated password:";
            // 
            // passwordCopiedLabel
            // 
            passwordCopiedLabel.AutoSize = true;
            passwordCopiedLabel.Font = new Font("Segoe UI", 10F);
            passwordCopiedLabel.ForeColor = SystemColors.ControlDarkDark;
            passwordCopiedLabel.Location = new Point(383, 15);
            passwordCopiedLabel.Name = "passwordCopiedLabel";
            passwordCopiedLabel.Size = new Size(115, 19);
            passwordCopiedLabel.TabIndex = 8;
            passwordCopiedLabel.Text = "Password copied!";
            passwordCopiedLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 164);
            Controls.Add(passwordCopiedLabel);
            Controls.Add(label2);
            Controls.Add(refreshButton);
            Controls.Add(passwordLengthTextBox);
            Controls.Add(passwordLengthTrackBar);
            Controls.Add(copyButton);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(40, 40, 40);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Secure Password Generator";
            ((System.ComponentModel.ISupportInitialize)passwordLengthTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Label label1;
        private Button copyButton;
        private TrackBar passwordLengthTrackBar;
        private TextBox passwordLengthTextBox;
        private Button refreshButton;
        private ToolTip toolTip;
        private Label label2;
        private Label passwordCopiedLabel;
    }
}
