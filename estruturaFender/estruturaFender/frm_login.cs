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
            login l = new login();
            l.setEmail(txt_email.Text);
            l.setPassw(txt_senha.Text);
            l.consultar_login();

            int valor = l.consultar_login();

            if(valor == 1)
            {
                frm_principal formulario = new frm_principal();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e Senhas Invalidos", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
