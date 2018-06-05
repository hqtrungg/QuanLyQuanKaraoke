namespace KaraManager.GiaoDien
{
    partial class FormDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatPhong));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbRoomList = new System.Windows.Forms.GroupBox();
            this.gbChosenMenu = new System.Windows.Forms.GroupBox();
            this.lbRoomCategoryReg = new System.Windows.Forms.Label();
            this.lbRoomNameReg = new System.Windows.Forms.Label();
            this.lbBeginTime = new System.Windows.Forms.Label();
            this.lbCustomerNameReg = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.dateTimeReg = new System.Windows.Forms.DateTimePicker();
            this.gbRoomRegister = new System.Windows.Forms.GroupBox();
            this.lbCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.tbCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.tbRoomNameReg = new System.Windows.Forms.TextBox();
            this.tbRoomCategoryReg = new System.Windows.Forms.TextBox();
            this.lbRoomCategory = new System.Windows.Forms.Label();
            this.cbRoomCategory = new System.Windows.Forms.ComboBox();
            this.btnRoomSearch = new System.Windows.Forms.Button();
            this.btnRoomRegister = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbRoomRegister.SuspendLayout();
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbRoomList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbChosenMenu);
            this.splitContainer1.Panel2.Controls.Add(this.gbMenu);
            this.splitContainer1.Panel2.Controls.Add(this.gbRoomRegister);
            this.splitContainer1.Size = new System.Drawing.Size(1095, 485);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbRoomList
            // 
            this.gbRoomList.BackColor = System.Drawing.Color.LightCoral;
            this.gbRoomList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomList.Location = new System.Drawing.Point(3, 3);
            this.gbRoomList.Name = "gbRoomList";
            this.gbRoomList.Size = new System.Drawing.Size(297, 479);
            this.gbRoomList.TabIndex = 0;
            this.gbRoomList.TabStop = false;
            this.gbRoomList.Text = "Danh sách phòng";
            // 
            // gbChosenMenu
            // 
            this.gbChosenMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChosenMenu.Location = new System.Drawing.Point(560, 3);
            this.gbChosenMenu.Name = "gbChosenMenu";
            this.gbChosenMenu.Size = new System.Drawing.Size(228, 470);
            this.gbChosenMenu.TabIndex = 3;
            this.gbChosenMenu.TabStop = false;
            this.gbChosenMenu.Text = "Món ăn đã chọn";
            // 
            // lbRoomCategoryReg
            // 
            this.lbRoomCategoryReg.AutoSize = true;
            this.lbRoomCategoryReg.Location = new System.Drawing.Point(17, 89);
            this.lbRoomCategoryReg.Name = "lbRoomCategoryReg";
            this.lbRoomCategoryReg.Size = new System.Drawing.Size(35, 16);
            this.lbRoomCategoryReg.TabIndex = 8;
            this.lbRoomCategoryReg.Text = "Loại ";
            // 
            // lbRoomNameReg
            // 
            this.lbRoomNameReg.AutoSize = true;
            this.lbRoomNameReg.Location = new System.Drawing.Point(17, 137);
            this.lbRoomNameReg.Name = "lbRoomNameReg";
            this.lbRoomNameReg.Size = new System.Drawing.Size(69, 16);
            this.lbRoomNameReg.TabIndex = 9;
            this.lbRoomNameReg.Text = "Tên phòng";
            // 
            // lbBeginTime
            // 
            this.lbBeginTime.AutoSize = true;
            this.lbBeginTime.Location = new System.Drawing.Point(17, 332);
            this.lbBeginTime.Name = "lbBeginTime";
            this.lbBeginTime.Size = new System.Drawing.Size(108, 16);
            this.lbBeginTime.TabIndex = 13;
            this.lbBeginTime.Text = "Thời gian bắt đầu";
            // 
            // lbCustomerNameReg
            // 
            this.lbCustomerNameReg.AutoSize = true;
            this.lbCustomerNameReg.Location = new System.Drawing.Point(17, 187);
            this.lbCustomerNameReg.Name = "lbCustomerNameReg";
            this.lbCustomerNameReg.Size = new System.Drawing.Size(99, 16);
            this.lbCustomerNameReg.TabIndex = 14;
            this.lbCustomerNameReg.Text = "Tên khách hàng";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(134, 184);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(141, 23);
            this.tbCustomerName.TabIndex = 17;
            // 
            // dateTimeReg
            // 
            this.dateTimeReg.Location = new System.Drawing.Point(134, 327);
            this.dateTimeReg.Name = "dateTimeReg";
            this.dateTimeReg.Size = new System.Drawing.Size(141, 23);
            this.dateTimeReg.TabIndex = 18;
            // 
            // gbRoomRegister
            // 
            this.gbRoomRegister.Controls.Add(this.btnRoomSearch);
            this.gbRoomRegister.Controls.Add(this.cbRoomCategory);
            this.gbRoomRegister.Controls.Add(this.lbRoomCategory);
            this.gbRoomRegister.Controls.Add(this.tbRoomCategoryReg);
            this.gbRoomRegister.Controls.Add(this.tbRoomNameReg);
            this.gbRoomRegister.Controls.Add(this.tbCustomerAddress);
            this.gbRoomRegister.Controls.Add(this.lbCustomerAddress);
            this.gbRoomRegister.Controls.Add(this.tbCustomerPhoneNumber);
            this.gbRoomRegister.Controls.Add(this.lbCustomerPhoneNumber);
            this.gbRoomRegister.Controls.Add(this.dateTimeReg);
            this.gbRoomRegister.Controls.Add(this.tbCustomerName);
            this.gbRoomRegister.Controls.Add(this.lbCustomerNameReg);
            this.gbRoomRegister.Controls.Add(this.lbBeginTime);
            this.gbRoomRegister.Controls.Add(this.lbRoomNameReg);
            this.gbRoomRegister.Controls.Add(this.lbRoomCategoryReg);
            this.gbRoomRegister.Controls.Add(this.btnRoomRegister);
            this.gbRoomRegister.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomRegister.Location = new System.Drawing.Point(3, 3);
            this.gbRoomRegister.Name = "gbRoomRegister";
            this.gbRoomRegister.Size = new System.Drawing.Size(287, 479);
            this.gbRoomRegister.TabIndex = 0;
            this.gbRoomRegister.TabStop = false;
            this.gbRoomRegister.Text = "Đặt Phòng";
            this.gbRoomRegister.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbCustomerPhoneNumber
            // 
            this.lbCustomerPhoneNumber.Location = new System.Drawing.Point(17, 232);
            this.lbCustomerPhoneNumber.Name = "lbCustomerPhoneNumber";
            this.lbCustomerPhoneNumber.Size = new System.Drawing.Size(96, 23);
            this.lbCustomerPhoneNumber.TabIndex = 20;
            this.lbCustomerPhoneNumber.Text = "Số điện thoại";
            this.lbCustomerPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCustomerPhoneNumber
            // 
            this.tbCustomerPhoneNumber.Location = new System.Drawing.Point(134, 232);
            this.tbCustomerPhoneNumber.Name = "tbCustomerPhoneNumber";
            this.tbCustomerPhoneNumber.Size = new System.Drawing.Size(141, 23);
            this.tbCustomerPhoneNumber.TabIndex = 21;
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.Location = new System.Drawing.Point(17, 280);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(96, 23);
            this.lbCustomerAddress.TabIndex = 22;
            this.lbCustomerAddress.Text = "Địa chỉ";
            this.lbCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(134, 280);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(141, 23);
            this.tbCustomerAddress.TabIndex = 23;
            // 
            // tbRoomNameReg
            // 
            this.tbRoomNameReg.Location = new System.Drawing.Point(134, 134);
            this.tbRoomNameReg.Name = "tbRoomNameReg";
            this.tbRoomNameReg.ReadOnly = true;
            this.tbRoomNameReg.Size = new System.Drawing.Size(141, 23);
            this.tbRoomNameReg.TabIndex = 24;
            // 
            // tbRoomCategoryReg
            // 
            this.tbRoomCategoryReg.Location = new System.Drawing.Point(134, 86);
            this.tbRoomCategoryReg.Name = "tbRoomCategoryReg";
            this.tbRoomCategoryReg.ReadOnly = true;
            this.tbRoomCategoryReg.Size = new System.Drawing.Size(141, 23);
            this.tbRoomCategoryReg.TabIndex = 25;
            // 
            // lbRoomCategory
            // 
            this.lbRoomCategory.AutoSize = true;
            this.lbRoomCategory.Location = new System.Drawing.Point(17, 39);
            this.lbRoomCategory.Name = "lbRoomCategory";
            this.lbRoomCategory.Size = new System.Drawing.Size(70, 16);
            this.lbRoomCategory.TabIndex = 26;
            this.lbRoomCategory.Text = "Loại phòng";
            // 
            // cbRoomCategory
            // 
            this.cbRoomCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomCategory.FormattingEnabled = true;
            this.cbRoomCategory.Location = new System.Drawing.Point(134, 36);
            this.cbRoomCategory.Name = "cbRoomCategory";
            this.cbRoomCategory.Size = new System.Drawing.Size(141, 24);
            this.cbRoomCategory.TabIndex = 27;
            // 
            // btnRoomSearch
            // 
            this.btnRoomSearch.Image = global::KaraManager.Properties.Resources.Search;
            this.btnRoomSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomSearch.Location = new System.Drawing.Point(169, 389);
            this.btnRoomSearch.Name = "btnRoomSearch";
            this.btnRoomSearch.Size = new System.Drawing.Size(106, 38);
            this.btnRoomSearch.TabIndex = 28;
            this.btnRoomSearch.Text = "Tìm Phòng";
            this.btnRoomSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoomSearch.UseVisualStyleBackColor = true;
            // 
            // btnRoomRegister
            // 
            this.btnRoomRegister.Image = global::KaraManager.Properties.Resources.Room;
            this.btnRoomRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomRegister.Location = new System.Drawing.Point(20, 389);
            this.btnRoomRegister.Name = "btnRoomRegister";
            this.btnRoomRegister.Size = new System.Drawing.Size(106, 38);
            this.btnRoomRegister.TabIndex = 3;
            this.btnRoomRegister.Text = "Đặt Phòng";
            this.btnRoomRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoomRegister.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFood.Image = global::KaraManager.Properties.Resources.Food;
            this.btnFood.Location = new System.Drawing.Point(39, 22);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(75, 65);
            this.btnFood.TabIndex = 3;
            this.btnFood.UseVisualStyleBackColor = false;
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDrink.Image = global::KaraManager.Properties.Resources.Drink;
            this.btnDrink.Location = new System.Drawing.Point(142, 22);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(75, 65);
            this.btnDrink.TabIndex = 4;
            this.btnDrink.UseVisualStyleBackColor = false;
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.dataGridView1);
            this.gbMenu.Controls.Add(this.btnDrink);
            this.gbMenu.Controls.Add(this.btnFood);
            this.gbMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMenu.Location = new System.Drawing.Point(296, 3);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(258, 479);
            this.gbMenu.TabIndex = 2;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Thực Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 365);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 485);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDatPhong";
            this.Text = "Đặt Phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDatPhong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbRoomRegister.ResumeLayout(false);
            this.gbRoomRegister.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbRoomList;
        private System.Windows.Forms.GroupBox gbChosenMenu;
        private System.Windows.Forms.GroupBox gbRoomRegister;
        private System.Windows.Forms.Button btnRoomSearch;
        private System.Windows.Forms.ComboBox cbRoomCategory;
        private System.Windows.Forms.Label lbRoomCategory;
        private System.Windows.Forms.TextBox tbRoomCategoryReg;
        private System.Windows.Forms.TextBox tbRoomNameReg;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerPhoneNumber;
        private System.Windows.Forms.Label lbCustomerPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimeReg;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbCustomerNameReg;
        private System.Windows.Forms.Label lbBeginTime;
        private System.Windows.Forms.Label lbRoomNameReg;
        private System.Windows.Forms.Label lbRoomCategoryReg;
        private System.Windows.Forms.Button btnRoomRegister;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnFood;



    }
}