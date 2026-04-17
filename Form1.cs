using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class frmCalculator : Form
    {
        string FirstSide;
        string SecondSide;
        char[] btnSIGN = new char[20];
        int counter;
        char FirstSign;
        public frmCalculator()
        {
            InitializeComponent();
        }
        void ClickNum(Button btnNum)
        {
            tbCalculate.Text += btnNum.Tag;
        }

        void IsSign(Button btnSign)
        {
            if (btnSign == btnBlas || btnSign == btnSub || btnSign == btnDive || btnSign == btnPercent || btnSign == btnMulti)
            {
                FirstSide = tbCalculate.Text;
                btnSIGN[counter] = Convert.ToChar(btnSign.Tag);
            }
            counter++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            panel2.BackColor = Color.FromArgb(30, 30, 30);
            tbCalculate.BackColor = Color.FromArgb(30, 30, 30);
            tbResualt.BackColor = Color.FromArgb(30, 30, 30);
            btnOne.BackColor = Color.FromArgb(60, 60, 60);
            btnTwo.BackColor = Color.FromArgb(60, 60, 60);
            btnThree.BackColor = Color.FromArgb(60, 60, 60);
            btnFour.BackColor = Color.FromArgb(60, 60, 60);
            btnDot.BackColor = Color.FromArgb(60, 60, 60);
            btnFive.BackColor = Color.FromArgb(60, 60, 60);
            btnSix.BackColor = Color.FromArgb(60, 60, 60);
            btnSeven.BackColor = Color.FromArgb(60, 60, 60);
            btnEght.BackColor = Color.FromArgb(60, 60, 60);
            btnNine.BackColor = Color.FromArgb(60, 60, 60);
            btnZero.BackColor = Color.FromArgb(60, 60, 60);
            btnBlas.BackColor = Color.FromArgb(80, 80, 80);
            btnSub.BackColor = Color.FromArgb(80, 80, 80);
            btnDive.BackColor = Color.FromArgb(80, 80, 80);
            btnPercent.BackColor = Color.FromArgb(80, 80, 80);
            btnMulti.BackColor = Color.FromArgb(80, 80, 80);

            btnEqual.BackColor = Color.FromArgb(0, 122, 204);


        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnEght_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClickNum((Button)sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsFaild())
                return;

            IsSign((Button)sender);

            ClickNum((Button)sender);

        }

        bool IsFaild()
        {
           

            string data = tbCalculate.Text;
            if (data[data.Length - 1] == '+' ||
           data[data.Length - 1] == '-' ||
           data[data.Length - 1] == '*' ||
           data[data.Length - 1] == '/' ||
           data[data.Length - 1] == '%')
            {

                return true;
            }

            return false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {


            if (IsFaild())
            {
                tbResualt.Text = "Faild!";
                tbResualt.ForeColor = Color.Red;
                return;

            }
            else
            {
                tbResualt.ForeColor = Color.White;

            }

            string[] Numbers;
            string Calculate = "0";
            string Resualt = tbCalculate.Text;
            Numbers = Resualt.Split(btnSIGN);

            for (int i = 0; i < Numbers.Count(); i++)
            {
                if (Numbers[i] == ".")
                {
                    Array.Clear(Numbers, i, 1);
                    Numbers[i] = ".0";
                }
            }

            Calculate = Numbers[0];

            for (int i = 0; i < Numbers.Count() - 1; i++)
            {
                if (btnSIGN[0] == '+' || btnSIGN[0] == '%' || btnSIGN[0] == '/' || btnSIGN[0] == '*')
                {
                    switch (btnSIGN[i])
                    {
                        case '+':
                            Calculate = Convert.ToString(Convert.ToDouble(Numbers[i + 1]) + Convert.ToDouble(Calculate));
                            break;

                        case '-':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) - Convert.ToDouble(Numbers[i + 1]));
                            break;

                        case '/':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) / Convert.ToDouble(Numbers[i + 1]));
                            break;

                        case '%':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) % Convert.ToDouble(Numbers[i + 1]));
                            break;


                        case '*':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) * Convert.ToDouble(Numbers[i + 1]));
                            break;
                    }
                }

                if (btnSIGN[0] == '-')
                {
                    switch (btnSIGN[i])
                    {
                        case '+':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) + Convert.ToDouble(Numbers[i + 1]));
                            break;

                        case '-':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) - Convert.ToDouble(Numbers[i + 1]));
                            break;

                        case '/':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) / Convert.ToDouble(Numbers[i + 1]));
                            break;

                        case '%':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) % Convert.ToDouble(Numbers[i + 1]));
                            break;


                        case '*':
                            Calculate = Convert.ToString(Convert.ToDouble(Calculate) * Convert.ToDouble(Numbers[i + 1]));
                            break;
                    }
                }


            }
            tbResualt.Text = Calculate;
            Array.Clear(btnSIGN, 0, btnSIGN.Length);
            counter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsFaild())
                return;

            IsSign((Button)sender);

            ClickNum((Button)sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsFaild())
                return;

            IsSign((Button)sender);

            ClickNum((Button)sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsFaild())
                return;

            IsSign((Button)sender);

            ClickNum((Button)sender);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string data = tbCalculate.Text;



            if (data[data.Length - 1] == '+' ||
                data[data.Length - 1] == '-' ||
                data[data.Length - 1] == '*' ||
                data[data.Length - 1] == '/' ||
                data[data.Length - 1] == '%')
            {
                Array.Clear(btnSIGN, counter - 1, 1);
                counter--;
            }

            if (tbCalculate.Text.Length > 0)
                tbCalculate.Text = tbCalculate.Text.Remove(tbCalculate.Text.Length - 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbCalculate.Text = "";
            tbResualt.Text = "";
            Array.Clear(btnSIGN, 0, btnSIGN.Length - 1);
            counter = 0;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (IsFaild())
                return;

            IsSign((Button)sender);

            ClickNum((Button)sender);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

            if (IsFaild())
                return;

            IsSign((Button)sender);

            ClickNum((Button)sender);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!tbCalculate.Text.Contains('.'))
                ClickNum((Button)sender);

        }
    }
}
