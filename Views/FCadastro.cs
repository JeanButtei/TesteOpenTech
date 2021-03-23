using CRUD.Controller;
using CRUD.DB;
using CRUD.Model;
using System;
using System.Windows.Forms;

namespace CRUD.Views
{
    public partial class FCadastro : Form
    {
        private EmpresaController controller = new EmpresaController();
        public FCadastro()
        {
            InitializeComponent();
        }

        private void limparFormulario()
        {
            foreach (var comp in this.Controls)
            {
                if (comp is TextBox)
                {
                    ((TextBox)comp).Text = String.Empty;
                }
            }
            TxtId.Focus();
            BtnGravar.Text = "Inserir";
            BtnExcluir.Enabled = false;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (TxtId.TextLength == 0)
            {
                controller.add(TxtNome.Text, TxtSite.Text, TxtQtdFunc.Text);
                limparFormulario();
            }
            else
            {
                controller.update(TxtId.Text, TxtNome.Text, TxtSite.Text, TxtQtdFunc.Text);
                limparFormulario();
            }
        }

        private void FCadastro_Load(object sender, EventArgs e)
        {
            controller.iniciarConexao();
            limparFormulario();
        }

        private void FCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.desconectar();
        }

        private void TxtId_Leave(object sender, EventArgs e)
        {
            BtnGravar.Text = (TxtId.TextLength > 0) ? "Alterar" : "Incluir";
            BtnExcluir.Enabled = TxtId.TextLength > 0;

            if (TxtId.TextLength > 0)
            {
                Empresa empresa = controller.getEmpresaById(TxtId.Text);
                if (empresa != null)
                {
                    TxtNome.Text = empresa.Nome;
                    TxtSite.Text = empresa.Site;
                    TxtQtdFunc.Text = empresa.QuantidadeFuncionarios.ToString();
                }
                else
                {                    
                    limparFormulario();
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtId.TextLength > 0)
            {
                controller.delete(TxtId.Text);
                limparFormulario();
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 08) && (e.KeyChar != 127))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void TxtQtdFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 08) && (e.KeyChar != 127))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
