using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbCong.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            String rdbName = "";
            foreach (RadioButton item in grbPhepToan.Controls)
            {
                if (item.Checked)
                {
                    rdbName = item.Name;
                }
            }

            double soHang1 = Convert.ToDouble(txbSoHang1.Text);
            double soHang2 = Convert.ToDouble(txbSoHang2.Text);
            double tong = 0;
            switch (rdbName)
            {
                case "rdbCong":
                    tong = soHang1 + soHang2;
                    break;
                case "rdbTru":
                    tong = soHang1 - soHang2;
                    break;
                case "rdbNhan":
                    tong = soHang1 * soHang2;
                    break;
                case "rdbChia":
                    tong = soHang1 / soHang2;
                    break;

            }

            txbKetQua.Text = String.Format("{0:0.00}",tong);
        }




    }
}
