namespace LawyersClient
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.clientView = new System.Windows.Forms.ListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.phoneColumn = new System.Windows.Forms.ColumnHeader();
            this.emailColumn = new System.Windows.Forms.ColumnHeader();
            this.lawyerColumn = new System.Windows.Forms.ColumnHeader();
            this.processNumberColumn = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientsTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientName = new System.Windows.Forms.ToolStripMenuItem();
            this.editClient = new System.Windows.Forms.ToolStripMenuItem();
            this.removeClient = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contractView = new System.Windows.Forms.ListView();
            this.valueContract = new System.Windows.Forms.ColumnHeader();
            this.valueEntrance = new System.Windows.Forms.ColumnHeader();
            this.installments = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contractItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientView
            // 
            this.clientView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.phoneColumn,
            this.emailColumn,
            this.lawyerColumn,
            this.processNumberColumn});
            this.clientView.FullRowSelect = true;
            this.clientView.GridLines = true;
            this.clientView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.clientView.HideSelection = false;
            this.clientView.Location = new System.Drawing.Point(9, 22);
            this.clientView.Name = "clientView";
            this.clientView.Size = new System.Drawing.Size(738, 75);
            this.clientView.TabIndex = 0;
            this.clientView.TabStop = false;
            this.clientView.UseCompatibleStateImageBehavior = false;
            this.clientView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Nome";
            this.nameColumn.Width = 170;
            // 
            // phoneColumn
            // 
            this.phoneColumn.Text = "Telefone";
            this.phoneColumn.Width = 120;
            // 
            // emailColumn
            // 
            this.emailColumn.Text = "Email";
            this.emailColumn.Width = 170;
            // 
            // lawyerColumn
            // 
            this.lawyerColumn.Text = "Nome do advogado";
            this.lawyerColumn.Width = 170;
            // 
            // processNumberColumn
            // 
            this.processNumberColumn.Text = "N° do processo";
            this.processNumberColumn.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.clientsTreeView);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 457);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Clientes";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(6, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(135, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Exportar em Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientsTreeView
            // 
            this.clientsTreeView.ContextMenuStrip = this.menuStrip;
            this.clientsTreeView.Location = new System.Drawing.Point(6, 22);
            this.clientsTreeView.Name = "clientsTreeView";
            this.clientsTreeView.Size = new System.Drawing.Size(256, 402);
            this.clientsTreeView.TabIndex = 3;
            this.clientsTreeView.TabStop = false;
            this.clientsTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.clientsTreeView_BeforeSelect);
            this.clientsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientName,
            this.editClient,
            this.removeClient});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(122, 70);
            this.menuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.menuStrip_Opening);
            // 
            // clientName
            // 
            this.clientName.Enabled = false;
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(121, 22);
            this.clientName.Text = "Cliente: ";
            // 
            // editClient
            // 
            this.editClient.Enabled = false;
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(121, 22);
            this.editClient.Text = "Editar";
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // removeClient
            // 
            this.removeClient.Enabled = false;
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(121, 22);
            this.removeClient.Text = "Remover";
            this.removeClient.Click += new System.EventHandler(this.removeClient_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientView);
            this.groupBox2.Location = new System.Drawing.Point(299, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 103);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(993, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Versão 1.2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.contractView);
            this.groupBox3.Location = new System.Drawing.Point(299, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(753, 103);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Contrato";
            // 
            // contractView
            // 
            this.contractView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.valueContract,
            this.valueEntrance,
            this.installments,
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader5});
            this.contractView.FullRowSelect = true;
            this.contractView.GridLines = true;
            this.contractView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.contractView.HideSelection = false;
            this.contractView.Location = new System.Drawing.Point(9, 22);
            this.contractView.MultiSelect = false;
            this.contractView.Name = "contractView";
            this.contractView.Size = new System.Drawing.Size(738, 75);
            this.contractView.TabIndex = 0;
            this.contractView.TabStop = false;
            this.contractView.UseCompatibleStateImageBehavior = false;
            this.contractView.View = System.Windows.Forms.View.Details;
            // 
            // valueContract
            // 
            this.valueContract.Text = "Valor";
            this.valueContract.Width = 125;
            // 
            // valueEntrance
            // 
            this.valueEntrance.Text = "Valor de entrada";
            this.valueEntrance.Width = 125;
            // 
            // installments
            // 
            this.installments.Text = "Parcelamento";
            this.installments.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor da parcela";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Valor final (c/ divisão)";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            this.columnHeader5.Width = 100;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.contractItems);
            this.groupBox4.Location = new System.Drawing.Point(299, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 239);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Divisão de Contrato";
            // 
            // contractItems
            // 
            this.contractItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.contractItems.FullRowSelect = true;
            this.contractItems.GridLines = true;
            this.contractItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.contractItems.HideSelection = false;
            this.contractItems.Location = new System.Drawing.Point(9, 18);
            this.contractItems.MultiSelect = false;
            this.contractItems.Name = "contractItems";
            this.contractItems.Size = new System.Drawing.Size(738, 215);
            this.contractItems.TabIndex = 2;
            this.contractItems.TabStop = false;
            this.contractItems.UseCompatibleStateImageBehavior = false;
            this.contractItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Percentual";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Objeto";
            this.columnHeader7.Width = 250;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Valor";
            this.columnHeader8.Width = 200;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.arquivoToolStripMenuItem.Text = "Início";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1064, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contratos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView clientView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader phoneColumn;
        private System.Windows.Forms.ColumnHeader lawyerColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView contractView;
        private System.Windows.Forms.ColumnHeader valueContract;
        private System.Windows.Forms.ColumnHeader valueEntrance;
        private System.Windows.Forms.ColumnHeader installments;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clientName;
        private System.Windows.Forms.ToolStripMenuItem editClient;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TreeView clientsTreeView;
        private System.Windows.Forms.ToolStripMenuItem removeClient;
        private System.Windows.Forms.ColumnHeader emailColumn;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView contractItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColumnHeader processNumberColumn;
        private System.Windows.Forms.Button button1;
    }
}
