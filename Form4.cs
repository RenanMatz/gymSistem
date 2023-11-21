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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlConnection consulta = new MySqlConnection("server=localhost; database=gym; uid=root; pwd=VTK%646W2391382535");
            consulta.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select idMaquina as id, nomeMaquina as Nome, tipo, statusMaquina as Status1, cor as Cor, garantia as Garantia from Equipamento", consulta);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvEquipamento.DataSource = dt;
        }

        private void CarregarDadosBanco()
        {
            MySqlConnection consulta = new MySqlConnection("server=localhost; database=gym; uid=root; pwd=etec");
            consulta.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select idMaquina as id, nomeMaquina as Nome, tipo, statusMaquina as Status1, cor as Cor, garantia as Garantia from Equipamento", consulta);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvEquipamento.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection MeuSql = new MySqlConnection("server=localhost; database=gym; uid=root; pwd=etec");
            MeuSql.Open();
            MySqlCommand comando = new MySqlCommand("update Equipamento set idMaquina=" + tbId.Text + ", nomeMaquina='" + tbName.Text + "', tipo='" + tbType.Text + "', statusMaquina='" + tbStatus.Text + "', cor='" + tbColor.Text + "', garantia='" + tbGuarantee.Text + "' where idMaquina=" + tbId.Text, MeuSql);
            comando.ExecuteNonQuery();
            MessageBox.Show("Dado alterados com sucesso!");
            tbId.Text = "";
            tbName.Text = "";
            tbType.Text = "";
            tbStatus.Text = "";
            tbColor.Text = "";
            tbGuarantee.Text = "";
            painel.Enabled = false;
            CarregarDadosBanco();
        }

        private void dgvEquipamento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbId.Text = dgvEquipamento.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbName.Text = dgvEquipamento.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbType.Text = dgvEquipamento.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbStatus.Text = dgvEquipamento.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbColor.Text = dgvEquipamento.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbGuarantee.Text = dgvEquipamento.Rows[e.RowIndex].Cells[5].Value.ToString();
            painel.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult certeza = MessageBox.Show("Realmente deseja excluir?", "Maquinário", MessageBoxButtons.YesNo);
            if(certeza == DialogResult.Yes)
            {
                MySqlConnection MeuSql = new MySqlConnection("server=localhost; database=gym; uid=root; pwd=etec");
                MeuSql.Open();
                MySqlCommand comando = new MySqlCommand("delete from Equipamento where idMAquina =" + tbId.Text + ";", MeuSql);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluído com sucesso!");
                tbId.Text = "";
                tbName.Text = "";
                tbType.Text = "";
                tbStatus.Text = "";
                tbColor.Text = "";
                tbGuarantee.Text = "";
                painel.Enabled = false;
                CarregarDadosBanco();
            }
        }
    }
}
