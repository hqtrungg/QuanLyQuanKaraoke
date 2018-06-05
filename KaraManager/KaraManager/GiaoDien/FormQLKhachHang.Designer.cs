namespace KaraManager.GiaoDien
{
    partial class FormQLKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKhachHang));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbCustomerDataInput = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbCustomerGender = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbCustomerDataList = new System.Windows.Forms.GroupBox();
            this.dgvCustomerData = new System.Windows.Forms.DataGridView();
            this.ColCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerDateOfBirth = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.ColCustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsCustomerDataList = new System.Windows.Forms.ToolStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCustomerDateSave = new System.Windows.Forms.Button();
            this.rbtnCustomerFemale = new System.Windows.Forms.RadioButton();
            this.rbtnCustomerMale = new System.Windows.Forms.RadioButton();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.lbCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.lbCustomerDateOfBirth = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tSAddCustomerData = new System.Windows.Forms.ToolStripButton();
            this.tSFixCustomerData = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveCustomerData = new System.Windows.Forms.ToolStripButton();
            this.tSReloadCustomerData = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbCustomerDataInput.SuspendLayout();
            this.gbCustomerGender.SuspendLayout();
            this.gbCustomerDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).BeginInit();
            this.tsCustomerDataList.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbCustomerDataInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbCustomerDataList);
            this.splitContainer1.Size = new System.Drawing.Size(920, 473);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbCustomerDataInput
            // 
            this.gbCustomerDataInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCustomerDataInput.Controls.Add(this.btnCustomerDateSave);
            this.gbCustomerDataInput.Controls.Add(this.dateTimePicker1);
            this.gbCustomerDataInput.Controls.Add(this.gbCustomerGender);
            this.gbCustomerDataInput.Controls.Add(this.textBox4);
            this.gbCustomerDataInput.Controls.Add(this.textBox3);
            this.gbCustomerDataInput.Controls.Add(this.textBox2);
            this.gbCustomerDataInput.Controls.Add(this.textBox1);
            this.gbCustomerDataInput.Controls.Add(this.lbCustomerAddress);
            this.gbCustomerDataInput.Controls.Add(this.lbCustomerPhoneNumber);
            this.gbCustomerDataInput.Controls.Add(this.lbCustomerDateOfBirth);
            this.gbCustomerDataInput.Controls.Add(this.lbCustomerID);
            this.gbCustomerDataInput.Controls.Add(this.lbCustomerName);
            this.gbCustomerDataInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerDataInput.ForeColor = System.Drawing.Color.Black;
            this.gbCustomerDataInput.Location = new System.Drawing.Point(3, 3);
            this.gbCustomerDataInput.Name = "gbCustomerDataInput";
            this.gbCustomerDataInput.Size = new System.Drawing.Size(300, 467);
            this.gbCustomerDataInput.TabIndex = 0;
            this.gbCustomerDataInput.TabStop = false;
            this.gbCustomerDataInput.Text = "Nhập thông tin khách hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // gbCustomerGender
            // 
            this.gbCustomerGender.Controls.Add(this.rbtnCustomerFemale);
            this.gbCustomerGender.Controls.Add(this.rbtnCustomerMale);
            this.gbCustomerGender.Location = new System.Drawing.Point(13, 142);
            this.gbCustomerGender.Name = "gbCustomerGender";
            this.gbCustomerGender.Size = new System.Drawing.Size(281, 59);
            this.gbCustomerGender.TabIndex = 9;
            this.gbCustomerGender.TabStop = false;
            this.gbCustomerGender.Text = "Giới tính";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 304);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbCustomerDataList
            // 
            this.gbCustomerDataList.Controls.Add(this.dgvCustomerData);
            this.gbCustomerDataList.Controls.Add(this.tsCustomerDataList);
            this.gbCustomerDataList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerDataList.Location = new System.Drawing.Point(3, 3);
            this.gbCustomerDataList.Name = "gbCustomerDataList";
            this.gbCustomerDataList.Size = new System.Drawing.Size(607, 470);
            this.gbCustomerDataList.TabIndex = 0;
            this.gbCustomerDataList.TabStop = false;
            this.gbCustomerDataList.Text = "Danh Sách Khách Hàng";
            // 
            // dgvCustomerData
            // 
            this.dgvCustomerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCustomerID,
            this.ColCustomerName,
            this.ColCustomerGender,
            this.ColCustomerDateOfBirth,
            this.ColCustomerAddress,
            this.ColCustomerPhoneNumber});
            this.dgvCustomerData.Location = new System.Drawing.Point(3, 65);
            this.dgvCustomerData.Name = "dgvCustomerData";
            this.dgvCustomerData.Size = new System.Drawing.Size(604, 405);
            this.dgvCustomerData.TabIndex = 1;
            // 
            // ColCustomerID
            // 
            this.ColCustomerID.HeaderText = "ID";
            this.ColCustomerID.Name = "ColCustomerID";
            // 
            // ColCustomerName
            // 
            this.ColCustomerName.HeaderText = "Họ và tên";
            this.ColCustomerName.Name = "ColCustomerName";
            // 
            // ColCustomerGender
            // 
            this.ColCustomerGender.HeaderText = "Giới tính";
            this.ColCustomerGender.Name = "ColCustomerGender";
            this.ColCustomerGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCustomerGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCustomerDateOfBirth
            // 
            // 
            // 
            // 
            this.ColCustomerDateOfBirth.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.ColCustomerDateOfBirth.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.ColCustomerDateOfBirth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColCustomerDateOfBirth.BackgroundStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.ColCustomerDateOfBirth.HeaderText = "Ngày sinh";
            this.ColCustomerDateOfBirth.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.ColCustomerDateOfBirth.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ColCustomerDateOfBirth.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.ColCustomerDateOfBirth.MonthCalendar.BackgroundStyle.Class = "";
            this.ColCustomerDateOfBirth.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ColCustomerDateOfBirth.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.ColCustomerDateOfBirth.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColCustomerDateOfBirth.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.ColCustomerDateOfBirth.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ColCustomerDateOfBirth.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ColCustomerDateOfBirth.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.ColCustomerDateOfBirth.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColCustomerDateOfBirth.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ColCustomerDateOfBirth.Name = "ColCustomerDateOfBirth";
            // 
            // ColCustomerAddress
            // 
            this.ColCustomerAddress.HeaderText = "Địa chỉ";
            this.ColCustomerAddress.Name = "ColCustomerAddress";
            // 
            // ColCustomerPhoneNumber
            // 
            this.ColCustomerPhoneNumber.HeaderText = "Số điện thoại";
            this.ColCustomerPhoneNumber.Name = "ColCustomerPhoneNumber";
            // 
            // tsCustomerDataList
            // 
            this.tsCustomerDataList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCustomerDataList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAddCustomerData,
            this.tSFixCustomerData,
            this.tSRemoveCustomerData,
            this.tSReloadCustomerData});
            this.tsCustomerDataList.Location = new System.Drawing.Point(3, 19);
            this.tsCustomerDataList.Name = "tsCustomerDataList";
            this.tsCustomerDataList.Padding = new System.Windows.Forms.Padding(5);
            this.tsCustomerDataList.Size = new System.Drawing.Size(601, 43);
            this.tsCustomerDataList.TabIndex = 0;
            this.tsCustomerDataList.Text = "CustomerList";
            // 
            // btnCustomerDateSave
            // 
            this.btnCustomerDateSave.Image = global::KaraManager.Properties.Resources.Tick;
            this.btnCustomerDateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerDateSave.Location = new System.Drawing.Point(76, 414);
            this.btnCustomerDateSave.Name = "btnCustomerDateSave";
            this.btnCustomerDateSave.Size = new System.Drawing.Size(131, 44);
            this.btnCustomerDateSave.TabIndex = 11;
            this.btnCustomerDateSave.Text = "Lưu danh sách";
            this.btnCustomerDateSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerDateSave.UseVisualStyleBackColor = true;
            // 
            // rbtnCustomerFemale
            // 
            this.rbtnCustomerFemale.Image = global::KaraManager.Properties.Resources.Female;
            this.rbtnCustomerFemale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnCustomerFemale.Location = new System.Drawing.Point(180, 22);
            this.rbtnCustomerFemale.Name = "rbtnCustomerFemale";
            this.rbtnCustomerFemale.Size = new System.Drawing.Size(60, 24);
            this.rbtnCustomerFemale.TabIndex = 1;
            this.rbtnCustomerFemale.TabStop = true;
            this.rbtnCustomerFemale.Text = "Nữ";
            this.rbtnCustomerFemale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnCustomerFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnCustomerMale
            // 
            this.rbtnCustomerMale.Image = global::KaraManager.Properties.Resources.Male;
            this.rbtnCustomerMale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnCustomerMale.Location = new System.Drawing.Point(46, 22);
            this.rbtnCustomerMale.Name = "rbtnCustomerMale";
            this.rbtnCustomerMale.Size = new System.Drawing.Size(71, 24);
            this.rbtnCustomerMale.TabIndex = 0;
            this.rbtnCustomerMale.TabStop = true;
            this.rbtnCustomerMale.Text = "Nam";
            this.rbtnCustomerMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnCustomerMale.UseVisualStyleBackColor = true;
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.Image = global::KaraManager.Properties.Resources.Address;
            this.lbCustomerAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerAddress.Location = new System.Drawing.Point(10, 271);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(80, 30);
            this.lbCustomerAddress.TabIndex = 4;
            this.lbCustomerAddress.Text = "     Địa chỉ";
            this.lbCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerPhoneNumber
            // 
            this.lbCustomerPhoneNumber.Image = global::KaraManager.Properties.Resources.PhoneNumber;
            this.lbCustomerPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerPhoneNumber.Location = new System.Drawing.Point(10, 339);
            this.lbCustomerPhoneNumber.Name = "lbCustomerPhoneNumber";
            this.lbCustomerPhoneNumber.Size = new System.Drawing.Size(107, 29);
            this.lbCustomerPhoneNumber.TabIndex = 3;
            this.lbCustomerPhoneNumber.Text = "Số điện thoại";
            this.lbCustomerPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerDateOfBirth
            // 
            this.lbCustomerDateOfBirth.Image = global::KaraManager.Properties.Resources.Birthday;
            this.lbCustomerDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerDateOfBirth.Location = new System.Drawing.Point(10, 204);
            this.lbCustomerDateOfBirth.Name = "lbCustomerDateOfBirth";
            this.lbCustomerDateOfBirth.Size = new System.Drawing.Size(89, 26);
            this.lbCustomerDateOfBirth.TabIndex = 2;
            this.lbCustomerDateOfBirth.Text = "Ngày sinh";
            this.lbCustomerDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.Image = global::KaraManager.Properties.Resources.ID;
            this.lbCustomerID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerID.Location = new System.Drawing.Point(10, 86);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(71, 24);
            this.lbCustomerID.TabIndex = 1;
            this.lbCustomerID.Text = "Mã số";
            this.lbCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Image = global::KaraManager.Properties.Resources.Name;
            this.lbCustomerName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerName.Location = new System.Drawing.Point(9, 28);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(90, 24);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "Họ và tên";
            this.lbCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSAddCustomerData
            // 
            this.tSAddCustomerData.Checked = true;
            this.tSAddCustomerData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tSAddCustomerData.Image = global::KaraManager.Properties.Resources.Add;
            this.tSAddCustomerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAddCustomerData.Name = "tSAddCustomerData";
            this.tSAddCustomerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSAddCustomerData.Size = new System.Drawing.Size(140, 30);
            this.tSAddCustomerData.Text = "Thêm khách hàng";
            // 
            // tSFixCustomerData
            // 
            this.tSFixCustomerData.Image = global::KaraManager.Properties.Resources.Fix;
            this.tSFixCustomerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFixCustomerData.Name = "tSFixCustomerData";
            this.tSFixCustomerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSFixCustomerData.Size = new System.Drawing.Size(115, 30);
            this.tSFixCustomerData.Text = "Sửa thông tin";
            // 
            // tSRemoveCustomerData
            // 
            this.tSRemoveCustomerData.Image = global::KaraManager.Properties.Resources.Delete;
            this.tSRemoveCustomerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRemoveCustomerData.Name = "tSRemoveCustomerData";
            this.tSRemoveCustomerData.Size = new System.Drawing.Size(119, 30);
            this.tSRemoveCustomerData.Text = "Xóa khách hàng";
            // 
            // tSReloadCustomerData
            // 
            this.tSReloadCustomerData.Image = global::KaraManager.Properties.Resources.Reload;
            this.tSReloadCustomerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSReloadCustomerData.Name = "tSReloadCustomerData";
            this.tSReloadCustomerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSReloadCustomerData.Size = new System.Drawing.Size(135, 30);
            this.tSReloadCustomerData.Text = "Tải lại danh sách";
            // 
            // FormQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 473);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormQLKhachHang";
            this.Text = "Quản Lý Thông Tin Khách Hàng";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbCustomerDataInput.ResumeLayout(false);
            this.gbCustomerDataInput.PerformLayout();
            this.gbCustomerGender.ResumeLayout(false);
            this.gbCustomerDataList.ResumeLayout(false);
            this.gbCustomerDataList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).EndInit();
            this.tsCustomerDataList.ResumeLayout(false);
            this.tsCustomerDataList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Label lbCustomerPhoneNumber;
        private System.Windows.Forms.Label lbCustomerDateOfBirth;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbCustomerName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCustomerDateSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbCustomerGender;
        private System.Windows.Forms.RadioButton rbtnCustomerFemale;
        private System.Windows.Forms.RadioButton rbtnCustomerMale;
        private System.Windows.Forms.GroupBox gbCustomerDataInput;
        private System.Windows.Forms.GroupBox gbCustomerDataList;
        private System.Windows.Forms.DataGridView dgvCustomerData;
        private System.Windows.Forms.ToolStrip tsCustomerDataList;
        private System.Windows.Forms.ToolStripButton tSAddCustomerData;
        private System.Windows.Forms.ToolStripButton tSFixCustomerData;
        private System.Windows.Forms.ToolStripButton tSRemoveCustomerData;
        private System.Windows.Forms.ToolStripButton tSReloadCustomerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerGender;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn ColCustomerDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerPhoneNumber;

        public bool MaximizeBox { get; set; }

        public System.Drawing.Icon Icon { get; set; }
    }
}