using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnZero.Text;
        }
        bool IsPoint = false;
        private void btnPoint_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "" && !IsPoint)
            {
                txtDisplay.Text = "0" + btnPoint.Text;
                IsPoint = true;
            }
            else if(!IsPoint)
            {
                txtDisplay.Text += btnPoint.Text;
                IsPoint = true;
            }
        }
        void ClearAll()
        {
            IsNegative = false;
            IsPoint = false;
            txtDisplay.Clear();
            txtDisplay.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }
        bool IsNegative = false;
        private void btnNegativePositive_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "" && !IsNegative)
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
                IsNegative = true;
            }
            else if (txtDisplay.Text != "" && !IsNegative)
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
                IsNegative = true;
            }
            else if(IsNegative)
            {
                txtDisplay.Text = txtDisplay.Text.Trim('-');
                IsNegative = false;
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtDisplay.Text);
            txtDisplay.Text = (num * num).ToString();
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtDisplay.Text);
            txtDisplay.Text = (num * num * num).ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int fact = 1;
            int num = int.Parse(txtDisplay.Text);
            for(int i = 1; i<= num; i++)
            {
                fact *= i;
            }
            txtDisplay.Text = fact.ToString();
        }
        int num1, num2;
        bool Addition = false;
        bool Multiply = false;
        bool Subtraction = false;
        bool Division = false;
        bool Exponent = false;
        private void btnAddition_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);
            Addition = true;
            Multiply = false;
            Subtraction = false;
            Division = false;
            Exponent = false;
            txtDisplay.Clear();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);
            Addition = false;
            Multiply = false;
            Subtraction = true;
            Division = false;
            Exponent = false;
            txtDisplay.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);
            Addition = false;
            Multiply = false;
            Subtraction = false;
            Division = true;
            Exponent = false;
            txtDisplay.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);
            Addition = false;
            Multiply = true;
            Subtraction = false;
            Division = false;
            Exponent = false;
            txtDisplay.Clear();
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);
            Addition = false;
            Multiply = false;
            Subtraction = false;
            Division = false;
            Exponent = true;
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = int.Parse(txtDisplay.Text);
                if (Addition)
                {
                    txtDisplay.Text = (num1 + num2).ToString();
                }
                else if (Subtraction)
                {
                    txtDisplay.Text = (num1 - num2).ToString();
                }
                else if (Multiply)
                {
                    txtDisplay.Text = (num1 * num2).ToString();
                }
                else if (Division)
                {
                    txtDisplay.Text = (num1 / num2).ToString();
                }
                else if (Exponent)
                {
                    int ans = 1;
                    for (int i = 1; i <= num2; i++)
                    {
                        ans *= num1;
                    }
                    txtDisplay.Text = ans.ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
