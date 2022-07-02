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
            int dateSeed = dateTimePicker1.Value.Day + dateTimePicker1.Value.Month + dateTimePicker1.Value.Year ;

            Random random = new Random(dateSeed);
            luckyNum = random.Next(256);

            LuckyNumber luckyNumber = new LuckyNumber(luckyNum);
            luckyNumber.Show();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
