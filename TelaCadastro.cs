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
    public partial class TelaCadastro : Form
    {
        private AppData appData = AppData.GetInstance();
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "CPF:";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = "CNPJ:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                return;
            }

            Pessoa pessoa;

            if (radioButton1.Checked) { 
                pessoa = new PessoaFisica(); 
            } else {
                pessoa = new PessoaJuridica();
            }
            pessoa.Cadastro = textBox1.Text;
            if (appData.Create(pessoa))
            {
                MessageBox.Show("Cadastro concluído");
            } 
            else
            {
                MessageBox.Show("Já cadastrado");
            }

        }
    }
}
