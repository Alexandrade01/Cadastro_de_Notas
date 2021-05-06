using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoHeranca
{
    public partial class Form1 : Form
    {
        List<AlunoBase> alunos = new List<AlunoBase>();

        public Form1()
        {
            InitializeComponent();
        }

        private void RequisitosBasicos(AlunoBase b)
        {
            b.RA = Convert.ToInt32(txtRA.Text);
            b.Nome = txtNomeAluno.Text;
            b.N1 = Convert.ToDouble(txtN1.Text);
            b.Faltas = Convert.ToInt32(txtFaltas.Text);
           
        }

        private void BtnAlunoEM(object sender, EventArgs e)
        {
            try
            {
                AlunoEM a = new AlunoEM();
                RequisitosBasicos(a);
                a.N2 = Convert.ToDouble(txtN2_EM.Text);
                a.N3 = Convert.ToDouble(txtN3_EM.Text);
                a.Responsavel = txtResponsavel.Text;
                a.Avaliacao(6);


                alunos.Add(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void BtnAlunoFtt(object sender, EventArgs e)
        {
            try
            {
                AlunoFTT a = new AlunoFTT();
                RequisitosBasicos(a);
                a.N2 = Convert.ToDouble(txtN2_FTT.Text);
                a.HorasEstagio = Convert.ToInt32(txtHorasEstagio.Text);
                a.Avaliacao(5);

                alunos.Add(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnAlunoPos(object sender, EventArgs e)
        {
            try
            {
                var a = new AlunoPos();
                RequisitosBasicos(a);
                a.InstituicaoEnsinoSuperior = txtGraduacao.Text;
                a.Avaliacao(7);

                alunos.Add(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnListagem(object sender, EventArgs e)
        {
            txtListagem.Clear();
            StringBuilder sb = new StringBuilder();

            foreach(AlunoBase aluno in alunos)
            {
                sb.AppendLine("RA: " + aluno.RA);
                sb.AppendLine("Nome: " + aluno.Nome);
                sb.AppendLine("N1: " + aluno.N1.ToString("0.0"));
                sb.AppendLine("Frequencia do Aluno: %" + aluno.FrequenciaAluno());

                if (aluno is AlunoEM)
                {
                    sb.AppendLine("N2: " + (aluno as AlunoEM).N2.ToString("0.0"));
                    sb.AppendLine("N3: " + (aluno as AlunoEM).N3.ToString("0.0"));
                    sb.AppendLine("Responsável: " + (aluno as AlunoEM).Responsavel);
                }
                else if (aluno is AlunoFTT)
                {
                    sb.AppendLine("N2: " + (aluno as AlunoFTT).N2.ToString("0.0"));
                    sb.AppendLine("Horas de estágio: " + (aluno as AlunoFTT).HorasEstagio);
                }
                else
                {
                    sb.AppendLine("Graduado em: " + ((AlunoPos)aluno).InstituicaoEnsinoSuperior);
                }

                sb.AppendLine("Média: " + aluno.CalcularMedia().ToString("0.0"));
                sb.AppendLine("");
                sb.AppendLine("");
            }

            txtListagem.Text = sb.ToString();
        }

        private void ListagemToString(object sender, EventArgs e)
        {
            txtListagem.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (AlunoBase aluno in alunos)
            {
                sb.AppendLine(aluno.ToString());
                sb.AppendLine("");
                sb.AppendLine("");
            }
            txtListagem.Text = sb.ToString();
        }

        private void BtnListaEM_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            StringBuilder sb = new StringBuilder();
            foreach(AlunoBase aluno in alunos)
            {
                if(aluno is AlunoEM)
                {
                    sb.AppendLine(aluno.ToString());
                    sb.AppendLine("");
                    sb.AppendLine("");
                   
                }
                

            }
            txtListagem.Text = sb.ToString();
        }

        private void BtnListaFTT_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (AlunoBase aluno in alunos)
            {
                if (aluno is AlunoFTT)
                {
                    sb.AppendLine(aluno.ToString());
                    sb.AppendLine("");
                    sb.AppendLine("");

                }
                

            }
            txtListagem.Text = sb.ToString();

        }

        private void BtnListaPos_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (AlunoBase aluno in alunos)
            {
                if (aluno is AlunoPos)
                {
                    sb.AppendLine(aluno.ToString());
                    sb.AppendLine("");
                    sb.AppendLine("");

                }
               

            }
            txtListagem.Text = sb.ToString();
        }
    }
}
