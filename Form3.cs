using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace gymSistem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(tbName.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'Nome' vazio!");
                tbName.Text = "";
                tbName.Focus();
                return;

            } else if(tbDate.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'Data' vazio!");
                tbDate.Text = "";
                tbDate.Focus();
                return;

            } else if(tbCPF.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'CPF' vazio!");
                tbCPF.Text = "";
                tbCPF.Focus();
                return;

            } else if(tbPassword.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'Senha' vazio!");
                tbPassword.Text = "";
                tbPassword.Focus();
                return;

            }

            try
            {
                DateTime dataNascimento;
                dataNascimento = DateTime.Parse(tbDate.Text); // Põe o valor inserido do campo tbDate dentro da var dataNascimento

                DateTime dataHoje;
                dataHoje = System.DateTime.Now; // Põe a quantidade de dias desse ano, na var dataHoje

                int idade = dataHoje.Year - dataNascimento.Year;

                if (dataNascimento.DayOfYear > dataHoje.DayOfYear)
                {
                    idade -= 1;
                }

                if (idade < 18)
                {
                    MessageBox.Show("Error: Idade mínima não alcançada" + " " + idade.ToString());
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Data inválida.");
                tbDate.Focus();
                return;
            }

            try
            {
                int cpf = int.Parse(tbCPF.Text);

            } catch
            {
                MessageBox.Show("Error: CPF inválido.");
                tbCPF.Focus();
                return;
            }
            

            MySqlConnection MeuSql = new MySqlConnection("server=localhost; database=gym; uid=root; pwd=etec");
            MeuSql.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO Usuario(nome,dataNasc,cpf,senha) values('" + tbName.Text + "', '" + tbDate.Text + "', '" + tbCPF.Text + "', '" + tbPassword.Text + "');", MeuSql);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro feito com sucesso!");
            tbName.Text = "";
            tbDate.Text = "";
            tbCPF.Text = "";
            tbPassword.Text = "";
            tbName.Focus();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
        }
    }
}
