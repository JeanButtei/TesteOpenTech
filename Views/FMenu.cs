using CRUD.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCadastro_Click(object sender, EventArgs e)
        {
            FCadastro formCadastro = new FCadastro();
            formCadastro.Show();
        }
    }
}
