namespace UserWindowsFormsApp
{
    partial class Form1
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
            this.userBioGroupBox = new System.Windows.Forms.GroupBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userAgeLabel = new System.Windows.Forms.Label();
            this.userAgeTextBox = new System.Windows.Forms.TextBox();
            this.writeToFileButton = new System.Windows.Forms.Button();
            this.subtract10FromSelectedAgeButton = new System.Windows.Forms.Button();
            this.add10ToEachAgeButton = new System.Windows.Forms.Button();
            this.readFromFileButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.displayDetailsBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.userBioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBioGroupBox
            // 
            this.userBioGroupBox.BackColor = System.Drawing.Color.PeachPuff;
            this.userBioGroupBox.Controls.Add(this.userNameTextBox);
            this.userBioGroupBox.Controls.Add(this.userNameLabel);
            this.userBioGroupBox.Controls.Add(this.userAgeLabel);
            this.userBioGroupBox.Controls.Add(this.userAgeTextBox);
            this.userBioGroupBox.Location = new System.Drawing.Point(95, 46);
            this.userBioGroupBox.Name = "userBioGroupBox";
            this.userBioGroupBox.Size = new System.Drawing.Size(190, 90);
            this.userBioGroupBox.TabIndex = 15;
            this.userBioGroupBox.TabStop = false;
            this.userBioGroupBox.Text = "User Bio";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(80, 19);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(11, 26);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // userAgeLabel
            // 
            this.userAgeLabel.AutoSize = true;
            this.userAgeLabel.Location = new System.Drawing.Point(20, 51);
            this.userAgeLabel.Name = "userAgeLabel";
            this.userAgeLabel.Size = new System.Drawing.Size(54, 13);
            this.userAgeLabel.TabIndex = 2;
            this.userAgeLabel.Text = "User Age:";
            // 
            // userAgeTextBox
            // 
            this.userAgeTextBox.Location = new System.Drawing.Point(81, 44);
            this.userAgeTextBox.Name = "userAgeTextBox";
            this.userAgeTextBox.Size = new System.Drawing.Size(99, 20);
            this.userAgeTextBox.TabIndex = 4;
            // 
            // writeToFileButton
            // 
            this.writeToFileButton.Location = new System.Drawing.Point(552, 281);
            this.writeToFileButton.Name = "writeToFileButton";
            this.writeToFileButton.Size = new System.Drawing.Size(154, 35);
            this.writeToFileButton.TabIndex = 19;
            this.writeToFileButton.Text = "Write Output To File";
            this.writeToFileButton.UseVisualStyleBackColor = true;
            // 
            // subtract10FromSelectedAgeButton
            // 
            this.subtract10FromSelectedAgeButton.Location = new System.Drawing.Point(552, 219);
            this.subtract10FromSelectedAgeButton.Name = "subtract10FromSelectedAgeButton";
            this.subtract10FromSelectedAgeButton.Size = new System.Drawing.Size(154, 43);
            this.subtract10FromSelectedAgeButton.TabIndex = 18;
            this.subtract10FromSelectedAgeButton.Text = "Subtract 10 years from Selected User";
            this.subtract10FromSelectedAgeButton.UseVisualStyleBackColor = true;
            // 
            // add10ToEachAgeButton
            // 
            this.add10ToEachAgeButton.Location = new System.Drawing.Point(552, 168);
            this.add10ToEachAgeButton.Name = "add10ToEachAgeButton";
            this.add10ToEachAgeButton.Size = new System.Drawing.Size(154, 31);
            this.add10ToEachAgeButton.TabIndex = 17;
            this.add10ToEachAgeButton.Text = "Add 10 years to each Age";
            this.add10ToEachAgeButton.UseVisualStyleBackColor = true;
            // 
            // readFromFileButton
            // 
            this.readFromFileButton.Location = new System.Drawing.Point(346, 168);
            this.readFromFileButton.Name = "readFromFileButton";
            this.readFromFileButton.Size = new System.Drawing.Size(110, 24);
            this.readFromFileButton.TabIndex = 16;
            this.readFromFileButton.Text = "Read From File";
            this.readFromFileButton.UseVisualStyleBackColor = true;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Items.AddRange(new object[] {
            "line 1",
            "line 2",
            "line 3",
            "line 4",
            "Line 5"});
            this.outputListBox.Location = new System.Drawing.Point(111, 219);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(249, 108);
            this.outputListBox.TabIndex = 14;
            // 
            // displayDetailsBtn
            // 
            this.displayDetailsBtn.Location = new System.Drawing.Point(130, 162);
            this.displayDetailsBtn.Name = "displayDetailsBtn";
            this.displayDetailsBtn.Size = new System.Drawing.Size(91, 37);
            this.displayDetailsBtn.TabIndex = 13;
            this.displayDetailsBtn.Text = "Display Details";
            this.displayDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Location = new System.Drawing.Point(294, 348);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(286, 56);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status will be displayed here";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userBioGroupBox);
            this.Controls.Add(this.writeToFileButton);
            this.Controls.Add(this.subtract10FromSelectedAgeButton);
            this.Controls.Add(this.add10ToEachAgeButton);
            this.Controls.Add(this.readFromFileButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.displayDetailsBtn);
            this.Controls.Add(this.statusLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.userBioGroupBox.ResumeLayout(false);
            this.userBioGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userBioGroupBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userAgeLabel;
        private System.Windows.Forms.TextBox userAgeTextBox;
        private System.Windows.Forms.Button writeToFileButton;
        private System.Windows.Forms.Button subtract10FromSelectedAgeButton;
        private System.Windows.Forms.Button add10ToEachAgeButton;
        private System.Windows.Forms.Button readFromFileButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button displayDetailsBtn;
        private System.Windows.Forms.Label statusLabel;
    }
}

