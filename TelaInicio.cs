using Controle_de_Contas_de_Energia.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Contas_de_Energia
{
    public partial class TelaInicio : Form
    {
        private AppData appData = AppData.GetInstance();
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();

            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.ShowDialog();
        }

        private void TelaInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            appData.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) { return; }

            bool success = appData.LogIn(textBox1.Text);

            if (!success ) {
                MessageBox.Show("Consumidor não cadastrado");
                return; 
            }

            TelaRelatorio telaRelatorio = new TelaRelatorio();
            telaRelatorio.ShowDialog();
        }
    }
}
