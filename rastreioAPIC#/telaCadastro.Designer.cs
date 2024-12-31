namespace rastreioAPIC_
{
    partial class telaCadastro
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.codigoRastreio = new System.Windows.Forms.TextBox();
            this.destino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de rastreio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nomeProduto
            // 
            this.nomeProduto.Location = new System.Drawing.Point(23, 57);
            this.nomeProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(88, 20);
            this.nomeProduto.TabIndex = 3;
            this.nomeProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // codigoRastreio
            // 
            this.codigoRastreio.Location = new System.Drawing.Point(238, 57);
            this.codigoRastreio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoRastreio.Name = "codigoRastreio";
            this.codigoRastreio.Size = new System.Drawing.Size(94, 20);
            this.codigoRastreio.TabIndex = 4;
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(23, 143);
            this.destino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(88, 20);
            this.destino.TabIndex = 6;
            this.destino.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(230, 143);
            this.data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(102, 20);
            this.data.TabIndex = 8;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // telaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codigoRastreio);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "telaCadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.telaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.TextBox codigoRastreio;
        private System.Windows.Forms.TextBox destino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
    }
}