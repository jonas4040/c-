namespace _20_05_2015
{
    partial class Form1
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
            this.msk_Data1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.btn_Subtrair = new System.Windows.Forms.Button();
            this.btn_Conferir = new System.Windows.Forms.Button();
            this.btn_Devolucao = new System.Windows.Forms.Button();
            this.lbl_Resultados = new System.Windows.Forms.Label();
            this.lbl_dataatual = new System.Windows.Forms.Label();
            this.txt_Dias = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.msk_Data2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_DataDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Resultados2 = new System.Windows.Forms.Label();
            this.lbl_Batata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msk_Data1
            // 
            this.msk_Data1.Location = new System.Drawing.Point(227, 47);
            this.msk_Data1.Mask = "00/00/0000";
            this.msk_Data1.Name = "msk_Data1";
            this.msk_Data1.Size = new System.Drawing.Size(69, 20);
            this.msk_Data1.TabIndex = 0;
            this.msk_Data1.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data que o livro foi pego:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dias para devolver:";
            // 
            // btn_Somar
            // 
            this.btn_Somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Somar.Location = new System.Drawing.Point(12, 338);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(169, 25);
            this.btn_Somar.TabIndex = 2;
            this.btn_Somar.Text = "Gerar data de devolução";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // btn_Subtrair
            // 
            this.btn_Subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtrair.Location = new System.Drawing.Point(12, 369);
            this.btn_Subtrair.Name = "btn_Subtrair";
            this.btn_Subtrair.Size = new System.Drawing.Size(169, 25);
            this.btn_Subtrair.TabIndex = 2;
            this.btn_Subtrair.Text = "Gerar dias para devolver";
            this.btn_Subtrair.UseVisualStyleBackColor = true;
            this.btn_Subtrair.Click += new System.EventHandler(this.btn_Subtrair_Click);
            // 
            // btn_Conferir
            // 
            this.btn_Conferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conferir.Location = new System.Drawing.Point(187, 338);
            this.btn_Conferir.Name = "btn_Conferir";
            this.btn_Conferir.Size = new System.Drawing.Size(198, 25);
            this.btn_Conferir.TabIndex = 2;
            this.btn_Conferir.Text = "Conferir com a data atual";
            this.btn_Conferir.UseVisualStyleBackColor = true;
            this.btn_Conferir.Click += new System.EventHandler(this.btn_Conferir_Click);
            // 
            // btn_Devolucao
            // 
            this.btn_Devolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Devolucao.Location = new System.Drawing.Point(187, 369);
            this.btn_Devolucao.Name = "btn_Devolucao";
            this.btn_Devolucao.Size = new System.Drawing.Size(198, 25);
            this.btn_Devolucao.TabIndex = 2;
            this.btn_Devolucao.Text = "Confeir a data de devolução";
            this.btn_Devolucao.UseVisualStyleBackColor = true;
            this.btn_Devolucao.Click += new System.EventHandler(this.btn_Devolucao_Click);
            // 
            // lbl_Resultados
            // 
            this.lbl_Resultados.AllowDrop = true;
            this.lbl_Resultados.AutoSize = true;
            this.lbl_Resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultados.Location = new System.Drawing.Point(16, 180);
            this.lbl_Resultados.Name = "lbl_Resultados";
            this.lbl_Resultados.Size = new System.Drawing.Size(0, 16);
            this.lbl_Resultados.TabIndex = 4;
            // 
            // lbl_dataatual
            // 
            this.lbl_dataatual.AutoSize = true;
            this.lbl_dataatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_dataatual.Location = new System.Drawing.Point(16, 79);
            this.lbl_dataatual.Name = "lbl_dataatual";
            this.lbl_dataatual.Size = new System.Drawing.Size(202, 16);
            this.lbl_dataatual.TabIndex = 5;
            this.lbl_dataatual.Text = "Data que tem que ser devolvido:";
            // 
            // txt_Dias
            // 
            this.txt_Dias.Location = new System.Drawing.Point(227, 109);
            this.txt_Dias.Name = "txt_Dias";
            this.txt_Dias.Size = new System.Drawing.Size(69, 20);
            this.txt_Dias.TabIndex = 6;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Limpar.Location = new System.Drawing.Point(12, 400);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(78, 25);
            this.btn_Limpar.TabIndex = 8;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // msk_Data2
            // 
            this.msk_Data2.Location = new System.Drawing.Point(227, 78);
            this.msk_Data2.Mask = "00/00/0000";
            this.msk_Data2.Name = "msk_Data2";
            this.msk_Data2.Size = new System.Drawing.Size(69, 20);
            this.msk_Data2.TabIndex = 9;
            this.msk_Data2.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(70, 18);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(72, 20);
            this.txt_Nome.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(160, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Código: ";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(224, 18);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(72, 20);
            this.txt_Codigo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data que foi devolvido:";
            // 
            // msk_DataDevolucao
            // 
            this.msk_DataDevolucao.Location = new System.Drawing.Point(227, 141);
            this.msk_DataDevolucao.Mask = "00/00/0000";
            this.msk_DataDevolucao.Name = "msk_DataDevolucao";
            this.msk_DataDevolucao.Size = new System.Drawing.Size(69, 20);
            this.msk_DataDevolucao.TabIndex = 14;
            this.msk_DataDevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Resultados2
            // 
            this.lbl_Resultados2.AutoSize = true;
            this.lbl_Resultados2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_Resultados2.Location = new System.Drawing.Point(16, 215);
            this.lbl_Resultados2.Name = "lbl_Resultados2";
            this.lbl_Resultados2.Size = new System.Drawing.Size(0, 16);
            this.lbl_Resultados2.TabIndex = 15;
            // 
            // lbl_Batata
            // 
            this.lbl_Batata.AutoSize = true;
            this.lbl_Batata.Font = new System.Drawing.Font("Microsoft Sans Serif", 1E-05F);
            this.lbl_Batata.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Batata.Location = new System.Drawing.Point(327, 9);
            this.lbl_Batata.Name = "lbl_Batata";
            this.lbl_Batata.Size = new System.Drawing.Size(6, 2);
            this.lbl_Batata.TabIndex = 16;
            this.lbl_Batata.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 433);
            this.Controls.Add(this.lbl_Batata);
            this.Controls.Add(this.lbl_Resultados2);
            this.Controls.Add(this.msk_DataDevolucao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msk_Data2);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_Dias);
            this.Controls.Add(this.lbl_dataatual);
            this.Controls.Add(this.lbl_Resultados);
            this.Controls.Add(this.btn_Subtrair);
            this.Controls.Add(this.btn_Devolucao);
            this.Controls.Add(this.btn_Conferir);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_Data1);
            this.Name = "Form1";
            this.Text = "Date Datas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_Data1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Button btn_Subtrair;
        private System.Windows.Forms.Button btn_Conferir;
        private System.Windows.Forms.Button btn_Devolucao;
        private System.Windows.Forms.Label lbl_Resultados;
        private System.Windows.Forms.Label lbl_dataatual;
        private System.Windows.Forms.TextBox txt_Dias;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.MaskedTextBox msk_Data2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_DataDevolucao;
        private System.Windows.Forms.Label lbl_Resultados2;
        private System.Windows.Forms.Label lbl_Batata;
    }
}

