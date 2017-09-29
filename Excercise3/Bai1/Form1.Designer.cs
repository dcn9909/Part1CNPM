namespace Bai1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbDiemTB = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbMaHS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grbThongTin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIẾP NHẬN HỒ SƠ HỌC SINH";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.dtpNgaySinh);
            this.grbThongTin.Controls.Add(this.rdNam);
            this.grbThongTin.Controls.Add(this.cbbLop);
            this.grbThongTin.Controls.Add(this.txbHoTen);
            this.grbThongTin.Controls.Add(this.txbDiemTB);
            this.grbThongTin.Controls.Add(this.txbDiaChi);
            this.grbThongTin.Controls.Add(this.txbMaHS);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Location = new System.Drawing.Point(12, 41);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(564, 156);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin học sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(91, 52);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(155, 22);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(313, 55);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(55, 20);
            this.rdNam.TabIndex = 3;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(313, 115);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(245, 24);
            this.cbbLop.TabIndex = 6;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(313, 21);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(245, 22);
            this.txbHoTen.TabIndex = 1;
            // 
            // txbDiemTB
            // 
            this.txbDiemTB.Location = new System.Drawing.Point(91, 115);
            this.txbDiemTB.Name = "txbDiemTB";
            this.txbDiemTB.Size = new System.Drawing.Size(155, 22);
            this.txbDiemTB.TabIndex = 5;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(91, 87);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(467, 22);
            this.txbDiaChi.TabIndex = 4;
            // 
            // txbMaHS
            // 
            this.txbMaHS.Location = new System.Drawing.Point(91, 24);
            this.txbMaHS.Name = "txbMaHS";
            this.txbMaHS.Size = new System.Drawing.Size(155, 22);
            this.txbMaHS.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điểm TB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Location = new System.Drawing.Point(582, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(6, 27);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(234, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(115, 27);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Thêm mới";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 294);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstDanhSach.FullRowSelect = true;
            this.lstDanhSach.GridLines = true;
            this.lstDanhSach.Location = new System.Drawing.Point(9, 21);
            this.lstDanhSach.MultiSelect = false;
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(876, 267);
            this.lstDanhSach.TabIndex = 0;
            this.lstDanhSach.UseCompatibleStateImageBehavior = false;
            this.lstDanhSach.View = System.Windows.Forms.View.Details;
            this.lstDanhSach.SelectedIndexChanged += new System.EventHandler(this.lstDanhSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học sinh";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên học sinh";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa chỉ";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Điểm trung bình";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lớp";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(115, 80);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận học sinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbDiemTB;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbMaHS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstDanhSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnLamMoi;
    }
}

