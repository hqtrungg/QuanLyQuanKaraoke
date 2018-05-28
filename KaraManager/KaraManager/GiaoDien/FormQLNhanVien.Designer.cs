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
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.gbWorkerGender = new System.Windows.Forms.GroupBox();
            this.rbtnWorkerFemale = new System.Windows.Forms.RadioButton();
            this.rbtnWorkerMale = new System.Windows.Forms.RadioButton();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbWorkerID = new System.Windows.Forms.Label();
            this.lbWorkerName = new System.Windows.Forms.Label();
            this.lbWorker = new System.Windows.Forms.Label();
            this.gbWorkerDataList = new System.Windows.Forms.GroupBox();
            this.tSWorkerData = new System.Windows.Forms.ToolStrip();
            this.dgvWorkerData = new System.Windows.Forms.DataGridView();
            this.btnSaveDataWorker = new System.Windows.Forms.Button();
            this.tSAddWorkerData = new System.Windows.Forms.ToolStripButton();
            this.tSFixWorkerData = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveWorkerData = new System.Windows.Forms.ToolStripButton();
            this.tSReloadWorkerData = new System.Windows.Forms.ToolStripButton();
            this.ColWorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWorkerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbWorkerGender.SuspendLayout();
            this.gbWorkerDataList.SuspendLayout();
            this.tSWorkerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerData)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveDataWorker);
            this.splitContainer2.Panel1.Controls.Add(this.lbPhoneNumber);
            this.splitContainer2.Panel1.Controls.Add(this.lbAddress);
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer2.Panel1.Controls.Add(this.lbDateOfBirth);
            this.splitContainer2.Panel1.Controls.Add(this.gbWorkerGender);
            this.splitContainer2.Panel1.Controls.Add(this.textBox8);
            this.splitContainer2.Panel1.Controls.Add(this.textBox7);
            this.splitContainer2.Panel1.Controls.Add(this.textBox6);
            this.splitContainer2.Panel1.Controls.Add(this.textBox5);
            this.splitContainer2.Panel1.Controls.Add(this.lbWorkerID);
            this.splitContainer2.Panel1.Controls.Add(this.lbWorkerName);
            this.splitContainer2.Panel1.Controls.Add(this.lbWorker);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbWorkerDataList);
            this.splitContainer2.Size = new System.Drawing.Size(920, 473);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.TabIndex = 0;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(18, 346);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(79, 14);
            this.lbPhoneNumber.TabIndex = 14;
            this.lbPhoneNumber.Text = "Số điện thoại";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(15, 292);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(42, 14);
            this.lbAddress.TabIndex = 13;
            this.lbAddress.Text = "Địa chỉ";
            this.lbAddress.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 255);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(273, 21);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(15, 239);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(59, 14);
            this.lbDateOfBirth.TabIndex = 11;
            this.lbDateOfBirth.Text = "Ngày sinh";
            // 
            // gbWorkerGender
            // 
            this.gbWorkerGender.Controls.Add(this.rbtnWorkerFemale);
            this.gbWorkerGender.Controls.Add(this.rbtnWorkerMale);
            this.gbWorkerGender.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkerGender.Location = new System.Drawing.Point(15, 160);
            this.gbWorkerGender.Name = "gbWorkerGender";
            this.gbWorkerGender.Size = new System.Drawing.Size(276, 54);
            this.gbWorkerGender.TabIndex = 10;
            this.gbWorkerGender.TabStop = false;
            this.gbWorkerGender.Text = "Giới tính";
            // 
            // rbtnWorkerFemale
            // 
            this.rbtnWorkerFemale.AutoSize = true;
            this.rbtnWorkerFemale.Location = new System.Drawing.Point(176, 20);
            this.rbtnWorkerFemale.Name = "rbtnWorkerFemale";
            this.rbtnWorkerFemale.Size = new System.Drawing.Size(41, 18);
            this.rbtnWorkerFemale.TabIndex = 1;
            this.rbtnWorkerFemale.TabStop = true;
            this.rbtnWorkerFemale.Text = "Nữ";
            this.rbtnWorkerFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnWorkerMale
            // 
            this.rbtnWorkerMale.AutoSize = true;
            this.rbtnWorkerMale.Location = new System.Drawing.Point(30, 20);
            this.rbtnWorkerMale.Name = "rbtnWorkerMale";
            this.rbtnWorkerMale.Size = new System.Drawing.Size(49, 18);
            this.rbtnWorkerMale.TabIndex = 0;
            this.rbtnWorkerMale.TabStop = true;
            this.rbtnWorkerMale.Text = "Nam";
            this.rbtnWorkerMale.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(18, 362);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(273, 21);
            this.textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(18, 308);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(273, 21);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(15, 118);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(276, 21);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 59);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 21);
            this.textBox5.TabIndex = 6;
            // 
            // lbWorkerID
            // 
            this.lbWorkerID.AutoSize = true;
            this.lbWorkerID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorkerID.Location = new System.Drawing.Point(12, 102);
            this.lbWorkerID.Name = "lbWorkerID";
            this.lbWorkerID.Size = new System.Drawing.Size(38, 14);
            this.lbWorkerID.TabIndex = 2;
            this.lbWorkerID.Text = "Mã số";
            // 
            // lbWorkerName
            // 
            this.lbWorkerName.AutoSize = true;
            this.lbWorkerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorkerName.Location = new System.Drawing.Point(12, 43);
            this.lbWorkerName.Name = "lbWorkerName";
            this.lbWorkerName.Size = new System.Drawing.Size(61, 14);
            this.lbWorkerName.TabIndex = 1;
            this.lbWorkerName.Text = "Họ và tên";
            // 
            // lbWorker
            // 
            this.lbWorker.BackColor = System.Drawing.Color.Yellow;
            this.lbWorker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbWorker.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorker.ForeColor = System.Drawing.Color.Blue;
            this.lbWorker.Location = new System.Drawing.Point(4, 4);
            this.lbWorker.Name = "lbWorker";
            this.lbWorker.Size = new System.Drawing.Size(299, 29);
            this.lbWorker.TabIndex = 0;
            this.lbWorker.Text = "Nhập thông tin nhân viên";
            this.lbWorker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbWorkerDataList
            // 
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
            // tSWorkerData
            // 
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
            // dgvWorkerData
            // 
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
            // btnSaveDataWorker
            // 
            this.btnSaveDataWorker.Image = global::KaraManager.Properties.Resources.Tick;
            this.btnSaveDataWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDataWorker.Location = new System.Drawing.Point(90, 403);
            this.btnSaveDataWorker.Name = "btnSaveDataWorker";
            this.btnSaveDataWorker.Size = new System.Drawing.Size(120, 44);
            this.btnSaveDataWorker.TabIndex = 15;
            this.btnSaveDataWorker.Text = "Lưu danh sách";
            this.btnSaveDataWorker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveDataWorker.UseVisualStyleBackColor = true;
            // 
            // tSAddWorkerData
            // 
            this.tSAddWorkerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tSAddWorkerData.Checked = true;
            this.tSAddWorkerData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tSAddWorkerData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSAddWorkerData.Image = global::KaraManager.Properties.Resources.Add;
            this.tSAddWorkerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAddWorkerData.Name = "tSAddWorkerData";
            this.tSAddWorkerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSAddWorkerData.Size = new System.Drawing.Size(123, 30);
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
            // FormQLNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(920, 473);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLNhanVien";
            this.Text = "Quản Lý Thông Tin Nhân Viên";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbWorkerGender.ResumeLayout(false);
            this.gbWorkerGender.PerformLayout();
            this.gbWorkerDataList.ResumeLayout(false);
            this.gbWorkerDataList.PerformLayout();
            this.tSWorkerData.ResumeLayout(false);
            this.tSWorkerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.GroupBox gbWorkerGender;
        private System.Windows.Forms.RadioButton rbtnWorkerFemale;
        private System.Windows.Forms.RadioButton rbtnWorkerMale;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbWorkerID;
        private System.Windows.Forms.Label lbWorkerName;
        private System.Windows.Forms.Label lbWorker;
        private System.Windows.Forms.Button btnSaveDataWorker;
        private System.Windows.Forms.Label lbPhoneNumber;
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


    }
}