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
            this.txbTenMonAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnThemNhieu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaNhieu = new System.Windows.Forms.Button();
            this.lsbMenu = new System.Windows.Forms.ListBox();
            this.lsbChon = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbTenMonAn
            // 
            this.txbTenMonAn.Location = new System.Drawing.Point(85, 15);
            this.txbTenMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenMonAn.Name = "txbTenMonAn";
            this.txbTenMonAn.Size = new System.Drawing.Size(326, 22);
            this.txbTenMonAn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên món";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(419, 12);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(100, 28);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnThemNhieu
            // 
            this.btnThemNhieu.Location = new System.Drawing.Point(231, 199);
            this.btnThemNhieu.Name = "btnThemNhieu";
            this.btnThemNhieu.Size = new System.Drawing.Size(75, 23);
            this.btnThemNhieu.TabIndex = 6;
            this.btnThemNhieu.Text = ">>";
            this.btnThemNhieu.UseVisualStyleBackColor = true;
            this.btnThemNhieu.Click += new System.EventHandler(this.btnThemNhieu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(231, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaNhieu
            // 
            this.btnXoaNhieu.Location = new System.Drawing.Point(231, 257);
            this.btnXoaNhieu.Name = "btnXoaNhieu";
            this.btnXoaNhieu.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNhieu.TabIndex = 8;
            this.btnXoaNhieu.Text = "<<";
            this.btnXoaNhieu.UseVisualStyleBackColor = true;
            this.btnXoaNhieu.Click += new System.EventHandler(this.btnXoaNhieu_Click);
            // 
            // lsbMenu
            // 
            this.lsbMenu.FormattingEnabled = true;
            this.lsbMenu.ItemHeight = 16;
            this.lsbMenu.Location = new System.Drawing.Point(12, 59);
            this.lsbMenu.Name = "lsbMenu";
            this.lsbMenu.Size = new System.Drawing.Size(213, 372);
            this.lsbMenu.TabIndex = 9;
            // 
            // lsbChon
            // 
            this.lsbChon.FormattingEnabled = true;
            this.lsbChon.ItemHeight = 16;
            this.lsbChon.Location = new System.Drawing.Point(312, 59);
            this.lsbChon.Name = "lsbChon";
            this.lsbChon.Size = new System.Drawing.Size(213, 372);
            this.lsbChon.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(231, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = ">";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 443);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lsbChon);
            this.Controls.Add(this.lsbMenu);
            this.Controls.Add(this.btnXoaNhieu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemNhieu);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenMonAn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTenMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnThemNhieu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaNhieu;
        private System.Windows.Forms.ListBox lsbMenu;
        private System.Windows.Forms.ListBox lsbChon;
        private System.Windows.Forms.Button btnThem;
    }
}

