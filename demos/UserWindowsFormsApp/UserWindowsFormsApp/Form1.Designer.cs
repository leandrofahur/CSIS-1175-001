namespace UserWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextbox = new System.Windows.Forms.TextBox();
            this.clickButton = new System.Windows.Forms.Button();
            this.userProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userAgeLabel = new System.Windows.Forms.Label();
            this.userAgeTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.writeToFileButton = new System.Windows.Forms.Button();
            this.userProcessGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(13, 71);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(83, 17);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name:";
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.Location = new System.Drawing.Point(104, 71);
            this.userNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.Size = new System.Drawing.Size(132, 22);
            this.userNameTextbox.TabIndex = 1;
            // 
            // clickButton
            // 
            this.clickButton.AutoSize = true;
            this.clickButton.BackColor = System.Drawing.Color.Cornsilk;
            this.clickButton.Location = new System.Drawing.Point(121, 144);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(105, 27);
            this.clickButton.TabIndex = 2;
            this.clickButton.Text = "Click Here";
            this.clickButton.UseVisualStyleBackColor = false;
            this.clickButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userProcessGroupBox
            // 
            this.userProcessGroupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.userProcessGroupBox.Controls.Add(this.userIdTextBox);
            this.userProcessGroupBox.Controls.Add(this.userIdLabel);
            this.userProcessGroupBox.Controls.Add(this.userAgeLabel);
            this.userProcessGroupBox.Controls.Add(this.userAgeTextBox);
            this.userProcessGroupBox.Controls.Add(this.userNameTextbox);
            this.userProcessGroupBox.Controls.Add(this.clickButton);
            this.userProcessGroupBox.Controls.Add(this.userNameLabel);
            this.userProcessGroupBox.Location = new System.Drawing.Point(441, 70);
            this.userProcessGroupBox.Name = "userProcessGroupBox";
            this.userProcessGroupBox.Size = new System.Drawing.Size(276, 198);
            this.userProcessGroupBox.TabIndex = 3;
            this.userProcessGroupBox.TabStop = false;
            this.userProcessGroupBox.Text = "User Process";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(103, 41);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(133, 22);
            this.userIdTextBox.TabIndex = 6;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(39, 41);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(57, 17);
            this.userIdLabel.TabIndex = 5;
            this.userIdLabel.Text = "User Id:";
            // 
            // userAgeLabel
            // 
            this.userAgeLabel.AutoSize = true;
            this.userAgeLabel.Location = new System.Drawing.Point(25, 116);
            this.userAgeLabel.Name = "userAgeLabel";
            this.userAgeLabel.Size = new System.Drawing.Size(71, 17);
            this.userAgeLabel.TabIndex = 4;
            this.userAgeLabel.Text = "User Age:";
            this.userAgeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // userAgeTextBox
            // 
            this.userAgeTextBox.Location = new System.Drawing.Point(104, 116);
            this.userAgeTextBox.Name = "userAgeTextBox";
            this.userAgeTextBox.Size = new System.Drawing.Size(132, 22);
            this.userAgeTextBox.TabIndex = 3;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Items.AddRange(new object[] {
            "line 1",
            "line 2",
            "line 3",
            "line 4",
            "line 5"});
            this.outputListBox.Location = new System.Drawing.Point(117, 70);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(294, 196);
            this.outputListBox.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(571, 291);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 5;
            // 
            // writeToFileButton
            // 
            this.writeToFileButton.AutoSize = true;
            this.writeToFileButton.Location = new System.Drawing.Point(495, 324);
            this.writeToFileButton.Name = "writeToFileButton";
            this.writeToFileButton.Size = new System.Drawing.Size(172, 27);
            this.writeToFileButton.TabIndex = 6;
            this.writeToFileButton.Text = "Write Output File";
            this.writeToFileButton.UseVisualStyleBackColor = true;
            this.writeToFileButton.Click += new System.EventHandler(this.writeToFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.writeToFileButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.userProcessGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.userProcessGroupBox.ResumeLayout(false);
            this.userProcessGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextbox;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.GroupBox userProcessGroupBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label userAgeLabel;
        private System.Windows.Forms.TextBox userAgeTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Button writeToFileButton;
    }
}

