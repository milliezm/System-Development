using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturaFender
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Fender Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = "adminfender@gmail.com";
            string senha = "fender123";

            if (txt_email.Text == email && txt_senha.Text == senha)
            {
                frm_principal formulario = new frm_principal();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail e senha Incorretos", "Fender Shop");
            }
        }
    }
}
