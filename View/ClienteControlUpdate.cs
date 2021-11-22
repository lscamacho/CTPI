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
    public partial class ClienteControlUpdate : UserControl
    {
        public ClienteControlUpdate()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente p = CarregarObjetoClienteDoForm();

                ClienteCtrl control = new ClienteCtrl();

                if ((Boolean)control.BD("alterar", p))
                {
                    MessageBox.Show("Cliente alterado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ALTERAR OS DADOS NO BD: " + ex.Message);
            }
        }

        private Cliente CarregarObjetoClienteDoForm()
        {
            Cliente p = new Cliente();
            try
            {
                //String cpf_sem_tracos = mtbCPF.Text.Replace("-", "");
                //String cpf_sem_pontos = cpf_sem_tracos.Replace(".", "");
                //p.CPF = Int64.Parse(cpf_sem_pontos);
                p.Cpf = Convert.ToInt64(mtbCpf.Text.Replace(".", "").Replace("-", ""));
                p.Nome = txbClienteNome.Text;
                p.Logradouro = txbLogradouro.Text;
                p.DataNascimento = mtbDtNascimento.Text;
                p.Sexo = txbSexo.Text;
                p.EstadoCivil = cbxEstadoCivil.Text;
                p.Telefone = txbTelefone.Text;
                p.Cep = mtbCep.Text;
                p.RendaMensal = txbRenda.Text;
                p.Estado = cbxEstado.Text;
                p.Cidade = txbCidade.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS PARA Cliente: " + ex.Message);
            }
            return p;
        }

        private void ClienteControlUpdate_Load(object sender, EventArgs e)
        {

        }

     
    }
}
