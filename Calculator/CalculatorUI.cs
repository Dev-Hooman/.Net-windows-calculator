using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class btn_percent : Form
    {
        Calculations cs = new Calculations();


        public btn_percent()
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Set the border style to a fixed size

            this.BackColor = Color.Black;


            foreach (var control in this.Controls)
            {
                if (control is Button)
                {
                    var btn = control as Button;

                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.BorderColor = Color.Black;

                    btn.Font = new Font("Segoe UI", 21, FontStyle.Regular);


                    btn.Size = new Size(61, 61);
                    btn.Cursor = Cursors.Hand;




                    var path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, btn.Width - 1, btn.Height - 1);
                    btn.Region = new Region(path);


                }
            }
        }




        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                if (cs.resultValue != 0)
                {
                    btn_ez.PerformClick();
                    cs.operationPerformed = "/";
                    lbl_operation.Text = cs.resultValue + " " + cs.operationPerformed;
                    cs.isOperationPerformed = true;
                }
                else
                {
                    cs.operationPerformed = "/";
                    cs.resultValue = double.Parse(txt_input.Text);
                    lbl_operation.Text = cs.resultValue + " " + cs.operationPerformed;
                    cs.isOperationPerformed = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Any Number first to perform action!");
            }

        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                if (cs.resultValue != 0)
                {
                    btn_ez.PerformClick();
                    cs.operationPerformed = "*";
                    lbl_operation.Text = cs.resultValue + " " + cs.operationPerformed;
                    cs.isOperationPerformed = true;
                }
                else
                {
                    cs.operationPerformed = "*";
                    cs.resultValue = double.Parse(txt_input.Text);
                    lbl_operation.Text = cs.resultValue + " " + cs.operationPerformed;
                    cs.isOperationPerformed = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Any Number first to perform action!");
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                if (cs.resultValue != 0)
                {
                    btn_ez.PerformClick();
                    cs.operationPerformed = "-";
                    lbl_operation.Text = cs.resultValue + " " + cs.operationPerformed;
                    cs.isOperationPerformed = true;
                }
                else
                {
                    cs.operationPerformed = "-";
                    cs.resultValue = double.Parse(txt_input.Text);
                    lbl_operation.Text = cs.resultValue + " " + cs.operationPerformed;
                    cs.isOperationPerformed = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Any Number first to perform action!");
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

            try
            {
                Button button = (Button)sender;

                if (cs.resultValue != 0)
                {
                    btn_ez.PerformClick();
                    cs.operationPerformed = "+";
                    lbl_operation.Text = cs.resultValue + " " + cs.operationPerformed;
                    cs.isOperationPerformed = true;
                }
                else
                {
                    cs.operationPerformed = "+";
                    cs.resultValue = double.Parse(txt_input.Text);
                    lbl_operation.Text = cs.resultValue + " " + cs.operationPerformed;
                    cs.isOperationPerformed = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Any Number first to perform action!");
            }
        }

        private void btn_ez_Click(object sender, EventArgs e)
        {
            switch (cs.operationPerformed)
            {
                case "+":
                    txt_input.Text = (cs.resultValue + double.Parse(txt_input.Text)).ToString();
                    break;
                case "-":
                    txt_input.Text = (cs.resultValue - double.Parse(txt_input.Text)).ToString();
                    break;
                case "*":
                    txt_input.Text = (cs.resultValue * double.Parse(txt_input.Text)).ToString();
                    break;
                case "/":
                    txt_input.Text = (cs.resultValue / double.Parse(txt_input.Text)).ToString();
                    break;
                default:
                    break;
            }

            cs.resultValue = double.Parse(txt_input.Text);
            lbl_operation.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void btn_one_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "1");

        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "2");

        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "3");

        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "4");

        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "5");

        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "6");

        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            /*
            if (txt_input.Text == "0" || cs.isOperationPerformed)
                txt_input.Clear();

            cs.isOperationPerformed = false;
            txt_input.Text = txt_input.Text + "7";
            */

            txt_input.Text = cs.keyPressed(txt_input.Text, "7");

        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "8");

        }
        private void btn_nine_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "9");

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (txt_input.Text.Length > 0)
            {
                txt_input.Text = txt_input.Text.Remove(txt_input.Text.Length - 1, 1);

                if (txt_input.Text == "")
                {
                    txt_input.Text = "0";
                    cs.resultValue = 0;
                    lbl_operation.Text = "";
                }


            }
        }

        private void lbl_operation_Click(object sender, EventArgs e)
        {

        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            txt_input.Text = "0";
            cs.resultValue = 0;
            lbl_operation.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_input.Text = cs.keyPressed(txt_input.Text, "0");

        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (!txt_input.Text.Contains("."))
                txt_input.Text = txt_input.Text + ".";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
