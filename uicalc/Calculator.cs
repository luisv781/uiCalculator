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
            string oper = "";
            topOutput.Visible = true;
            switch (operButton.Text)
            {
                case "+":
                    topOutput.Text = output + " + ";
                    firstInput = false;
                    operation = "add";
                    updateOutput(secondOutput);
                    break;
            }
        }

        private void clearOutput(object sender, EventArgs e)
        {
            output = "";
            updateOutput(output);
        }

        private void eraseOutput(object sender, EventArgs e)
        {
            output = output.Remove(output.Length - 1);
            updateOutput(output);
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
            switch (operation)
            {
                case "add":
                    double firstNum = Convert.ToDouble(output);
                    double secondNum = Convert.ToDouble(secondOutput);
                    double result = firstNum + secondNum;
                    outputBox.Text = Convert.ToString(result);
                    output = Convert.ToString(result);
                    break;
                case "subtract":
                    break;
                case "multiply":
                    break;
                case "divide":
                    break;
                default:
                    outputBox.Text = "Error";
                    break;
            }

            topOutput.Text = "";
            topOutput.Visible = false;

            firstInput = true;
            // output = "";
            secondOutput = "";
            operation = "";
        }

    }
}
