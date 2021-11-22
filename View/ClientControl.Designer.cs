
namespace View
{
    partial class ClientControl
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbClienteNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbRenda = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbSexo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preencha com as informações do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txbClienteNome
            // 
            this.txbClienteNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClienteNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbClienteNome.Location = new System.Drawing.Point(21, 92);
            this.txbClienteNome.Name = "txbClienteNome";
            this.txbClienteNome.Size = new System.Drawing.Size(835, 28);
            this.txbClienteNome.TabIndex = 2;
            this.txbClienteNome.Tag = "";
            this.txbClienteNome.Text = "Nome completo do Cliente";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mtbCpf.Location = new System.Drawing.Point(21, 178);
            this.mtbCpf.Mask = "000,000,000,-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(249, 28);
            this.mtbCpf.TabIndex = 5;
            this.mtbCpf.Text = "3848388838";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF";
            // 
            // mtbDtNascimento
            // 
            this.mtbDtNascimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDtNascimento.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mtbDtNascimento.Location = new System.Drawing.Point(316, 178);
            this.mtbDtNascimento.Mask = "00/00/0000";
            this.mtbDtNascimento.Name = "mtbDtNascimento";
            this.mtbDtNascimento.Size = new System.Drawing.Size(249, 28);
            this.mtbDtNascimento.TabIndex = 7;
            this.mtbDtNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbDtNascimento_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo";
            // 
            // cbxEstadoCivil
            // 
            this.cbxEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoCivil.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxEstadoCivil.FormattingEnabled = true;
            this.cbxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)"});
            this.cbxEstadoCivil.Location = new System.Drawing.Point(21, 277);
            this.cbxEstadoCivil.Name = "cbxEstadoCivil";
            this.cbxEstadoCivil.Size = new System.Drawing.Size(249, 29);
            this.cbxEstadoCivil.TabIndex = 12;
            this.cbxEstadoCivil.Text = "Solteiro(a)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado civil";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbTelefone.Location = new System.Drawing.Point(319, 277);
            this.txbTelefone.Mask = "(99) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(246, 28);
            this.txbTelefone.TabIndex = 14;
            this.txbTelefone.Text = "21434343434";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefone";
            // 
            // txbRenda
            // 
            this.txbRenda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRenda.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbRenda.Location = new System.Drawing.Point(610, 277);
            this.txbRenda.Mask = "$ 999,99";
            this.txbRenda.Name = "txbRenda";
            this.txbRenda.Size = new System.Drawing.Size(260, 28);
            this.txbRenda.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(606, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Renda Mensal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Logradouro";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogradouro.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbLogradouro.Location = new System.Drawing.Point(21, 366);
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(544, 28);
            this.txbLogradouro.TabIndex = 19;
            this.txbLogradouro.Tag = "";
            this.txbLogradouro.Text = "Logradouro";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(610, 366);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 28);
            this.textBox3.TabIndex = 21;
            this.textBox3.Tag = "";
            this.textBox3.Text = "Complemento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(606, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Complemento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxEstado.Location = new System.Drawing.Point(21, 461);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(138, 29);
            this.cbxEstado.TabIndex = 25;
            this.cbxEstado.Text = "AC";
            // 
            // txbCidade
            // 
            this.txbCidade.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCidade.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCidade.Location = new System.Drawing.Point(206, 462);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(359, 28);
            this.txbCidade.TabIndex = 26;
            this.txbCidade.Tag = "";
            this.txbCidade.Text = "Cidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(200, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cidade";
            // 
            // mtbCep
            // 
            this.mtbCep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCep.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mtbCep.Location = new System.Drawing.Point(597, 462);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(273, 28);
            this.mtbCep.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(593, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "CEP";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Location = new System.Drawing.Point(666, 524);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 28);
            this.btnCadastrar.TabIndex = 31;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(768, 524);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 28);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txbSexo
            // 
            this.txbSexo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSexo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSexo.Location = new System.Drawing.Point(597, 178);
            this.txbSexo.Name = "txbSexo";
            this.txbSexo.Size = new System.Drawing.Size(256, 28);
            this.txbSexo.TabIndex = 35;
            this.txbSexo.Tag = "";
            this.txbSexo.Text = "masculino";
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbSexo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txbLogradouro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbRenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxEstadoCivil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbDtNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.txbClienteNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(886, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbClienteNome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDtNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxEstadoCivil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txbRenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbSexo;
    }
}
