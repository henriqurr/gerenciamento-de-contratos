namespace LawyersClient.Assets.View
{
    partial class Insert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert));
            this.label1 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputProcessNumber = new System.Windows.Forms.TextBox();
            this.valueFinalPercent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.valueFinalText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.installmentsValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputInstallments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputEntrance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputLawyer = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contractItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeClient = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(55, 27);
            this.inputName.MaxLength = 50;
            this.inputName.Name = "inputName";
            this.inputName.PlaceholderText = "Ex.: João da Silva";
            this.inputName.Size = new System.Drawing.Size(279, 23);
            this.inputName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(51, 107);
            this.inputEmail.MaxLength = 50;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.PlaceholderText = "Ex.: email@provedor.com";
            this.inputEmail.Size = new System.Drawing.Size(283, 23);
            this.inputEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(66, 67);
            this.inputPhone.MaxLength = 15;
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.PlaceholderText = "Digite aqui (apenas números)";
            this.inputPhone.Size = new System.Drawing.Size(268, 23);
            this.inputPhone.TabIndex = 2;
            this.inputPhone.Leave += new System.EventHandler(this.inputPhone_Leave);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(730, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.inputProcessNumber);
            this.groupBox2.Controls.Add(this.valueFinalPercent);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.valueFinalText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.installmentsValue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.inputInstallments);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.inputEntrance);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.inputValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.inputLawyer);
            this.groupBox2.Location = new System.Drawing.Point(358, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 189);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Contrato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "N° do processo:";
            // 
            // inputProcessNumber
            // 
            this.inputProcessNumber.Location = new System.Drawing.Point(326, 27);
            this.inputProcessNumber.MaxLength = 50;
            this.inputProcessNumber.Name = "inputProcessNumber";
            this.inputProcessNumber.PlaceholderText = "Digite aqui";
            this.inputProcessNumber.Size = new System.Drawing.Size(112, 23);
            this.inputProcessNumber.TabIndex = 5;
            this.inputProcessNumber.TextChanged += new System.EventHandler(this.inputProcessNumber_Leave);
            // 
            // valueFinalPercent
            // 
            this.valueFinalPercent.Location = new System.Drawing.Point(386, 151);
            this.valueFinalPercent.MaxLength = 50;
            this.valueFinalPercent.Name = "valueFinalPercent";
            this.valueFinalPercent.PlaceholderText = "0%";
            this.valueFinalPercent.ReadOnly = true;
            this.valueFinalPercent.Size = new System.Drawing.Size(52, 23);
            this.valueFinalPercent.TabIndex = 12;
            this.valueFinalPercent.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Valor final (somando todos os items da divisão):";
            // 
            // valueFinalText
            // 
            this.valueFinalText.Location = new System.Drawing.Point(277, 151);
            this.valueFinalText.MaxLength = 50;
            this.valueFinalText.Name = "valueFinalText";
            this.valueFinalText.PlaceholderText = "R$ 0,00";
            this.valueFinalText.ReadOnly = true;
            this.valueFinalText.Size = new System.Drawing.Size(103, 23);
            this.valueFinalText.TabIndex = 11;
            this.valueFinalText.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Valor das parcelas:";
            // 
            // installmentsValue
            // 
            this.installmentsValue.Location = new System.Drawing.Point(341, 107);
            this.installmentsValue.MaxLength = 50;
            this.installmentsValue.Name = "installmentsValue";
            this.installmentsValue.PlaceholderText = "R$ 0,00";
            this.installmentsValue.ReadOnly = true;
            this.installmentsValue.Size = new System.Drawing.Size(97, 23);
            this.installmentsValue.TabIndex = 9;
            this.installmentsValue.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Parcelas:";
            // 
            // inputInstallments
            // 
            this.inputInstallments.Location = new System.Drawing.Point(65, 107);
            this.inputInstallments.MaxLength = 2;
            this.inputInstallments.Name = "inputInstallments";
            this.inputInstallments.PlaceholderText = "Quantidade de Parcelas";
            this.inputInstallments.ReadOnly = true;
            this.inputInstallments.Size = new System.Drawing.Size(147, 23);
            this.inputInstallments.TabIndex = 7;
            this.inputInstallments.TabStop = false;
            this.inputInstallments.TextChanged += new System.EventHandler(this.inputInstallments_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Entrada:";
            // 
            // inputEntrance
            // 
            this.inputEntrance.Location = new System.Drawing.Point(288, 67);
            this.inputEntrance.MaxLength = 50;
            this.inputEntrance.Name = "inputEntrance";
            this.inputEntrance.PlaceholderText = "Digite aqui";
            this.inputEntrance.ReadOnly = true;
            this.inputEntrance.Size = new System.Drawing.Size(150, 23);
            this.inputEntrance.TabIndex = 5;
            this.inputEntrance.TabStop = false;
            this.inputEntrance.TextChanged += new System.EventHandler(this.inputEntrance_TextChanged);
            this.inputEntrance.Leave += new System.EventHandler(this.inputEntrance_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor:";
            // 
            // inputValue
            // 
            this.inputValue.Location = new System.Drawing.Point(48, 66);
            this.inputValue.MaxLength = 50;
            this.inputValue.Name = "inputValue";
            this.inputValue.PlaceholderText = "Digite aqui";
            this.inputValue.ReadOnly = true;
            this.inputValue.Size = new System.Drawing.Size(164, 23);
            this.inputValue.TabIndex = 3;
            this.inputValue.TabStop = false;
            this.inputValue.TextChanged += new System.EventHandler(this.inputValue_TextChanged);
            this.inputValue.Leave += new System.EventHandler(this.inputValue_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Advogado:";
            // 
            // inputLawyer
            // 
            this.inputLawyer.Location = new System.Drawing.Point(77, 27);
            this.inputLawyer.MaxLength = 50;
            this.inputLawyer.Name = "inputLawyer";
            this.inputLawyer.PlaceholderText = "Ex.: João da Silva";
            this.inputLawyer.Size = new System.Drawing.Size(135, 23);
            this.inputLawyer.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.contractItems);
            this.groupBox3.Location = new System.Drawing.Point(12, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(793, 242);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Divisão de Contrato";
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
            this.contractItems.HideSelection = false;
            this.contractItems.Location = new System.Drawing.Point(6, 18);
            this.contractItems.Name = "contractItems";
            this.contractItems.Size = new System.Drawing.Size(778, 214);
            this.contractItems.TabIndex = 1;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientName,
            this.toolStripMenuItem1,
            this.removeClient});
            this.contextMenuStrip1.Name = "menuStrip";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 70);
            // 
            // clientName
            // 
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(125, 22);
            this.clientName.Text = "Adicionar";
            this.clientName.Click += new System.EventHandler(this.clientName_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem1.Text = "Editar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // removeClient
            // 
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(125, 22);
            this.removeClient.Text = "Remover";
            this.removeClient.Click += new System.EventHandler(this.removeClient_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(815, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Insert_FormClosed);
            this.Load += new System.EventHandler(this.Insert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputEntrance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputLawyer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox installmentsValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputInstallments;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView contractItems;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox valueFinalPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox valueFinalText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeClient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputProcessNumber;
    }
}