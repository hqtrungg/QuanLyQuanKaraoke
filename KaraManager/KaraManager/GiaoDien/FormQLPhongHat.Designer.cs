namespace KaraManager.GiaoDien
{
    partial class FormQLPhongHat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLPhongHat));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbRoomData = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbRoomDataList = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvRoomData = new System.Windows.Forms.DataGridView();
            this.btnRoomDataSave = new System.Windows.Forms.Button();
            this.lbRoomArea = new System.Windows.Forms.Label();
            this.lbRoomCategory = new System.Windows.Forms.Label();
            this.lbRoomName = new System.Windows.Forms.Label();
            this.lbRoomStatus = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.tSAddRoomData = new System.Windows.Forms.ToolStripButton();
            this.tSFixRoomData = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveRoomData = new System.Windows.Forms.ToolStripButton();
            this.tSReloadRoomData = new System.Windows.Forms.ToolStripButton();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoomArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbRoomData.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbRoomData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbRoomDataList);
            this.splitContainer1.Size = new System.Drawing.Size(920, 473);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbRoomData
            // 
            this.gbRoomData.Controls.Add(this.comboBox1);
            this.gbRoomData.Controls.Add(this.btnRoomDataSave);
            this.gbRoomData.Controls.Add(this.lbRoomArea);
            this.gbRoomData.Controls.Add(this.textBox4);
            this.gbRoomData.Controls.Add(this.textBox3);
            this.gbRoomData.Controls.Add(this.textBox2);
            this.gbRoomData.Controls.Add(this.textBox1);
            this.gbRoomData.Controls.Add(this.lbRoomCategory);
            this.gbRoomData.Controls.Add(this.lbRoomName);
            this.gbRoomData.Controls.Add(this.lbRoomStatus);
            this.gbRoomData.Controls.Add(this.lbRoomID);
            this.gbRoomData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomData.Location = new System.Drawing.Point(0, 3);
            this.gbRoomData.Name = "gbRoomData";
            this.gbRoomData.Size = new System.Drawing.Size(303, 470);
            this.gbRoomData.TabIndex = 0;
            this.gbRoomData.TabStop = false;
            this.gbRoomData.Text = "Nhập thông tin phòng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(282, 23);
            this.textBox4.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Phòng thường",
            "Phòng V.I.P"});
            this.comboBox1.Location = new System.Drawing.Point(12, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // gbRoomDataList
            // 
            this.gbRoomDataList.Controls.Add(this.dgvRoomData);
            this.gbRoomDataList.Controls.Add(this.toolStrip1);
            this.gbRoomDataList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomDataList.Location = new System.Drawing.Point(3, 3);
            this.gbRoomDataList.Name = "gbRoomDataList";
            this.gbRoomDataList.Size = new System.Drawing.Size(607, 470);
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
            this.toolStrip1.Size = new System.Drawing.Size(601, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.dgvRoomData.Location = new System.Drawing.Point(3, 55);
            this.dgvRoomData.Name = "dgvRoomData";
            this.dgvRoomData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRoomData.Size = new System.Drawing.Size(604, 415);
            this.dgvRoomData.TabIndex = 1;
            // 
            // btnRoomDataSave
            // 
            this.btnRoomDataSave.Image = global::KaraManager.Properties.Resources.Tick;
            this.btnRoomDataSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomDataSave.Location = new System.Drawing.Point(91, 388);
            this.btnRoomDataSave.Name = "btnRoomDataSave";
            this.btnRoomDataSave.Size = new System.Drawing.Size(131, 44);
            this.btnRoomDataSave.TabIndex = 11;
            this.btnRoomDataSave.Text = "Lưu danh sách";
            this.btnRoomDataSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoomDataSave.UseVisualStyleBackColor = true;
            // 
            // lbRoomArea
            // 
            this.lbRoomArea.Image = global::KaraManager.Properties.Resources.Area;
            this.lbRoomArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomArea.Location = new System.Drawing.Point(12, 302);
            this.lbRoomArea.Name = "lbRoomArea";
            this.lbRoomArea.Size = new System.Drawing.Size(78, 32);
            this.lbRoomArea.TabIndex = 10;
            this.lbRoomArea.Text = "Khu vực";
            this.lbRoomArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRoomCategory
            // 
            this.lbRoomCategory.Image = global::KaraManager.Properties.Resources.RoomCategory;
            this.lbRoomCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomCategory.Location = new System.Drawing.Point(12, 159);
            this.lbRoomCategory.Name = "lbRoomCategory";
            this.lbRoomCategory.Size = new System.Drawing.Size(97, 28);
            this.lbRoomCategory.TabIndex = 3;
            this.lbRoomCategory.Text = "Loại phòng";
            this.lbRoomCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRoomName
            // 
            this.lbRoomName.Image = global::KaraManager.Properties.Resources.Room;
            this.lbRoomName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomName.Location = new System.Drawing.Point(12, 96);
            this.lbRoomName.Name = "lbRoomName";
            this.lbRoomName.Size = new System.Drawing.Size(97, 31);
            this.lbRoomName.TabIndex = 2;
            this.lbRoomName.Text = "Tên phòng";
            this.lbRoomName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRoomStatus
            // 
            this.lbRoomStatus.Image = global::KaraManager.Properties.Resources.Status;
            this.lbRoomStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomStatus.Location = new System.Drawing.Point(12, 230);
            this.lbRoomStatus.Name = "lbRoomStatus";
            this.lbRoomStatus.Size = new System.Drawing.Size(97, 29);
            this.lbRoomStatus.TabIndex = 1;
            this.lbRoomStatus.Text = "Tình trạng";
            this.lbRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRoomID
            // 
            this.lbRoomID.Image = global::KaraManager.Properties.Resources.ID;
            this.lbRoomID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRoomID.Location = new System.Drawing.Point(12, 32);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(108, 32);
            this.lbRoomID.TabIndex = 0;
            this.lbRoomID.Text = "Mã số phòng";
            this.lbRoomID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSAddRoomData
            // 
            this.tSAddRoomData.Image = global::KaraManager.Properties.Resources.Add;
            this.tSAddRoomData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSAddRoomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAddRoomData.Name = "tSAddRoomData";
            this.tSAddRoomData.Padding = new System.Windows.Forms.Padding(5);
            this.tSAddRoomData.Size = new System.Drawing.Size(126, 30);
            this.tSAddRoomData.Text = "Thêm phòng hát";
            this.tSAddRoomData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSAddRoomData.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tSFixRoomData
            // 
            this.tSFixRoomData.Image = global::KaraManager.Properties.Resources.Fix;
            this.tSFixRoomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFixRoomData.Name = "tSFixRoomData";
            this.tSFixRoomData.Padding = new System.Windows.Forms.Padding(5);
            this.tSFixRoomData.Size = new System.Drawing.Size(108, 30);
            this.tSFixRoomData.Text = "Sửa thông tin";
            // 
            // tSRemoveRoomData
            // 
            this.tSRemoveRoomData.Image = global::KaraManager.Properties.Resources.Delete;
            this.tSRemoveRoomData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tSRemoveRoomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRemoveRoomData.Name = "tSRemoveRoomData";
            this.tSRemoveRoomData.Size = new System.Drawing.Size(105, 30);
            this.tSRemoveRoomData.Text = "Xóa phòng hát";
            this.tSRemoveRoomData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSReloadRoomData
            // 
            this.tSReloadRoomData.Image = global::KaraManager.Properties.Resources.Reload;
            this.tSReloadRoomData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSReloadRoomData.Name = "tSReloadRoomData";
            this.tSReloadRoomData.Size = new System.Drawing.Size(115, 30);
            this.tSReloadRoomData.Text = "Tải lại danh sách";
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
            // FormQLPhongHat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 473);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLPhongHat";
            this.Text = "Quản Lý Phòng Hát";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbRoomData.ResumeLayout(false);
            this.gbRoomData.PerformLayout();
            this.gbRoomDataList.ResumeLayout(false);
            this.gbRoomDataList.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbRoomData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRoomDataSave;
        private System.Windows.Forms.Label lbRoomArea;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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