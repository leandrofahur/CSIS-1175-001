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
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
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
            this.userProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.sortByAgeBtn = new System.Windows.Forms.Button();
            this.userBioGroupBox.SuspendLayout();
            this.userProcessGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBioGroupBox
            // 
            this.userBioGroupBox.BackColor = System.Drawing.Color.PeachPuff;
            this.userBioGroupBox.Controls.Add(this.userIdTextBox);
            this.userBioGroupBox.Controls.Add(this.userIdLabel);
            this.userBioGroupBox.Controls.Add(this.userNameTextBox);
            this.userBioGroupBox.Controls.Add(this.userNameLabel);
            this.userBioGroupBox.Controls.Add(this.userAgeLabel);
            this.userBioGroupBox.Controls.Add(this.userAgeTextBox);
            this.userBioGroupBox.Location = new System.Drawing.Point(95, 29);
            this.userBioGroupBox.Name = "userBioGroupBox";
            this.userBioGroupBox.Size = new System.Drawing.Size(199, 127);
            this.userBioGroupBox.TabIndex = 15;
            this.userBioGroupBox.TabStop = false;
            this.userBioGroupBox.Text = "User Bio";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(84, 30);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIdTextBox.TabIndex = 6;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(32, 41);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(44, 13);
            this.userIdLabel.TabIndex = 5;
            this.userIdLabel.Text = "User Id:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(84, 56);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(15, 63);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // userAgeLabel
            // 
            this.userAgeLabel.AutoSize = true;
            this.userAgeLabel.Location = new System.Drawing.Point(24, 88);
            this.userAgeLabel.Name = "userAgeLabel";
            this.userAgeLabel.Size = new System.Drawing.Size(54, 13);
            this.userAgeLabel.TabIndex = 2;
            this.userAgeLabel.Text = "User Age:";
            // 
            // userAgeTextBox
            // 
            this.userAgeTextBox.Location = new System.Drawing.Point(85, 81);
            this.userAgeTextBox.Name = "userAgeTextBox";
            this.userAgeTextBox.Size = new System.Drawing.Size(99, 20);
            this.userAgeTextBox.TabIndex = 4;
            // 
            // writeToFileButton
            // 
            this.writeToFileButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.writeToFileButton.Location = new System.Drawing.Point(23, 173);
            this.writeToFileButton.Name = "writeToFileButton";
            this.writeToFileButton.Size = new System.Drawing.Size(154, 35);
            this.writeToFileButton.TabIndex = 19;
            this.writeToFileButton.Text = "Write Output To File";
            this.writeToFileButton.UseVisualStyleBackColor = false;
            this.writeToFileButton.Click += new System.EventHandler(this.writeToFileButton_Click);
            // 
            // subtract10FromSelectedAgeButton
            // 
            this.subtract10FromSelectedAgeButton.Location = new System.Drawing.Point(23, 64);
            this.subtract10FromSelectedAgeButton.Name = "subtract10FromSelectedAgeButton";
            this.subtract10FromSelectedAgeButton.Size = new System.Drawing.Size(154, 43);
            this.subtract10FromSelectedAgeButton.TabIndex = 18;
            this.subtract10FromSelectedAgeButton.Text = "Subtract 10 years from Selected User";
            this.subtract10FromSelectedAgeButton.UseVisualStyleBackColor = true;
            this.subtract10FromSelectedAgeButton.Click += new System.EventHandler(this.subtract10FromSelectedAgeButton_Click);
            // 
            // add10ToEachAgeButton
            // 
            this.add10ToEachAgeButton.Location = new System.Drawing.Point(23, 13);
            this.add10ToEachAgeButton.Name = "add10ToEachAgeButton";
            this.add10ToEachAgeButton.Size = new System.Drawing.Size(154, 31);
            this.add10ToEachAgeButton.TabIndex = 17;
            this.add10ToEachAgeButton.Text = "Add 10 years to each Age";
            this.add10ToEachAgeButton.UseVisualStyleBackColor = true;
            this.add10ToEachAgeButton.Click += new System.EventHandler(this.add10ToEachAgeButton_Click);
            // 
            // readFromFileButton
            // 
            this.readFromFileButton.Location = new System.Drawing.Point(319, 162);
            this.readFromFileButton.Name = "readFromFileButton";
            this.readFromFileButton.Size = new System.Drawing.Size(110, 24);
            this.readFromFileButton.TabIndex = 16;
            this.readFromFileButton.Text = "Read From File";
            this.readFromFileButton.UseVisualStyleBackColor = true;
            this.readFromFileButton.Click += new System.EventHandler(this.readFromFileButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Items.AddRange(new object[] {
            "line 1",
            "line 2",
            "line 3",
            "line 4",
            "Line 5",
            "Line 6",
            "Line 7",
            "Line 8",
            "Line 9",
            "Hello World"});
            this.outputListBox.Location = new System.Drawing.Point(109, 220);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(249, 108);
            this.outputListBox.TabIndex = 14;
            this.outputListBox.SelectedIndexChanged += new System.EventHandler(this.outputListBox_SelectedIndexChanged);
            // 
            // displayDetailsBtn
            // 
            this.displayDetailsBtn.Location = new System.Drawing.Point(130, 162);
            this.displayDetailsBtn.Name = "displayDetailsBtn";
            this.displayDetailsBtn.Size = new System.Drawing.Size(91, 37);
            this.displayDetailsBtn.TabIndex = 13;
            this.displayDetailsBtn.Text = "Display Details";
            this.displayDetailsBtn.UseVisualStyleBackColor = true;
            this.displayDetailsBtn.Click += new System.EventHandler(this.displayDetailsBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Location = new System.Drawing.Point(245, 347);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(389, 58);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status will be displayed here";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userProcessGroupBox
            // 
            this.userProcessGroupBox.BackColor = System.Drawing.Color.PeachPuff;
            this.userProcessGroupBox.Controls.Add(this.sortByAgeBtn);
            this.userProcessGroupBox.Controls.Add(this.add10ToEachAgeButton);
            this.userProcessGroupBox.Controls.Add(this.subtract10FromSelectedAgeButton);
            this.userProcessGroupBox.Controls.Add(this.writeToFileButton);
            this.userProcessGroupBox.Location = new System.Drawing.Point(506, 65);
            this.userProcessGroupBox.Name = "userProcessGroupBox";
            this.userProcessGroupBox.Size = new System.Drawing.Size(200, 224);
            this.userProcessGroupBox.TabIndex = 20;
            this.userProcessGroupBox.TabStop = false;
            this.userProcessGroupBox.Text = "User Process";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(361, 65);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 21;
            this.btnTest.Text = "button test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortByAgeBtn
            // 
            this.sortByAgeBtn.Location = new System.Drawing.Point(68, 130);
            this.sortByAgeBtn.Name = "sortByAgeBtn";
            this.sortByAgeBtn.Size = new System.Drawing.Size(75, 23);
            this.sortByAgeBtn.TabIndex = 20;
            this.sortByAgeBtn.Text = "Sort By Age";
            this.sortByAgeBtn.UseVisualStyleBackColor = true;
            this.sortByAgeBtn.Click += new System.EventHandler(this.sortByAgeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.userProcessGroupBox);
            this.Controls.Add(this.userBioGroupBox);
            this.Controls.Add(this.readFromFileButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.displayDetailsBtn);
            this.Controls.Add(this.statusLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.userBioGroupBox.ResumeLayout(false);
            this.userBioGroupBox.PerformLayout();
            this.userProcessGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox userProcessGroupBox;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Button sortByAgeBtn;
    }
}

