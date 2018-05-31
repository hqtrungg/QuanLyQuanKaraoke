namespace KaraManager.GiaoDien
{
    partial class UCFormQLPhongHat
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbRoomDataInput = new System.Windows.Forms.GroupBox();
            this.cbRoomCategory = new System.Windows.Forms.ComboBox();
            this.btnRoomDataSave = new System.Windows.Forms.Button();
            this.lbRoomArea = new System.Windows.Forms.Label();
            this.tbRoomStatus = new System.Windows.Forms.TextBox();
            this.tbRoomName = new System.Windows.Forms.TextBox();
            this.tbRoomArea = new System.Windows.Forms.TextBox();
            this.tbRoomDetails = new System.Windows.Forms.TextBox();
            this.lbRoomCategory = new System.Windows.Forms.Label();
            this.lbRoomName = new System.Windows.Forms.Label();
            this.lbRoomStatus = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.gbRoomDataList = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSAddRoomData = new System.Windows.Forms.ToolStripButton();
            this.tSFixRoomData = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveRoomData = new System.Windows.Forms.ToolStripButton();
            this.tSReloadRoomData = new System.Windows.Forms.ToolStripButton();
            this.dgvRoomData = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbRoomDataInput.SuspendLayout();
            this.gbRoomDataList.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbRoomDataInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbRoomDataList);
            this.splitContainer1.Size = new System.Drawing.Size(1059, 728);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbRoomDataInput
            // 
            this.gbRoomDataInput.Controls.Add(this.cbRoomCategory);
            this.gbRoomDataInput.Controls.Add(this.btnRoomDataSave);
            this.gbRoomDataInput.Controls.Add(this.lbRoomArea);
            this.gbRoomDataInput.Controls.Add(this.tbRoomStatus);
            this.gbRoomDataInput.Controls.Add(this.tbRoomName);
            this.gbRoomDataInput.Controls.Add(this.tbRoomArea);
            this.gbRoomDataInput.Controls.Add(this.tbRoomDetails);
            this.gbRoomDataInput.Controls.Add(this.lbRoomCategory);
            this.gbRoomDataInput.Controls.Add(this.lbRoomName);
            this.gbRoomDataInput.Controls.Add(this.lbRoomStatus);
            this.gbRoomDataInput.Controls.Add(this.lbRoomID);
            this.gbRoomDataInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomDataInput.Location = new System.Drawing.Point(3, 3);
            this.gbRoomDataInput.Name = "gbRoomDataInput";
            this.gbRoomDataInput.Size = new System.Drawing.Size(347, 722);
            this.gbRoomDataInput.TabIndex = 0;
            this.gbRoomDataInput.TabStop = false;
            this.gbRoomDataInput.Text = "Nhập thông tin phòng hát";
            // 
            // cbRoomCategory
            // 
            this.cbRoomCategory.FormattingEnabled = true;
            this.cbRoomCategory.Items.AddRange(new object[] {
            "Phòng thường",
            "Phòng V.I.P"});
            this.cbRoomCategory.Location = new System.Drawing.Point(32, 291);
            this.cbRoomCategory.Name = "cbRoomCategory";
            this.cbRoomCategory.Size = new System.Drawing.Size(282, 24);
            this.cbRoomCategory.TabIndex = 23;
            // 
            // btnRoomDataSave
            // 
            this.btnRoomDataSave.Image = global::KaraManager.Properties.Resources.Tick;
            this.btnRoomDataSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomDataSave.Location = new System.Drawing.Point(99, 565);
            this.btnRoomDataSave.Name = "btnRoomDataSave";
            this.btnRoomDataSave.Size = new System.Drawing.Size(137, 60);
            this.btnRoomDataSave.TabIndex = 22;
            this.btnRoomDataSave.Text = "Lưu danh sách";
            this.btnRoomDataSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoomDataSave.UseVisualStyleBackColor = true;
            // 
            // lbRoomArea
            // 
            this.lbRoomArea.Image = global::KaraManager.Properties.Resources.Area;
            this.lbRoomArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomArea.Location = new System.Drawing.Point(29, 448);
            this.lbRoomArea.Name = "lbRoomArea";
            this.lbRoomArea.Size = new System.Drawing.Size(78, 32);
            this.lbRoomArea.TabIndex = 21;
            this.lbRoomArea.Text = "Khu vực";
            this.lbRoomArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRoomStatus
            // 
            this.tbRoomStatus.Location = new System.Drawing.Point(32, 384);
            this.tbRoomStatus.Name = "tbRoomStatus";
            this.tbRoomStatus.Size = new System.Drawing.Size(282, 23);
            this.tbRoomStatus.TabIndex = 20;
            // 
            // tbRoomName
            // 
            this.tbRoomName.Location = new System.Drawing.Point(32, 189);
            this.tbRoomName.Name = "tbRoomName";
            this.tbRoomName.Size = new System.Drawing.Size(282, 23);
            this.tbRoomName.TabIndex = 19;
            // 
            // tbRoomArea
            // 
            this.tbRoomArea.Location = new System.Drawing.Point(32, 483);
            this.tbRoomArea.Name = "tbRoomArea";
            this.tbRoomArea.Size = new System.Drawing.Size(282, 23);
            this.tbRoomArea.TabIndex = 18;
            // 
            // tbRoomDetails
            // 
            this.tbRoomDetails.Location = new System.Drawing.Point(32, 96);
            this.tbRoomDetails.Name = "tbRoomDetails";
            this.tbRoomDetails.Size = new System.Drawing.Size(282, 23);
            this.tbRoomDetails.TabIndex = 17;
            // 
            // lbRoomCategory
            // 
            this.lbRoomCategory.Image = global::KaraManager.Properties.Resources.RoomCategory;
            this.lbRoomCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomCategory.Location = new System.Drawing.Point(29, 260);
            this.lbRoomCategory.Name = "lbRoomCategory";
            this.lbRoomCategory.Size = new System.Drawing.Size(97, 28);
            this.lbRoomCategory.TabIndex = 16;
            this.lbRoomCategory.Text = "Loại phòng";
            this.lbRoomCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRoomName
            // 
            this.lbRoomName.Image = global::KaraManager.Properties.Resources.Room;
            this.lbRoomName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomName.Location = new System.Drawing.Point(29, 155);
            this.lbRoomName.Name = "lbRoomName";
            this.lbRoomName.Size = new System.Drawing.Size(97, 31);
            this.lbRoomName.TabIndex = 15;
            this.lbRoomName.Text = "Tên phòng";
            this.lbRoomName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRoomStatus
            // 
            this.lbRoomStatus.Image = global::KaraManager.Properties.Resources.Status;
            this.lbRoomStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomStatus.Location = new System.Drawing.Point(29, 352);
            this.lbRoomStatus.Name = "lbRoomStatus";
            this.lbRoomStatus.Size = new System.Drawing.Size(97, 29);
            this.lbRoomStatus.TabIndex = 14;
            this.lbRoomStatus.Text = "Tình trạng";
            this.lbRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRoomID
            // 
            this.lbRoomID.Image = global::KaraManager.Properties.Resources.ID;
            this.lbRoomID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomID.Location = new System.Drawing.Point(29, 61);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(108, 32);
            this.lbRoomID.TabIndex = 13;
            this.lbRoomID.Text = "Mã số phòng";
            this.lbRoomID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbRoomDataList
            // 
            this.gbRoomDataList.Controls.Add(this.dgvRoomData);
            this.gbRoomDataList.Controls.Add(this.toolStrip1);
            this.gbRoomDataList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomDataList.Location = new System.Drawing.Point(3, 3);
            this.gbRoomDataList.Name = "gbRoomDataList";
            this.gbRoomDataList.Size = new System.Drawing.Size(696, 722);
            this.gbRoomDataList.TabIndex = 0;
            this.gbRoomDataList.TabStop = false;
            this.gbRoomDataList.Text = "Danh sách phòng hát";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAddRoomData,
            this.tSFixRoomData,
            this.tSRemoveRoomData,
            this.tSReloadRoomData});
            this.toolStrip1.Location = new System.Drawing.Point(3, 19);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSAddRoomData
            // 
            this.tSAddRoomData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSAddRoomData.Image = global::KaraManager.Properties.Resources.Add;
            this.tSAddRoomData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSAddRoomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAddRoomData.Name = "tSAddRoomData";
            this.tSAddRoomData.Padding = new System.Windows.Forms.Padding(5);
            this.tSAddRoomData.Size = new System.Drawing.Size(134, 31);
            this.tSAddRoomData.Text = "Thêm phòng hát";
            this.tSAddRoomData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSFixRoomData
            // 
            this.tSFixRoomData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSFixRoomData.Image = global::KaraManager.Properties.Resources.Fix;
            this.tSFixRoomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFixRoomData.Name = "tSFixRoomData";
            this.tSFixRoomData.Padding = new System.Windows.Forms.Padding(5);
            this.tSFixRoomData.Size = new System.Drawing.Size(116, 31);
            this.tSFixRoomData.Text = "Sửa thông tin";
            // 
            // tSRemoveRoomData
            // 
            this.tSRemoveRoomData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSRemoveRoomData.Image = global::KaraManager.Properties.Resources.Delete;
            this.tSRemoveRoomData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSRemoveRoomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRemoveRoomData.Name = "tSRemoveRoomData";
            this.tSRemoveRoomData.Padding = new System.Windows.Forms.Padding(5);
            this.tSRemoveRoomData.Size = new System.Drawing.Size(125, 31);
            this.tSRemoveRoomData.Text = "Xóa phòng hát";
            this.tSRemoveRoomData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSReloadRoomData
            // 
            this.tSReloadRoomData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSReloadRoomData.Image = global::KaraManager.Properties.Resources.Reload;
            this.tSReloadRoomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSReloadRoomData.Name = "tSReloadRoomData";
            this.tSReloadRoomData.Padding = new System.Windows.Forms.Padding(5);
            this.tSReloadRoomData.Size = new System.Drawing.Size(135, 31);
            this.tSReloadRoomData.Text = "Tải lại danh sách";
            // 
            // dgvRoomData
            // 
            this.dgvRoomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRoomData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColRoomName,
            this.ColRoomCat,
            this.ColRoomStatus,
            this.ColRoomArea});
            this.dgvRoomData.Location = new System.Drawing.Point(3, 53);
            this.dgvRoomData.Name = "dgvRoomData";
            this.dgvRoomData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRoomData.Size = new System.Drawing.Size(690, 669);
            this.dgvRoomData.TabIndex = 2;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            // 
            // ColRoomName
            // 
            this.ColRoomName.HeaderText = "Tên Phòng";
            this.ColRoomName.Name = "ColRoomName";
            // 
            // ColRoomCat
            // 
            this.ColRoomCat.HeaderText = "Loại Phòng";
            this.ColRoomCat.Name = "ColRoomCat";
            // 
            // ColRoomStatus
            // 
            this.ColRoomStatus.HeaderText = "Tình Trạng";
            this.ColRoomStatus.Name = "ColRoomStatus";
            // 
            // ColRoomArea
            // 
            this.ColRoomArea.HeaderText = "Khu vực";
            this.ColRoomArea.Name = "ColRoomArea";
            // 
            // UCFormQLPhongHat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCFormQLPhongHat";
            this.Size = new System.Drawing.Size(1059, 728);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbRoomDataInput.ResumeLayout(false);
            this.gbRoomDataInput.PerformLayout();
            this.gbRoomDataList.ResumeLayout(false);
            this.gbRoomDataList.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbRoomDataInput;
        private System.Windows.Forms.ComboBox cbRoomCategory;
        private System.Windows.Forms.Button btnRoomDataSave;
        private System.Windows.Forms.Label lbRoomArea;
        private System.Windows.Forms.TextBox tbRoomStatus;
        private System.Windows.Forms.TextBox tbRoomName;
        private System.Windows.Forms.TextBox tbRoomArea;
        private System.Windows.Forms.TextBox tbRoomDetails;
        private System.Windows.Forms.Label lbRoomCategory;
        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.Label lbRoomStatus;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.GroupBox gbRoomDataList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSAddRoomData;
        private System.Windows.Forms.ToolStripButton tSFixRoomData;
        private System.Windows.Forms.ToolStripButton tSRemoveRoomData;
        private System.Windows.Forms.ToolStripButton tSReloadRoomData;
        private System.Windows.Forms.DataGridView dgvRoomData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoomArea;
    }
}
