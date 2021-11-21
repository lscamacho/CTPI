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
    public partial class SaleControl : UserControl
    {
        public SaleControl()
        {
            InitializeComponent();
        }


        private void btnCadastrarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Venda p = CarregarObjetoVendaDoForm();

                VendaCtrl control = new VendaCtrl();

                if ((Boolean)control.BD("inserir", p))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO INSERIR DADOS NO BD: " + ex.Message);
            }
        }

        private Venda CarregarObjetoVendaDoForm()
        {
            Venda p = new Venda();
            try
            {
                //String cpf_sem_tracos = mtbCPF.Text.Replace("-", "");
                //String cpf_sem_pontos = cpf_sem_tracos.Replace(".", "");
                //p.CPF = Int64.Parse(cpf_sem_pontos);
                p.IdVenda = Convert.ToInt64(txbIdVenda.Text.Replace(".", "").Replace("-", ""));
                p.IdProduto = Convert.ToInt64(txbProdNome.Text.Replace(".", "").Replace("-", ""));
                p.MatriculaFuncionario = Convert.ToInt64(txbFuncionarioMatricula.Text.Replace(".", "").Replace("-", ""));
                p.CpfCliente = Convert.ToInt64(txbCpfCliente.Text.Replace(".", "").Replace("-", ""));
                p.Data = cbxDatVenda.Text;
                p.Valor = cbxValorVenda.Text;


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

        private void txbCpfCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
