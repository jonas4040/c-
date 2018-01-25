namespace _08_04_2015
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_NumAulas = new System.Windows.Forms.TextBox();
            this.txt_AulaVal = new System.Windows.Forms.TextBox();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.btn_Calculus = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Teacher Datas 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de aulas dadas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor da aula:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(142, 61);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(327, 20);
            this.txt_Name.TabIndex = 4;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_NumAulas
            // 
            this.txt_NumAulas.Location = new System.Drawing.Point(142, 95);
            this.txt_NumAulas.Name = "txt_NumAulas";
            this.txt_NumAulas.Size = new System.Drawing.Size(83, 20);
            this.txt_NumAulas.TabIndex = 5;
            this.txt_NumAulas.TextChanged += new System.EventHandler(this.txt_NumAulas_TextChanged);
            // 
            // txt_AulaVal
            // 
            this.txt_AulaVal.Location = new System.Drawing.Point(142, 129);
            this.txt_AulaVal.Name = "txt_AulaVal";
            this.txt_AulaVal.Size = new System.Drawing.Size(83, 20);
            this.txt_AulaVal.TabIndex = 6;
            this.txt_AulaVal.TextChanged += new System.EventHandler(this.txt_AulaVal_TextChanged);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Location = new System.Drawing.Point(17, 167);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(122, 30);
            this.btn_Ajuda.TabIndex = 7;
            this.btn_Ajuda.Text = "Ajuda";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            this.btn_Ajuda.Click += new System.EventHandler(this.btn_Ajuda_Click);
            // 
            // btn_Calculus
            // 
            this.btn_Calculus.Location = new System.Drawing.Point(145, 167);
            this.btn_Calculus.Name = "btn_Calculus";
            this.btn_Calculus.Size = new System.Drawing.Size(122, 30);
            this.btn_Calculus.TabIndex = 7;
            this.btn_Calculus.Text = "Processar dados";
            this.btn_Calculus.UseVisualStyleBackColor = true;
            this.btn_Calculus.Click += new System.EventHandler(this.btn_Calculus_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(273, 167);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(122, 30);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackgroundImage = global::_08_04_2015.Properties.Resources.exit_2_128;
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.Location = new System.Drawing.Point(429, 167);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(40, 30);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_08_04_2015.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 209);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculus);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.txt_AulaVal);
            this.Controls.Add(this.txt_NumAulas);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Teacher Datas 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_NumAulas;
        private System.Windows.Forms.TextBox txt_AulaVal;
        private System.Windows.Forms.Button btn_Ajuda;
        private System.Windows.Forms.Button btn_Calculus;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Sair;
    }
}

