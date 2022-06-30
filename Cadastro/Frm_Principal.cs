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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = Banco.MostraTodos();
        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            Frm_Pessoas frmPs = new Frm_Pessoas(this);
            frmPs.txtNome.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            frmPs.txtTelefone.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            frmPs.txtId.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            frmPs.btnSalvar.Hide();
            frmPs.btn_Relatorio.Hide();
            frmPs.txtId.Hide();
            frmPs.ShowDialog();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            Frm_Pessoas frm = new Frm_Pessoas(this);
            frm.btnExcluir.Hide();
            frm.btnAlterar.Hide();
            frm.ShowDialog();
        }

    }
}
