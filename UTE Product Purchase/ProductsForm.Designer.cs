
namespace UTE_Product_Purchase
{
    partial class ProductsForm
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
            this.addProductBtn = new System.Windows.Forms.Button();
            this.nameInputTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceInputLbl = new System.Windows.Forms.Label();
            this.priceInputTb = new System.Windows.Forms.TextBox();
            this.prodPanel = new System.Windows.Forms.Panel();
            this.getImgBtn = new System.Windows.Forms.Button();
            this.inputPicBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upcTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductBtn
            // 
            this.addProductBtn.AutoSize = true;
            this.addProductBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addProductBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.addProductBtn.FlatAppearance.BorderSize = 2;
            this.addProductBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.addProductBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.addProductBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addProductBtn.Location = new System.Drawing.Point(422, 199);
            this.addProductBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(85, 25);
            this.addProductBtn.TabIndex = 5;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // nameInputTb
            // 
            this.nameInputTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputTb.Location = new System.Drawing.Point(7, 35);
            this.nameInputTb.Name = "nameInputTb";
            this.nameInputTb.Size = new System.Drawing.Size(221, 26);
            this.nameInputTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // priceInputLbl
            // 
            this.priceInputLbl.AutoSize = true;
            this.priceInputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInputLbl.Location = new System.Drawing.Point(7, 64);
            this.priceInputLbl.Name = "priceInputLbl";
            this.priceInputLbl.Size = new System.Drawing.Size(52, 20);
            this.priceInputLbl.TabIndex = 23;
            this.priceInputLbl.Text = "Price: ";
            // 
            // priceInputTb
            // 
            this.priceInputTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInputTb.Location = new System.Drawing.Point(7, 87);
            this.priceInputTb.Name = "priceInputTb";
            this.priceInputTb.Size = new System.Drawing.Size(221, 26);
            this.priceInputTb.TabIndex = 2;
            // 
            // prodPanel
            // 
            this.prodPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prodPanel.AutoScroll = true;
            this.prodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodPanel.Location = new System.Drawing.Point(7, 229);
            this.prodPanel.Name = "prodPanel";
            this.prodPanel.Size = new System.Drawing.Size(500, 297);
            this.prodPanel.TabIndex = 24;
            // 
            // getImgBtn
            // 
            this.getImgBtn.AutoSize = true;
            this.getImgBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.getImgBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.getImgBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.getImgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.getImgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.getImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getImgBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getImgBtn.Location = new System.Drawing.Point(143, 154);
            this.getImgBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getImgBtn.Name = "getImgBtn";
            this.getImgBtn.Size = new System.Drawing.Size(85, 25);
            this.getImgBtn.TabIndex = 4;
            this.getImgBtn.Text = "Get Image";
            this.getImgBtn.UseVisualStyleBackColor = false;
            this.getImgBtn.Click += new System.EventHandler(this.getImgBtn_Click);
            // 
            // inputPicBox
            // 
            this.inputPicBox.Location = new System.Drawing.Point(12, 119);
            this.inputPicBox.Name = "inputPicBox";
            this.inputPicBox.Size = new System.Drawing.Size(100, 100);
            this.inputPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputPicBox.TabIndex = 29;
            this.inputPicBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "UPC: ";
            // 
            // upcTextBox
            // 
            this.upcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcTextBox.Location = new System.Drawing.Point(232, 87);
            this.upcTextBox.Name = "upcTextBox";
            this.upcTextBox.Size = new System.Drawing.Size(221, 26);
            this.upcTextBox.TabIndex = 3;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(518, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upcTextBox);
            this.Controls.Add(this.inputPicBox);
            this.Controls.Add(this.getImgBtn);
            this.Controls.Add(this.prodPanel);
            this.Controls.Add(this.priceInputLbl);
            this.Controls.Add(this.priceInputTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInputTb);
            this.Controls.Add(this.addProductBtn);
            this.Name = "ProductsForm";
            this.Text = "Products Form";
            ((System.ComponentModel.ISupportInitialize)(this.inputPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.TextBox nameInputTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceInputLbl;
        private System.Windows.Forms.TextBox priceInputTb;
        private System.Windows.Forms.Panel prodPanel;
        private System.Windows.Forms.Button getImgBtn;
        private System.Windows.Forms.PictureBox inputPicBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox upcTextBox;
    }
}