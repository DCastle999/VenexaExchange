using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenexaExchangeForm
{
    public partial class Cadastro : Form
    {
        Broker b = new Broker();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btProx_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string cpf_cnpj = tbCp.Text;
            string localidade = tbLocalidade.Text;
            string associacao = tbAssociacao.Text;

            string value = "";
            bool isChecked = rbFisica.Checked;
            if (isChecked)
                value = rbFisica.Text;
            else
                value = rbJuridica.Text;

            if (value=="Pessoa física")
            {
                Fisica f1 = new Fisica(nome, cpf_cnpj, localidade, associacao);
            }
            else if (value == "Pessoa jurídica")
            {
                Juridica j1 = new Juridica(nome, cpf_cnpj, localidade, associacao);
            }


            b.ShowDialog();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
