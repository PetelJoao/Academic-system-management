using Microsoft.VisualBasic.ApplicationServices;
using petel_raziel_ava.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petel_raziel_ava
{
    public partial class Main_aluno : Form
    {


        Contas conta { get; set; }
        Guid UserId { get; set; }
        public Main_aluno(Contas conta, Guid userID)
        {


            InitializeComponent();
            this.conta = conta;
            this.UserId = userID;
            BindingSource Joe = new BindingSource();
            Joe.DataSource = conta.Amarzenamento;
            TableUserGuna.DataSource = Joe;
            atualizarJanela();

        }

        private void Main_aluno_Load(object sender, EventArgs e)
        {

        }

        private void TableUserGuna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void atualizarJanela()
        { //aqui
            var usuarios = conta.Amarzenamento_.GetAll();
            conta.Amarzenamento.Clear();
            guna2ComboBox1.Items.Clear();
            guna2ComboBox2.Items.Clear();
            foreach (var usuario in usuarios)
            {
                if (usuario.Tipo == "Professor")
                {
                    foreach (var informacao in usuario.Informacoes_usuario)
                    {



                        conta.Amarzenamento.Add(informacao);
                        guna2ComboBox1.Items.Add(informacao.Nome_criador);
                        guna2ComboBox2.Items.Add(informacao.Data);


                    }


                }


            }
            BindingSource Joe = new BindingSource();
            Joe.DataSource = conta.Amarzenamento;
            TableUserGuna.DataSource = null;
            TableUserGuna.Rows.Clear();
            TableUserGuna.Columns.Clear();
            TableUserGuna.DataSource = Joe;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Login pagina_login = new Login(conta);

            pagina_login.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {



            bool correct_name = false;
            foreach (var informacao in conta.Amarzenamento)
            {

                if (informacao.Nome_evento == guna2TextBox2.Text.ToString() &&
                 informacao.Nome_criador == guna2TextBox1.Text.ToString())
                {
                    correct_name = true;


                    try
                    {
                        var inscrito = informacao.inscritos_em.Contains(this.UserId);
                        if (inscrito)
                        {

                            MessageBox.Show("VOCÉ JA ESTA INSCRITO NESTE EVENTO!");
                            break;
                        }
                        else
                        {
                            informacao.inscritos_em.Add(this.UserId);
                            MessageBox.Show("INSCRITO COM SUCESSO");
                            break;
                        }

                    }
                    catch
                    {
                        informacao.inscritos_em.Add(this.UserId);
                        MessageBox.Show("INSCRITO COM SUCESSO");
                    }

                }



            }

            if (!correct_name) { MessageBox.Show("Ops... Evento ou professor inexistente!"); }







        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task exportar_eventos()
        {
            using (StreamWriter sw = new StreamWriter($@"C:\Users\Huawei\Documents\Eventos_disponiveis.txt"))
            {
                await Task.Run(() =>
                {

                    foreach (DataGridViewRow row in TableUserGuna.Rows)
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




        //Filtrar Eventos 
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            BindingSource Trump = new BindingSource();
           if(guna2ComboBox1.SelectedItem != null && guna2ComboBox2.SelectedItem != null)
            {
                var tabela_filtrada = conta.Amarzenamento.

                Where(x => x.Nome_criador == guna2ComboBox1.SelectedItem.ToString()
                     && x.Data == guna2ComboBox2.SelectedItem.ToString()).Select(x => x);

                Trump.DataSource = tabela_filtrada;
                TableUserGuna.DataSource = null;
                TableUserGuna.Rows.Clear();
                TableUserGuna.Columns.Clear();
                TableUserGuna.DataSource = Trump;
                
            }
            else
            {
                MessageBox.Show("os dois campos  precisam estar preenchido para prosseguir!");
            }
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            List<string> pessoas_inscritas = new List<string>();
            var val = "";
            foreach (var informacao in conta.Amarzenamento)
            {

                if (informacao.Nome_evento == guna2TextBox2.Text.ToString() &&
                 informacao.Nome_criador == guna2TextBox1.Text.ToString())
                {

                    foreach (var id_pessoal in informacao.inscritos_em)
                    {


                        foreach (var inf in conta.Amarzenamento_.GetAll())
                        {
                            if (inf.UserId == id_pessoal)
                            {
                                val += inf.Nome + " \n";
                            }
                        }

                    }

                    break;
                }

            }

            MessageBox.Show(val);
        }
        //exportar eventos disponiveis
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Task eventos_exportar = exportar_eventos();
            Task.WhenAll(eventos_exportar);
        }
    }
}
