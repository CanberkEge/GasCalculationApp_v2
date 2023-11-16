using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasCalculationApp_v2
{
    public partial class GasCalculatorForm : Form
    {
        public GasCalculatorForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void InitializeTextBoxes()
        {
            SetFaintText(distanceTextBox, "Mesafeyi girin (km)");
            SetFaintText(priceTextBox, "Yakıt litre fiyatını girin (tl)");
            SetFaintText(averageGasSpendTextBox, "Ortalama tükeitimi girin (litre/100km)");

            // Add event handlers to manage the faint text behavior
            distanceTextBox.Enter += TextBox_Enter;
            distanceTextBox.Leave += TextBox_Leave;

            priceTextBox.Enter += TextBox_Enter;
            priceTextBox.Leave += TextBox_Leave;

            averageGasSpendTextBox.Enter += TextBox_Enter;
            averageGasSpendTextBox.Leave += TextBox_Leave;
        }

        private void SetFaintText(TextBox textBox, string faintText)
        {
            textBox.ForeColor = SystemColors.GrayText;
            textBox.Text = faintText;
            textBox.Tag = faintText; // Set Tag property to store the original faint text
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.ForeColor == SystemColors.GrayText)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetFaintText(textBox, textBox.Tag.ToString());
            }
        }

        

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            double distance, price, averageGasSpend, totalGasSpend, totalPrice;

            if (!double.TryParse(distanceTextBox.Text, out distance) ||
                !double.TryParse(priceTextBox.Text, out price) ||
                !double.TryParse(averageGasSpendTextBox.Text, out averageGasSpend))
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
                return;
            }

            totalGasSpend = ((averageGasSpend * distance) / 100);
            totalPrice = (totalGasSpend * price);

            resultLabel.Text = $"Toplam harcanan yakıt = {totalGasSpend:F2} litre\nToplam tutar = {totalPrice:F2} tl";

            double times;
            string resume;
            int days;

            resume = MessageBox.Show("Kaç kez olduğunu belirtmek için devam mı?", "Devam?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? "devam" : "sonlanmıştır";

            if (resume == "devam")
            {
                days = (int)daysNumericUpDown.Value;
                times = (totalPrice * days);
                resultLabel.Text += $"\n{days} günlük tutar = {times:F2} tl";
            }
            else
            {
                resultLabel.Text += "\nProgram sonlanmıştır.";
            }
        }
    }
}
