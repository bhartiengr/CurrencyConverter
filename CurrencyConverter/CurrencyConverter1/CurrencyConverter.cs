using System.IO;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter1
{
    public partial class CurrencyConverter : Form
    {
        public string IsNumeric { get; private set; }

        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CurrencyConverter_Load(object sender, EventArgs e) 
        {
            cmboxFrom.SelectedIndex = 0;
            cmboxTo.SelectedIndex = 0;
           
        }

        public void btConvert_Click(object sender, EventArgs e)
        {
            double result ;
            if (string.IsNullOrEmpty(txtboxCurrencyAmount.Text))
            {
                MessageBox.Show("Enter Currency");
                new Exception("Currency cannot be empty");

            }
            else if (double.Parse(txtboxCurrencyAmount.Text) > 99999999999999999)
            {
                MessageBox.Show("Enter a valid Currency");
                new Exception("Currency too big to be evaluated");
              
            }
            else
            {
                double currency = double.Parse(txtboxCurrencyAmount.Text);
                // double currencytwodec = Math.Round((double)currency, 2);

                if (cmboxFrom.SelectedItem == cmboxTo.SelectedItem)
                {
                    MessageBox.Show("Enter Different Convertion Currencies");

                }
                else if (cmboxFrom.SelectedItem == "USD" && cmboxTo.SelectedItem == "POUND")
                {

                    result = currency / 1.3066;
                    double resulttwodecimal = Math.Round((double)result, 2);
                    txtboxResult.Text = resulttwodecimal.ToString() + " " + cmboxTo.SelectedItem;
                }
                else if (cmboxFrom.SelectedItem == "USD" && cmboxTo.SelectedItem == "RUPPEE")
                {
                    result = currency * 69.02;
                    double resulttwodecimal = Math.Round((double)result, 2);
                    txtboxResult.Text = resulttwodecimal.ToString() + " " + cmboxTo.SelectedItem;
                }
                else if (cmboxFrom.SelectedItem == "POUND" && cmboxTo.SelectedItem == "USD")
                {
                    // Optional bonus problem statement
                    if(currency<1000)
                    {
                        MessageBox.Show("Levy fees of fixed 25 pounds Applied");
                    }
                    else
                    {
                        MessageBox.Show("Levy fees of 1% Applied");
                    }
                    result = (currency < 1000) ? ((currency + 25) / 1.3066) : ((currency + (currency / 100)) / 1.3066);
                    double resulttwodecimal = Math.Round((double)result, 2);
                    txtboxResult.Text = resulttwodecimal.ToString() + " " + cmboxTo.SelectedItem;

                }
                else if (cmboxFrom.SelectedItem == "POUND" && cmboxTo.SelectedItem == "RUPPEE")
                {
                    result = currency * 85.02;
                    double resulttwodecimal = Math.Round((double)result, 2);
                    txtboxResult.Text = resulttwodecimal.ToString() + " " + cmboxTo.SelectedItem;
                }
                else if (cmboxFrom.SelectedItem == "RUPPEE" && cmboxTo.SelectedItem == "USD")
                {
                    result = currency / 69.02;
                    double resulttwodecimal = Math.Round((double)result, 2);
                    txtboxResult.Text = resulttwodecimal.ToString() + " " + cmboxTo.SelectedItem;
                }
                else if (cmboxFrom.SelectedItem == "RUPPEE" && cmboxTo.SelectedItem == "POUND")
                {
                    result = currency / 85.02;
                    double resulttwodecimal = Math.Round((double)result, 2);
                    txtboxResult.Text = resulttwodecimal.ToString() + " " + cmboxTo.SelectedItem;
                }
            }

        }

        public void txtboxCurrencyAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
           // btConvert.Enabled = true;
            char ch = e.KeyChar;

            if(ch ==46 && txtboxCurrencyAmount.Text.IndexOf(".")!= -1)
            {
                e.Handled = true;
                return;
            }
            if(!Char.IsDigit(ch) && ch !=8 && ch!=46)
            {
                e.Handled = true;
            }
        }

        public void txtboxCurrencyAmount_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }

    
}
