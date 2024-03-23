namespace uicalc
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        bool firstInput = true;
        string output = "";
        string secondOutput = "";
        string operation = "";
        private void insertNumber(object sender, EventArgs e)
        {
            Button numButton = (Button) sender;
            string num = numButton.Text;

            if (firstInput)
            {
                topOutput.Visible = false;
                output = output + Convert.ToString(num);
                updateOutput(output);
            } else
            {
                secondOutput = secondOutput + Convert.ToString(num);
                updateOutput(secondOutput);
            }
            
        }

        private void useOperator(object sender, EventArgs e)
        {
            Button operButton = (Button) sender;
            if (output != "")
            {
                topOutput.Visible = true;
                firstInput = false;
                updateOutput(secondOutput);
                switch (operButton.Text)
                {
                    case "+":
                        topOutput.Text = output + " + ";
                        operation = "add";
                        break;
                    case "-":
                        topOutput.Text = output + " - ";
                        operation = "subtract";
                        break;
                    case "*":
                        topOutput.Text = output + " * ";
                        operation = "multiply";
                        break;
                    case "/":
                        topOutput.Text = output + " / ";
                        operation = "divide";
                        break;
                }
            }
        }

        private void useSpecialOperator(object sender, EventArgs e)
        {
            Button operButton = (Button) sender;
            double result = 0;
            if (output != "")
            {
                topOutput.Visible = true;
                firstInput = true;
                switch (operButton.Text)
                {
                    case "sqrt":
                        topOutput.Text = "sqrt( " + output + " )";
                        result = Math.Sqrt(Convert.ToDouble(output));
                        outputBox.Text = Convert.ToString(result);
                        break;
                    case "1/x":
                        topOutput.Text = "1/( " + output + " )";
                        result = Math.ReciprocalEstimate(Convert.ToDouble(output));
                        outputBox.Text = Convert.ToString(result);
                        break;
                    case "x^2":
                        topOutput.Text = "sqr( " + output + " )";
                        result = Math.Pow(Convert.ToDouble(output), 2);
                        outputBox.Text = Convert.ToString(result);
                        break;
                }
                output = Convert.ToString(result);
            }
        }

        private void clearEntry(object sender, EventArgs e)
        {
            if (firstInput)
            {
                output = "";
                updateOutput(output);
            } else
            {
                secondOutput = "";
                updateOutput(secondOutput);
            }
        }

        private void clearOutput(object sender, EventArgs e)
        {
            output = "";
            secondOutput = "";
            operation = "";
            firstInput = true;
            updateOutput(output);

            topOutput.Text = "";
            topOutput.Visible = false;
        }

        private void eraseOutput(object sender, EventArgs e)
        {
            if (firstInput)
            {
                output = output.Remove(output.Length - 1);
                updateOutput(output);
            } else
            {
                secondOutput = secondOutput.Remove(secondOutput.Length - 1);
                updateOutput(secondOutput);
            }
        }

        private void updateOutput(string outp)
        {
            if (outp != "")
            {
                outputBox.Text = outp;
            } else
            {
                outputBox.Text = "0";
            }
        }

        private void evaluateAnswer(object sender, EventArgs e)
        {
            if (output != "" && secondOutput != "" && operation != "")
            {
                double firstNum = Convert.ToDouble(output);
                double secondNum = Convert.ToDouble(secondOutput);
                double result = 0;

                switch (operation)
                {
                    case "add":
                        result = firstNum + secondNum;
                        outputBox.Text = Convert.ToString(result);
                        break;
                    case "subtract":
                        result = firstNum - secondNum;
                        outputBox.Text = Convert.ToString(result);
                        break;
                    case "multiply":
                        result = firstNum * secondNum;
                        outputBox.Text = Convert.ToString(result);
                        break;
                    case "divide":
                        result = firstNum / secondNum;
                        outputBox.Text = Convert.ToString(result);
                        break;
                    default:
                        outputBox.Text = "Error";
                        break;
                }
                output = Convert.ToString(result);

                topOutput.Text = "";
                topOutput.Visible = false;

                firstInput = true;
                // output = "";
                secondOutput = "";
                operation = "";
            }
        }

    }
}
