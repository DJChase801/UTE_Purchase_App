
namespace UTE_Product_Purchase
{
    partial class AdminStart
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
            this.label5 = new System.Windows.Forms.Label();
            this.prodsBtn = new System.Windows.Forms.Button();
            this.purchasesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(65, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "UTE ADMINS ONLY!";
            // 
            // prodsBtn
            // 
            this.prodsBtn.AutoSize = true;
            this.prodsBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.prodsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.prodsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.prodsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.prodsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prodsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodsBtn.Location = new System.Drawing.Point(40, 105);
            this.prodsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.prodsBtn.Name = "prodsBtn";
            this.prodsBtn.Size = new System.Drawing.Size(85, 25);
            this.prodsBtn.TabIndex = 18;
            this.prodsBtn.Text = "Products";
            this.prodsBtn.UseVisualStyleBackColor = false;
            this.prodsBtn.Click += new System.EventHandler(this.prodsBtn_Click);
            // 
            // purchasesBtn
            // 
            this.purchasesBtn.AutoSize = true;
            this.purchasesBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.purchasesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.purchasesBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.purchasesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.purchasesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.purchasesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchasesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.purchasesBtn.Location = new System.Drawing.Point(207, 105);
            this.purchasesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.purchasesBtn.Name = "purchasesBtn";
            this.purchasesBtn.Size = new System.Drawing.Size(85, 25);
            this.purchasesBtn.TabIndex = 19;
            this.purchasesBtn.Text = "Purchases";
            this.purchasesBtn.UseVisualStyleBackColor = false;
            this.purchasesBtn.Click += new System.EventHandler(this.purchasesBtn_Click);
            // 
            // AdminStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(338, 179);
            this.Controls.Add(this.purchasesBtn);
            this.Controls.Add(this.prodsBtn);
            this.Controls.Add(this.label5);
            this.Name = "AdminStart";
            this.Text = "AdminStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button prodsBtn;
        private System.Windows.Forms.Button purchasesBtn;
    }
}