using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace l2_task2_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Integer0Button.Click += IntegerButton_Click;
            Integer1Button.Click += IntegerButton_Click;
            Integer2Button.Click += IntegerButton_Click;
            Integer3Button.Click += IntegerButton_Click;
            Integer4Button.Click += IntegerButton_Click;
            Integer5Button.Click += IntegerButton_Click;
            Integer6Button.Click += IntegerButton_Click;
            Integer7Button.Click += IntegerButton_Click;
            Integer8Button.Click += IntegerButton_Click;
            Integer9Button.Click += IntegerButton_Click;

            ResetButton.Click += ResetButton_Click;

            PlusButton.Click += OperatorButton_Click;
            MinusButton.Click += OperatorButton_Click;
            MultiplyButton.Click += OperatorButton_Click;
            DivideButton.Click += OperatorButton_Click;

            EqualsButton.Click += EqualsButton_Click;
        }

        private void IntegerButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendText(button.Text);
        }

        private void AppendText(string text)
        {
            textBox1.Text += text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendText(" " + button.Text + " ");
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {

            var expression = textBox1.Text;
            var result = Parse(expression);
            textBox1.Text = result.ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private double Parse(string expression)
        {
            return CSharpScript.EvaluateAsync<double>(expression).Result;
        }
    }
}