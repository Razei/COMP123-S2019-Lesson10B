using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson10B
{
    public partial class MainForm : Form
    {
        public StartForm parent { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ImperialUnitRadioButton.Checked
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackButton_Click(sender, e);            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.START_FORM].Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.END_FORM].Show();
            this.Hide();
        }
    }
}
