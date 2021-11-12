
namespace UTE_Product_Purchase
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.prodNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodPriceLbl = new System.Windows.Forms.Label();
            this.prodPic = new System.Windows.Forms.PictureBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.prodUPCLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // prodNameLbl
            // 
            this.prodNameLbl.AutoSize = true;
            this.prodNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameLbl.Location = new System.Drawing.Point(161, 9);
            this.prodNameLbl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodNameLbl.Name = "prodNameLbl";
            this.prodNameLbl.Size = new System.Drawing.Size(51, 20);
            this.prodNameLbl.TabIndex = 2;
            this.prodNameLbl.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price: ";
            // 
            // prodPriceLbl
            // 
            this.prodPriceLbl.AutoSize = true;
            this.prodPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPriceLbl.Location = new System.Drawing.Point(161, 37);
            this.prodPriceLbl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodPriceLbl.Name = "prodPriceLbl";
            this.prodPriceLbl.Size = new System.Drawing.Size(51, 20);
            this.prodPriceLbl.TabIndex = 4;
            this.prodPriceLbl.Text = "label4";
            // 
            // prodPic
            // 
            this.prodPic.Location = new System.Drawing.Point(0, 0);
            this.prodPic.Name = "prodPic";
            this.prodPic.Size = new System.Drawing.Size(100, 100);
            this.prodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodPic.TabIndex = 0;
            this.prodPic.TabStop = false;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(357, 37);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // prodUPCLabel
            // 
            this.prodUPCLabel.AutoSize = true;
            this.prodUPCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodUPCLabel.Location = new System.Drawing.Point(161, 67);
            this.prodUPCLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodUPCLabel.Name = "prodUPCLabel";
            this.prodUPCLabel.Size = new System.Drawing.Size(51, 20);
            this.prodUPCLabel.TabIndex = 8;
            this.prodUPCLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "UPC:";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.prodUPCLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.prodPriceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodPic);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(447, 100);
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox prodPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prodNameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prodPriceLbl;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label prodUPCLabel;
        private System.Windows.Forms.Label label4;
    }
}
