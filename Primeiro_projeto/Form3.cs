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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool campoValido = ValidarCampos();
            if (campoValido)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");                
            }
        }

            private bool ValidarCampos()
            {
                // Validando 
                if (txtnome.Text.Equals(""))
                {
                    MessageBox.Show("O campo 'Nome Veículo' é  obrigatório!");
                    return false;
                }

                else if (txtplaca.Text.Equals(""))
                {
                    MessageBox.Show("O campo 'Placa' é  obrigatório!");
                    return false;
                }

                else if (txtrenavan.Text.Equals(""))
                {
                    MessageBox.Show("O campo 'Renavan' é  obrigatório!");
                    return false;
                }

                else if (txtcor.Text.Equals(""))
                {
                    MessageBox.Show("O campo 'Cor Veículo' é  obrigatório!");
                    return false;
                }

                else if (cbomarca.SelectedIndex.Equals(false))
                {
                    MessageBox.Show("O campo 'Marca' é  obrigatório!");
                    return false;
                }

                else if (cboportas.SelectedIndex.Equals(false))
                {
                    MessageBox.Show("O campo 'Nº Portas' é  obrigatório!");
                    return false;
                }

                else if (cbocambio.SelectedIndex.Equals(false))
                {
                    MessageBox.Show("O campo 'Cambio' é  obrigatório!");
                    return false;
                }    
              
                else if (pictureBox1.Image.Equals(null))
                {
                    MessageBox.Show("O campo 'Carregar Foto' é  obrigatório!");
                    return false;
                }

                return true;
            }
       

        private void button2_Click(object sender, EventArgs e)
        {
            abrefoto.Title = "Selecione a foto";
            abrefoto.Filter = "JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp";
            abrefoto.ShowDialog();

            pictureBox1.Image = Image.FromFile(abrefoto.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 abre = new Form1();
            abre.ShowDialog();
        }
    }
}
