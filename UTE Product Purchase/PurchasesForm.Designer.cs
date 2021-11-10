
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
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearDataBtn = new System.Windows.Forms.Button();
            this.totalGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Price,
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
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // clearDataBtn
            // 
            this.clearDataBtn.AutoSize = true;
            this.clearDataBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.clearDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearDataBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.clearDataBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.clearDataBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clearDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearDataBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearDataBtn.Location = new System.Drawing.Point(704, 640);
            this.clearDataBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearDataBtn.Name = "clearDataBtn";
            this.clearDataBtn.Size = new System.Drawing.Size(85, 25);
            this.clearDataBtn.TabIndex = 20;
            this.clearDataBtn.Text = "Clear Data";
            this.clearDataBtn.UseVisualStyleBackColor = false;
            this.clearDataBtn.Click += new System.EventHandler(this.clearDataBtn_Click);
            // 
            // totalGridView
            // 
            this.totalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.quantityCol});
            this.totalGridView.Location = new System.Drawing.Point(13, 334);
            this.totalGridView.Name = "totalGridView";
            this.totalGridView.RowHeadersVisible = false;
            this.totalGridView.RowHeadersWidth = 51;
            this.totalGridView.Size = new System.Drawing.Size(776, 301);
            this.totalGridView.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "All Purchases:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Totals:";
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
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalGridView);
            this.Controls.Add(this.clearDataBtn);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn memName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button clearDataBtn;
        private System.Windows.Forms.DataGridView totalGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityCol;
    }
}