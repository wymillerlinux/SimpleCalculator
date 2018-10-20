using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator.WyattCalculator
{
    public partial class SolutionForm : Form
    {
        public SolutionForm(int answer, string unit)
        {
            InitializeComponent();
            lbl_answer.Text = answer.ToString();
            lbl_unitanswer.Text = unit;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
