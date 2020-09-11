namespace CRUDApp_WindowsForm
{
    partial class CRUDForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Shohin = new System.Windows.Forms.DataGridView();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.csvBtn2 = new System.Windows.Forms.Button();
            this.csvBtn1 = new System.Windows.Forms.Button();
            this.opencsvFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Shohin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Shohin
            // 
            this.dataGridView_Shohin.AllowUserToAddRows = false;
            this.dataGridView_Shohin.AllowUserToOrderColumns = true;
            this.dataGridView_Shohin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Shohin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Shohin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Shohin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Shohin.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_Shohin.Location = new System.Drawing.Point(11, 51);
            this.dataGridView_Shohin.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Shohin.Name = "dataGridView_Shohin";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Shohin.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_Shohin.RowHeadersWidth = 62;
            this.dataGridView_Shohin.RowTemplate.Height = 27;
            this.dataGridView_Shohin.Size = new System.Drawing.Size(565, 267);
            this.dataGridView_Shohin.TabIndex = 0;
            // 
            // ViewBtn
            // 
            this.ViewBtn.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ViewBtn.Location = new System.Drawing.Point(486, 11);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(90, 30);
            this.ViewBtn.TabIndex = 1;
            this.ViewBtn.Text = "表示";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteBtn.Location = new System.Drawing.Point(486, 335);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(90, 30);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InsertBtn.Location = new System.Drawing.Point(11, 335);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(90, 30);
            this.InsertBtn.TabIndex = 3;
            this.InsertBtn.Text = "追加";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UpdateBtn.Location = new System.Drawing.Point(254, 335);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(90, 30);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "編集";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CloseBtn.Location = new System.Drawing.Point(486, 460);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(90, 30);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "終了";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // csvBtn2
            // 
            this.csvBtn2.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.csvBtn2.Location = new System.Drawing.Point(11, 420);
            this.csvBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.csvBtn2.Name = "csvBtn2";
            this.csvBtn2.Size = new System.Drawing.Size(226, 30);
            this.csvBtn2.TabIndex = 7;
            this.csvBtn2.Text = "csvから追加（２）";
            this.csvBtn2.UseVisualStyleBackColor = true;
            this.csvBtn2.Click += new System.EventHandler(this.csvBtn2_Click);
            // 
            // csvBtn1
            // 
            this.csvBtn1.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.csvBtn1.Location = new System.Drawing.Point(11, 386);
            this.csvBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.csvBtn1.Name = "csvBtn1";
            this.csvBtn1.Size = new System.Drawing.Size(226, 30);
            this.csvBtn1.TabIndex = 8;
            this.csvBtn1.Text = "csvから追加（１）";
            this.csvBtn1.UseVisualStyleBackColor = true;
            this.csvBtn1.Click += new System.EventHandler(this.csvBtn1_Click);
            // 
            // opencsvFileDialog
            // 
            this.opencsvFileDialog.Filter = "csv files(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            // 
            // CRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 501);
            this.Controls.Add(this.csvBtn1);
            this.Controls.Add(this.csvBtn2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.dataGridView_Shohin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUDForm";
            this.Text = "kadai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Shohin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.DataGridView dataGridView_Shohin;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button csvBtn2;
        private System.Windows.Forms.Button csvBtn1;
        private System.Windows.Forms.OpenFileDialog opencsvFileDialog;
    }
}

