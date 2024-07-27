using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FühreOperationDurch(Operation.Addieren);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            FühreOperationDurch(Operation.Subtrahieren);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            FühreOperationDurch(Operation.Multiplikation);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            FühreOperationDurch(Operation.Division);
        }

        private void FühreOperationDurch(Operation operation)
        {
            if (double.TryParse(zahl1TextBox.Text, out double zahl1) &&
                double.TryParse(zahl2TextBox.Text, out double zahl2))
            {
                double ergebnis = 0;
                switch (operation)
                {
                    case Operation.Addieren:
                        ergebnis = zahl1 + zahl2;
                        break;
                    case Operation.Subtrahieren:
                        ergebnis = zahl1 - zahl2;
                        break;
                    case Operation.Multiplikation:
                        ergebnis = zahl1 * zahl2;
                        break;
                    case Operation.Division:
                        if (zahl2 != 0)
                        {
                            ergebnis = zahl1 / zahl2;
                        }
                        else
                        {
                            MessageBox.Show("Fehler bei der Division: Der Divisor darf nicht null sein.");
                            return;
                        }
                        break;
                }
                ergebnisTextBox.Text = ergebnis.ToString();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie gültige Zahlen ein.");
            }
        }

        private enum Operation
        {
            Addieren,
            Subtrahieren,
            Multiplikation,
            Division
        }
    }
}
