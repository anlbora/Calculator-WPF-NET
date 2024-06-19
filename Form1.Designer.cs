namespace Calculator
{
    partial class mainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_close = new Button();
            btn_minimize = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_extract = new Button();
            btn_minus_plus = new Button();
            btn_clear = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_sum = new Button();
            btn_opening_paranthesis = new Button();
            btn_delete = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_divide = new Button();
            btn_closing_paranthesis = new Button();
            btn_science = new Button();
            btn_000 = new Button();
            btn_0 = new Button();
            btn_comma = new Button();
            btn_multiply = new Button();
            btn_square_root = new Button();
            btn_equal = new Button();
            panel1 = new Panel();
            lbl_answer = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.LightBlue;
            btn_close.Location = new Point(621, 13);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(30, 30);
            btn_close.TabIndex = 0;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.LightBlue;
            btn_minimize.Location = new Point(585, 13);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(30, 30);
            btn_minimize.TabIndex = 0;
            btn_minimize.Text = "-";
            btn_minimize.UseVisualStyleBackColor = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 2;
            label1.Text = "CALCULATOR APP";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_1);
            flowLayoutPanel1.Controls.Add(btn_2);
            flowLayoutPanel1.Controls.Add(btn_3);
            flowLayoutPanel1.Controls.Add(btn_extract);
            flowLayoutPanel1.Controls.Add(btn_minus_plus);
            flowLayoutPanel1.Controls.Add(btn_clear);
            flowLayoutPanel1.Controls.Add(btn_4);
            flowLayoutPanel1.Controls.Add(btn_5);
            flowLayoutPanel1.Controls.Add(btn_6);
            flowLayoutPanel1.Controls.Add(btn_sum);
            flowLayoutPanel1.Controls.Add(btn_opening_paranthesis);
            flowLayoutPanel1.Controls.Add(btn_delete);
            flowLayoutPanel1.Controls.Add(btn_7);
            flowLayoutPanel1.Controls.Add(btn_8);
            flowLayoutPanel1.Controls.Add(btn_9);
            flowLayoutPanel1.Controls.Add(btn_divide);
            flowLayoutPanel1.Controls.Add(btn_closing_paranthesis);
            flowLayoutPanel1.Controls.Add(btn_science);
            flowLayoutPanel1.Controls.Add(btn_000);
            flowLayoutPanel1.Controls.Add(btn_0);
            flowLayoutPanel1.Controls.Add(btn_comma);
            flowLayoutPanel1.Controls.Add(btn_multiply);
            flowLayoutPanel1.Controls.Add(btn_square_root);
            flowLayoutPanel1.Controls.Add(btn_equal);
            flowLayoutPanel1.Location = new Point(13, 277);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(637, 427);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_1.Location = new Point(3, 3);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(100, 100);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_2.Location = new Point(109, 3);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(100, 100);
            btn_2.TabIndex = 0;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_3.Location = new Point(215, 3);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(100, 100);
            btn_3.TabIndex = 0;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_extract
            // 
            btn_extract.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_extract.Location = new Point(321, 3);
            btn_extract.Name = "btn_extract";
            btn_extract.Size = new Size(100, 100);
            btn_extract.TabIndex = 0;
            btn_extract.Text = "-";
            btn_extract.UseVisualStyleBackColor = true;
            btn_extract.Click += btn_extract_Click;
            // 
            // btn_minus_plus
            // 
            btn_minus_plus.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_minus_plus.Location = new Point(427, 3);
            btn_minus_plus.Name = "btn_minus_plus";
            btn_minus_plus.Size = new Size(100, 100);
            btn_minus_plus.TabIndex = 0;
            btn_minus_plus.Text = "±";
            btn_minus_plus.UseVisualStyleBackColor = true;
            btn_minus_plus.Click += btn_minus_plus_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_clear.Location = new Point(533, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(100, 100);
            btn_clear.TabIndex = 0;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_4.Location = new Point(3, 109);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(100, 100);
            btn_4.TabIndex = 0;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_5.Location = new Point(109, 109);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(100, 100);
            btn_5.TabIndex = 0;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_6.Location = new Point(215, 109);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(100, 100);
            btn_6.TabIndex = 0;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_sum
            // 
            btn_sum.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_sum.Location = new Point(321, 109);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(100, 100);
            btn_sum.TabIndex = 0;
            btn_sum.Text = "+";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // btn_opening_paranthesis
            // 
            btn_opening_paranthesis.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_opening_paranthesis.Location = new Point(427, 109);
            btn_opening_paranthesis.Name = "btn_opening_paranthesis";
            btn_opening_paranthesis.Size = new Size(100, 100);
            btn_opening_paranthesis.TabIndex = 0;
            btn_opening_paranthesis.Text = "(";
            btn_opening_paranthesis.UseVisualStyleBackColor = true;
            btn_opening_paranthesis.Click += btn_opening_paranthesis_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_delete.Location = new Point(533, 109);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(100, 100);
            btn_delete.TabIndex = 0;
            btn_delete.Text = "DEL";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_7.Location = new Point(3, 215);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(100, 100);
            btn_7.TabIndex = 0;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_8.Location = new Point(109, 215);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(100, 100);
            btn_8.TabIndex = 0;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_9.Location = new Point(215, 215);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(100, 100);
            btn_9.TabIndex = 0;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_divide
            // 
            btn_divide.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_divide.Location = new Point(321, 215);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(100, 100);
            btn_divide.TabIndex = 0;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_closing_paranthesis
            // 
            btn_closing_paranthesis.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_closing_paranthesis.Location = new Point(427, 215);
            btn_closing_paranthesis.Name = "btn_closing_paranthesis";
            btn_closing_paranthesis.Size = new Size(100, 100);
            btn_closing_paranthesis.TabIndex = 0;
            btn_closing_paranthesis.Text = ")";
            btn_closing_paranthesis.UseVisualStyleBackColor = true;
            btn_closing_paranthesis.Click += btn_closing_paranthesis_Click;
            // 
            // btn_science
            // 
            btn_science.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_science.Location = new Point(533, 215);
            btn_science.Name = "btn_science";
            btn_science.Size = new Size(100, 100);
            btn_science.TabIndex = 0;
            btn_science.Text = "SCI";
            btn_science.UseVisualStyleBackColor = true;
            btn_science.Click += btn_science_Click;
            // 
            // btn_000
            // 
            btn_000.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_000.Location = new Point(3, 321);
            btn_000.Name = "btn_000";
            btn_000.Size = new Size(100, 100);
            btn_000.TabIndex = 0;
            btn_000.Text = "000";
            btn_000.UseVisualStyleBackColor = true;
            btn_000.Click += btn_000_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_0.Location = new Point(109, 321);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(100, 100);
            btn_0.TabIndex = 0;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_comma
            // 
            btn_comma.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_comma.Location = new Point(215, 321);
            btn_comma.Name = "btn_comma";
            btn_comma.Size = new Size(100, 100);
            btn_comma.TabIndex = 0;
            btn_comma.Text = ",";
            btn_comma.UseVisualStyleBackColor = true;
            btn_comma.Click += btn_comma_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_multiply.Location = new Point(321, 321);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(100, 100);
            btn_multiply.TabIndex = 0;
            btn_multiply.Text = "x";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_square_root
            // 
            btn_square_root.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_square_root.Location = new Point(427, 321);
            btn_square_root.Name = "btn_square_root";
            btn_square_root.Size = new Size(100, 100);
            btn_square_root.TabIndex = 0;
            btn_square_root.Text = "√";
            btn_square_root.UseVisualStyleBackColor = true;
            btn_square_root.Click += btn_square_root_Click;
            // 
            // btn_equal
            // 
            btn_equal.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            btn_equal.Location = new Point(533, 321);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(100, 100);
            btn_equal.TabIndex = 0;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_answer);
            panel1.Location = new Point(13, 49);
            panel1.Margin = new Padding(20);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 217);
            panel1.TabIndex = 4;
            // 
            // lbl_answer
            // 
            lbl_answer.AutoSize = true;
            lbl_answer.Font = new Font("Unispace", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_answer.Location = new Point(3, 131);
            lbl_answer.Margin = new Padding(20);
            lbl_answer.Name = "lbl_answer";
            lbl_answer.Size = new Size(618, 77);
            lbl_answer.TabIndex = 0;
            lbl_answer.Text = "000000000000000";
            lbl_answer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(664, 717);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(btn_minimize);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainApp";
            Padding = new Padding(10);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator App";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_close;
        private Button btn_minimize;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_extract;
        private Button btn_minus_plus;
        private Button btn_clear;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_sum;
        private Button btn_opening_paranthesis;
        private Button btn_delete;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_divide;
        private Button btn_closing_paranthesis;
        private Button btn_000;
        private Button btn_0;
        private Button btn_comma;
        private Button btn_multiply;
        private Button btn_square_root;
        private Panel panel1;
        private Button btn_science;
        private Button btn_equal;
        private Label lbl_answer;
    }
}
