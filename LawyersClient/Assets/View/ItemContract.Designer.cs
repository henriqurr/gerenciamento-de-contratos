namespace LawyersClient.Assets.View
{
    partial class ItemContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemContract));
            this.label3 = new System.Windows.Forms.Label();
            this.inputObject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPercent = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Objeto:";
            // 
            // inputObject
            // 
            this.inputObject.Location = new System.Drawing.Point(75, 19);
            this.inputObject.MaxLength = 50;
            this.inputObject.Name = "inputObject";
            this.inputObject.PlaceholderText = "Digite aqui";
            this.inputObject.Size = new System.Drawing.Size(268, 23);
            this.inputObject.TabIndex = 7;
            this.inputObject.TextChanged += new System.EventHandler(this.inputObject_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Porcentagem:";
            // 
            // inputPercent
            // 
            this.inputPercent.Location = new System.Drawing.Point(110, 58);
            this.inputPercent.MaxLength = 50;
            this.inputPercent.Name = "inputPercent";
            this.inputPercent.PlaceholderText = "Digite aqui";
            this.inputPercent.Size = new System.Drawing.Size(233, 23);
            this.inputPercent.TabIndex = 9;
            this.inputPercent.TextChanged += new System.EventHandler(this.inputPercent_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Location = new System.Drawing.Point(268, 95);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "Enviar";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ItemContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(365, 130);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputObject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item do contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPercent;
        private System.Windows.Forms.Button sendButton;
    }
}