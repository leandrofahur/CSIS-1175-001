namespace ApplicationForm
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
            this.formGroupBox = new System.Windows.Forms.GroupBox();
            this.reenterPasswordVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.reenterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.reenterPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveListButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.formGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // formGroupBox
            // 
            this.formGroupBox.Controls.Add(this.clearListButton);
            this.formGroupBox.Controls.Add(this.reenterPasswordVisibleCheckBox);
            this.formGroupBox.Controls.Add(this.passwordVisibleCheckBox);
            this.formGroupBox.Controls.Add(this.clearButton);
            this.formGroupBox.Controls.Add(this.addButton);
            this.formGroupBox.Controls.Add(this.reenterPasswordTextBox);
            this.formGroupBox.Controls.Add(this.reenterPasswordLabel);
            this.formGroupBox.Controls.Add(this.passwordTextBox);
            this.formGroupBox.Controls.Add(this.passwordLabel);
            this.formGroupBox.Controls.Add(this.lastNameTextBox);
            this.formGroupBox.Controls.Add(this.lastNameLabel);
            this.formGroupBox.Controls.Add(this.firstNameTextBox);
            this.formGroupBox.Controls.Add(this.firstNameLabel);
            this.formGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.formGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formGroupBox.Location = new System.Drawing.Point(12, 11);
            this.formGroupBox.Name = "formGroupBox";
            this.formGroupBox.Size = new System.Drawing.Size(258, 407);
            this.formGroupBox.TabIndex = 0;
            this.formGroupBox.TabStop = false;
            this.formGroupBox.Text = "User Form";
            // 
            // reenterPasswordVisibleCheckBox
            // 
            this.reenterPasswordVisibleCheckBox.AutoSize = true;
            this.reenterPasswordVisibleCheckBox.Location = new System.Drawing.Point(11, 263);
            this.reenterPasswordVisibleCheckBox.Name = "reenterPasswordVisibleCheckBox";
            this.reenterPasswordVisibleCheckBox.Size = new System.Drawing.Size(70, 24);
            this.reenterPasswordVisibleCheckBox.TabIndex = 11;
            this.reenterPasswordVisibleCheckBox.Text = "visible";
            this.reenterPasswordVisibleCheckBox.UseVisualStyleBackColor = true;
            this.reenterPasswordVisibleCheckBox.CheckedChanged += new System.EventHandler(this.reenterPasswordVisibleCheckBox_CheckedChanged);
            // 
            // passwordVisibleCheckBox
            // 
            this.passwordVisibleCheckBox.AutoSize = true;
            this.passwordVisibleCheckBox.Location = new System.Drawing.Point(10, 181);
            this.passwordVisibleCheckBox.Name = "passwordVisibleCheckBox";
            this.passwordVisibleCheckBox.Size = new System.Drawing.Size(74, 24);
            this.passwordVisibleCheckBox.TabIndex = 2;
            this.passwordVisibleCheckBox.Text = "Visible";
            this.passwordVisibleCheckBox.UseVisualStyleBackColor = true;
            this.passwordVisibleCheckBox.CheckedChanged += new System.EventHandler(this.passwordVisibleCheckBox_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(277, 387);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(162, 31);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(138, 311);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 31);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(11, 311);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 31);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // reenterPasswordTextBox
            // 
            this.reenterPasswordTextBox.Location = new System.Drawing.Point(11, 231);
            this.reenterPasswordTextBox.Name = "reenterPasswordTextBox";
            this.reenterPasswordTextBox.Size = new System.Drawing.Size(236, 26);
            this.reenterPasswordTextBox.TabIndex = 7;
            this.reenterPasswordTextBox.TextChanged += new System.EventHandler(this.reenterPasswordTextBox_TextChanged);
            // 
            // reenterPasswordLabel
            // 
            this.reenterPasswordLabel.AutoSize = true;
            this.reenterPasswordLabel.Location = new System.Drawing.Point(6, 208);
            this.reenterPasswordLabel.Name = "reenterPasswordLabel";
            this.reenterPasswordLabel.Size = new System.Drawing.Size(140, 20);
            this.reenterPasswordLabel.TabIndex = 6;
            this.reenterPasswordLabel.Text = "Reenter Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(11, 149);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(236, 26);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(7, 126);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(11, 97);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(7, 74);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(11, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 22);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(277, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 355);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // saveListButton
            // 
            this.saveListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveListButton.Location = new System.Drawing.Point(444, 387);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(164, 31);
            this.saveListButton.TabIndex = 12;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearListButton.Location = new System.Drawing.Point(11, 359);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(236, 31);
            this.clearListButton.TabIndex = 13;
            this.clearListButton.Text = "Upload List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 428);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.formGroupBox);
            this.Controls.Add(this.saveListButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.formGroupBox.ResumeLayout(false);
            this.formGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox formGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox reenterPasswordTextBox;
        private System.Windows.Forms.Label reenterPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox reenterPasswordVisibleCheckBox;
        private System.Windows.Forms.CheckBox passwordVisibleCheckBox;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.Button saveListButton;
    }
}

