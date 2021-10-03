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


namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
             InitializeComponent();
            slidePanel.Height = btnHome.Height;
            homeControl1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FrmLogin formLogin = new FrmLogin();
            this.Hide();

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                User u = (User)formLogin.Tag;
                itbUsuarioLogado.Text = u.Usuario;
                this.Show();
            }
            else
            {
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();

            this.Visible = false;

            form.ShowDialog();

            //MessageBox.Show("sadasd");
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void itbUsuarioLogado_Click(object sender, EventArgs e)
        {

        }

        private void itbHora_Click(object sender, EventArgs e)
        {

        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            itbHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tHora.Enabled = true;
        }

        private void imSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Inicializar outro formulário
        private void brBtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();
            form.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btnHome_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHome.Height;
            slidePanel.Top = btnHome.Top;
            homeControl1.BringToFront();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnClient.Height;
            slidePanel.Top = btnClient.Top;
            clientControl1.BringToFront();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnSale.Height;
            slidePanel.Top = btnSale.Top;
            saleControl1.BringToFront();
        }

        private void btnPoduct_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnPoduct.Height;
            slidePanel.Top = btnPoduct.Top;
            productControl1.BringToFront();
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnListing.Height;
            slidePanel.Top = btnListing.Top;
            listingControl1.BringToFront();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            slidePanel.Height = btnUpdate.Height;
            slidePanel.Top = btnUpdate.Top;
            clienteControlUpdate1.BringToFront();
        }

        private void btnAdm_Click_4(object sender, EventArgs e)
        {
            slidePanel.Height = btnAdm.Height;
            slidePanel.Top = btnAdm.Top;
            funcionarioControl1.BringToFront();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnAdm.Height;
            slidePanel.Top = btnAdm.Top;
            funcionarioControl1.BringToFront();
        }
    }
}
