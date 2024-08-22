using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCrudAnimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        animal a = new animal();

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                a.setNome(txt_nome.Text);
                a.setIdade(txt_idade.Text);
                a.setSexo(txt_sexo.Text);
                a.setEspecie(txt_especie.Text);
                a.setPeso(txt_peso.Text);
                a.setTamanho(txt_tamanho.Text);
                a.inserir();
            }
            finally
            {
                MessageBox.Show("Informações Gravadas com sucesso");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.Consultar();
            dataGridView1.Columns["nome_animal"].HeaderText = "Nome";
            dataGridView1.Columns["idade_animal"].HeaderText = "Idade";
            dataGridView1.Columns["sexo_animal"].HeaderText = "Sexo";
            dataGridView1.Columns["especie_animal"].HeaderText = "Espécie";
            dataGridView1.Columns["peso_animal"].HeaderText = "Peso";
            dataGridView1.Columns["tamanho_animal"].HeaderText = "Tamanho";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                a.setNome(txt_nome.Text);
                a.excluir();
                dataGridView1.DataSource = a.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações Excluídas com Sucesso");
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                a.setNome(txt_nome.Text);
                a.setIdade(txt_idade.Text);
                a.setSexo(txt_sexo.Text);
                a.setEspecie(txt_especie.Text);
                a.setPeso(txt_peso.Text);
                a.setTamanho(txt_tamanho.Text);
                a.alterar();
                dataGridView1.DataSource = a.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações Alteradas com sucesso");
            }
        }

        public void exibirregistro(int i)
        {
            txt_nome.Text = "" + dataGridView1[0, i].Value;
            txt_idade.Text = "" + dataGridView1[1, i].Value;
            txt_sexo.Text = "" + dataGridView1[2, i].Value;
            txt_especie.Text = "" + dataGridView1[3, i].Value;
            txt_peso.Text = "" + dataGridView1[4, i].Value;
            txt_tamanho.Text = "" + dataGridView1[5, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibirregistro(dataGridView1.CurrentRow.Index);
        }
    }
}
