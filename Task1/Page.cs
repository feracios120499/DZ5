using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Page : UserControl
    {
        public EventHandler eventDelete;
        public EventHandler eventActiv;
        public Page()
        {
            InitializeComponent();
        }
        public Page(string text)
        {
            InitializeComponent();
            labelTitle.Text = text;
        }

        private void Page_Load(object sender, EventArgs e)
        {

        }
        public string GetName()
        {
            return labelTitle.Text;
        }
        public void Rename(string newName)
        {
            labelTitle.Text = newName;
            SetActiv();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            eventDelete?.Invoke(this,new EventArgs());
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            SetActiv();
        }
        public void SetActiv()
        {
            Panel parent = this.Parent as Panel;
            foreach (Page item in parent.Controls)
            {
                if (item == this)
                {
                    item.Activ(true);
                    eventActiv?.Invoke(this, new EventArgs());
                }
                else
                {
                    item.Activ(false);
                }
            }
        }
        public void Activ(bool flag)
        {
            if (flag)
            {
                top.BackColor = Color.Orange;
                this.BackColor = Color.DarkGray;
            }
            else
            {
                top.BackColor = Color.Transparent;
                this.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
