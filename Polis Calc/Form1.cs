using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc_Logic.Transformtopolis;

namespace Polis_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TransformToPolisView A = new TransformToPolisView(InputTxt.Text);
                A.Transform();
                OutputTxt.Text = A.ExitString;
                Result.Text = A.Calculate();
            }
        }
    }
}
