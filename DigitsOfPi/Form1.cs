using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitsOfPi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowProgress(string pi, int totalDigits, int digitsSoFar)
        {
            piProgressBar.Text = pi;
            piProgressBar.Maximum = totalDigits;
            piProgressBar.Value = digitsSoFar;
        }

        async Task CalcPi(int digits)
        {   
            StringBuilder pi = new StringBuilder("3", digits + 2);
            // Show progress
            ShowProgress(pi.ToString(), digits, 0);
            if (digits > 0)
            {
                pi.Append(".");
                for (int i = 0; i < digits; i += 9)
                {
                    int nineDigits = await Task.Run(() => NineDigitsOfPi.StartingAt(i + 1));
                    int digitCount = Math.Min(digits - i, 9);
                    string ds = string.Format("{0:D9}", nineDigits);
                    pi.Append(ds.Substring(0, digitCount));
                    // Show progress
                    ShowProgress(pi.ToString(), digits, i + digitCount);
                    piTextBox.Text = pi.ToString();

                    // autoscroll
                    piTextBox.Select(i, 1);
                    piTextBox.ScrollToCaret();
                }
            }
        }

        private async void calculatePiBtn_Click(object sender, EventArgs e)
        {
            await CalcPi(Convert.ToInt32(numbericUpDnDigitsOfPi.Value));
            MessageBox.Show("Done");
        }
    }
}
