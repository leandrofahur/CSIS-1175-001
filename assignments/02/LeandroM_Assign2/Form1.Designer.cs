namespace LeandroM_Assign2
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.retailStockListBox = new System.Windows.Forms.ListBox();
            this.loadDataGroupBox = new System.Windows.Forms.GroupBox();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.updateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.restockedQtyTextBox = new System.Windows.Forms.TextBox();
            this.restockedQtyLabel = new System.Windows.Forms.Label();
            this.soldQtyLabel = new System.Windows.Forms.Label();
            this.soldQtyTextBox = new System.Windows.Forms.TextBox();
            this.updateRestokedQtyButton = new System.Windows.Forms.Button();
            this.updateSoldQtyButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.deleteSelectedItemButton = new System.Windows.Forms.Button();
            this.saveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.createSalesReportButton = new System.Windows.Forms.Button();
            this.saveRetailStockDataButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.loadDataGroupBox.SuspendLayout();
            this.updateDataGroupBox.SuspendLayout();
            this.saveDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(272, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(443, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Reatil Stock Application";
            // 
            // retailStockListBox
            // 
            this.retailStockListBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailStockListBox.FormattingEnabled = true;
            this.retailStockListBox.ItemHeight = 15;
            this.retailStockListBox.Location = new System.Drawing.Point(35, 68);
            this.retailStockListBox.Name = "retailStockListBox";
            this.retailStockListBox.Size = new System.Drawing.Size(1120, 229);
            this.retailStockListBox.TabIndex = 1;
            // 
            // loadDataGroupBox
            // 
            this.loadDataGroupBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.loadDataGroupBox.Controls.Add(this.loadDataButton);
            this.loadDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDataGroupBox.Location = new System.Drawing.Point(158, 327);
            this.loadDataGroupBox.Name = "loadDataGroupBox";
            this.loadDataGroupBox.Size = new System.Drawing.Size(163, 124);
            this.loadDataGroupBox.TabIndex = 2;
            this.loadDataGroupBox.TabStop = false;
            this.loadDataGroupBox.Text = "Load Data";
            // 
            // loadDataButton
            // 
            this.loadDataButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loadDataButton.Location = new System.Drawing.Point(16, 45);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(126, 55);
            this.loadDataButton.TabIndex = 0;
            this.loadDataButton.Text = "Read Retail Stock Data";
            this.loadDataButton.UseVisualStyleBackColor = false;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // updateDataGroupBox
            // 
            this.updateDataGroupBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.updateDataGroupBox.Controls.Add(this.restockedQtyTextBox);
            this.updateDataGroupBox.Controls.Add(this.restockedQtyLabel);
            this.updateDataGroupBox.Controls.Add(this.soldQtyLabel);
            this.updateDataGroupBox.Controls.Add(this.soldQtyTextBox);
            this.updateDataGroupBox.Controls.Add(this.updateRestokedQtyButton);
            this.updateDataGroupBox.Controls.Add(this.updateSoldQtyButton);
            this.updateDataGroupBox.Controls.Add(this.sortButton);
            this.updateDataGroupBox.Controls.Add(this.deleteSelectedItemButton);
            this.updateDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDataGroupBox.Location = new System.Drawing.Point(327, 327);
            this.updateDataGroupBox.Name = "updateDataGroupBox";
            this.updateDataGroupBox.Size = new System.Drawing.Size(527, 146);
            this.updateDataGroupBox.TabIndex = 3;
            this.updateDataGroupBox.TabStop = false;
            this.updateDataGroupBox.Text = "Update Data";
            // 
            // restockedQtyTextBox
            // 
            this.restockedQtyTextBox.Location = new System.Drawing.Point(407, 32);
            this.restockedQtyTextBox.Name = "restockedQtyTextBox";
            this.restockedQtyTextBox.Size = new System.Drawing.Size(114, 23);
            this.restockedQtyTextBox.TabIndex = 8;
            // 
            // restockedQtyLabel
            // 
            this.restockedQtyLabel.AutoSize = true;
            this.restockedQtyLabel.Location = new System.Drawing.Point(265, 35);
            this.restockedQtyLabel.Name = "restockedQtyLabel";
            this.restockedQtyLabel.Size = new System.Drawing.Size(136, 17);
            this.restockedQtyLabel.TabIndex = 7;
            this.restockedQtyLabel.Text = "Restocked Quantity:";
            // 
            // soldQtyLabel
            // 
            this.soldQtyLabel.AutoSize = true;
            this.soldQtyLabel.Location = new System.Drawing.Point(7, 35);
            this.soldQtyLabel.Name = "soldQtyLabel";
            this.soldQtyLabel.Size = new System.Drawing.Size(97, 17);
            this.soldQtyLabel.TabIndex = 6;
            this.soldQtyLabel.Text = "Sold Quantity:";
            // 
            // soldQtyTextBox
            // 
            this.soldQtyTextBox.Location = new System.Drawing.Point(110, 32);
            this.soldQtyTextBox.Name = "soldQtyTextBox";
            this.soldQtyTextBox.Size = new System.Drawing.Size(142, 23);
            this.soldQtyTextBox.TabIndex = 5;
            // 
            // updateRestokedQtyButton
            // 
            this.updateRestokedQtyButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updateRestokedQtyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRestokedQtyButton.Location = new System.Drawing.Point(268, 66);
            this.updateRestokedQtyButton.Name = "updateRestokedQtyButton";
            this.updateRestokedQtyButton.Size = new System.Drawing.Size(253, 34);
            this.updateRestokedQtyButton.TabIndex = 4;
            this.updateRestokedQtyButton.Text = "Update Restocked Qty For Selected Item";
            this.updateRestokedQtyButton.UseVisualStyleBackColor = false;
            this.updateRestokedQtyButton.Click += new System.EventHandler(this.updateRestokedQtyButton_Click);
            // 
            // updateSoldQtyButton
            // 
            this.updateSoldQtyButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.updateSoldQtyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSoldQtyButton.Location = new System.Drawing.Point(6, 66);
            this.updateSoldQtyButton.Name = "updateSoldQtyButton";
            this.updateSoldQtyButton.Size = new System.Drawing.Size(246, 34);
            this.updateSoldQtyButton.TabIndex = 3;
            this.updateSoldQtyButton.Text = "Update Sold Qty For Selected Item";
            this.updateSoldQtyButton.UseVisualStyleBackColor = false;
            this.updateSoldQtyButton.Click += new System.EventHandler(this.updateSoldQtyButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(268, 106);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(253, 34);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Sort By Descending Order of Sales";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // deleteSelectedItemButton
            // 
            this.deleteSelectedItemButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.deleteSelectedItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedItemButton.Location = new System.Drawing.Point(6, 106);
            this.deleteSelectedItemButton.Name = "deleteSelectedItemButton";
            this.deleteSelectedItemButton.Size = new System.Drawing.Size(246, 34);
            this.deleteSelectedItemButton.TabIndex = 1;
            this.deleteSelectedItemButton.Text = "Delete Selected Retail Item";
            this.deleteSelectedItemButton.UseVisualStyleBackColor = false;
            this.deleteSelectedItemButton.Click += new System.EventHandler(this.deleteSelectedItemButton_Click);
            // 
            // saveDataGroupBox
            // 
            this.saveDataGroupBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.saveDataGroupBox.Controls.Add(this.button7);
            this.saveDataGroupBox.Controls.Add(this.createSalesReportButton);
            this.saveDataGroupBox.Controls.Add(this.saveRetailStockDataButton);
            this.saveDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataGroupBox.Location = new System.Drawing.Point(860, 327);
            this.saveDataGroupBox.Name = "saveDataGroupBox";
            this.saveDataGroupBox.Size = new System.Drawing.Size(177, 146);
            this.saveDataGroupBox.TabIndex = 3;
            this.saveDataGroupBox.TabStop = false;
            this.saveDataGroupBox.Text = "Save Data";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 28);
            this.button7.TabIndex = 7;
            this.button7.Text = "Create Restock Needs Report";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // createSalesReportButton
            // 
            this.createSalesReportButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.createSalesReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSalesReportButton.Location = new System.Drawing.Point(6, 73);
            this.createSalesReportButton.Name = "createSalesReportButton";
            this.createSalesReportButton.Size = new System.Drawing.Size(165, 28);
            this.createSalesReportButton.TabIndex = 6;
            this.createSalesReportButton.Text = "Create Sales Report";
            this.createSalesReportButton.UseVisualStyleBackColor = false;
            this.createSalesReportButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // saveRetailStockDataButton
            // 
            this.saveRetailStockDataButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.saveRetailStockDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRetailStockDataButton.Location = new System.Drawing.Point(6, 35);
            this.saveRetailStockDataButton.Name = "saveRetailStockDataButton";
            this.saveRetailStockDataButton.Size = new System.Drawing.Size(165, 28);
            this.saveRetailStockDataButton.TabIndex = 5;
            this.saveRetailStockDataButton.Text = "Save Retail Stock Data";
            this.saveRetailStockDataButton.UseVisualStyleBackColor = false;
            this.saveRetailStockDataButton.Click += new System.EventHandler(this.saveRetailStockDataButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(280, 489);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(10);
            this.statusLabel.Size = new System.Drawing.Size(631, 71);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Operation Status Update Displayed Here";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1080, 581);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.saveDataGroupBox);
            this.Controls.Add(this.updateDataGroupBox);
            this.Controls.Add(this.loadDataGroupBox);
            this.Controls.Add(this.retailStockListBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.PerformLayout();
            this.saveDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox retailStockListBox;
        private System.Windows.Forms.GroupBox loadDataGroupBox;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.GroupBox updateDataGroupBox;
        private System.Windows.Forms.Button updateRestokedQtyButton;
        private System.Windows.Forms.Button updateSoldQtyButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button deleteSelectedItemButton;
        private System.Windows.Forms.GroupBox saveDataGroupBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button createSalesReportButton;
        private System.Windows.Forms.Button saveRetailStockDataButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox restockedQtyTextBox;
        private System.Windows.Forms.Label restockedQtyLabel;
        private System.Windows.Forms.Label soldQtyLabel;
        private System.Windows.Forms.TextBox soldQtyTextBox;
    }
}

