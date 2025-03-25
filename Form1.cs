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
        void caculateAnswer(int 輸入, double 要轉換的數值)
        {
            if (輸入 != 0)
                txtCM.Text = string.Format("{0:0.##########}", 要轉換的數值);
            if (輸入 != 1)
                txtM.Text = string.Format("{0:0.##########}", 要轉換的數值 / 100);
            if (輸入 != 2)
                txtKM.Text = string.Format("{0:0.##########}", 要轉換的數值 / 100000);
            if (輸入 != 3)
                txtIn.Text = string.Format("{0:0.##########}", 要轉換的數值 / 2.54);
            if (輸入 != 4)
                txtFt.Text = string.Format("{0:0.##########}", 要轉換的數值 / 30.48);
            if (輸入 != 5)
                txtYard.Text = string.Format("{0:0.##########}", 要轉換的數值 / 91.44);
        }
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;
        }
    }
}
