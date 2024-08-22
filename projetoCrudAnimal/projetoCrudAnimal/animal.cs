﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace projetoCrudAnimal
{
    class animal : conexao
    {
        private string nome;
        private string idade;
        private string sexo;
        private string especie;
        private string peso;
        private string tamanho;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setIdade(string idade)
        {
            this.idade = idade;
        }

        public string getIdade()
        {
            return this.idade;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public string getSexo()
        {
            return this.sexo;
        }

        public void setEspecie(string especie)
        {
            this.especie = especie;
        }

        public string getEspecie()
        {
            return this.especie;
        }

        public void setPeso(string peso)
        {
            this.peso = peso;
        }

        public string getPeso()
        {
            return this.peso;
        }

        public void setTamanho(string tamanho)
        {
            this.tamanho = tamanho;
        }

        public string getTamanho()
        {
            return this.tamanho;
        }

        public void inserir()
        {
            string query = "insert into animal(nome_animal,idade_animal,sexo_animal,especie_animal,peso_animal,tamanho_animal) Values('"
                + getNome() + "' , '" +
                getIdade() + " ' , ' " +
                getSexo() + " ' , ' " +
                getEspecie() + " ' , ' " +
                getPeso() + " ' , ' " +
                getTamanho() + "')";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir()
        {
            string query = "delete from animal where nome_animal = '" + getNome() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "select * from animal";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar()
        {
            string query = "update animal set nome_animal = '" + getNome() +
                "', idade_animal = '" + getIdade() +
                "', sexo_animal = '" + getSexo() + 
                "', especie_animal = '" + getEspecie() +
                "', peso_animal = '" + getPeso() +
                "', tamanho_animal = '" + getTamanho() +
                "' where nome_animal = '" + getNome() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
