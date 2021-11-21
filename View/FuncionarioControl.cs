using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Control;

namespace View
{
    public partial class FuncionarioControl : UserControl
    {
        public FuncionarioControl()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario p = CarregarObjetoFuncionarioDoForm();

                FuncionarioCtrl control = new FuncionarioCtrl();

                if ((Boolean)control.BD("inserir", p))
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO INSERIR DADOS NO BD: " + ex.Message);
            }
        }

        private Funcionario CarregarObjetoFuncionarioDoForm()
        {
            Funcionario p = new Funcionario();
            try
            {
                //String cpf_sem_tracos = mtbCPF.Text.Replace("-", "");
                //String cpf_sem_pontos = cpf_sem_tracos.Replace(".", "");
                //p.CPF = Int64.Parse(cpf_sem_pontos);
                p.Nome = txbFuncionarioNome.Text;
                p.Matricula = Convert.ToInt64(txbMatricula.Text.Replace(".", "").Replace("-", ""));
                p.Cpf = txbFuncionarioCpf.Text;
                p.DataNascimento = txbFuncionarioDtNasc.Text;
                p.Sexo = txbFuncionarioSexo.Text;
                p.EstadoCivil = txbFuncionarioEstCivil.Text;
                p.Telefone = txbFuncionarioTelefone.Text;
                p.Cargo = txbFuncionarioCargo.Text;
                p.Endereco = txbFuncionarioEnd.Text;
                p.Estado = txbFuncionarioEstado.Text;
                p.Cidade = txbFuncionarioCidade.Text;
                p.Cep = txbFuncionarioCep.Text;           


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS PARA Cliente: " + ex.Message);
            }
            return p;
        }

        private void mtbDtNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
