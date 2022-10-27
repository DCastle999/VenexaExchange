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
    public partial class PaginaInicial : Form
    {
        Cadastro c = new Cadastro();
        Broker b = new Broker();
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            c.ShowDialog();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAtivos_Click(object sender, EventArgs e)
        {
            b.ShowDialog();
        }
    }
}
