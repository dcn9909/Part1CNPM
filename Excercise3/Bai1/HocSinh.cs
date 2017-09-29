using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class HocSinh
    {
        string maHS;
        public string MaHS { get => maHS; set => maHS = value; }


        string hoTen;
        public string HoTen { get => hoTen; set => hoTen = value; }

        string gioiTinh;
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        DateTime ngaySinh;
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        string diaChi;
        public string DiaChi { get => diaChi; set => diaChi = value; }

        double diemTB;
        public double DiemTB { get => diemTB; set => diemTB = value; }

        string lop;
        public string Lop { get => lop; set => lop = value; }

        public HocSinh(string maHS, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, float diemTB, string lop)
        {
            this.maHS = maHS;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.diemTB = diemTB;
            this.lop = lop;
        }

        public HocSinh()
        {

        }


        public HocSinh(DataRow row)
        {
            this.maHS = row["MaHS"].ToString();
            this.hoTen = row["HoTen"].ToString();
            this.GioiTinh = (bool)row["GioiTinh"] ? "Nam" : "Nữ";
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.diaChi = row["DiaChi"].ToString();
            this.diemTB = (float)row["DTB"];
            this.lop = row["Lop"].ToString();

        }

        public HocSinh(SqlDataReader dataReader)
        {
            this.maHS = dataReader["MaHS"].ToString();
            this.hoTen = dataReader["HoTen"].ToString();
            this.GioiTinh = (bool)dataReader["GioiTinh"] ? "Nam" : "Nữ";
            this.ngaySinh = (DateTime)dataReader["NgaySinh"];
            this.diaChi = dataReader["DiaChi"].ToString();
            this.diemTB = Convert.ToDouble(dataReader["DTB"]);
            this.lop = dataReader["Lop"].ToString();

        }


    }
}
