using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastebin
{
    public partial class CodeForm : Form
    {
        TextBox box;

        public CodeForm()
        {
            InitializeComponent();
        }

        public CodeForm(TextBox t)
        {
            InitializeComponent();

            textBoxCode.Text = t.Text;

            box = t;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(box != null)
            {
                box.Text = textBoxCode.Text;
            }

            Close();
        }
    }
}
