using System.Reflection.Emit;

namespace TP_MOD_03
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private bool isPlusReady = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_onClick(object sender, EventArgs e) { input("1"); }
        private void button2_onClick(object sender, EventArgs e) { input("2"); }
        private void button3_onClick(object sender, EventArgs e) { input("3"); }
        private void button4_onClick(object sender, EventArgs e) { input("4"); }
        private void button5_onClick(object sender, EventArgs e) { input("5"); }
        private void button6_onClick(object sender, EventArgs e) { input("6"); }
        private void button7_onClick(object sender, EventArgs e) { input("7"); }
        private void button8_onClick(object sender, EventArgs e) { input("8"); }
        private void button9_onClick(object sender, EventArgs e) { input("9"); }
        private void button0_onClick(object sender, EventArgs e) { input("0"); }

        private void buttonPlus_onClick(object sender, EventArgs e)
        {
            if (!isPlusReady && label.Text != "Label Output")
            {
                double.TryParse(label.Text, out num1);
                label.Text += " + ";
                isPlusReady = true;
            }
        }

        private void buttonResult_onClick(object sender, EventArgs e)
        {
            if (isPlusReady)
            {
                double ress = num1 + num2;
                label.Text = ress.ToString();

                num1 = 0;
                num2 = 0;
                isPlusReady = false;
            }
        }

        private void input(string n)
        {
            if (isPlusReady)
            {
                if (label.Text.EndsWith(" + "))
                    label.Text += n;
                else
                    label.Text += n;

                string[] parts = label.Text.Split(new string[] { " + " }, StringSplitOptions.None);
                if (parts.Length == 2)
                    double.TryParse(parts[1].Trim(), out num2);
            }
            else
            {
                if (label.Text == "Label Output" || label.Text == "0")
                    label.Text = n;
                else
                    label.Text += n;

                double.TryParse(label.Text, out num1);
            }
        }
    }
}