using petel_raziel_ava.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petel_raziel_ava
{
    public partial class Login : Form
    {
        Contas conta { get; set; }
      
        public Login(Contas conta)
        {
            InitializeComponent();
            this.conta = conta;
         
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void VerificarUsuario(string nome, string senha)
        {
            var existente = true;
            foreach (var usuario in conta.Amarzenamento_.GetAll())
            {
                if (usuario.Nome == nome && usuario.Email == senha)
                {



                    conta.Amarzenamento = usuario.Informacoes_usuario;
                    
                    if (usuario.Tipo == "Professor")
                    {
                        MessageBox.Show("Professor Usuario encontrado com sucesso!");
                        Main_professor Tela_principal = new Main_professor(conta, usuario.Nome);
                        existente = false;
                        Tela_principal.Show();
                        this.Hide();
                    }
                  if (usuario.Tipo == "Aluno")
                    {
                        MessageBox.Show("Aluno Usuario encontrado com sucesso!");
                        Main_aluno Tela_principal = new Main_aluno(conta,usuario.UserId);
                        existente = false;
                        Tela_principal.Show();
                        this.Hide();

                    }
                 
                }
            }

            if(existente) { MessageBox.Show("User not found 404!"); }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {

            VerificarUsuario(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 registrar = new Form1(conta);
            registrar.Show();
            this.Hide();
        }
    }
}
