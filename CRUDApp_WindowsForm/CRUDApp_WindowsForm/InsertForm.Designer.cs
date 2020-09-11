namespace CRUDApp_WindowsForm
{
    partial class InsertForm
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
            this.ShohinmeiLbl = new System.Windows.Forms.Label();
            this.BunruiLbl = new System.Windows.Forms.Label();
            this.HanbaiTankaLbl = new System.Windows.Forms.Label();
            this.ShiireTankaLbl = new System.Windows.Forms.Label();
            this.ShohinmeimaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BunruimaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HanbaiTankamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ShiireTankamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.InsertBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShohinmeiLbl
            // 
            this.ShohinmeiLbl.AutoSize = true;
            this.ShohinmeiLbl.Location = new System.Drawing.Point(12, 9);
            this.ShohinmeiLbl.Name = "ShohinmeiLbl";
            this.ShohinmeiLbl.Size = new System.Drawing.Size(41, 12);
            this.ShohinmeiLbl.TabIndex = 0;
            this.ShohinmeiLbl.Text = "商品名";
            // 
            // BunruiLbl
            // 
            this.BunruiLbl.AutoSize = true;
            this.BunruiLbl.Location = new System.Drawing.Point(118, 9);
            this.BunruiLbl.Name = "BunruiLbl";
            this.BunruiLbl.Size = new System.Drawing.Size(53, 12);
            this.BunruiLbl.TabIndex = 1;
            this.BunruiLbl.Text = "商品分類";
            // 
            // HanbaiTankaLbl
            // 
            this.HanbaiTankaLbl.AutoSize = true;
            this.HanbaiTankaLbl.Location = new System.Drawing.Point(224, 9);
            this.HanbaiTankaLbl.Name = "HanbaiTankaLbl";
            this.HanbaiTankaLbl.Size = new System.Drawing.Size(53, 12);
            this.HanbaiTankaLbl.TabIndex = 2;
            this.HanbaiTankaLbl.Text = "販売単価";
            // 
            // ShiireTankaLbl
            // 
            this.ShiireTankaLbl.AutoSize = true;
            this.ShiireTankaLbl.Location = new System.Drawing.Point(330, 9);
            this.ShiireTankaLbl.Name = "ShiireTankaLbl";
            this.ShiireTankaLbl.Size = new System.Drawing.Size(53, 12);
            this.ShiireTankaLbl.TabIndex = 3;
            this.ShiireTankaLbl.Text = "仕入単価";
            // 
            // ShohinmeimaskedTextBox
            // 
            this.ShohinmeimaskedTextBox.Location = new System.Drawing.Point(14, 24);
            this.ShohinmeimaskedTextBox.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.ShohinmeimaskedTextBox.Name = "ShohinmeimaskedTextBox";
            this.ShohinmeimaskedTextBox.Size = new System.Drawing.Size(100, 19);
            this.ShohinmeimaskedTextBox.TabIndex = 4;
            // 
            // BunruimaskedTextBox
            // 
            this.BunruimaskedTextBox.Location = new System.Drawing.Point(120, 24);
            this.BunruimaskedTextBox.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.BunruimaskedTextBox.Name = "BunruimaskedTextBox";
            this.BunruimaskedTextBox.Size = new System.Drawing.Size(100, 19);
            this.BunruimaskedTextBox.TabIndex = 5;
            // 
            // HanbaiTankamaskedTextBox
            // 
            this.HanbaiTankamaskedTextBox.Location = new System.Drawing.Point(226, 24);
            this.HanbaiTankamaskedTextBox.Mask = "000000000";
            this.HanbaiTankamaskedTextBox.Name = "HanbaiTankamaskedTextBox";
            this.HanbaiTankamaskedTextBox.Size = new System.Drawing.Size(100, 19);
            this.HanbaiTankamaskedTextBox.TabIndex = 6;
            this.HanbaiTankamaskedTextBox.ValidatingType = typeof(int);
            // 
            // ShiireTankamaskedTextBox
            // 
            this.ShiireTankamaskedTextBox.Location = new System.Drawing.Point(332, 24);
            this.ShiireTankamaskedTextBox.Mask = "000000000";
            this.ShiireTankamaskedTextBox.Name = "ShiireTankamaskedTextBox";
            this.ShiireTankamaskedTextBox.Size = new System.Drawing.Size(100, 19);
            this.ShiireTankamaskedTextBox.TabIndex = 7;
            // 
            // InsertBtn2
            // 
            this.InsertBtn2.Location = new System.Drawing.Point(357, 49);
            this.InsertBtn2.Name = "InsertBtn2";
            this.InsertBtn2.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn2.TabIndex = 8;
            this.InsertBtn2.Text = "追加";
            this.InsertBtn2.UseVisualStyleBackColor = true;
            this.InsertBtn2.Click += new System.EventHandler(this.InsertBtn2_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 90);
            this.Controls.Add(this.InsertBtn2);
            this.Controls.Add(this.ShiireTankamaskedTextBox);
            this.Controls.Add(this.HanbaiTankamaskedTextBox);
            this.Controls.Add(this.BunruimaskedTextBox);
            this.Controls.Add(this.ShohinmeimaskedTextBox);
            this.Controls.Add(this.ShiireTankaLbl);
            this.Controls.Add(this.HanbaiTankaLbl);
            this.Controls.Add(this.BunruiLbl);
            this.Controls.Add(this.ShohinmeiLbl);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShohinmeiLbl;
        private System.Windows.Forms.Label BunruiLbl;
        private System.Windows.Forms.Label HanbaiTankaLbl;
        private System.Windows.Forms.Label ShiireTankaLbl;
        private System.Windows.Forms.MaskedTextBox ShohinmeimaskedTextBox;
        private System.Windows.Forms.MaskedTextBox BunruimaskedTextBox;
        private System.Windows.Forms.MaskedTextBox HanbaiTankamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox ShiireTankamaskedTextBox;
        private System.Windows.Forms.Button InsertBtn2;
    }
}