using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FindAndReplace : Form
    {
        Form1 form;
        int count=0;
        public FindAndReplace()
        {
            InitializeComponent();
        }
        public FindAndReplace(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.TextLength != 0)
            {
                form.SearchText(textBoxSearch.Text, ref count);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            count = 0;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (textBoxOld.TextLength != 0 && textBoxNew.TextLength != 0)
            {
                form.ReplaceText(textBoxOld.Text, textBoxNew.Text);
            }
        }
    }
}
