namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".") 
            { 
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }
            else

            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue! = 0)
            {
                buttonEQUALS_Click.PerfromClick()
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else 
            {

            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }
         
        private void buttonCE_click(Object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void buttonEQUALS_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
             resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = "";
        }
    }
}