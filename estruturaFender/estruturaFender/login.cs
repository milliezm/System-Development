using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace estruturaFender
{
    class login : conexao
    {

        private string email;
        private string passw;

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setPassw(string passw)
        {
            this.passw = passw;
        }

        public string getPassw()
        {
            return this.passw;
        }

        public int consultar_login()
        {
            this.abrirconexao();

            string mSQL = "Select count(email) from fender where email = '" + getEmail() + "' and senha = '" + getPassw() + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 resultado_query = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();

            int valor_login;
            valor_login = resultado_query;
            this.fecharconexao();
            return valor_login;
        }
    }
}
