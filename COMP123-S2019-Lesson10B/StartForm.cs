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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("NextButton_Click");

            //referencing the program in the namespace to get the dictionary
            Program.Forms[FormName.MAIN_FORM].Show();

            this.Hide();
        }
    }
}
