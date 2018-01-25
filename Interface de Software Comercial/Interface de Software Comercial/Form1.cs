using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interface_de_Software_Comercial
{
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
        }

        private void chk_Email_CheckedChanged(object sender, EventArgs e){
            if (chk_Email.Checked == true){
                txt_Email.Enabled = true;
            } else {
                txt_Email.Enabled = false;
            }
        }

        private void chk_Facebook_CheckedChanged(object sender, EventArgs e){
            if (chk_Facebook.Checked == true){
                txt_Facebook.Enabled = true;
            }else{
                txt_Facebook.Enabled = false;
            }
        }

        private void chk_Twitter_CheckedChanged(object sender, EventArgs e){
            if (chk_Twitter.Checked == true){
                txt_Twitter.Enabled = true;
            } else {
                txt_Twitter.Enabled = false;
            }
        }

        private void btn_CarregarImagem_Click(object sender, EventArgs e){
            pct_Imagem.Image = Interface_de_Software_Comercial.Properties.Resources.Saitama;
        }

        private void btn_LimparImagem_Click(object sender, EventArgs e){
            pct_Imagem.Image = null;
        }

        private void btn_Sair_Click(object sender, EventArgs e){
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e){
            txt_Codigo.Text = "";
            txt_Nome.Text = "";
            txt_RG.Text = "";
            txt_CPF.Text = "";
            txt_TelRes.Text = "";
            txt_TelCel.Text = "";
            rdb_Fem.Checked = false;
            rdb_Masc.Checked = false;
            txt_CEP.Text = "";
            txt_Logradouro.Text = "";
            txt_Numero.Text = "";
            txt_Bairro.Text = "";
            txt_Cidade.Text = "";
            txt_Estado.Text = "";
            txt_Email.Text = "";
            txt_Facebook.Text = "";
            txt_Twitter.Text = "";
            chk_Email.Checked = false;
            chk_Facebook.Checked = false;
            chk_Twitter.Checked = false;
            txt_Email.Enabled = false;
            txt_Facebook.Enabled = false;
            txt_Twitter.Enabled = false;
            pct_Imagem.Image = null;
        }

        private void btn_Incluir_Click(object sender, EventArgs e){
            txt_Codigo.Text = "SUPER-01";
            txt_Nome.Text = "Saitama";
            txt_RG.Text = "12000205-95";
            txt_CPF.Text = "12.309.805-85";
            txt_TelRes.Text = "(011) 6637-8624";
            txt_TelCel.Text = "(011) 98637-8644";
            rdb_Fem.Checked = false;
            rdb_Masc.Checked = true;
            txt_CEP.Text = "13-206-935";
            txt_Logradouro.Text = "Rua Saitama";
            txt_Numero.Text = "52";
            txt_Bairro.Text = "Bairro 1";
            txt_Cidade.Text = "Cidade Z";
            txt_Estado.Text = "Estado SS";
            txt_Email.Text = "saitama@gmail.com";
            txt_Facebook.Text = "facebook.com/sait_onepunch";
            txt_Twitter.Text = "@onepunch_man";
            chk_Email.Checked = true;
            chk_Facebook.Checked = true;
            chk_Twitter.Checked = true;
            txt_Email.Enabled = true;
            txt_Facebook.Enabled = true;
            txt_Twitter.Enabled = true;
            pct_Imagem.Image = Interface_de_Software_Comercial.Properties.Resources.Saitama;
        }

        private void btn_Consultar_Click(object sender, EventArgs e){
            if ((txt_Codigo.Text != "") && (txt_Nome.Text != "") && (txt_RG.Text != "") && (txt_CPF.Text != "") && (txt_TelRes.Text != "") && (txt_TelCel.Text != "") && ((rdb_Fem.Checked == true) || (rdb_Masc.Checked == true)) && (txt_CEP.Text != "") && (txt_Logradouro.Text != "") && (txt_Numero.Text != "") && (txt_Bairro.Text != "") && (txt_Cidade.Text != "") && (txt_Estado.Text != "")){
                
                string message = "Código: " + txt_Codigo.Text + "\nNome: " + txt_Nome.Text + "\nR.G.: " + txt_RG.Text + "\nC.P.F.: " + txt_CPF.Text + "\nTelefone Residencial: " + txt_TelRes.Text + "\nTelefone Celular: " + txt_TelCel.Text;

                if (rdb_Masc.Checked == true){
                    message += "\nSexo: Masculino" + "\nCEP: " + txt_CEP.Text + "\nLogradouro: " + txt_Logradouro.Text + "\nNúmero: " + txt_Numero.Text + "\nBairro: " + txt_Bairro.Text + "\nCidade: " + txt_Cidade.Text + "\nEstado: " + txt_Estado.Text;
                }

                if (rdb_Fem.Checked == true){
                    message += "\nSexo: Feminino" + "\nCEP: " + txt_CEP.Text + "\nLogradouro: " + txt_Logradouro.Text + "\nNúmero: " + txt_Numero.Text + "\nBairro: " + txt_Bairro.Text + "\nCidade: " + txt_Cidade.Text + "\nEstado: " + txt_Estado.Text;
                }

                if (chk_Email.Checked == true && txt_Email.Text != ""){
                    message += "\nE-Mail: " + txt_Email.Text;
                }

                if (chk_Facebook.Checked == true && txt_Facebook.Text != ""){
                    message += "\nFacebook: " + txt_Facebook.Text;
                }

                if (chk_Twitter.Checked == true && txt_Twitter.Text != ""){
                    message += "\nTwitter: " + txt_Twitter.Text;
                }

                MessageBox.Show(message, "Dados cadastrais");

            } else {
                MessageBox.Show("Estão faltando dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_CEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
