
namespace View
{
    partial class FrmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnListing = new System.Windows.Forms.Button();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPoduct = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.funcionarioControl1 = new View.FuncionarioControl();
            this.clienteControlUpdate1 = new View.ClienteControlUpdate();
            this.listingControl1 = new View.ListingControl();
            this.productControl1 = new View.ProductControl();
            this.saleControl1 = new View.SaleControl();
            this.clientControl1 = new View.ClientControl();
            this.homeControl1 = new View.HomeControl();
            this.barraStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tHora
            // 
            this.tHora.Enabled = true;
            this.tHora.Interval = 1000;
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 20);
            this.toolStripStatusLabel1.Text = "usuarioLogado:";
            // 
            // itbUsuarioLogado
            // 
            this.itbUsuarioLogado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itbUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.itbUsuarioLogado.Name = "itbUsuarioLogado";
            this.itbUsuarioLogado.Size = new System.Drawing.Size(107, 20);
            this.itbUsuarioLogado.Text = "usuarioLogado";
            this.itbUsuarioLogado.Click += new System.EventHandler(this.itbUsuarioLogado_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // itbHora
            // 
            this.itbHora.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itbHora.ForeColor = System.Drawing.Color.White;
            this.itbHora.Name = "itbHora";
            this.itbHora.Size = new System.Drawing.Size(64, 20);
            this.itbHora.Text = "00:00:00";
            this.itbHora.Click += new System.EventHandler(this.itbHora_Click);
            // 
            // barraStatus
            // 
            this.barraStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.barraStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.barraStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.itbUsuarioLogado,
            this.toolStripStatusLabel2,
            this.itbHora});
            this.barraStatus.Location = new System.Drawing.Point(547, 3);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barraStatus.Size = new System.Drawing.Size(312, 26);
            this.barraStatus.TabIndex = 0;
            this.barraStatus.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.btnAdm);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnListing);
            this.panel1.Controls.Add(this.slidePanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPoduct);
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 592);
            this.panel1.TabIndex = 1;
            // 
            // btnAdm
            // 
            this.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.White;
            this.btnAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnAdm.Image")));
            this.btnAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdm.Location = new System.Drawing.Point(10, 502);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(188, 64);
            this.btnAdm.TabIndex = 8;
            this.btnAdm.Text = "      Adm";
            this.btnAdm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(10, 432);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 64);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "      Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnListing
            // 
            this.btnListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListing.FlatAppearance.BorderSize = 0;
            this.btnListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListing.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListing.ForeColor = System.Drawing.Color.White;
            this.btnListing.Image = ((System.Drawing.Image)(resources.GetObject("btnListing.Image")));
            this.btnListing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListing.Location = new System.Drawing.Point(12, 362);
            this.btnListing.Name = "btnListing";
            this.btnListing.Size = new System.Drawing.Size(188, 64);
            this.btnListing.TabIndex = 6;
            this.btnListing.Text = "      Listing";
            this.btnListing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListing.UseVisualStyleBackColor = true;
            this.btnListing.Click += new System.EventHandler(this.btnListing_Click);
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.slidePanel.Location = new System.Drawing.Point(3, 82);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(10, 64);
            this.slidePanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPoduct
            // 
            this.btnPoduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoduct.FlatAppearance.BorderSize = 0;
            this.btnPoduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoduct.ForeColor = System.Drawing.Color.White;
            this.btnPoduct.Image = ((System.Drawing.Image)(resources.GetObject("btnPoduct.Image")));
            this.btnPoduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoduct.Location = new System.Drawing.Point(12, 292);
            this.btnPoduct.Name = "btnPoduct";
            this.btnPoduct.Size = new System.Drawing.Size(188, 64);
            this.btnPoduct.TabIndex = 4;
            this.btnPoduct.Text = "      Product";
            this.btnPoduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPoduct.UseVisualStyleBackColor = true;
            this.btnPoduct.Click += new System.EventHandler(this.btnPoduct_Click);
            // 
            // btnSale
            // 
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(12, 222);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(188, 64);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = "      Sale";
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnClient
            // 
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(12, 152);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(188, 64);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "      Client";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 82);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(188, 64);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "      Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOff);
            this.panel2.Controls.Add(this.barraStatus);
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 29);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Múscia Legal";
            // 
            // btnOff
            // 
            this.btnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.Color.White;
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.Location = new System.Drawing.Point(854, 0);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(24, 29);
            this.btnOff.TabIndex = 3;
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // funcionarioControl1
            // 
            this.funcionarioControl1.Location = new System.Drawing.Point(204, 27);
            this.funcionarioControl1.Name = "funcionarioControl1";
            this.funcionarioControl1.Size = new System.Drawing.Size(886, 565);
            this.funcionarioControl1.TabIndex = 9;
            // 
            // clienteControlUpdate1
            // 
            this.clienteControlUpdate1.Location = new System.Drawing.Point(204, 32);
            this.clienteControlUpdate1.Name = "clienteControlUpdate1";
            this.clienteControlUpdate1.Size = new System.Drawing.Size(886, 565);
            this.clienteControlUpdate1.TabIndex = 8;
            // 
            // listingControl1
            // 
            this.listingControl1.Location = new System.Drawing.Point(204, 29);
            this.listingControl1.Name = "listingControl1";
            this.listingControl1.Size = new System.Drawing.Size(886, 565);
            this.listingControl1.TabIndex = 7;
            // 
            // productControl1
            // 
            this.productControl1.Location = new System.Drawing.Point(204, 29);
            this.productControl1.Name = "productControl1";
            this.productControl1.Size = new System.Drawing.Size(886, 565);
            this.productControl1.TabIndex = 6;
            // 
            // saleControl1
            // 
            this.saleControl1.Location = new System.Drawing.Point(204, 29);
            this.saleControl1.Name = "saleControl1";
            this.saleControl1.Size = new System.Drawing.Size(886, 565);
            this.saleControl1.TabIndex = 5;
            // 
            // clientControl1
            // 
            this.clientControl1.Location = new System.Drawing.Point(204, 29);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(895, 560);
            this.clientControl1.TabIndex = 4;
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(204, 29);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1048, 693);
            this.homeControl1.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 592);
            this.Controls.Add(this.funcionarioControl1);
            this.Controls.Add(this.clienteControlUpdate1);
            this.Controls.Add(this.listingControl1);
            this.Controls.Add(this.productControl1);
            this.Controls.Add(this.saleControl1);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação teste de aula";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer tHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel itbUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel itbHora;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPoduct;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListing;
        private HomeControl homeControl1;
        private ClientControl clientControl1;
        private SaleControl saleControl1;
        private ProductControl productControl1;
        private ListingControl listingControl1;
        private System.Windows.Forms.Button btnUpdate;
        private ClienteControlUpdate clienteControlUpdate1;
        private System.Windows.Forms.Button btnAdm;
        private FuncionarioControl funcionarioControl1;
    }
}

