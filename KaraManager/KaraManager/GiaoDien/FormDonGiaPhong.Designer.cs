namespace KaraManager.GiaoDien
{
    partial class FormDonGiaPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonGiaPhong));
            this.grbRoomPrice = new System.Windows.Forms.GroupBox();
            this.dgvRoomPrice = new System.Windows.Forms.DataGridView();
            this.tsRoomPrice = new System.Windows.Forms.ToolStrip();
            this.tSAddRoomPrice = new System.Windows.Forms.ToolStripButton();
            this.tSFixRoomPrice = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveRoomPrice = new System.Windows.Forms.ToolStripButton();
            this.tSReloadRoomPrice = new System.Windows.Forms.ToolStripButton();
            this.ColRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbRoomPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomPrice)).BeginInit();
            this.tsRoomPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRoomPrice
            // 
            this.grbRoomPrice.Controls.Add(this.dgvRoomPrice);
            this.grbRoomPrice.Controls.Add(this.tsRoomPrice);
            this.grbRoomPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRoomPrice.Location = new System.Drawing.Point(0, 0);
            this.grbRoomPrice.Name = "grbRoomPrice";
            this.grbRoomPrice.Size = new System.Drawing.Size(560, 343);
            this.grbRoomPrice.TabIndex = 0;
            this.grbRoomPrice.TabStop = false;
            this.grbRoomPrice.Text = "Danh sách đơn giá";
            // 
            // dgvRoomPrice
            // 
            this.dgvRoomPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomPrice.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRoomPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRoomID,
            this.ColRoomName,
            this.ColRoomCat,
            this.ColPrice});
            this.dgvRoomPrice.Location = new System.Drawing.Point(3, 47);
            this.dgvRoomPrice.Name = "dgvRoomPrice";
            this.dgvRoomPrice.Size = new System.Drawing.Size(554, 296);
            this.dgvRoomPrice.TabIndex = 1;
            // 
            // tsRoomPrice
            // 
            this.tsRoomPrice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAddRoomPrice,
            this.tSFixRoomPrice,
            this.tSRemoveRoomPrice,
            this.tSReloadRoomPrice});
            this.tsRoomPrice.Location = new System.Drawing.Point(3, 19);
            this.tsRoomPrice.Name = "tsRoomPrice";
            this.tsRoomPrice.Size = new System.Drawing.Size(554, 33);
            this.tsRoomPrice.TabIndex = 0;
            this.tsRoomPrice.Text = "RoomPriceToolStrip";
            // 
            // tSAddRoomPrice
            // 
            this.tSAddRoomPrice.Image = global::KaraManager.Properties.Resources.Add;
            this.tSAddRoomPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAddRoomPrice.Name = "tSAddRoomPrice";
            this.tSAddRoomPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tSAddRoomPrice.Size = new System.Drawing.Size(125, 30);
            this.tSAddRoomPrice.Text = "Thêm giá phòng";
            // 
            // tSFixRoomPrice
            // 
            this.tSFixRoomPrice.Image = global::KaraManager.Properties.Resources.Fix;
            this.tSFixRoomPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFixRoomPrice.Name = "tSFixRoomPrice";
            this.tSFixRoomPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tSFixRoomPrice.Size = new System.Drawing.Size(113, 30);
            this.tSFixRoomPrice.Text = "Sửa giá phòng";
            // 
            // tSRemoveRoomPrice
            // 
            this.tSRemoveRoomPrice.Image = global::KaraManager.Properties.Resources.Delete;
            this.tSRemoveRoomPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRemoveRoomPrice.Name = "tSRemoveRoomPrice";
            this.tSRemoveRoomPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tSRemoveRoomPrice.Size = new System.Drawing.Size(114, 30);
            this.tSRemoveRoomPrice.Text = "Xóa giá phòng";
            // 
            // tSReloadRoomPrice
            // 
            this.tSReloadRoomPrice.Image = global::KaraManager.Properties.Resources.Reload;
            this.tSReloadRoomPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSReloadRoomPrice.Name = "tSReloadRoomPrice";
            this.tSReloadRoomPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tSReloadRoomPrice.Size = new System.Drawing.Size(125, 30);
            this.tSReloadRoomPrice.Text = "Tải lại danh sách";
            // 
            // ColRoomID
            // 
            this.ColRoomID.HeaderText = "STT";
            this.ColRoomID.Name = "ColRoomID";
            // 
            // ColRoomName
            // 
            this.ColRoomName.HeaderText = "Tên phòng";
            this.ColRoomName.Name = "ColRoomName";
            // 
            // ColRoomCat
            // 
            this.ColRoomCat.HeaderText = "Loại phòng";
            this.ColRoomCat.Name = "ColRoomCat";
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Đơn giá";
            this.ColPrice.Name = "ColPrice";
            // 
            // FormDonGiaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 343);
            this.Controls.Add(this.grbRoomPrice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDonGiaPhong";
            this.Text = "Đơn Giá Phòng";
            this.grbRoomPrice.ResumeLayout(false);
            this.grbRoomPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomPrice)).EndInit();
            this.tsRoomPrice.ResumeLayout(false);
            this.tsRoomPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRoomPrice;
        private System.Windows.Forms.ToolStrip tsRoomPrice;
        private System.Windows.Forms.ToolStripButton tSAddRoomPrice;
        private System.Windows.Forms.ToolStripButton tSFixRoomPrice;
        private System.Windows.Forms.ToolStripButton tSRemoveRoomPrice;
        private System.Windows.Forms.DataGridView dgvRoomPrice;
        private System.Windows.Forms.ToolStripButton tSReloadRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
    }
}