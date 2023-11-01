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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnRegisterM_Click(object sender, EventArgs e)
        {
            if (tbNameMachine.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'Nome' vazio!");
                tbNameMachine.Text = "";
                tbNameMachine.Focus();
                return;

            }
            else if (tbType.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'Tipo' vazio!");
                tbType.Text = "";
                tbType.Focus();
                return;

            }
            else if (tbStatus.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'Status' vazio!");
                tbStatus.Text = "";
                tbStatus.Focus();
                return;

            }
            else if (tbColor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'Cor' vazio!");
                tbColor.Text = "";
                tbColor.Focus();
                return;

            } else if(tbGuarantee.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Erro: Campo 'Garantia' vazio!");
                tbGuarantee.Text = "";
                tbGuarantee.Focus();
                return;
            }

            MySqlConnection MeuSql = new MySqlConnection("server=localhost; database=gym; uid=root; pwd=etec");
            MeuSql.Open();
            MySqlCommand inserirE = new MySqlCommand("INSERT INTO Equipamento(nomeMaquina,tipo,statusMaquina,cor,garantia) values('" + tbNameMachine.Text + "', '" + tbType.Text + "', '" + tbStatus.Text + "', '" + tbColor.Text + "', '" + tbGuarantee.Text + "');", MeuSql);
            inserirE.ExecuteNonQuery();

            MessageBox.Show("Registro feito com sucesso!");
            tbNameMachine.Text = "";
            tbType.Text = "";
            tbStatus.Text = "";
            tbColor.Text = "";
            tbGuarantee.Text = "";
            tbNameMachine.Focus();
        }
    }
}
