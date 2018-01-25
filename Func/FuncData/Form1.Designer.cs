namespace _25_03_2015_EXE1
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
            this.lbl_Dados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Salphour = new System.Windows.Forms.TextBox();
            this.txt_JobQt = new System.Windows.Forms.TextBox();
            this.btn_ShowSal = new System.Windows.Forms.Button();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TtlSell = new System.Windows.Forms.TextBox();
            this.txt_Codex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Dados
            // 
            this.lbl_Dados.AutoSize = true;
            this.lbl_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_Dados.Location = new System.Drawing.Point(12, 9);
            this.lbl_Dados.Name = "lbl_Dados";
            this.lbl_Dados.Size = new System.Drawing.Size(270, 31);
            this.lbl_Dados.TabIndex = 0;
            this.lbl_Dados.Text = "Dados do funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário p/ hora: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qtde. de horas trabalhadas: ";
            // 
            // txt_Name
            // 
            this.txt_Name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Name.Location = new System.Drawing.Point(163, 88);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(295, 20);
            this.txt_Name.TabIndex = 4;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_Salphour
            // 
            this.txt_Salphour.Location = new System.Drawing.Point(163, 123);
            this.txt_Salphour.Name = "txt_Salphour";
            this.txt_Salphour.Size = new System.Drawing.Size(295, 20);
            this.txt_Salphour.TabIndex = 5;
            this.txt_Salphour.TextChanged += new System.EventHandler(this.txt_Salphour_TextChanged);
            // 
            // txt_JobQt
            // 
            this.txt_JobQt.Location = new System.Drawing.Point(163, 157);
            this.txt_JobQt.Name = "txt_JobQt";
            this.txt_JobQt.Size = new System.Drawing.Size(295, 20);
            this.txt_JobQt.TabIndex = 6;
            this.txt_JobQt.TextChanged += new System.EventHandler(this.txt_JobQt_TextChanged);
            // 
            // btn_ShowSal
            // 
            this.btn_ShowSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ShowSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_ShowSal.Location = new System.Drawing.Point(317, 228);
            this.btn_ShowSal.Name = "btn_ShowSal";
            this.btn_ShowSal.Size = new System.Drawing.Size(141, 28);
            this.btn_ShowSal.TabIndex = 7;
            this.btn_ShowSal.Text = "Exibir salário";
            this.btn_ShowSal.UseVisualStyleBackColor = true;
            this.btn_ShowSal.Click += new System.EventHandler(this.btn_ShowSal_Click);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_Ajuda.Location = new System.Drawing.Point(163, 228);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(141, 28);
            this.btn_Ajuda.TabIndex = 8;
            this.btn_Ajuda.Text = "Ajuda";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            this.btn_Ajuda.Click += new System.EventHandler(this.btn_Ajuda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total vendido: ";
            // 
            // txt_TtlSell
            // 
            this.txt_TtlSell.Location = new System.Drawing.Point(163, 190);
            this.txt_TtlSell.Name = "txt_TtlSell";
            this.txt_TtlSell.Size = new System.Drawing.Size(295, 20);
            this.txt_TtlSell.TabIndex = 10;
            this.txt_TtlSell.TextChanged += new System.EventHandler(this.txt_TtlSell_TextChanged);
            // 
            // txt_Codex
            // 
            this.txt_Codex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Codex.Location = new System.Drawing.Point(163, 54);
            this.txt_Codex.Name = "txt_Codex";
            this.txt_Codex.Size = new System.Drawing.Size(295, 20);
            this.txt_Codex.TabIndex = 12;
            this.txt_Codex.TextChanged += new System.EventHandler(this.txt_Codex_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código do Funcionário: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 268);
            this.Controls.Add(this.txt_Codex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TtlSell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.btn_ShowSal);
            this.Controls.Add(this.txt_JobQt);
            this.Controls.Add(this.txt_Salphour);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Dados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Salphour;
        private System.Windows.Forms.TextBox txt_JobQt;
        private System.Windows.Forms.Button btn_ShowSal;
        private System.Windows.Forms.Button btn_Ajuda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TtlSell;
        private System.Windows.Forms.TextBox txt_Codex;
        private System.Windows.Forms.Label label5;
    }
}

