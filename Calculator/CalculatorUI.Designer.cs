namespace Calculator
{
    partial class btn_percent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_percent));
            txt_input = new TextBox();
            btn_minus = new Button();
            btn_multiply = new Button();
            btn_divide = new Button();
            btn_clear = new Button();
            btn_plus = new Button();
            btn_ez = new Button();
            btn_seven = new Button();
            btn_eight = new Button();
            btn_nine = new Button();
            lbl_operation = new Label();
            btn_ac = new Button();
            btn_six = new Button();
            btn_five = new Button();
            btn_four = new Button();
            btn_three = new Button();
            btn_two = new Button();
            btn_one = new Button();
            btn_zero = new Button();
            btn_point = new Button();
            btn_info = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_input
            // 
            txt_input.BackColor = SystemColors.InfoText;
            txt_input.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            txt_input.ForeColor = Color.FloralWhite;
            txt_input.Location = new Point(40, 51);
            txt_input.Multiline = true;
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(359, 41);
            txt_input.TabIndex = 0;
            txt_input.TextAlign = HorizontalAlignment.Right;
            txt_input.TextChanged += textBox1_TextChanged;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.DarkOrange;
            btn_minus.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn_minus.ForeColor = SystemColors.HighlightText;
            btn_minus.Image = Properties.Resources.icons8_subtract_16;
            btn_minus.Location = new Point(312, 270);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(75, 39);
            btn_minus.TabIndex = 1;
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.AccessibleRole = AccessibleRole.None;
            btn_multiply.BackColor = Color.DarkOrange;
            btn_multiply.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn_multiply.ForeColor = SystemColors.HighlightText;
            btn_multiply.Image = Properties.Resources.icons8_multiply_16;
            btn_multiply.Location = new Point(312, 198);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(75, 39);
            btn_multiply.TabIndex = 2;
            btn_multiply.UseVisualStyleBackColor = false;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = Color.DarkOrange;
            btn_divide.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn_divide.ForeColor = SystemColors.HighlightText;
            btn_divide.Image = Properties.Resources.icons8_divide_16;
            btn_divide.Location = new Point(312, 122);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(75, 39);
            btn_divide.TabIndex = 3;
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ControlLight;
            btn_clear.Location = new Point(231, 123);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 39);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = Color.DarkOrange;
            btn_plus.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn_plus.ForeColor = SystemColors.HighlightText;
            btn_plus.Image = Properties.Resources.icons8_plus_math_16;
            btn_plus.Location = new Point(312, 340);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(75, 39);
            btn_plus.TabIndex = 5;
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_ez
            // 
            btn_ez.BackColor = Color.DarkOrange;
            btn_ez.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ez.ForeColor = SystemColors.HighlightText;
            btn_ez.Image = Properties.Resources.icons8_equal_sign_16;
            btn_ez.Location = new Point(312, 416);
            btn_ez.Name = "btn_ez";
            btn_ez.Size = new Size(75, 44);
            btn_ez.TabIndex = 6;
            btn_ez.UseVisualStyleBackColor = false;
            btn_ez.Click += btn_ez_Click;
            // 
            // btn_seven
            // 
            btn_seven.BackColor = SystemColors.ControlDark;
            btn_seven.ForeColor = SystemColors.ControlLightLight;
            btn_seven.Location = new Point(69, 199);
            btn_seven.Name = "btn_seven";
            btn_seven.Size = new Size(75, 39);
            btn_seven.TabIndex = 7;
            btn_seven.Text = "7";
            btn_seven.UseVisualStyleBackColor = false;
            btn_seven.Click += btn_seven_Click;
            // 
            // btn_eight
            // 
            btn_eight.BackColor = SystemColors.ControlDark;
            btn_eight.ForeColor = SystemColors.ControlLightLight;
            btn_eight.Location = new Point(150, 198);
            btn_eight.Name = "btn_eight";
            btn_eight.Size = new Size(75, 39);
            btn_eight.TabIndex = 8;
            btn_eight.Text = "8";
            btn_eight.UseVisualStyleBackColor = false;
            btn_eight.Click += btn_eight_Click;
            // 
            // btn_nine
            // 
            btn_nine.BackColor = SystemColors.ControlDark;
            btn_nine.ForeColor = SystemColors.ControlLightLight;
            btn_nine.Location = new Point(231, 199);
            btn_nine.Name = "btn_nine";
            btn_nine.Size = new Size(75, 39);
            btn_nine.TabIndex = 9;
            btn_nine.Text = "9";
            btn_nine.UseVisualStyleBackColor = false;
            btn_nine.Click += btn_nine_Click;
            // 
            // lbl_operation
            // 
            lbl_operation.AutoSize = true;
            lbl_operation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_operation.ForeColor = Color.Snow;
            lbl_operation.Location = new Point(373, 9);
            lbl_operation.Name = "lbl_operation";
            lbl_operation.Size = new Size(0, 25);
            lbl_operation.TabIndex = 10;
            lbl_operation.Click += lbl_operation_Click;
            // 
            // btn_ac
            // 
            btn_ac.BackColor = SystemColors.ControlLight;
            btn_ac.Location = new Point(150, 122);
            btn_ac.Name = "btn_ac";
            btn_ac.Size = new Size(75, 39);
            btn_ac.TabIndex = 11;
            btn_ac.Text = "AC";
            btn_ac.UseVisualStyleBackColor = false;
            btn_ac.Click += btn_ac_Click;
            // 
            // btn_six
            // 
            btn_six.BackColor = SystemColors.ControlDark;
            btn_six.ForeColor = SystemColors.ControlLightLight;
            btn_six.Location = new Point(231, 271);
            btn_six.Name = "btn_six";
            btn_six.Size = new Size(75, 39);
            btn_six.TabIndex = 14;
            btn_six.Text = "6";
            btn_six.UseVisualStyleBackColor = false;
            btn_six.Click += btn_six_Click;
            // 
            // btn_five
            // 
            btn_five.BackColor = SystemColors.ControlDark;
            btn_five.ForeColor = SystemColors.ControlLightLight;
            btn_five.Location = new Point(150, 270);
            btn_five.Name = "btn_five";
            btn_five.Size = new Size(75, 39);
            btn_five.TabIndex = 13;
            btn_five.Text = "5";
            btn_five.UseVisualStyleBackColor = false;
            btn_five.Click += btn_five_Click;
            // 
            // btn_four
            // 
            btn_four.BackColor = SystemColors.ControlDark;
            btn_four.ForeColor = SystemColors.ControlLightLight;
            btn_four.Location = new Point(69, 271);
            btn_four.Name = "btn_four";
            btn_four.Size = new Size(75, 39);
            btn_four.TabIndex = 12;
            btn_four.Text = "4";
            btn_four.UseVisualStyleBackColor = false;
            btn_four.Click += btn_four_Click;
            // 
            // btn_three
            // 
            btn_three.BackColor = SystemColors.ControlDark;
            btn_three.ForeColor = SystemColors.ControlLightLight;
            btn_three.Location = new Point(231, 341);
            btn_three.Name = "btn_three";
            btn_three.Size = new Size(75, 39);
            btn_three.TabIndex = 17;
            btn_three.Text = "3";
            btn_three.UseVisualStyleBackColor = false;
            btn_three.Click += btn_three_Click;
            // 
            // btn_two
            // 
            btn_two.BackColor = SystemColors.ControlDark;
            btn_two.ForeColor = SystemColors.ControlLightLight;
            btn_two.Location = new Point(150, 340);
            btn_two.Name = "btn_two";
            btn_two.Size = new Size(75, 39);
            btn_two.TabIndex = 16;
            btn_two.Text = "2";
            btn_two.UseVisualStyleBackColor = false;
            btn_two.Click += btn_two_Click;
            // 
            // btn_one
            // 
            btn_one.BackColor = SystemColors.ControlDark;
            btn_one.ForeColor = SystemColors.ControlLightLight;
            btn_one.Location = new Point(69, 341);
            btn_one.Name = "btn_one";
            btn_one.Size = new Size(75, 39);
            btn_one.TabIndex = 15;
            btn_one.Text = "1";
            btn_one.UseVisualStyleBackColor = false;
            btn_one.Click += btn_one_Click;
            // 
            // btn_zero
            // 
            btn_zero.BackColor = SystemColors.ControlDark;
            btn_zero.ForeColor = SystemColors.ControlLightLight;
            btn_zero.Location = new Point(69, 416);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(75, 39);
            btn_zero.TabIndex = 18;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = false;
            btn_zero.Click += button1_Click;
            // 
            // btn_point
            // 
            btn_point.BackColor = SystemColors.ControlDark;
            btn_point.ForeColor = SystemColors.ControlLightLight;
            btn_point.Location = new Point(150, 416);
            btn_point.Name = "btn_point";
            btn_point.Size = new Size(75, 39);
            btn_point.TabIndex = 19;
            btn_point.Text = ".";
            btn_point.UseVisualStyleBackColor = false;
            btn_point.Click += btn_point_Click;
            // 
            // btn_info
            // 
            btn_info.BackColor = SystemColors.ControlLight;
            btn_info.Image = (Image)resources.GetObject("btn_info.Image");
            btn_info.Location = new Point(69, 122);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(75, 39);
            btn_info.TabIndex = 20;
            btn_info.UseVisualStyleBackColor = false;
            btn_info.Click += btn_info_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(100, 512);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 21;
            label1.Text = "Made with ❤ by Abdul Rehman Sarfaraz";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(231, 416);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btn_percent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(431, 570);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btn_info);
            Controls.Add(btn_zero);
            Controls.Add(btn_point);
            Controls.Add(btn_three);
            Controls.Add(btn_two);
            Controls.Add(btn_one);
            Controls.Add(btn_six);
            Controls.Add(btn_five);
            Controls.Add(btn_four);
            Controls.Add(btn_ac);
            Controls.Add(lbl_operation);
            Controls.Add(btn_nine);
            Controls.Add(btn_eight);
            Controls.Add(btn_seven);
            Controls.Add(btn_ez);
            Controls.Add(btn_plus);
            Controls.Add(btn_clear);
            Controls.Add(btn_divide);
            Controls.Add(btn_multiply);
            Controls.Add(btn_minus);
            Controls.Add(txt_input);
            Name = "btn_percent";
            Text = "CalculatorUI";
            Load += CalculatorUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_input;
        private Button btn_minus;
        private Button btn_multiply;
        private Button btn_divide;
        private Button btn_clear;
        private Button btn_plus;
        private Button btn_ez;
        private Button btn_seven;
        private Button btn_eight;
        private Button btn_nine;
        private Label lbl_operation;
        private Button btn_ac;
        private Button btn_six;
        private Button btn_five;
        private Button btn_four;
        private Button btn_three;
        private Button btn_two;
        private Button btn_one;
        private Button btn_zero;
        private Button btn_point;
        private Button btn_info;
        private Label label1;
        private Button button1;
    }
}