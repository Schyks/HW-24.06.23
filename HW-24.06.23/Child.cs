using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_24._06._23
{
    public partial class Child : Form
    {
        Parent parent;
        public Child(Parent parent)
        {
            InitializeComponent();
            this.parent = parent;
            textBox1.TextChanged += Child_TextChanged;
        }
        public void SetText(string text)
        {
            textBox1.Text = text; 
        }
        private void Child_TextChanged(object sender, EventArgs e)
        {
            parent.SetText(textBox1.Text);
        }
    }
}
