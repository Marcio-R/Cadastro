
namespace Cadastro
{
    partial class Frm_Relatorio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Teste_cadastroDataSet = new Cadastro.Teste_cadastroDataSet();
            this.PessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PessoasTableAdapter = new Cadastro.Teste_cadastroDataSetTableAdapters.PessoasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Teste_cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PessoasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsPessoa";
            reportDataSource1.Value = this.PessoasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cadastro.RelatorioPessoas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Teste_cadastroDataSet
            // 
            this.Teste_cadastroDataSet.DataSetName = "Teste_cadastroDataSet";
            this.Teste_cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PessoasBindingSource
            // 
            this.PessoasBindingSource.DataMember = "Pessoas";
            this.PessoasBindingSource.DataSource = this.Teste_cadastroDataSet;
            // 
            // PessoasTableAdapter
            // 
            this.PessoasTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Relatorio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Teste_cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PessoasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PessoasBindingSource;
        private Teste_cadastroDataSet Teste_cadastroDataSet;
        private Teste_cadastroDataSetTableAdapters.PessoasTableAdapter PessoasTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

