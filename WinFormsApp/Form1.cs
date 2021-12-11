using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClassLibrary1.Class1 _interface = new ClassLibrary1.Class1();
            string foo = _interface.foo();

            TextBox1.Text = foo;

            var popup = new Popup(foo);
            popup.Show(this);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
