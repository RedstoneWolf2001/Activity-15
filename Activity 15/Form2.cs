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
    public partial class LuckyNumber : Form
    {
        public LuckyNumber(int inputNum)
        {
            InitializeComponent();
            ResultsLBL.Text = inputNum.ToString(); // inputs the lucky number 
        }
    }
}
