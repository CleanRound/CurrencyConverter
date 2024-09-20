using System;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        // Conversion rates (example rates)
        private const double USD_TO_UAH = 41.35;
        private const double EUR_TO_UAH = 46.21;
        private const double UAH_TO_USD = 1 / USD_TO_UAH;
        private const double UAH_TO_EUR = 1 / EUR_TO_UAH;
        private const double EUR_TO_USD = EUR_TO_UAH / USD_TO_UAH;
        private const double USD_TO_EUR = USD_TO_UAH / EUR_TO_UAH;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonConvert.Enabled = false; // Disable the Convert button initially
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control keys, and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            // Activate the button if all fields are valid
            buttonConvert.Enabled = textBoxAmount.TextLength > 0 && comboBoxFrom.SelectedIndex >= 0 && comboBoxTo.SelectedIndex >= 0;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Activate the button if all fields are valid
            buttonConvert.Enabled = textBoxAmount.TextLength > 0 && comboBoxFrom.SelectedIndex >= 0 && comboBoxTo.SelectedIndex >= 0;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(textBoxAmount.Text, out amount))
            {
                double result = ConvertCurrency(amount, comboBoxFrom.SelectedItem.ToString(), comboBoxTo.SelectedItem.ToString());
                textBoxResult.Text = result.ToString("F2");
            }
        }

        private double ConvertCurrency(double amount, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == toCurrency)
                return amount;

            switch (fromCurrency + "_" + toCurrency)
            {
                case "USD_UAH": return amount * USD_TO_UAH;
                case "EUR_UAH": return amount * EUR_TO_UAH;
                case "UAH_USD": return amount * UAH_TO_USD;
                case "UAH_EUR": return amount * UAH_TO_EUR;
                case "EUR_USD": return amount * EUR_TO_USD;
                case "USD_EUR": return amount * USD_TO_EUR;
                default: return 0;
            }
        }
    }
}
