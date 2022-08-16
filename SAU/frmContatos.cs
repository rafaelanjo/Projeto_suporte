using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAU
{
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtCodigo.Clear();
            txtNumeroEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            

            //posicionar o cursor 
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Rotina para sair do form.
            //Enciar mensagem

            MessageBox.Show("Deseja realmente sair?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}
