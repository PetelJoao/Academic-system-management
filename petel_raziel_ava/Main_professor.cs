using petel_raziel_ava.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace petel_raziel_ava
{
    public partial class Main_professor : Form
    {
        Contas conta { get; set; }
        string nome_usuaro;

        public Main_professor(Contas conta,string User_name)
        {

            InitializeComponent();
            this.nome_usuaro = User_name;
            BindingSource joebiden = new BindingSource();
            this.conta = conta;
            joebiden.DataSource = conta.Amarzenamento;
            Tableguna.DataSource = joebiden;

        }

        private void Main_professor_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Carregar_Enventos()
        {




        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Informacoes ifn = new Informacoes() { Nome_evento = guna2TextBox1.Text, Descricao = guna2TextBox2.Text, Data = dateTimePicker1.Text, Nome_criador = nome_usuaro };

            conta.Amarzenamento.Add(ifn);
            BindingSource binding = new BindingSource();
            binding.DataSource = conta.Amarzenamento;
            Tableguna.DataSource = binding;


        }



        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            List<Informacoes> dados_tabela = new List<Informacoes>();
            foreach (DataGridViewRow row in Tableguna.Rows)
            {
                dados_tabela.Add(new Informacoes
                {
                    Nome_evento = row.Cells["Nome_evento"].ToString(),
                    Descricao = row.Cells["Data"].ToString(),
                    Data = row.Cells["Descricao"].ToString()

                });

            }

            conta.Amarzenamento = dados_tabela;
            Login pagina_login = new Login(conta);

            pagina_login.Show();
            this.Hide();

        }

        private void Tableguna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Task eventos_exportar = exportar_eventos();
            Task.WhenAll(eventos_exportar);

        }

        private async Task exportar_eventos()
        {
            using (StreamWriter sw = new StreamWriter($@"C:\Users\Huawei\Documents\{nome_usuaro}Eventos.txt"))
            {
                await Task.Run(() =>
                {

                    foreach (DataGridViewRow row in Tableguna.Rows)
                    {
                        sw.WriteLineAsync(

                                  row.Cells[0].Value?.ToString() +
                            " " + row.Cells[1].Value?.ToString() +
                            " " + row.Cells[2].Value?.ToString()
                            );
                    }
                });

            }

        }
        private async Task exportar_usuarios()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Huawei\Documents\Usuarios.txt"))
            {

                await Task.Run(() =>

                    {
                        foreach (var conta in conta.Amarzenamento_.GetAll())
                        {
                            if(conta.Tipo == "Aluno")
                            {
                                var eventos_inscritos = conta.Informacoes_usuario.Where(x => x.inscritos_em.Contains(conta.UserId)).Select(x => x.Nome_evento).ToList();
                                var eve =string.Join(" ", eventos_inscritos);
                                sw.WriteLineAsync("Nome da conta:" + conta.Nome +
                            " " + "tipo de conta:" + conta.Tipo +
                            " " + "Inscrito no Evento:" + eve


                            );

                            }
                            else
                            {
                                sw.WriteLineAsync("Nome da conta:" + conta.Nome +
                              " " + "tipo de conta:" + conta.Tipo

                              );
                            }
                          

                            
                        }

                    });

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Task eventos_exportar = exportar_eventos();
            Task usuarios_esportar = exportar_usuarios();

            Task.WhenAll(eventos_exportar, usuarios_esportar);

        }
    }
}
