using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        public void cool()
        {
                string[] contents = { "(ゝ∀･)", "(   ꒪꒫꒪)", " ˃ ⤙ ˂", "(╬☉д⊙)", "٩(๑`ȏ´๑)۶" };
                Random random = new Random();
                int index = random.Next(contents.Length);
                Console.WriteLine(contents[index]);
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
            if (double.TryParse(strInput, out douOutput) == true) 
            { 
                caculateAnswer(0, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字"; cool();
                txtCM.Text = "";
            }
        }
        private void caculateAnswer(int 輸入, double 要轉換的數值)
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

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }
    }
}
