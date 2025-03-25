using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenthcalaulartornew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
        string strInput;
        double douOutput;
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;
            void caculateAnswer(int 輸入, double 要轉換的數值)
            {
                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtM.Text = string.Format("{0:0.##########}", 要轉換的數值 / 100);
                    txtKM.Text = string.Format("{0:0.##########}", 要轉換的數值 / 100000);
                    txtIn.Text = string.Format("{0:0.##########}", 要轉換的數值 / 2.54);
                    txtFt.Text = string.Format("{0:0.##########}", 要轉換的數值 / 30.48);
                    txtYard.Text = string.Format("{0:0.##########}", 要轉換的數值 / 91.44);

                    caculateAnswer(0, douOutput);
                }
                else
                {
                    txtInfo.Text = "請輸入數字";
                    txtCM.Text = "";
                }
            }
        }
    }
}
