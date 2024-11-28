using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using petel_raziel_ava.Models;

namespace petel_raziel_ava
{//formulario
    public partial class Form1 : Form
    {
        public Contas conta { get; set; }
        public Form1(Contas conta)
        {
            InitializeComponent();
            this.conta = conta;
        }

       
        //Verifica se o usuario é o do tipo Aluno
        private bool e_usuario(Usuarios usuario)
        {
            if (usuario.Tipo == "Aluno")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //botão de efectuar cadastro
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios

            {
                Nome = textBox1.Text,

                Email = textBox2.Text,

                Tipo = comboBox1.SelectedItem.ToString(),

                UserId = Guid.NewGuid(),

                Informacoes_usuario = new(),

    
            };

          
            if (e_usuario(user))
            {
                var usuarios = conta.Amarzenamento_.GetAll();

                foreach (var usuario in usuarios)
                {
                    if (usuario.Tipo == "Professor")
                    {
                        foreach (var informacao in usuario.Informacoes_usuario)
                        {
                            user.Informacoes_usuario.Add(informacao);
                        }

                    }


                }
            }


            conta.Amarzenamento_.Adicionar(user);



            Login login = new Login(conta);
            login.Show();
            this.Hide();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
