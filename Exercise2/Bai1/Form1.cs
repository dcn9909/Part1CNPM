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
            lsbMenu.Items.Add("Khai vị");
            lsbMenu.Items.Add("Tôm hấp bia");
            lsbMenu.Items.Add("Lẫu hải sản");
            lsbMenu.Items.Add("Trái cây");
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            lsbMenu.Items.Add(txbTenMonAn.Text);
            txbTenMonAn.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lsbMenu.SelectedItem!=null && !lsbChon.Items.Contains(lsbMenu.SelectedItem))
            {
                
                lsbChon.Items.Add(lsbMenu.SelectedItem);
                
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsbChon.SelectedItem != null)
            {

                lsbChon.Items.Remove(lsbChon.SelectedItem);

            }

        }

        private void btnThemNhieu_Click(object sender, EventArgs e)
        {
            foreach (var item in lsbMenu.Items)
            {
                lsbChon.Items.Add(item);
            }
        }

        private void btnXoaNhieu_Click(object sender, EventArgs e)
        {
            foreach (var item in lsbMenu.Items)
            {
                lsbChon.Items.Remove(item);
            }
        }
    }
}
