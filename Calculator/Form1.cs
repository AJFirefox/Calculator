using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public string lastResult = "";
        public double Memory = 0;

        private bool isExponentInput = false;
        private string baseValue = "";
        private string exponentValue = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // --- Helper Helper Method to Route Number Typing ---
        private void AppendDigit(string digit)
        {
            if (result.Text == "Error") result.Text = "";

            if (isExponentInput)
            {
                // If it's the default "0", overwrite it. Otherwise, append.
                if (exponentValue == "0")
                {
                    exponentValue = digit;
                }
                else
                {
                    exponentValue += digit;
                }
                // Maintain the mathematical format on screen
                result.Text = baseValue + "*10^" + exponentValue;
            }
            else
            {
                result.Text += digit;
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        private void One_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            isExponentInput = false; // Typing a new operator breaks exponent mode
            result.Text += "+";
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            isExponentInput = false;
            result.Text += "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            isExponentInput = false;
            result.Text += "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            isExponentInput = false;
            result.Text += "/";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            result.Text = "";
            isExponentInput = false;
            baseValue = "";
            exponentValue = "";
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            // Decimals are only valid for the base value, not the integer exponent
            if (!isExponentInput)
            {
                result.Text += ".";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";

            if (result.Text.Length > 0)
            {
                // If we are tracking an exponent string, delete from the tracking variable too
                if (isExponentInput && exponentValue.Length > 0)
                {
                    exponentValue = exponentValue.Substring(0, exponentValue.Length - 1);
                    if (exponentValue.Length == 0) exponentValue = "0"; // reset to default
                    result.Text = baseValue + "*10^" + exponentValue;
                }
                else
                {
                    // If they backspace past the *10^, turn off exponent mode
                    if (result.Text.EndsWith("*10^0"))
                    {
                        isExponentInput = false;
                        result.Text = baseValue;
                    }
                    else
                    {
                        result.Text = result.Text.Substring(0, result.Text.Length - 1);
                    }
                }
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                string formulaToCompute = result.Text;

                // System.Data.DataTable.Compute doesn't support the caret (^) operator natively.
                // It requires using the Power function or string parsing. 
                // We'll manually parse out the *10^ parts using Math.Pow if multiple calculations exist,
                // or convert "*10^" to a double string so Compute can solve the rest.
                if (isExponentInput)
                {
                    double baseNum = Convert.ToDouble(baseValue);
                    double expNum = Convert.ToDouble(exponentValue);
                    double scientificValue = baseNum * Math.Pow(10, expNum);

                    // Replace the notation expression with its real raw numerical value for the DataTable compute engine
                    formulaToCompute = formulaToCompute.Replace(baseValue + "*10^" + exponentValue, scientificValue.ToString());
                }

                object calculation = new System.Data.DataTable().Compute(formulaToCompute, "");
                result.Text = calculation.ToString();
            }
            catch (Exception ex)
            {
                result.Text = "Error";
            }

            // Reset states safely after calculation completes
            isExponentInput = false;
            lastResult = result.Text;
        }

        private void Negation_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";

            // Negate the exponent if currently typing the exponent, otherwise negate the full string
            if (isExponentInput)
            {
                if (exponentValue.StartsWith("-"))
                    exponentValue = exponentValue.Substring(1);
                else
                    exponentValue = "-" + exponentValue;

                result.Text = baseValue + "*10^" + exponentValue;
            }
            else if (result.Text.Length > 0)
            {
                if (result.Text[0] == '-')
                {
                    result.Text = result.Text.Substring(1);
                }
                else
                {
                    result.Text = "-" + result.Text;
                }
            }
        }

        private void Round_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            try
            {
                double number = Convert.ToDouble(result.Text);
                result.Text = Math.Round(number).ToString();
            }
            catch (Exception ex)
            {
                result.Text = "Error";
            }
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            isExponentInput = false;
            result.Text = lastResult;
        }

        private void MemoryAdd_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            try
            {
                Memory += Convert.ToDouble(result.Text);
            }
            catch
            {
                result.Text = "Error";
            }
        }

        private void MemoryRemove_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            try
            {
                Memory -= Convert.ToDouble(result.Text); // Changed to subtraction for "MemoryRemove" functionality
            }
            catch
            {
                result.Text = "Error";
            }
        }

        private void MemoryRecall_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            isExponentInput = false;
            result.Text = Memory.ToString();
        }

        private void Exponent_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";

            // Only trigger if we have a valid base number on screen and aren't already editing an exponent
            if (!string.IsNullOrEmpty(result.Text) && !isExponentInput)
            {
                baseValue = result.Text;
                isExponentInput = true;
                exponentValue = "0";

                // Updates display to match your exact mathematical text layout style
                result.Text = baseValue + "*10^" + exponentValue;
            }
        }
    }
}
