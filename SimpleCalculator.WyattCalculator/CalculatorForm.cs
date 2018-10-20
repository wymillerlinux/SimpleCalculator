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
    public partial class frm_mainWindow : Form
    {
        public frm_mainWindow()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            bool isValidated = Validate();
            if (isValidated)
            {
                int x = Convert.ToInt32(txtBtn_heightEntry.Text);
                int y = Convert.ToInt32(txtBtn_widthEntry.Text);
                int answer = x * y;
                if (radBtn_english.Checked == true)
                {
                    Form solutionForm = new SolutionForm(answer, "feet");
                    solutionForm.MaximizeBox = false;
                    solutionForm.MinimizeBox = false;
                    solutionForm.ShowDialog();
                    solutionForm.Dispose();
                }
                if (radBtn_metric.Checked == true)
                {
                    Form solutionForm = new SolutionForm(answer, "meters");
                    solutionForm.MaximizeBox = false;
                    solutionForm.MinimizeBox = false;
                    solutionForm.ShowDialog();
                    solutionForm.Dispose();
                }

            }

        }

        private bool Validate() {

            if (radBtn_metric.Checked == false && radBtn_english.Checked == false)
            {
                MessageBox.Show("Please select a unit of measure.");
                radBtn_english.Checked = true;
                return false;
            }

            if (txtBtn_heightEntry.Text == "")
            {
                MessageBox.Show("Please enter an integer in the height box.");
                return false;
            }

            if (txtBtn_widthEntry.Text == "")
            {
                MessageBox.Show("Please enter an integer in the width box.");
                return false;
            }

            return true;
        }

        private void radBtn_english_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_english.Checked == true)
            {
                lbl_width.Text = "Width (ft)";
                lbl_length.Text = "Length (ft)";
            }
        }

        private void radBtn_metric_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_metric.Checked == true)
            {
                lbl_width.Text = "Width (m)";
                lbl_length.Text = "Length (m)";
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            Form helpForm = new HelpForm();
            helpForm.MinimizeBox = false;
            helpForm.MaximizeBox = false;
            helpForm.ShowDialog();
            helpForm.Dispose();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
