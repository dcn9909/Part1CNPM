using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbSoHang1.Text)&& !String.IsNullOrEmpty(txbSoHang2.Text))
            {
                txbTong.Text = String.Format("{0}", Int32.Parse(txbSoHang1.Text) 
                                                    + Int32.Parse(txbSoHang2.Text));
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập số hạng nào","Thông báo",MessageBoxButtons.OK,
                                                                        MessageBoxIcon.Error);
            }
            
        }
    }
}
