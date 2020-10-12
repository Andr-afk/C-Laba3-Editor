using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EditorDevelopment;


namespace DemoEditor
{
    public partial class MainForm : Form
    {

        Editor edit = new Editor();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnableButton();
            
            ValueNumber.Text = edit.Number;
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

        private void btnB_Click(object sender, EventArgs e)
        {
            Button b = (sender as Button);
            byte pressed_button = Convert.ToByte(b.TabIndex);
            ValueNumber.Text = edit.DoEdit(pressed_button);
        }
    }
}
