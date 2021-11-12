
namespace UTE_Product_Purchase
{
    partial class PurchasesForm
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
            this.purchaseDataGrid = new System.Windows.Forms.DataGridView();
            this.memName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.getPurchasesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseDataGrid
            // 
            this.purchaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memName,
            this.Product,
            this.Date});
            this.purchaseDataGrid.Location = new System.Drawing.Point(12, 31);
            this.purchaseDataGrid.Name = "purchaseDataGrid";
            this.purchaseDataGrid.RowHeadersVisible = false;
            this.purchaseDataGrid.RowHeadersWidth = 51;
            this.purchaseDataGrid.Size = new System.Drawing.Size(776, 276);
            this.purchaseDataGrid.TabIndex = 0;
            // 
            // memName
            // 
            this.memName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memName.HeaderText = "Name";
            this.memName.MinimumWidth = 6;
            this.memName.Name = "memName";
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // totalGridView
            // 
            this.totalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.quantityCol});
            this.totalGridView.Location = new System.Drawing.Point(12, 334);
            this.totalGridView.Name = "totalGridView";
            this.totalGridView.RowHeadersVisible = false;
            this.totalGridView.RowHeadersWidth = 51;
            this.totalGridView.Size = new System.Drawing.Size(776, 322);
            this.totalGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // quantityCol
            // 
            this.quantityCol.HeaderText = "Quantity";
            this.quantityCol.MinimumWidth = 6;
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "All Purchases:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Totals:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(293, 675);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 24;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(499, 675);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 25;
            // 
            // getPurchasesBtn
            // 
            this.getPurchasesBtn.AutoSize = true;
            this.getPurchasesBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.getPurchasesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.getPurchasesBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.getPurchasesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.getPurchasesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.getPurchasesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getPurchasesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getPurchasesBtn.Location = new System.Drawing.Point(704, 673);
            this.getPurchasesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.getPurchasesBtn.Name = "getPurchasesBtn";
            this.getPurchasesBtn.Size = new System.Drawing.Size(87, 25);
            this.getPurchasesBtn.TabIndex = 26;
            this.getPurchasesBtn.Text = "Get Purchases";
            this.getPurchasesBtn.UseVisualStyleBackColor = false;
            this.getPurchasesBtn.Click += new System.EventHandler(this.GetPurchasesBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 659);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "End Date:";
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getPurchasesBtn);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalGridView);
            this.Controls.Add(this.purchaseDataGrid);
            this.Name = "PurchasesForm";
            this.Text = "PurchasesForm";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView purchaseDataGrid;
        private System.Windows.Forms.DataGridView totalGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn memName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button getPurchasesBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}