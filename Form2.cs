using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymSistem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "adm" && tbPassword.Text == "91382535")
            {
                MessageBox.Show("Bem vindo!");
                Form4 infMachines = new Form4();
                infMachines.Show();
            } else
            {
                MessageBox.Show("Erro: Usuário ou senha incorretos");
            }
        }

        private void btnNoCount_Click(object sender, EventArgs e)
        {

            Form3 register = new Form3();
            register.Show();
        }
    }
}
