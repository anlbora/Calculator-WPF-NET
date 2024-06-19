using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class mainApp : Form
    {
        float answer;
        string input = "";
        string expression = ""; // To keep track of the full expression
        bool isNewOperation = true; // Flag to indicate if a new operation starts
        bool isLastEqualPress = false; // Flag to check if last button press was equal

        public mainApp()
        {
            InitializeComponent();
            answer = 0;
            lbl_answer.Text = "0";
            lbl_answer.Font = new Font(lbl_answer.Font.FontFamily, 48); // Start with the maximum font size
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Handle numeric key presses
            if (keyData >= Keys.D0 && keyData <= Keys.D9)
            {
                HandleNumericInput((keyData - Keys.D0).ToString());
                return true;
            }
            if (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9)
            {
                HandleNumericInput((keyData - Keys.NumPad0).ToString());
                return true;
            }

            // Handle operation key presses
            switch (keyData)
            {
                case Keys.Add:
                case Keys.Oemplus: // + key
                    btn_sum_Click(this, new EventArgs());
                    return true;
                case Keys.Subtract:
                case Keys.OemMinus: // - key
                    btn_extract_Click(this, new EventArgs());
                    return true;
                case Keys.Multiply:
                    btn_multiply_Click(this, new EventArgs());
                    return true;
                case Keys.Divide:
                    btn_divide_Click(this, new EventArgs());
                    return true;
                case Keys.Enter:
                    btn_equal_Click(this, new EventArgs());
                    return true;
                case Keys.Back:
                    btn_delete_Click(this, new EventArgs());
                    return true;
                case Keys.Escape:
                    btn_clear_Click(this, new EventArgs());
                    return true;
                default:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void HandleNumericInput(string number)
        {
            if (isNewOperation || isLastEqualPress)
            {
                input = number;
                isNewOperation = false;
                isLastEqualPress = false;
            }
            else
            {
                input += number;
            }
            expression += number;
            UpdateAnswerDisplay();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            HandleNumericInput("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            HandleNumericInput("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            HandleNumericInput("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            HandleNumericInput("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            HandleNumericInput("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            HandleNumericInput("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            HandleNumericInput("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            HandleNumericInput("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            HandleNumericInput("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            HandleNumericInput("0");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input = "";
            expression = "";
            lbl_answer.Text = "0";
            answer = 0;
            isNewOperation = true;
            isLastEqualPress = false;
            ResetFontSize();
        }

        private void HandleOperation(string operationSign)
        {
            if (isLastEqualPress)
            {
                // If last operation was equal, start new expression with the answer
                expression = answer.ToString();
            }

            if (!string.IsNullOrEmpty(input) || isLastEqualPress)
            {
                expression += " " + operationSign + " ";
                input = ""; // Reset the input for the next operand
                UpdateAnswerDisplay();
            }
            isNewOperation = false;
            isLastEqualPress = false; // Reset after any new operation
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            HandleOperation("+");
        }

        private void btn_extract_Click(object sender, EventArgs e)
        {
            HandleOperation("-");
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            HandleOperation("*");
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            HandleOperation("/");
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                // Evaluate the full expression using DataTable
                var result = EvaluateExpression(expression);
                answer = float.Parse(result);
                expression = answer.ToString(); // Update expression to show the result
                UpdateAnswerDisplay(result);
                input = ""; // Clear the input for the next number entry
                isNewOperation = true; // Ready for a new operation
                isLastEqualPress = true; // Indicate that the last button press was equal
            }
            catch (Exception)
            {
                lbl_answer.Text = "Error";
            }
        }

        private void btn_square_root_Click(object sender, EventArgs e)
        {
            try
            {
                // Use the displayed answer if no new input is provided
                float number;
                if (string.IsNullOrEmpty(input))
                {
                    number = float.Parse(lbl_answer.Text);
                }
                else
                {
                    number = float.Parse(input);
                }

                if (number >= 0)
                {
                    answer = MathF.Sqrt(number);
                    expression = answer.ToString(); // Update expression to show the result
                    UpdateAnswerDisplay(answer.ToString());
                    input = ""; // Reset input for the next number entry
                    isNewOperation = true; // Ready for a new operation
                    isLastEqualPress = true; // Indicate that the last operation was a calculation
                }
                else
                {
                    lbl_answer.Text = "Invalid input";
                }
            }
            catch (FormatException)
            {
                lbl_answer.Text = "Error";
            }
        }


        private void btn_opening_paranthesis_Click(object sender, EventArgs e)
        {
            if (isNewOperation || isLastEqualPress)
            {
                expression = "(";
                isNewOperation = false;
                isLastEqualPress = false;
            }
            else
            {
                expression += "(";
            }
            UpdateAnswerDisplay();
        }

        private void btn_closing_paranthesis_Click(object sender, EventArgs e)
        {
            expression += ")";
            UpdateAnswerDisplay();
        }

        private void btn_000_Click(object sender, EventArgs e)
        {
            input += "000";
            expression += "000";
            UpdateAnswerDisplay();
        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                input += ".";
                expression += ".";
                UpdateAnswerDisplay();
            }
        }

        private void btn_minus_plus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (input[0] == '-')
                {
                    input = input.Substring(1);
                    expression = expression.Substring(0, expression.Length - input.Length - 1) + input;
                }
                else
                {
                    input = "-" + input;
                    expression = expression.Substring(0, expression.Length - input.Length + 1) + input;
                }
                UpdateAnswerDisplay();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                input = input.Substring(0, input.Length - 1);
                expression = expression.Substring(0, expression.Length - 1);
                lbl_answer.Text = string.IsNullOrEmpty(input) ? "0" : expression;
                UpdateAnswerDisplay();
            }
        }

        private void btn_science_Click(object sender, EventArgs e)
        {
            // Placeholder for switching to scientific mode
            MessageBox.Show("Scientific mode functionality to be implemented.");
        }

        private void btn_equal_Click_1(object sender, EventArgs e)
        {
            // If there are two equal buttons, consolidate their functionality.
            btn_equal_Click(sender, e);
        }

        // Helper method to evaluate expressions
        private string EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return (string)row["expression"];
        }

        // Helper method to update the answer display and adjust font size if needed
        private void UpdateAnswerDisplay(string text = null)
        {
            lbl_answer.Text = text ?? expression;
            AdjustFontSize();
        }

        // Method to dynamically adjust the font size of the label based on its content
        private void AdjustFontSize()
        {
            const int maxFontSize = 48;
            const int minFontSize = 10; // Lowered min size to allow more flexibility for larger text
            const int thresholdLength = 10; // Start reducing font size after 10 characters

            if (lbl_answer.Text.Length <= thresholdLength)
            {
                // If the length is below the threshold, use the maximum font size
                lbl_answer.Font = new Font(lbl_answer.Font.FontFamily, maxFontSize);
            }
            else
            {
                // Calculate the new font size
                int newFontSize = maxFontSize - (lbl_answer.Text.Length - thresholdLength);
                // Ensure the font size does not go below the minimum size
                lbl_answer.Font = new Font(lbl_answer.Font.FontFamily, Math.Max(minFontSize, newFontSize));
            }
        }

        // Method to reset the font size to the default maximum
        private void ResetFontSize()
        {
            lbl_answer.Font = new Font(lbl_answer.Font.FontFamily, 48); // Assuming 48 is the default max font size
        }
    }
}
