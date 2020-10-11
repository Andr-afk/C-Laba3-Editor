using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void EnableButton()
        {
            foreach (Control value in Controls)
            {
                if (value is Button && Convert.ToString(value.Tag) == "number")
                {
                    if (value.TabIndex >= UD_baseValue.Value) value.Enabled = false;
                    else value.Enabled = true;
                }
            }
        }

        private void UD_baseValue_ValueChanged(object sender, EventArgs e)
        {
            EnableButton();
            
        }


    }
}
