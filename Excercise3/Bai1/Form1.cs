using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public string strConnection = @"Data Source=.;Initial Catalog=CNPM;Integrated Security=True;Pooling=False";

        public SqlConnection connection;
        private void Form1_Load(object sender, EventArgs e)
        {
            #region thêm lớp vào cbb
            cbbLop.Items.Add("Lớp 10A1");
            cbbLop.Items.Add("Lớp 10A2");
            cbbLop.Items.Add("Lớp 10A3");
            cbbLop.Items.Add("Lớp 10A4");
            cbbLop.Items.Add("Lớp 10A5");
            cbbLop.SelectedIndex = 0;
            #endregion

            #region Kết nối db

            try
            {
                connection = new SqlConnection(strConnection);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex.Message);
            }



            #endregion



            List<HocSinh> lst = LoadListHS();

            foreach (HocSinh hs in lst)
            {
                lstDanhSach.Items.Add(new ListViewItem(new string[] {hs.MaHS,hs.HoTen,hs.GioiTinh,
                                      hs.NgaySinh.ToString(),hs.DiaChi,hs.DiemTB.ToString(),hs.Lop }));
            }



            //Resize độ rộng của column
            lstDanhSach.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstDanhSach.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (txbHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            if (txbDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            if (txbDiemTB.Text.Trim() == "")
            {
                MessageBox.Show("Điểm trung bình không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (Convert.ToDouble(txbDiemTB.Text) > 10 || Convert.ToDouble(txbDiemTB.Text) < 0)
            {
                MessageBox.Show("Điểm trung bình phải lớn hơn 0 và bé hơn 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }




            if (flag)
            {
                int gioiTinh = rdNam.Checked == true ? 1 : 0;
                double diemTB = Convert.ToDouble(txbDiemTB.Text);
                string query = "INSERT dbo.HocSinh ( MaHS , HoTen , GioiTinh , NgaySinh , DiaChi ,DTB , Lop ) VALUES  (";
                query += "N'" + txbMaHS.Text + "',";
                query += "N'" + txbHoTen.Text.Trim() + "',";
                query += gioiTinh + ",";
                query += "'" + dtpNgaySinh.Value.ToString() + "',";
                query += "N'" + txbDiaChi.Text + "',";
                query += txbDiemTB.Text + ",";
                query += "N'" + cbbLop.SelectedItem.ToString() + "')";
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();

                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            // Xóa tất cả các fields
            txbDiaChi.Text = "";
            txbDiemTB.Text = "";
            txbHoTen.Text = "";
            txbMaHS.Text = "";
            rdNam.Checked = false;

        }

        public List<HocSinh> LoadListHS()
        {
            List<HocSinh> listHS = new List<HocSinh>();

            string query = "select * from HocSinh ";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                HocSinh hs;

                while (reader.Read())
                {
                    hs = new HocSinh(reader);
                    listHS.Add(hs);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex);
            }
            finally
            {
                connection.Close();

            }

            return listHS;


        }

        

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndices.Count > 0)
            {
                HocSinh hocSinh = new HocSinh();
                hocSinh.MaHS = lstDanhSach.SelectedItems[0].SubItems[0].Text.Trim();
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string query = "select * from HocSinh where MaHS='" + hocSinh.MaHS + "'";

                    SqlCommand sqlCommand = new SqlCommand(query, connection);

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {

                        hocSinh = new HocSinh(dataReader);
                        #region đưa data vào các control
                        txbMaHS.Text = hocSinh.MaHS;
                        txbHoTen.Text = hocSinh.HoTen;
                        if (hocSinh.GioiTinh.Equals("Nam"))
                        {
                            rdNam.Checked = true;
                        }
                        dtpNgaySinh.Value = hocSinh.NgaySinh;
                        txbDiaChi.Text = hocSinh.DiaChi;
                        txbDiemTB.Text = hocSinh.DiemTB.ToString();

                        cbbLop.SelectedIndex = cbbLop.Items.IndexOf(hocSinh.Lop.Trim());

                        #endregion
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.ToString());
                    Console.Write(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }
    }
}
