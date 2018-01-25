namespace Interface_de_Software_Comercial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pct_Imagem = new System.Windows.Forms.PictureBox();
            this.btn_CarregarImagem = new System.Windows.Forms.Button();
            this.btn_LimparImagem = new System.Windows.Forms.Button();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdb_Fem = new System.Windows.Forms.RadioButton();
            this.rdb_Masc = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Twitter = new System.Windows.Forms.TextBox();
            this.txt_Facebook = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.chk_Twitter = new System.Windows.Forms.CheckBox();
            this.chk_Facebook = new System.Windows.Forms.CheckBox();
            this.chk_Email = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_TelCel = new System.Windows.Forms.MaskedTextBox();
            this.txt_TelRes = new System.Windows.Forms.MaskedTextBox();
            this.txt_RG = new System.Windows.Forms.MaskedTextBox();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.txt_CEP = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Imagem)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CPF);
            this.groupBox1.Controls.Add(this.txt_RG);
            this.groupBox1.Controls.Add(this.txt_TelRes);
            this.groupBox1.Controls.Add(this.txt_TelCel);
            this.groupBox1.Controls.Add(this.pct_Imagem);
            this.groupBox1.Controls.Add(this.btn_CarregarImagem);
            this.groupBox1.Controls.Add(this.btn_LimparImagem);
            this.groupBox1.Controls.Add(this.txt_Codigo);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais:";
            // 
            // pct_Imagem
            // 
            this.pct_Imagem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pct_Imagem.Location = new System.Drawing.Point(486, 14);
            this.pct_Imagem.Name = "pct_Imagem";
            this.pct_Imagem.Size = new System.Drawing.Size(141, 151);
            this.pct_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Imagem.TabIndex = 6;
            this.pct_Imagem.TabStop = false;
            // 
            // btn_CarregarImagem
            // 
            this.btn_CarregarImagem.Location = new System.Drawing.Point(633, 14);
            this.btn_CarregarImagem.Name = "btn_CarregarImagem";
            this.btn_CarregarImagem.Size = new System.Drawing.Size(114, 70);
            this.btn_CarregarImagem.TabIndex = 7;
            this.btn_CarregarImagem.Text = "Carregar Imagem";
            this.btn_CarregarImagem.UseVisualStyleBackColor = true;
            this.btn_CarregarImagem.Click += new System.EventHandler(this.btn_CarregarImagem_Click);
            // 
            // btn_LimparImagem
            // 
            this.btn_LimparImagem.Location = new System.Drawing.Point(633, 95);
            this.btn_LimparImagem.Name = "btn_LimparImagem";
            this.btn_LimparImagem.Size = new System.Drawing.Size(114, 70);
            this.btn_LimparImagem.TabIndex = 8;
            this.btn_LimparImagem.Text = "Limpar Imagem";
            this.btn_LimparImagem.UseVisualStyleBackColor = true;
            this.btn_LimparImagem.Click += new System.EventHandler(this.btn_LimparImagem_Click);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(63, 19);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(107, 20);
            this.txt_Codigo.TabIndex = 3;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(63, 45);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(417, 20);
            this.txt_Nome.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdb_Fem);
            this.groupBox4.Controls.Add(this.rdb_Masc);
            this.groupBox4.Location = new System.Drawing.Point(6, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 42);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexo:";
            // 
            // rdb_Fem
            // 
            this.rdb_Fem.AutoSize = true;
            this.rdb_Fem.Location = new System.Drawing.Point(97, 19);
            this.rdb_Fem.Name = "rdb_Fem";
            this.rdb_Fem.Size = new System.Drawing.Size(67, 17);
            this.rdb_Fem.TabIndex = 1;
            this.rdb_Fem.Text = "Feminino";
            this.rdb_Fem.UseVisualStyleBackColor = true;
            // 
            // rdb_Masc
            // 
            this.rdb_Masc.AutoSize = true;
            this.rdb_Masc.Location = new System.Drawing.Point(6, 19);
            this.rdb_Masc.Name = "rdb_Masc";
            this.rdb_Masc.Size = new System.Drawing.Size(73, 17);
            this.rdb_Masc.TabIndex = 0;
            this.rdb_Masc.Text = "Masculino";
            this.rdb_Masc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tel. Residencial:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tel. Celular:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "C.P.F.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "R.G.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_CEP);
            this.groupBox2.Controls.Add(this.txt_Estado);
            this.groupBox2.Controls.Add(this.txt_Bairro);
            this.groupBox2.Controls.Add(this.txt_Cidade);
            this.groupBox2.Controls.Add(this.txt_Numero);
            this.groupBox2.Controls.Add(this.txt_Logradouro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(567, 49);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(158, 20);
            this.txt_Estado.TabIndex = 7;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(141, 49);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(158, 20);
            this.txt_Bairro.TabIndex = 6;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(354, 49);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(158, 20);
            this.txt_Cidade.TabIndex = 5;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(59, 49);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(33, 20);
            this.txt_Numero.TabIndex = 4;
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Location = new System.Drawing.Point(268, 22);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(457, 20);
            this.txt_Logradouro.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Logradouro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(518, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Twitter);
            this.groupBox3.Controls.Add(this.txt_Facebook);
            this.groupBox3.Controls.Add(this.txt_Email);
            this.groupBox3.Controls.Add(this.chk_Twitter);
            this.groupBox3.Controls.Add(this.chk_Facebook);
            this.groupBox3.Controls.Add(this.chk_Email);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 98);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Extras";
            // 
            // txt_Twitter
            // 
            this.txt_Twitter.Enabled = false;
            this.txt_Twitter.Location = new System.Drawing.Point(70, 72);
            this.txt_Twitter.Name = "txt_Twitter";
            this.txt_Twitter.Size = new System.Drawing.Size(599, 20);
            this.txt_Twitter.TabIndex = 4;
            // 
            // txt_Facebook
            // 
            this.txt_Facebook.Enabled = false;
            this.txt_Facebook.Location = new System.Drawing.Point(70, 45);
            this.txt_Facebook.Name = "txt_Facebook";
            this.txt_Facebook.Size = new System.Drawing.Size(599, 20);
            this.txt_Facebook.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Location = new System.Drawing.Point(70, 19);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(599, 20);
            this.txt_Email.TabIndex = 2;
            // 
            // chk_Twitter
            // 
            this.chk_Twitter.AutoSize = true;
            this.chk_Twitter.Location = new System.Drawing.Point(675, 74);
            this.chk_Twitter.Name = "chk_Twitter";
            this.chk_Twitter.Size = new System.Drawing.Size(58, 17);
            this.chk_Twitter.TabIndex = 1;
            this.chk_Twitter.Text = "Twitter";
            this.chk_Twitter.UseVisualStyleBackColor = true;
            this.chk_Twitter.CheckedChanged += new System.EventHandler(this.chk_Twitter_CheckedChanged);
            // 
            // chk_Facebook
            // 
            this.chk_Facebook.AutoSize = true;
            this.chk_Facebook.Location = new System.Drawing.Point(675, 47);
            this.chk_Facebook.Name = "chk_Facebook";
            this.chk_Facebook.Size = new System.Drawing.Size(74, 17);
            this.chk_Facebook.TabIndex = 1;
            this.chk_Facebook.Text = "Facebook";
            this.chk_Facebook.UseVisualStyleBackColor = true;
            this.chk_Facebook.CheckedChanged += new System.EventHandler(this.chk_Facebook_CheckedChanged);
            // 
            // chk_Email
            // 
            this.chk_Email.AutoSize = true;
            this.chk_Email.Location = new System.Drawing.Point(675, 19);
            this.chk_Email.Name = "chk_Email";
            this.chk_Email.Size = new System.Drawing.Size(55, 17);
            this.chk_Email.TabIndex = 1;
            this.chk_Email.Text = "E-Mail";
            this.chk_Email.UseVisualStyleBackColor = true;
            this.chk_Email.CheckedChanged += new System.EventHandler(this.chk_Email_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Twitter:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Facebook:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-Mail:";
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(12, 421);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(118, 52);
            this.btn_Incluir.TabIndex = 3;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(136, 421);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(128, 52);
            this.btn_Alterar.TabIndex = 4;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(270, 421);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(121, 52);
            this.btn_Consultar.TabIndex = 5;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(397, 421);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(122, 52);
            this.btn_Excluir.TabIndex = 6;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(525, 421);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(118, 52);
            this.btn_Limpar.TabIndex = 7;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(649, 421);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(118, 52);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(264, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(299, 37);
            this.label16.TabIndex = 9;
            this.label16.Text = "Cadastro de Cliente";
            // 
            // txt_TelCel
            // 
            this.txt_TelCel.Location = new System.Drawing.Point(324, 97);
            this.txt_TelCel.Mask = "(999) 00000-0000";
            this.txt_TelCel.Name = "txt_TelCel";
            this.txt_TelCel.Size = new System.Drawing.Size(156, 20);
            this.txt_TelCel.TabIndex = 9;
            // 
            // txt_TelRes
            // 
            this.txt_TelRes.Location = new System.Drawing.Point(98, 97);
            this.txt_TelRes.Mask = "(999) 0000-0000";
            this.txt_TelRes.Name = "txt_TelRes";
            this.txt_TelRes.Size = new System.Drawing.Size(151, 20);
            this.txt_TelRes.TabIndex = 2;
            // 
            // txt_RG
            // 
            this.txt_RG.Location = new System.Drawing.Point(63, 71);
            this.txt_RG.Mask = "99,999,999-9";
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(186, 20);
            this.txt_RG.TabIndex = 10;
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(305, 71);
            this.txt_CPF.Mask = "999,999,999-99";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(175, 20);
            this.txt_CPF.TabIndex = 11;
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(43, 23);
            this.txt_CEP.Mask = "99999-999";
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(149, 20);
            this.txt_CEP.TabIndex = 8;
            this.txt_CEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_CEP_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 482);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Imagem)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdb_Fem;
        private System.Windows.Forms.RadioButton rdb_Masc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_LimparImagem;
        private System.Windows.Forms.Button btn_CarregarImagem;
        private System.Windows.Forms.PictureBox pct_Imagem;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Twitter;
        private System.Windows.Forms.TextBox txt_Facebook;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.CheckBox chk_Twitter;
        private System.Windows.Forms.CheckBox chk_Facebook;
        private System.Windows.Forms.CheckBox chk_Email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txt_TelCel;
        private System.Windows.Forms.MaskedTextBox txt_TelRes;
        private System.Windows.Forms.MaskedTextBox txt_RG;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.MaskedTextBox txt_CEP;
    }
}

