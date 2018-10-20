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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            lbl_directions.Text =
                "1) Choose the unit of measure." + Environment.NewLine +
                "2) Enter in the width and length of the fence." + Environment.NewLine +
                "3) Click the Calculate button." + Environment.NewLine +
                "4) A window will open showing the calculation.";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
