using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Calcutlator : Form
    {
        /// <summary>
        /// biến mảng lưu phép tính
        /// </summary>
        private List<String> Operator = new List<string>();


        public Queue<double> SoHang;


        public Queue<char> PhepToan;



        /// <summary>
        /// Hàm thực hiện phép tính
        /// </summary>
        /// <param name="operater"></param>
        /// <param name="num"></param>
        /// <param name="num1"></param>
        /// <returns></returns>
        public double Calculate(char operater, double num, double num1)
        {


            double result = 0;
            switch (operater)
            {
                case '+':
                    result = num + num1;
                    break;
                case '-':
                    result = num - num1;
                    break;
                case '*':
                    result = num * num1;
                    break;
                case '/':
                    result = num / num1;
                    break;
            }
            return result;
        }


        public Calcutlator()
        {
            InitializeComponent();
        }

        private void Calcutlator_Load(object sender, EventArgs e)
        {
            SoHang = new Queue<double>();
            PhepToan = new Queue<char>();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txbResult.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbResult.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            
            string text = txbResult.Text;
            string str = "";
            foreach (char item in text)
            {

                if (item.Equals('/') || item.Equals('*') || item.Equals('+') || item.Equals('-'))
                {

                    SoHang.Enqueue(Convert.ToDouble(str));
                    str = "";
                }
                else
                {
                    str += item;
                }
                if (text.IndexOf(item) == text.Length - 1)
                {
                    SoHang.Enqueue(Convert.ToDouble(str));
                }

            }

            double result = SoHang.Dequeue();
            for (int i = 0; i < PhepToan.Count; i++)
            {
                result = Calculate(PhepToan.Dequeue(),result,SoHang.Dequeue());
            }
            txbResult.Text = result.ToString();
        }

        #region Button của phép tính
        private void btnDivide_Click(object sender, EventArgs e)
        {
            PhepToan.Enqueue('/');
            txbResult.Text += "/";
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            PhepToan.Enqueue('*');
            txbResult.Text += "*";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhepToan.Enqueue('+');
            txbResult.Text += "+";
        }


        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PhepToan.Enqueue('-');
            txbResult.Text += "-";
        }


        #endregion

        #region Phím số


        private void btn1_Click(object sender, EventArgs e)
        {
            txbResult.Text += "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResult.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResult.Text += "9";
        }

        #endregion
    }
}
