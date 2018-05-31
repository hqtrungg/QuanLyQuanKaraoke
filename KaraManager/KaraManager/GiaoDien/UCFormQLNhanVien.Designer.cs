namespace KaraManager.GiaoDien
{
    partial class UCFormQLNhanVien
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
            this.gbWorkerDataInput = new System.Windows.Forms.GroupBox();
            this.gbWorkerDataList = new System.Windows.Forms.GroupBox();
            this.btnCustomerDateSave = new System.Windows.Forms.Button();
            this.datetimeCustomerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.gbCustomerGender = new System.Windows.Forms.GroupBox();
            this.rbtnCustomerFemale = new System.Windows.Forms.RadioButton();
            this.rbtnCustomerMale = new System.Windows.Forms.RadioButton();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.lbCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.lbCustomerDateOfBirth = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tSCustomerDataList = new System.Windows.Forms.ToolStrip();
            this.tSAddCustomerData = new System.Windows.Forms.ToolStripButton();
            this.tSFixCustomerData = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveCustomerData = new System.Windows.Forms.ToolStripButton();
            this.tSReloadCustomerData = new System.Windows.Forms.ToolStripButton();
            this.dgvCustomerData = new System.Windows.Forms.DataGridView();
            this.ColCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerDateOfBirth = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.ColCustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbWorkerDataInput.SuspendLayout();
            this.gbWorkerDataList.SuspendLayout();
            this.gbCustomerGender.SuspendLayout();
            this.tSCustomerDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbWorkerDataInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbWorkerDataList);
            this.splitContainer1.Size = new System.Drawing.Size(1059, 728);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbWorkerDataInput
            // 
            this.gbWorkerDataInput.Controls.Add(this.btnCustomerDateSave);
            this.gbWorkerDataInput.Controls.Add(this.datetimeCustomerDateOfBirth);
            this.gbWorkerDataInput.Controls.Add(this.gbCustomerGender);
            this.gbWorkerDataInput.Controls.Add(this.tbCustomerAddress);
            this.gbWorkerDataInput.Controls.Add(this.tbCustomerID);
            this.gbWorkerDataInput.Controls.Add(this.tbCustomerPhoneNumber);
            this.gbWorkerDataInput.Controls.Add(this.tbCustomerName);
            this.gbWorkerDataInput.Controls.Add(this.lbCustomerAddress);
            this.gbWorkerDataInput.Controls.Add(this.lbCustomerPhoneNumber);
            this.gbWorkerDataInput.Controls.Add(this.lbCustomerDateOfBirth);
            this.gbWorkerDataInput.Controls.Add(this.lbCustomerID);
            this.gbWorkerDataInput.Controls.Add(this.lbCustomerName);
            this.gbWorkerDataInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkerDataInput.Location = new System.Drawing.Point(3, 3);
            this.gbWorkerDataInput.Name = "gbWorkerDataInput";
            this.gbWorkerDataInput.Size = new System.Drawing.Size(347, 722);
            this.gbWorkerDataInput.TabIndex = 0;
            this.gbWorkerDataInput.TabStop = false;
            this.gbWorkerDataInput.Text = "Nhập thông tin nhân viên";
            // 
            // gbWorkerDataList
            // 
            this.gbWorkerDataList.Controls.Add(this.dgvCustomerData);
            this.gbWorkerDataList.Controls.Add(this.tSCustomerDataList);
            this.gbWorkerDataList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkerDataList.Location = new System.Drawing.Point(3, 3);
            this.gbWorkerDataList.Name = "gbWorkerDataList";
            this.gbWorkerDataList.Size = new System.Drawing.Size(696, 722);
            this.gbWorkerDataList.TabIndex = 0;
            this.gbWorkerDataList.TabStop = false;
            this.gbWorkerDataList.Text = "Danh sách nhân viên";
            // 
            // btnCustomerDateSave
            // 
            this.btnCustomerDateSave.Image = global::KaraManager.Properties.Resources.Tick;
            this.btnCustomerDateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerDateSave.Location = new System.Drawing.Point(105, 624);
            this.btnCustomerDateSave.Name = "btnCustomerDateSave";
            this.btnCustomerDateSave.Size = new System.Drawing.Size(137, 60);
            this.btnCustomerDateSave.TabIndex = 35;
            this.btnCustomerDateSave.Text = "Lưu danh sách";
            this.btnCustomerDateSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerDateSave.UseVisualStyleBackColor = true;
            // 
            // datetimeCustomerDateOfBirth
            // 
            this.datetimeCustomerDateOfBirth.Location = new System.Drawing.Point(27, 369);
            this.datetimeCustomerDateOfBirth.Name = "datetimeCustomerDateOfBirth";
            this.datetimeCustomerDateOfBirth.Size = new System.Drawing.Size(295, 23);
            this.datetimeCustomerDateOfBirth.TabIndex = 34;
            // 
            // gbCustomerGender
            // 
            this.gbCustomerGender.Controls.Add(this.rbtnCustomerFemale);
            this.gbCustomerGender.Controls.Add(this.rbtnCustomerMale);
            this.gbCustomerGender.Location = new System.Drawing.Point(27, 236);
            this.gbCustomerGender.Name = "gbCustomerGender";
            this.gbCustomerGender.Size = new System.Drawing.Size(295, 67);
            this.gbCustomerGender.TabIndex = 33;
            this.gbCustomerGender.TabStop = false;
            this.gbCustomerGender.Text = "Giới tính";
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
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(27, 463);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(295, 23);
            this.tbCustomerAddress.TabIndex = 32;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(27, 178);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(295, 23);
            this.tbCustomerID.TabIndex = 31;
            // 
            // tbCustomerPhoneNumber
            // 
            this.tbCustomerPhoneNumber.Location = new System.Drawing.Point(27, 555);
            this.tbCustomerPhoneNumber.Name = "tbCustomerPhoneNumber";
            this.tbCustomerPhoneNumber.Size = new System.Drawing.Size(295, 23);
            this.tbCustomerPhoneNumber.TabIndex = 30;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(27, 97);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(295, 23);
            this.tbCustomerName.TabIndex = 29;
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.Image = global::KaraManager.Properties.Resources.Address;
            this.lbCustomerAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerAddress.Location = new System.Drawing.Point(24, 421);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(79, 39);
            this.lbCustomerAddress.TabIndex = 28;
            this.lbCustomerAddress.Text = "     Địa chỉ";
            this.lbCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerPhoneNumber
            // 
            this.lbCustomerPhoneNumber.Image = global::KaraManager.Properties.Resources.PhoneNumber;
            this.lbCustomerPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerPhoneNumber.Location = new System.Drawing.Point(24, 515);
            this.lbCustomerPhoneNumber.Name = "lbCustomerPhoneNumber";
            this.lbCustomerPhoneNumber.Size = new System.Drawing.Size(108, 37);
            this.lbCustomerPhoneNumber.TabIndex = 27;
            this.lbCustomerPhoneNumber.Text = "Số điện thoại";
            this.lbCustomerPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerDateOfBirth
            // 
            this.lbCustomerDateOfBirth.Image = global::KaraManager.Properties.Resources.Birthday;
            this.lbCustomerDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerDateOfBirth.Location = new System.Drawing.Point(24, 333);
            this.lbCustomerDateOfBirth.Name = "lbCustomerDateOfBirth";
            this.lbCustomerDateOfBirth.Size = new System.Drawing.Size(89, 33);
            this.lbCustomerDateOfBirth.TabIndex = 26;
            this.lbCustomerDateOfBirth.Text = "Ngày sinh";
            this.lbCustomerDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.Image = global::KaraManager.Properties.Resources.ID;
            this.lbCustomerID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerID.Location = new System.Drawing.Point(24, 141);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(69, 34);
            this.lbCustomerID.TabIndex = 25;
            this.lbCustomerID.Text = "Mã số";
            this.lbCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Image = global::KaraManager.Properties.Resources.Name;
            this.lbCustomerName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCustomerName.Location = new System.Drawing.Point(24, 56);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(89, 38);
            this.lbCustomerName.TabIndex = 24;
            this.lbCustomerName.Text = "Họ và tên";
            this.lbCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSCustomerDataList
            // 
            this.tSCustomerDataList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAddCustomerData,
            this.tSFixCustomerData,
            this.tSRemoveCustomerData,
            this.tSReloadCustomerData});
            this.tSCustomerDataList.Location = new System.Drawing.Point(3, 19);
            this.tSCustomerDataList.Name = "tSCustomerDataList";
            this.tSCustomerDataList.Size = new System.Drawing.Size(690, 33);
            this.tSCustomerDataList.TabIndex = 2;
            this.tSCustomerDataList.Text = "toolStrip1";
            // 
            // tSAddCustomerData
            // 
            this.tSAddCustomerData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSAddCustomerData.Image = global::KaraManager.Properties.Resources.Add;
            this.tSAddCustomerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSAddCustomerData.Name = "tSAddCustomerData";
            this.tSAddCustomerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSAddCustomerData.Size = new System.Drawing.Size(130, 30);
            this.tSAddCustomerData.Text = "Thêm nhân viên";
            // 
            // tSFixCustomerData
            // 
            this.tSFixCustomerData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSFixCustomerData.Image = global::KaraManager.Properties.Resources.Fix;
            this.tSFixCustomerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSFixCustomerData.Name = "tSFixCustomerData";
            this.tSFixCustomerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSFixCustomerData.Size = new System.Drawing.Size(115, 30);
            this.tSFixCustomerData.Text = "Sửa thông tin";
            // 
            // tSRemoveCustomerData
            // 
            this.tSRemoveCustomerData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSRemoveCustomerData.Image = global::KaraManager.Properties.Resources.Delete;
            this.tSRemoveCustomerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRemoveCustomerData.Name = "tSRemoveCustomerData";
            this.tSRemoveCustomerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSRemoveCustomerData.Size = new System.Drawing.Size(119, 30);
            this.tSRemoveCustomerData.Text = "Xóa nhân viên";
            // 
            // tSReloadCustomerData
            // 
            this.tSReloadCustomerData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSReloadCustomerData.Image = global::KaraManager.Properties.Resources.Reload;
            this.tSReloadCustomerData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSReloadCustomerData.Name = "tSReloadCustomerData";
            this.tSReloadCustomerData.Padding = new System.Windows.Forms.Padding(5);
            this.tSReloadCustomerData.Size = new System.Drawing.Size(135, 30);
            this.tSReloadCustomerData.Text = "Tải lại danh sách";
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
            this.dgvCustomerData.Location = new System.Drawing.Point(3, 58);
            this.dgvCustomerData.Name = "dgvCustomerData";
            this.dgvCustomerData.Size = new System.Drawing.Size(690, 664);
            this.dgvCustomerData.TabIndex = 3;
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
            // UCFormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCFormQLNhanVien";
            this.Size = new System.Drawing.Size(1059, 728);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbWorkerDataInput.ResumeLayout(false);
            this.gbWorkerDataInput.PerformLayout();
            this.gbWorkerDataList.ResumeLayout(false);
            this.gbWorkerDataList.PerformLayout();
            this.gbCustomerGender.ResumeLayout(false);
            this.tSCustomerDataList.ResumeLayout(false);
            this.tSCustomerDataList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbWorkerDataInput;
        private System.Windows.Forms.GroupBox gbWorkerDataList;
        private System.Windows.Forms.Button btnCustomerDateSave;
        private System.Windows.Forms.DateTimePicker datetimeCustomerDateOfBirth;
        private System.Windows.Forms.GroupBox gbCustomerGender;
        private System.Windows.Forms.RadioButton rbtnCustomerFemale;
        private System.Windows.Forms.RadioButton rbtnCustomerMale;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbCustomerPhoneNumber;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Label lbCustomerPhoneNumber;
        private System.Windows.Forms.Label lbCustomerDateOfBirth;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.ToolStrip tSCustomerDataList;
        private System.Windows.Forms.ToolStripButton tSAddCustomerData;
        private System.Windows.Forms.ToolStripButton tSFixCustomerData;
        private System.Windows.Forms.ToolStripButton tSRemoveCustomerData;
        private System.Windows.Forms.ToolStripButton tSReloadCustomerData;
        private System.Windows.Forms.DataGridView dgvCustomerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerGender;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn ColCustomerDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerPhoneNumber;
    }
}
