using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Frm_Pessoas : Form
    {
        public Frm_Pessoas(Frm_Principal principal)
        {
            InitializeComponent();
            txtId.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtTelefone.Text != "")
            {
                Pessoa pe = new Pessoa();
                pe.Nome = txtNome.Text;
                pe.Telefone = txtTelefone.Text;
                Banco.NovaPessoa(pe);
                txtNome.Clear();
                txtTelefone.Clear();
            }
            else
            {
                MessageBox.Show("Preencha os campos");
                txtNome.Focus();

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Pessoa pe = new Pessoa();
                pe.Id = int.Parse(txtId.Text);
                Banco.Delete(pe);
                txtNome.Clear();
                txtTelefone.Clear();
            }
            else
            {
                MessageBox.Show("Exclusão não efetuada ");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtTelefone.Text != "")
            {
                Pessoa pe = new Pessoa();
                pe.Id = int.Parse(txtId.Text);
                pe.Nome = txtNome.Text;
                pe.Telefone = txtTelefone.Text;
                Banco.Atualizar(pe);
                txtNome.Clear();
                txtTelefone.Clear();

            }
            else
            {
                MessageBox.Show("Não foi possivel alterar");
            }
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            Frm_Relatorio frm_Relatorio = new Frm_Relatorio();
            frm_Relatorio.ShowDialog();
        }
    }
}
