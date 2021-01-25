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

namespace OperacoesBancarias.forms
{
    public partial class FormCreateClienteAccount : Form
    {
        public FormCreateClienteAccount()
        {
            InitializeComponent();
        }

        private void FormCreateClienteAccount_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        //METODO SUBMIT 
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1_Enter(sender, e);
            verificaSeOsCamposForamPreenchidosECadastra();
        }

        //METODO LIMPAR CAMPOS
        public void clearFull()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = ""; 
        }

        //METODO CRIAR CLIENTE A PARTIR DOS TEXTBOXS
        private Cliente createCliente()
        {
                Cliente cliente = new Cliente();

                cliente.Nome = textBox1.Text;

                cliente.Cpf = textBox2.Text;

                cliente.Rg = textBox3.Text;

                cliente.Endereco = textBox4.Text;

                return cliente;
        }

        //METODO DE MENSAGEM APÓS CADASTRO DO CLIENTE
        private void createClienteForm()
        {
            MessageBox.Show(getClienteCpf(createCliente()));
        }

        //RETORNA O CPF DO CLIENTE CADASTRADO
        private string getClienteCpf(Cliente cliente)
        {
            return ($"CPF: {cliente.Cpf}");
        }

        //METODO DE LIMPAR CAMPOS
        private void button2_Click(object sender, EventArgs e)
        {
            clearFull();
        }

        // METODO DE VERIFICAÇAO CAMPOS NULOS OU EM BRANCO, E CADASTRO
        private void verificaSeOsCamposForamPreenchidosECadastra()
        {
            if (
                (textBox1.Text != null && textBox1.Text != "") &&
                (textBox2.Text != null && textBox2.Text != "") &&
                (textBox3.Text != null && textBox3.Text != "") &&
                (textBox4.Text != null && textBox4.Text != ""))
            {
                createClienteForm();
                clearFull();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser previamente preenchidos!");
            }
        }
    }
}
