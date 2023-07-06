using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class frmWinCalc : Form
    {
        private string number1 = "", number2 = "", answer = "";
        private bool dotStatus = false;
        private char symbol = '0';
        //
        private void AddToDisplay(string numbersSymbol)
        {
            if (numbersSymbol == ".")
                this.dotStatus = true;

            if (this.txtDisplay.Text == "0" && numbersSymbol == ".")
            {
                this.dotStatus = true;
                this.txtDisplay.Text += numbersSymbol;

            }
            else if (this.txtDisplay.Text == "0") // 0=0
            {
                this.txtDisplay.Text = numbersSymbol;
            }
            else if (this.txtDisplay.Text != "0") // 0=0
            {
                this.txtDisplay.Text += numbersSymbol;
            }
        }
        private string calculating(string num1,string num2 ,char _symbol)
        {
            double numberFisrt = double.Parse(num1);
            double numbersecond = double.Parse(num2);
            double numAnswer = 0.0f;
            switch(_symbol)
            {
                case '+':numAnswer = numberFisrt + numbersecond; break;
                case '-': numAnswer = numberFisrt - numbersecond; break;
                case '*': numAnswer = numberFisrt * numbersecond; break;
                case '/': numAnswer = numberFisrt / numbersecond; break;

            }
            return numAnswer.ToString();


        }
        private void setNumber1(char _symbol)
        {
            this.symbol = _symbol;
            this.number1 = this.txtDisplay.Text;
            this.txtDisplay.Text = "0";
            this.dotStatus = false;
        }


        public frmWinCalc()
        {
            InitializeComponent();
        }
        #region MathSymbol
        private void frmWinCalc_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.number1 = this.number2 =  this.answer = "0";
            this.txtDisplay.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.txtDisplay.Text.Length > 0)
                this.txtDisplay.Text = 
                    this.txtDisplay.Text.Remove(this.txtDisplay.Text.Length - 1);
            if ((this.txtDisplay.Text.Length == 0) || (this.txtDisplay.Text == ""))
                this.txtDisplay.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.symbol = '+';
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.symbol = '-';
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            this.symbol = '*';
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.symbol = '/';
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            this.number2 = this.txtDisplay.Text;
            this.txtDisplay.Text =
            this.calculating(this.number1, number2, this.symbol);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!this.dotStatus)
                this.AddToDisplay(".");
        }
        #endregion

        #region Number
        private void btn0_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("6");
        }

        private void mnuClearItem_Click(object sender, EventArgs e)
        {
            this.btnClear_Click(sender, e);
        }

        private void mnuExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAboutItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("7");

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("9");
        }
        #endregion

    }
}
