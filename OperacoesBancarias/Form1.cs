using OperacoesBancarias.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacoesBancarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1_Enter(sender, e);
            Cliente cliente = createCliente();
            string retornoCliente = getClienteNomeCpf(cliente);
            MessageBox.Show("Cliente cadastrado com sucesso!" + retornoCliente);

            clearFull();
        }

        public void clearFull()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = ""; 
        }

        private Cliente createCliente()
        {
                Cliente cliente = new Cliente();

                cliente.Nome = textBox1.Text;

                cliente.Cpf = textBox2.Text;

                cliente.Rg = textBox3.Text;

                cliente.Endereco = textBox4.Text;

                return cliente;
        }

        private string getClienteNomeCpf(Cliente cliente)
        {
            string retorno = "\n Nome: "+ cliente.Nome + " CPF: " + cliente.Cpf;

            return retorno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFull();
        }
    }
}
