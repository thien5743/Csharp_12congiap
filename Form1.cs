using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_12congiap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                    string can, chi;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 2000; i <= 2050; i++)
            {
                int indexCan = i % 10;
                int indexChi = i % 12;
               
            }
           
          
            switch (Convert.ToInt32(txtduong.Text) % 10) 
            {
                case 0:
                    can = "canh";
                    break;
                case 1:
                    can = "tan";
                    break;
                case 2:
                    can = "nham";
                    break;
                case 3:
                    can = "quy";
                    break;
                case 4:
                    can = "giap";
                    break;
                case 5:
                    can = "at";
                    break;
                case 6:
                    can = "binh";
                    break;
                case 7:
                    can = "dinh";
                    break;
                case 8:
                    can = "mau";
                    break;

                case 9:
                    can = "ky";
                    break;

                
                

            }
            switch (Convert.ToInt32(txtduong.Text) % 12)
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


                    txtamlich.Text = can + " " + chi;
            }
            ;
        }
    }
}
