namespace WindowsFormsPractice
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
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.insertTaskTextBox = new System.Windows.Forms.TextBox();
            this.searchTaskTextBox = new System.Windows.Forms.TextBox();
            this.insertTaskLabel = new System.Windows.Forms.Label();
            this.searchTaskLabel = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.clearTaskButton = new System.Windows.Forms.Button();
            this.searchTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskListBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskListBox
            // 
            this.taskListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 20;
            this.taskListBox.Location = new System.Drawing.Point(12, 218);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(372, 224);
            this.taskListBox.TabIndex = 0;
            // 
            // insertTaskTextBox
            // 
            this.insertTaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTaskTextBox.Location = new System.Drawing.Point(12, 34);
            this.insertTaskTextBox.Name = "insertTaskTextBox";
            this.insertTaskTextBox.Size = new System.Drawing.Size(372, 26);
            this.insertTaskTextBox.TabIndex = 1;
            // 
            // searchTaskTextBox
            // 
            this.searchTaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTaskTextBox.Location = new System.Drawing.Point(12, 139);
            this.searchTaskTextBox.Name = "searchTaskTextBox";
            this.searchTaskTextBox.Size = new System.Drawing.Size(372, 26);
            this.searchTaskTextBox.TabIndex = 2;
            // 
            // insertTaskLabel
            // 
            this.insertTaskLabel.AutoSize = true;
            this.insertTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTaskLabel.Location = new System.Drawing.Point(12, 11);
            this.insertTaskLabel.Name = "insertTaskLabel";
            this.insertTaskLabel.Size = new System.Drawing.Size(88, 20);
            this.insertTaskLabel.TabIndex = 3;
            this.insertTaskLabel.Text = "Insert Task";
            // 
            // searchTaskLabel
            // 
            this.searchTaskLabel.AutoSize = true;
            this.searchTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTaskLabel.Location = new System.Drawing.Point(12, 116);
            this.searchTaskLabel.Name = "searchTaskLabel";
            this.searchTaskLabel.Size = new System.Drawing.Size(98, 20);
            this.searchTaskLabel.TabIndex = 4;
            this.searchTaskLabel.Text = "Search Task";
            // 
            // addTaskButton
            // 
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.Location = new System.Drawing.Point(12, 66);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(80, 29);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.Text = "Add";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // clearTaskButton
            // 
            this.clearTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTaskButton.Location = new System.Drawing.Point(98, 66);
            this.clearTaskButton.Name = "clearTaskButton";
            this.clearTaskButton.Size = new System.Drawing.Size(80, 29);
            this.clearTaskButton.TabIndex = 6;
            this.clearTaskButton.Text = "Clear";
            this.clearTaskButton.UseVisualStyleBackColor = true;
            this.clearTaskButton.Click += new System.EventHandler(this.clearTaskButton_Click);
            // 
            // searchTaskButton
            // 
            this.searchTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTaskButton.Location = new System.Drawing.Point(12, 171);
            this.searchTaskButton.Name = "searchTaskButton";
            this.searchTaskButton.Size = new System.Drawing.Size(80, 29);
            this.searchTaskButton.TabIndex = 7;
            this.searchTaskButton.Text = "Search";
            this.searchTaskButton.UseVisualStyleBackColor = true;
            this.searchTaskButton.Click += new System.EventHandler(this.searchTaskButton_Click);
            // 
            // deleteTaskListBoxButton
            // 
            this.deleteTaskListBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTaskListBoxButton.Location = new System.Drawing.Point(151, 448);
            this.deleteTaskListBoxButton.Name = "deleteTaskListBoxButton";
            this.deleteTaskListBoxButton.Size = new System.Drawing.Size(80, 29);
            this.deleteTaskListBoxButton.TabIndex = 8;
            this.deleteTaskListBoxButton.Text = "Delete";
            this.deleteTaskListBoxButton.UseVisualStyleBackColor = true;
            this.deleteTaskListBoxButton.Click += new System.EventHandler(this.deleteTaskListBoxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(396, 487);
            this.Controls.Add(this.deleteTaskListBoxButton);
            this.Controls.Add(this.searchTaskButton);
            this.Controls.Add(this.clearTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.searchTaskLabel);
            this.Controls.Add(this.insertTaskLabel);
            this.Controls.Add(this.searchTaskTextBox);
            this.Controls.Add(this.insertTaskTextBox);
            this.Controls.Add(this.taskListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.TextBox insertTaskTextBox;
        private System.Windows.Forms.TextBox searchTaskTextBox;
        private System.Windows.Forms.Label insertTaskLabel;
        private System.Windows.Forms.Label searchTaskLabel;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button clearTaskButton;
        private System.Windows.Forms.Button searchTaskButton;
        private System.Windows.Forms.Button deleteTaskListBoxButton;
    }
}

