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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 register = new Form3();
            register.Show();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 infMachines = new Form4();
            infMachines.Show();
        }

        private void registroDasMáquinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 registerMachine = new Form5();
            registerMachine.Show();
        }
    }
}
