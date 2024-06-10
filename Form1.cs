using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_canchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string can = "";
            switch (Convert.ToInt32(txtnam1.Text.Substring(3, 1)))
            {
                case 0:
                    can = "canh";
                    break;
                case 1:
                    can = "tân";
                    break;
                case 2:
                    can = "nhâm";
                    break;
                case 3:
                    can = "quý";
                    break;
                case 4:
                    can = "giáp";
                    break;
                case 5:
                    can = "ất";
                    break;
                case 6:
                    can = "binh";
                    break;
                case 7:
                    can = "đinh";
                    break;
                case 8:
                    can = "mậu";
                    break;
                case 9:
                    can = "kỷ";
                    break;
            }
            string chi = "";
            switch (Convert.ToInt32(txtnam1.Text.Substring(3, 1)))
            {
                case 0:
                    chi = "thân";
                    break;
                case 1:
                    chi = "dậu";
                    break;
                case 2:
                    chi = "tuất";
                    break;
                case 3:
                    chi = "hợi";
                    break;
                case 4:
                    chi = "tý";
                    break;
                case 5:
                    chi = "sửu";
                    break;
                case 6:
                    chi = "dần";
                    break;
                case 7:
                    chi = "mão";
                    break;
                case 8:
                    chi = "thìn";
                    break;
                case 9:
                    chi = "tỵ";
                    break;
                case 10:
                    chi = "ngọ";
                    break;
                case 11:
                    chi = "mùi";
                    break;
            }
            txtnam2.Text = can + " " + chi;
        }
    }
}    