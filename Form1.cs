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

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios

            {
                Nome = textBox1.Text,

                Email = textBox2.Text,

                Tipo = comboBox1.SelectedItem.ToString(),

                UserId = Guid.NewGuid(),

                Informacoes_usuario = new(),
            
                //aqui

            };
         
            //aqui
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
    }
}
