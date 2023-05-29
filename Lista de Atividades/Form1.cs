using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Atividades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tx_resultado.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = tx_cpf.Text;
            int idade = Convert.ToInt32(tx_idade.Text);
            double altura = Convert.ToDouble(tx_altura.Text);
            double peso = Convert.ToDouble(tx_peso.Text);
            string sexo = tx_sexo.Text;
            Pessoa p = new Pessoa(nome, cpf, idade, sexo, peso, altura);
            (double a, string b, string c) = p.CalcularIMC();
            tx_resultado.Text = $"O IMC é {a.ToString("0.00")}\nA classificação é {b}\nO grau é {c}";
            bool resultadocpf = Validacoes.ValidaCPF(cpf);
            MessageBox.Show(resultadocpf.ToString());

            if(resultadocpf == false)
            {
                MessageBox.Show("CPF inválido!");
            }
            else
            {
                MessageBox.Show("CPF válido!");
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
