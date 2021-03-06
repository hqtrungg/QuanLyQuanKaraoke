﻿namespace KaraManager.GiaoDien
{
    partial class UCFormDonGiaPhong
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
            this.gbRoomPrice = new System.Windows.Forms.GroupBox();
            this.tsRoomPrice = new System.Windows.Forms.ToolStrip();
            this.tSAddRoomPrice = new System.Windows.Forms.ToolStripButton();
            this.tSFixRoomPrice = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveRoomPrice = new System.Windows.Forms.ToolStripButton();
            this.tSReloadRoomPrice = new System.Windows.Forms.ToolStripButton();
            this.dgvRoomPrice = new System.Windows.Forms.DataGridView();
            this.ColRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRoomPrice.SuspendLayout();
            this.tsRoomPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRoomPrice
            // 
            this.gbRoomPrice.Controls.Add(this.dgvRoomPrice);
            this.gbRoomPrice.Controls.Add(this.tsRoomPrice);
            this.gbRoomPrice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomPrice.Location = new System.Drawing.Point(3, 3);
            this.gbRoomPrice.Name = "gbRoomPrice";
            this.gbRoomPrice.Size = new System.Drawing.Size(1053, 722);
            this.gbRoomPrice.TabIndex = 0;
            this.gbRoomPrice.TabStop = false;
            this.gbRoomPrice.Text = "Danh sách đơn giá phòng";
            // 
            // tsRoomPrice
            // 
            this.tsRoomPrice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAddRoomPrice,
            this.tSFixRoomPrice,
            this.tSRemoveRoomPrice,
            this.tSReloadRoomPrice});
            this.tsRoomPrice.Location = new System.Drawing.Point(3, 22);
            this.tsRoomPrice.Name = "tsRoomPrice";
            this.tsRoomPrice.Size = new System.Drawing.Size(1047, 34);
            this.tsRoomPrice.TabIndex = 1;
            this.tsRoomPrice.Text = "RoomPriceToolStrip";
            // 
            // tSAddRoomPrice
            // 
            this.tSAddRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSAddRoomPrice.Image = global::KaraManager.Properties.Resources.Add;
            this.tSAddRoomPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAddRoomPrice.Name = "tSAddRoomPrice";
            this.tSAddRoomPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tSAddRoomPrice.Size = new System.Drawing.Size(134, 31);
            this.tSAddRoomPrice.Text = "Thêm giá phòng";
            // 
            // tSFixRoomPrice
            // 
            this.tSFixRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSFixRoomPrice.Image = global::KaraManager.Properties.Resources.Fix;
            this.tSFixRoomPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFixRoomPrice.Name = "tSFixRoomPrice";
            this.tSFixRoomPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tSFixRoomPrice.Size = new System.Drawing.Size(124, 31);
            this.tSFixRoomPrice.Text = "Sửa giá phòng";
            // 
            // tSRemoveRoomPrice
            // 
            this.tSRemoveRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSRemoveRoomPrice.Image = global::KaraManager.Properties.Resources.Delete;
            this.tSRemoveRoomPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRemoveRoomPrice.Name = "tSRemoveRoomPrice";
            this.tSRemoveRoomPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tSRemoveRoomPrice.Size = new System.Drawing.Size(125, 31);
            this.tSRemoveRoomPrice.Text = "Xóa giá phòng";
            // 
            // tSReloadRoomPrice
            // 
            this.tSReloadRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSReloadRoomPrice.Image = global::KaraManager.Properties.Resources.Reload;
            this.tSReloadRoomPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSReloadRoomPrice.Name = "tSReloadRoomPrice";
            this.tSReloadRoomPrice.Padding = new System.Windows.Forms.Padding(5);
            this.tSReloadRoomPrice.Size = new System.Drawing.Size(135, 31);
            this.tSReloadRoomPrice.Text = "Tải lại danh sách";
            // 
            // dgvRoomPrice
            // 
            this.dgvRoomPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomPrice.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRoomPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRoomID,
            this.ColRoomName,
            this.ColRoomCat,
            this.ColPrice});
            this.dgvRoomPrice.Location = new System.Drawing.Point(3, 59);
            this.dgvRoomPrice.Name = "dgvRoomPrice";
            this.dgvRoomPrice.Size = new System.Drawing.Size(1044, 657);
            this.dgvRoomPrice.TabIndex = 2;
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
            // UCFormDonGiaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbRoomPrice);
            this.Name = "UCFormDonGiaPhong";
            this.Size = new System.Drawing.Size(1059, 728);
            this.gbRoomPrice.ResumeLayout(false);
            this.gbRoomPrice.PerformLayout();
            this.tsRoomPrice.ResumeLayout(false);
            this.tsRoomPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRoomPrice;
        private System.Windows.Forms.ToolStrip tsRoomPrice;
        private System.Windows.Forms.ToolStripButton tSAddRoomPrice;
        private System.Windows.Forms.ToolStripButton tSFixRoomPrice;
        private System.Windows.Forms.ToolStripButton tSRemoveRoomPrice;
        private System.Windows.Forms.ToolStripButton tSReloadRoomPrice;
        private System.Windows.Forms.DataGridView dgvRoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
    }
}
