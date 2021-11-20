
namespace UTE_Product_Purchase
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.memNameTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.prodCmbox = new System.Windows.Forms.ComboBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prodPriceLbl = new System.Windows.Forms.Label();
            this.prodNameLbl = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.prodPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cartList = new System.Windows.Forms.ListBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.scanLabel = new System.Windows.Forms.Label();
            this.scanTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // memNameTB
            // 
            this.memNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memNameTB.Location = new System.Drawing.Point(18, 103);
            this.memNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.memNameTB.Name = "memNameTB";
            this.memNameTB.Size = new System.Drawing.Size(274, 26);
            this.memNameTB.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.Location = new System.Drawing.Point(18, 80);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(117, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Member Name:";
            // 
            // prodCmbox
            // 
            this.prodCmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCmbox.FormattingEnabled = true;
            this.prodCmbox.Location = new System.Drawing.Point(18, 166);
            this.prodCmbox.Margin = new System.Windows.Forms.Padding(2);
            this.prodCmbox.Name = "prodCmbox";
            this.prodCmbox.Size = new System.Drawing.Size(274, 28);
            this.prodCmbox.TabIndex = 2;
            this.prodCmbox.SelectedValueChanged += new System.EventHandler(this.prodCmbox_SelectedValueChanged);
            // 
            // acceptBtn
            // 
            this.acceptBtn.AutoSize = true;
            this.acceptBtn.BackColor = System.Drawing.Color.LightGreen;
            this.acceptBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.acceptBtn.FlatAppearance.BorderSize = 2;
            this.acceptBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.acceptBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.acceptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.ForeColor = System.Drawing.Color.Black;
            this.acceptBtn.Location = new System.Drawing.Point(336, 500);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(70, 26);
            this.acceptBtn.TabIndex = 5;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.Location = new System.Drawing.Point(410, 500);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(70, 26);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = " Clear";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(212, 279);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add To Cart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(335, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cart: ";
            // 
            // prodPriceLbl
            // 
            this.prodPriceLbl.AutoSize = true;
            this.prodPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPriceLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodPriceLbl.Location = new System.Drawing.Point(16, 428);
            this.prodPriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodPriceLbl.Name = "prodPriceLbl";
            this.prodPriceLbl.Size = new System.Drawing.Size(48, 20);
            this.prodPriceLbl.TabIndex = 12;
            this.prodPriceLbl.Text = "Price:";
            // 
            // prodNameLbl
            // 
            this.prodNameLbl.AutoSize = true;
            this.prodNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodNameLbl.Location = new System.Drawing.Point(16, 399);
            this.prodNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodNameLbl.Name = "prodNameLbl";
            this.prodNameLbl.Size = new System.Drawing.Size(55, 20);
            this.prodNameLbl.TabIndex = 13;
            this.prodNameLbl.Text = "Name:";
            // 
            // adminBtn
            // 
            this.adminBtn.AutoSize = true;
            this.adminBtn.BackColor = System.Drawing.Color.Red;
            this.adminBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.adminBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.adminBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.adminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.adminBtn.Location = new System.Drawing.Point(525, 11);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(2);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(85, 26);
            this.adminBtn.TabIndex = 14;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.AutoSize = true;
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.removeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.removeBtn.Location = new System.Drawing.Point(484, 500);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(70, 26);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(216, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Product Purchase App";
            // 
            // prodPic
            // 
            this.prodPic.BackColor = System.Drawing.Color.White;
            this.prodPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodPic.InitialImage = global::UTE_Product_Purchase.Properties.Resources.Site_Logo;
            this.prodPic.Location = new System.Drawing.Point(18, 202);
            this.prodPic.Margin = new System.Windows.Forms.Padding(6);
            this.prodPic.Name = "prodPic";
            this.prodPic.Size = new System.Drawing.Size(189, 191);
            this.prodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodPic.TabIndex = 1;
            this.prodPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = global::UTE_Product_Purchase.Properties.Resources.Site_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 53);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cartList
            // 
            this.cartList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartList.FormattingEnabled = true;
            this.cartList.ItemHeight = 20;
            this.cartList.Location = new System.Drawing.Point(339, 103);
            this.cartList.Name = "cartList";
            this.cartList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cartList.Size = new System.Drawing.Size(264, 364);
            this.cartList.TabIndex = 17;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalLbl.Location = new System.Drawing.Point(335, 473);
            this.totalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(48, 20);
            this.totalLbl.TabIndex = 18;
            this.totalLbl.Text = "Total:";
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scanLabel.Location = new System.Drawing.Point(15, 476);
            this.scanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(192, 20);
            this.scanLabel.TabIndex = 20;
            this.scanLabel.Text = "Quick Scan + Add To Cart";
            // 
            // scanTextBox
            // 
            this.scanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanTextBox.Location = new System.Drawing.Point(18, 499);
            this.scanTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.scanTextBox.Name = "scanTextBox";
            this.scanTextBox.Size = new System.Drawing.Size(275, 26);
            this.scanTextBox.TabIndex = 3;
            this.scanTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scanTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select Product:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(621, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodPic);
            this.Controls.Add(this.prodCmbox);
            this.Controls.Add(this.scanLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.scanTextBox);
            this.Controls.Add(this.prodPriceLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.prodNameLbl);
            this.Controls.Add(this.cartList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.memNameTB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "UTE";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox prodPic;
        private System.Windows.Forms.TextBox memNameTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox prodCmbox;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prodPriceLbl;
        private System.Windows.Forms.Label prodNameLbl;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox cartList;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label scanLabel;
        private System.Windows.Forms.TextBox scanTextBox;
        private System.Windows.Forms.Label label2;
    }
}

