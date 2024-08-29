using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace estruturaFender
{
    class conexao
    {

        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;

        public conexao()
        {
            inicializar();
        }

        public void inicializar()
        {
            servidor = "127.0.0.1";
            database = "crud_csharp";
            usuario = "root";
            senha = "";
            string conexaostring;
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE= " +
                database + ";" + "UID=" + usuario + ";" + "PASSWORD =" +
                senha + ";";
            conectar = new MySqlConnection(conexaostring);
        }

        public bool abrirconexao()
        {    //Try Catch é um tratamento de erro para códigos
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex) //Catch - Caso o try não execute 
            {                         //o catch entra em ação
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não Foi possivel conectar.");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário e senha invalidos!");
                        break;
                }
                return false;
            }
        }
        public bool fecharconexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
