using System.Diagnostics.Tracing;
using System.Windows.Forms;

namespace OperacoesBancarias.forms
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.funcionalidades = new System.Windows.Forms.GroupBox();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastrarConta = new System.Windows.Forms.Button();
            this.btnBuscarContas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.funcionalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(40, 17);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(175, 17);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "OPERAÇÕES BANCÁRIAS";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Navy;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(729, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // funcionalidades
            // 
            this.funcionalidades.BackColor = System.Drawing.Color.Navy;
            this.funcionalidades.Controls.Add(this.btnBuscarContas);
            this.funcionalidades.Controls.Add(this.btnCadastrarConta);
            this.funcionalidades.Controls.Add(this.btnCadastroCliente);
            this.funcionalidades.ForeColor = System.Drawing.Color.Transparent;
            this.funcionalidades.Location = new System.Drawing.Point(0, 37);
            this.funcionalidades.Name = "funcionalidades";
            this.funcionalidades.Size = new System.Drawing.Size(200, 414);
            this.funcionalidades.TabIndex = 1;
            this.funcionalidades.TabStop = false;
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Navy;
            this.btnCadastroCliente.Location = new System.Drawing.Point(12, 47);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(176, 23);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "CADASTRAR CLIENTE";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.ForeColor = System.Drawing.Color.Navy;
            this.btnCadastrarConta.Location = new System.Drawing.Point(12, 107);
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(176, 23);
            this.btnCadastrarConta.TabIndex = 1;
            this.btnCadastrarConta.Text = "CADASTRAR CONTA";
            this.btnCadastrarConta.UseVisualStyleBackColor = true;
            this.btnCadastrarConta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscarContas
            // 
            this.btnBuscarContas.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscarContas.Location = new System.Drawing.Point(12, 164);
            this.btnBuscarContas.Name = "btnBuscarContas";
            this.btnBuscarContas.Size = new System.Drawing.Size(176, 23);
            this.btnBuscarContas.TabIndex = 2;
            this.btnBuscarContas.Text = "BUSCAR CONTA";
            this.btnBuscarContas.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.funcionalidades);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.funcionalidades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Button btnClose;
        private Label titulo;
        private GroupBox funcionalidades;
        private Button btnBuscarContas;
        private Button btnCadastrarConta;
        private Button btnCadastroCliente;
    }
}