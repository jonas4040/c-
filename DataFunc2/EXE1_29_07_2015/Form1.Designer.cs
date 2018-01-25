namespace EXE1_29_07_2015
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_SalBR = new System.Windows.Forms.Label();
            this.lbl_INSS = new System.Windows.Forms.Label();
            this.lbl_SalLIQ = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.txt_Nhtrab = new System.Windows.Forms.TextBox();
            this.txt_valhora = new System.Windows.Forms.TextBox();
            this.lbl_IRRF = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(243, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Dados do funcionário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número de horas trabalhadas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor da hora: ";
            // 
            // lbl_SalBR
            // 
            this.lbl_SalBR.AutoSize = true;
            this.lbl_SalBR.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_SalBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalBR.Location = new System.Drawing.Point(12, 194);
            this.lbl_SalBR.Name = "lbl_SalBR";
            this.lbl_SalBR.Size = new System.Drawing.Size(100, 18);
            this.lbl_SalBR.TabIndex = 1;
            this.lbl_SalBR.Text = "Salário bruto: ";
            // 
            // lbl_INSS
            // 
            this.lbl_INSS.AutoSize = true;
            this.lbl_INSS.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_INSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_INSS.Location = new System.Drawing.Point(12, 231);
            this.lbl_INSS.Name = "lbl_INSS";
            this.lbl_INSS.Size = new System.Drawing.Size(46, 18);
            this.lbl_INSS.TabIndex = 1;
            this.lbl_INSS.Text = "INSS:";
            // 
            // lbl_SalLIQ
            // 
            this.lbl_SalLIQ.AutoSize = true;
            this.lbl_SalLIQ.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_SalLIQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalLIQ.Location = new System.Drawing.Point(12, 264);
            this.lbl_SalLIQ.Name = "lbl_SalLIQ";
            this.lbl_SalLIQ.Size = new System.Drawing.Size(104, 18);
            this.lbl_SalLIQ.TabIndex = 1;
            this.lbl_SalLIQ.Text = "Salário líquido:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(226, 58);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(267, 20);
            this.txt_Nome.TabIndex = 2;
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Location = new System.Drawing.Point(226, 90);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(267, 20);
            this.txt_Cargo.TabIndex = 3;
            // 
            // txt_Nhtrab
            // 
            this.txt_Nhtrab.Location = new System.Drawing.Point(226, 124);
            this.txt_Nhtrab.Name = "txt_Nhtrab";
            this.txt_Nhtrab.Size = new System.Drawing.Size(55, 20);
            this.txt_Nhtrab.TabIndex = 4;
            // 
            // txt_valhora
            // 
            this.txt_valhora.Location = new System.Drawing.Point(226, 159);
            this.txt_valhora.Name = "txt_valhora";
            this.txt_valhora.Size = new System.Drawing.Size(55, 20);
            this.txt_valhora.TabIndex = 5;
            // 
            // lbl_IRRF
            // 
            this.lbl_IRRF.AutoSize = true;
            this.lbl_IRRF.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_IRRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IRRF.Location = new System.Drawing.Point(223, 231);
            this.lbl_IRRF.Name = "lbl_IRRF";
            this.lbl_IRRF.Size = new System.Drawing.Size(46, 18);
            this.lbl_IRRF.TabIndex = 1;
            this.lbl_IRRF.Text = "IRRF:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(165, 291);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(116, 35);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(287, 291);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(116, 35);
            this.btn_Novo.TabIndex = 7;
            this.btn_Novo.Text = "NOVO";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(409, 291);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(116, 35);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 338);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_valhora);
            this.Controls.Add(this.txt_Nhtrab);
            this.Controls.Add(this.txt_Cargo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_SalLIQ);
            this.Controls.Add(this.lbl_IRRF);
            this.Controls.Add(this.lbl_INSS);
            this.Controls.Add(this.lbl_SalBR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_SalBR;
        private System.Windows.Forms.Label lbl_INSS;
        private System.Windows.Forms.Label lbl_SalLIQ;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Cargo;
        private System.Windows.Forms.TextBox txt_Nhtrab;
        private System.Windows.Forms.TextBox txt_valhora;
        private System.Windows.Forms.Label lbl_IRRF;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Sair;
    }
}

