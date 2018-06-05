namespace KaraManager.GiaoDien
{
    partial class FormQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNhanVien));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbWorkerDataInput = new System.Windows.Forms.GroupBox();
            this.btnWorkerDataSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbWorkerGender = new System.Windows.Forms.GroupBox();
            this.rbtnWorkerFemale = new System.Windows.Forms.RadioButton();
            this.rbtnWorkerMale = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbWorkerDateOfBirth = new System.Windows.Forms.Label();
            this.lbWorkerPhoneNumber = new System.Windows.Forms.Label();
            this.lbWorkerAddress = new System.Windows.Forms.Label();
            this.lbWorkerID = new System.Windows.Forms.Label();
            this.lbWorkerName = new System.Windows.Forms.Label();
            this.gbWorkerDataList = new System.Windows.Forms.GroupBox();
            this.dgvWorkerData = new System.Windows.Forms.DataGridView();
            this.ColWorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSWorkerData = new System.Windows.Forms.ToolStrip();
            this.tSAddWorkerData = new System.Windows.Forms.ToolStripButton();
            this.tSFixWorkerData = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveWorkerData = new System.Windows.Forms.ToolStripButton();
            this.tSReloadWorkerData = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbWorkerDataInput.SuspendLayout();
            this.gbWorkerGender.SuspendLayout();
            this.gbWorkerDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerData)).BeginInit();
            this.tSWorkerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer2.Panel1.Controls.Add(this.gbWorkerDataInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbWorkerDataList);
            this.splitContainer2.Size = new System.Drawing.Size(920, 473);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbWorkerDataInput
            // 
            this.gbWorkerDataInput.Controls.Add(this.btnWorkerDataSave);
            this.gbWorkerDataInput.Controls.Add(this.dateTimePicker1);
            this.gbWorkerDataInput.Controls.Add(this.gbWorkerGender);
            this.gbWorkerDataInput.Controls.Add(this.textBox4);
            this.gbWorkerDataInput.Controls.Add(this.textBox3);
            this.gbWorkerDataInput.Controls.Add(this.textBox2);
            this.gbWorkerDataInput.Controls.Add(this.textBox1);
            this.gbWorkerDataInput.Controls.Add(this.lbWorkerDateOfBirth);
            this.gbWorkerDataInput.Controls.Add(this.lbWorkerPhoneNumber);
            this.gbWorkerDataInput.Controls.Add(this.lbWorkerAddress);
            this.gbWorkerDataInput.Controls.Add(this.lbWorkerID);
            this.gbWorkerDataInput.Controls.Add(this.lbWorkerName);
            this.gbWorkerDataInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkerDataInput.Location = new System.Drawing.Point(3, 4);
            this.gbWorkerDataInput.Name = "gbWorkerDataInput";
            this.gbWorkerDataInput.Size = new System.Drawing.Size(304, 466);
            this.gbWorkerDataInput.TabIndex = 16;
            this.gbWorkerDataInput.TabStop = false;
            this.gbWorkerDataInput.Text = "Nhập thông tin nhân viên";
            this.gbWorkerDataInput.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnWorkerDataSave
            // 
            this.btnWorkerDataSave.Image = global::KaraManager.Properties.Resources.Tick;
            this.btnWorkerDataSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkerDataSave.Location = new System.Drawing.Point(85, 402);
            this.btnWorkerDataSave.Name = "btnWorkerDataSave";
            this.btnWorkerDataSave.Size = new System.Drawing.Size(131, 44);
            this.btnWorkerDataSave.TabIndex = 11;
            this.btnWorkerDataSave.Text = "Lưu danh sách";
            this.btnWorkerDataSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkerDataSave.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // gbWorkerGender
            // 
            this.gbWorkerGender.Controls.Add(this.rbtnWorkerFemale);
            this.gbWorkerGender.Controls.Add(this.rbtnWorkerMale);
            this.gbWorkerGender.Location = new System.Drawing.Point(9, 147);
            this.gbWorkerGender.Name = "gbWorkerGender";
            this.gbWorkerGender.Size = new System.Drawing.Size(289, 63);
            this.gbWorkerGender.TabIndex = 9;
            this.gbWorkerGender.TabStop = false;
            this.gbWorkerGender.Text = "Giới tính";
            // 
            // rbtnWorkerFemale
            // 
            this.rbtnWorkerFemale.Image = global::KaraManager.Properties.Resources.Female;
            this.rbtnWorkerFemale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnWorkerFemale.Location = new System.Drawing.Point(170, 22);
            this.rbtnWorkerFemale.Name = "rbtnWorkerFemale";
            this.rbtnWorkerFemale.Size = new System.Drawing.Size(66, 26);
            this.rbtnWorkerFemale.TabIndex = 1;
            this.rbtnWorkerFemale.TabStop = true;
            this.rbtnWorkerFemale.Text = "Nữ";
            this.rbtnWorkerFemale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnWorkerFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnWorkerMale
            // 
            this.rbtnWorkerMale.Image = global::KaraManager.Properties.Resources.Male;
            this.rbtnWorkerMale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnWorkerMale.Location = new System.Drawing.Point(47, 22);
            this.rbtnWorkerMale.Name = "rbtnWorkerMale";
            this.rbtnWorkerMale.Size = new System.Drawing.Size(75, 26);
            this.rbtnWorkerMale.TabIndex = 0;
            this.rbtnWorkerMale.TabStop = true;
            this.rbtnWorkerMale.Text = "Nam";
            this.rbtnWorkerMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnWorkerMale.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 305);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(289, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 359);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 23);
            this.textBox1.TabIndex = 5;
            // 
            // lbWorkerDateOfBirth
            // 
            this.lbWorkerDateOfBirth.Image = global::KaraManager.Properties.Resources.Birthday;
            this.lbWorkerDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWorkerDateOfBirth.Location = new System.Drawing.Point(13, 213);
            this.lbWorkerDateOfBirth.Name = "lbWorkerDateOfBirth";
            this.lbWorkerDateOfBirth.Size = new System.Drawing.Size(94, 39);
            this.lbWorkerDateOfBirth.TabIndex = 4;
            this.lbWorkerDateOfBirth.Text = "Ngày sinh";
            this.lbWorkerDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWorkerPhoneNumber
            // 
            this.lbWorkerPhoneNumber.Image = global::KaraManager.Properties.Resources.PhoneNumber;
            this.lbWorkerPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWorkerPhoneNumber.Location = new System.Drawing.Point(13, 331);
            this.lbWorkerPhoneNumber.Name = "lbWorkerPhoneNumber";
            this.lbWorkerPhoneNumber.Size = new System.Drawing.Size(95, 34);
            this.lbWorkerPhoneNumber.TabIndex = 3;
            this.lbWorkerPhoneNumber.Text = "Điện thoại";
            this.lbWorkerPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWorkerAddress
            // 
            this.lbWorkerAddress.Image = global::KaraManager.Properties.Resources.Address;
            this.lbWorkerAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWorkerAddress.Location = new System.Drawing.Point(13, 271);
            this.lbWorkerAddress.Name = "lbWorkerAddress";
            this.lbWorkerAddress.Size = new System.Drawing.Size(82, 41);
            this.lbWorkerAddress.TabIndex = 2;
            this.lbWorkerAddress.Text = "Địa chỉ";
            this.lbWorkerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWorkerID
            // 
            this.lbWorkerID.Image = global::KaraManager.Properties.Resources.ID;
            this.lbWorkerID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWorkerID.Location = new System.Drawing.Point(13, 77);
            this.lbWorkerID.Name = "lbWorkerID";
            this.lbWorkerID.Size = new System.Drawing.Size(78, 35);
            this.lbWorkerID.TabIndex = 1;
            this.lbWorkerID.Text = "Mã số";
            this.lbWorkerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWorkerName
            // 
            this.lbWorkerName.Image = global::KaraManager.Properties.Resources.Name;
            this.lbWorkerName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWorkerName.Location = new System.Drawing.Point(13, 21);
            this.lbWorkerName.Name = "lbWorkerName";
            this.lbWorkerName.Size = new System.Drawing.Size(90, 34);
            this.lbWorkerName.TabIndex = 0;
            this.lbWorkerName.Text = "Họ và tên";
            this.lbWorkerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbWorkerDataList
            // 
            this.gbWorkerDataList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbWorkerDataList.Controls.Add(this.dgvWorkerData);
            this.gbWorkerDataList.Controls.Add(this.tSWorkerData);
            this.gbWorkerDataList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkerDataList.Location = new System.Drawing.Point(3, 4);
            this.gbWorkerDataList.Name = "gbWorkerDataList";
            this.gbWorkerDataList.Padding = new System.Windows.Forms.Padding(5);
            this.gbWorkerDataList.Size = new System.Drawing.Size(607, 469);
            this.gbWorkerDataList.TabIndex = 0;
            this.gbWorkerDataList.TabStop = false;
            this.gbWorkerDataList.Text = "Danh Sách Nhân Viên";
            // 
            // dgvWorkerData
            // 
            this.dgvWorkerData.AllowDrop = true;
            this.dgvWorkerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkerData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColWorkerID,
            this.ColWorkerName,
            this.ColWorkerGender,
            this.ColWorkerDateOfBirth,
            this.ColWorkerAddress,
            this.ColWorkerPhoneNumber});
            this.dgvWorkerData.Location = new System.Drawing.Point(5, 55);
            this.dgvWorkerData.Name = "dgvWorkerData";
            this.dgvWorkerData.Size = new System.Drawing.Size(599, 414);
            this.dgvWorkerData.TabIndex = 1;
            // 
            // ColWorkerID
            // 
            this.ColWorkerID.HeaderText = "ID";
            this.ColWorkerID.Name = "ColWorkerID";
            // 
            // ColWorkerName
            // 
            this.ColWorkerName.HeaderText = "Họ và tên";
            this.ColWorkerName.Name = "ColWorkerName";
            // 
            // ColWorkerGender
            // 
            this.ColWorkerGender.HeaderText = "Giới tính";
            this.ColWorkerGender.Name = "ColWorkerGender";
            // 
            // ColWorkerDateOfBirth
            // 
            this.ColWorkerDateOfBirth.HeaderText = "Ngày sinh";
            this.ColWorkerDateOfBirth.Name = "ColWorkerDateOfBirth";
            // 
            // ColWorkerAddress
            // 
            this.ColWorkerAddress.HeaderText = "Địa chỉ";
            this.ColWorkerAddress.Name = "ColWorkerAddress";
            // 
            // ColWorkerPhoneNumber
            // 
            this.ColWorkerPhoneNumber.HeaderText = "Số điện thoại";
            this.ColWorkerPhoneNumber.Name = "ColWorkerPhoneNumber";
            // 
            // tSWorkerData
            // 
            this.tSWorkerData.AutoSize = false;
            this.tSWorkerData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAddWorkerData,
            this.tSFixWorkerData,
            this.tSRemoveWorkerData,
            this.tSReloadWorkerData});
            this.tSWorkerData.Location = new System.Drawing.Point(5, 21);
            this.tSWorkerData.Name = "tSWorkerData";
            this.tSWorkerData.Size = new System.Drawing.Size(597, 33);
            this.tSWorkerData.TabIndex = 0;
            this.tSWorkerData.Text = "toolStrip1";
            // 
            // tSAddWorkerData
            // 
            this.tSAddWorkerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tSAddWorkerData.Checked = true;
            this.tSAddWorkerData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tSAddWorkerData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSAddWorkerData.Image = global::KaraManager.Properties.Resources.Add;
            this.tSAddWorkerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAddWorkerData.Name = "tSAddWorkerData";
            this.tSAddWorkerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSAddWorkerData.Size = new System.Drawing.Size(130, 30);
            this.tSAddWorkerData.Text = "Thêm nhân viên";
            // 
            // tSFixWorkerData
            // 
            this.tSFixWorkerData.Image = global::KaraManager.Properties.Resources.Fix;
            this.tSFixWorkerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFixWorkerData.Name = "tSFixWorkerData";
            this.tSFixWorkerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSFixWorkerData.Size = new System.Drawing.Size(108, 30);
            this.tSFixWorkerData.Text = "Sửa thông tin";
            // 
            // tSRemoveWorkerData
            // 
            this.tSRemoveWorkerData.Image = global::KaraManager.Properties.Resources.Delete;
            this.tSRemoveWorkerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRemoveWorkerData.Name = "tSRemoveWorkerData";
            this.tSRemoveWorkerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSRemoveWorkerData.Size = new System.Drawing.Size(112, 30);
            this.tSRemoveWorkerData.Text = "Xóa nhân viên";
            // 
            // tSReloadWorkerData
            // 
            this.tSReloadWorkerData.Image = global::KaraManager.Properties.Resources.Reload;
            this.tSReloadWorkerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSReloadWorkerData.Name = "tSReloadWorkerData";
            this.tSReloadWorkerData.Size = new System.Drawing.Size(115, 30);
            this.tSReloadWorkerData.Text = "Tải lại danh sách";
            // 
            // FormQLNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(920, 473);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormQLNhanVien";
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Text = "Quản Lý Thông Tin Nhân Viên";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbWorkerDataInput.ResumeLayout(false);
            this.gbWorkerDataInput.PerformLayout();
            this.gbWorkerGender.ResumeLayout(false);
            this.gbWorkerDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerData)).EndInit();
            this.tSWorkerData.ResumeLayout(false);
            this.tSWorkerData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbWorkerDataList;
        private System.Windows.Forms.ToolStrip tSWorkerData;
        private System.Windows.Forms.ToolStripButton tSAddWorkerData;
        private System.Windows.Forms.ToolStripButton tSFixWorkerData;
        private System.Windows.Forms.ToolStripButton tSRemoveWorkerData;
        private System.Windows.Forms.ToolStripButton tSReloadWorkerData;
        private System.Windows.Forms.DataGridView dgvWorkerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWorkerGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWorkerDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWorkerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWorkerPhoneNumber;
        private System.Windows.Forms.GroupBox gbWorkerDataInput;
        private System.Windows.Forms.Label lbWorkerDateOfBirth;
        private System.Windows.Forms.Label lbWorkerPhoneNumber;
        private System.Windows.Forms.Label lbWorkerAddress;
        private System.Windows.Forms.Label lbWorkerID;
        private System.Windows.Forms.Label lbWorkerName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbWorkerGender;
        private System.Windows.Forms.RadioButton rbtnWorkerFemale;
        private System.Windows.Forms.RadioButton rbtnWorkerMale;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnWorkerDataSave;


    }
}