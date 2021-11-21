
namespace View
{
    partial class SaleControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbProdNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCpfCliente = new System.Windows.Forms.TextBox();
            this.cbxDatVenda = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxValorVenda = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFuncionarioMatricula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbIdVenda = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbProdNome
            // 
            this.txbProdNome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbProdNome.Location = new System.Drawing.Point(210, 160);
            this.txbProdNome.Name = "txbProdNome";
            this.txbProdNome.Size = new System.Drawing.Size(498, 36);
            this.txbProdNome.TabIndex = 3;
            this.txbProdNome.Tag = "";
            this.txbProdNome.Text = "121";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 42);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preencha com as informações da venda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(779, 520);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 28);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarVenda
            // 
            this.btnCadastrarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnCadastrarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarVenda.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCadastrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVenda.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVenda.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarVenda.Location = new System.Drawing.Point(677, 520);
            this.btnCadastrarVenda.Name = "btnCadastrarVenda";
            this.btnCadastrarVenda.Size = new System.Drawing.Size(88, 28);
            this.btnCadastrarVenda.TabIndex = 33;
            this.btnCadastrarVenda.Text = "Registrar";
            this.btnCadastrarVenda.UseVisualStyleBackColor = false;
            this.btnCadastrarVenda.Click += new System.EventHandler(this.btnCadastrarVenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cliente";
            // 
            // txbCpfCliente
            // 
            this.txbCpfCliente.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpfCliente.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCpfCliente.Location = new System.Drawing.Point(210, 319);
            this.txbCpfCliente.Name = "txbCpfCliente";
            this.txbCpfCliente.Size = new System.Drawing.Size(498, 36);
            this.txbCpfCliente.TabIndex = 35;
            this.txbCpfCliente.Tag = "";
            this.txbCpfCliente.Text = "14576898870";
            this.txbCpfCliente.TextChanged += new System.EventHandler(this.txbCpfCliente_TextChanged);
            // 
            // cbxDatVenda
            // 
            this.cbxDatVenda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDatVenda.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxDatVenda.Location = new System.Drawing.Point(210, 399);
            this.cbxDatVenda.Mask = "00/00/0000";
            this.cbxDatVenda.Name = "cbxDatVenda";
            this.cbxDatVenda.Size = new System.Drawing.Size(249, 36);
            this.cbxDatVenda.TabIndex = 37;
            this.cbxDatVenda.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "Data";
            // 
            // cbxValorVenda
            // 
            this.cbxValorVenda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxValorVenda.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxValorVenda.Location = new System.Drawing.Point(210, 480);
            this.cbxValorVenda.Mask = "$9999,99";
            this.cbxValorVenda.Name = "cbxValorVenda";
            this.cbxValorVenda.Size = new System.Drawing.Size(249, 36);
            this.cbxValorVenda.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Funcionário";
            // 
            // txbFuncionarioMatricula
            // 
            this.txbFuncionarioMatricula.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFuncionarioMatricula.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbFuncionarioMatricula.Location = new System.Drawing.Point(210, 239);
            this.txbFuncionarioMatricula.Name = "txbFuncionarioMatricula";
            this.txbFuncionarioMatricula.Size = new System.Drawing.Size(498, 36);
            this.txbFuncionarioMatricula.TabIndex = 41;
            this.txbFuncionarioMatricula.Tag = "";
            this.txbFuncionarioMatricula.Text = "123";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 44;
            this.label7.Text = "ID Venda";
            // 
            // txbIdVenda
            // 
            this.txbIdVenda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdVenda.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbIdVenda.Location = new System.Drawing.Point(210, 83);
            this.txbIdVenda.Name = "txbIdVenda";
            this.txbIdVenda.Size = new System.Drawing.Size(256, 36);
            this.txbIdVenda.TabIndex = 43;
            this.txbIdVenda.Tag = "";
            this.txbIdVenda.Text = "1111";
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbIdVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbFuncionarioMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxValorVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDatVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCpfCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarVenda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbProdNome);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(886, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbProdNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCpfCliente;
        private System.Windows.Forms.MaskedTextBox cbxDatVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox cbxValorVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFuncionarioMatricula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbIdVenda;
    }
}
