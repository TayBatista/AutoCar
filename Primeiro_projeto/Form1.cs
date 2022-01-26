using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            if ((txtlogin.Text.Equals("") || txtsenha.Text.Equals("")) || (txtlogin.Text != ("teste") && txtsenha.Text != ("1234")))
            {
                MessageBox.Show("Login ou senha incorretos!");
            }
            else
            {
                this.Hide();
                Form2 abre = new Form2();
                abre.ShowDialog();                
            }
        }
    }
}
