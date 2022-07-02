using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class LuckyNumberCalc : Form
    {

        public LuckyNumberCalc()
        {
            InitializeComponent();
        }

        private void CalcBTN_Click(object sender, EventArgs e)
        {
            int luckyNum;
            int dateSeed = dateTimePicker1.Value.Day + dateTimePicker1.Value.Month + dateTimePicker1.Value.Year; // gets the seed based off of the selected date

            Random random = new Random(dateSeed);
            luckyNum = random.Next(256);// generates random number

            LuckyNumber luckyNumber = new LuckyNumber(luckyNum); //passes and opens the lucky number into the new form
            luckyNumber.Show();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
