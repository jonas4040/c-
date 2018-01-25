using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08_04_2015
{
    public partial class Form1 : Form
    {

        String nome;
        int AulasDadas;
        double ValorAula, SalBrt, INSS, IRRF, SalLiq1, SalLiq2;

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e){
        }

        private void txt_NumAulas_TextChanged(object sender, EventArgs e){
        }

        private void txt_AulaVal_TextChanged(object sender, EventArgs e){
        }

        private void btn_Ajuda_Click(object sender, EventArgs e){
            MessageBox.Show("Aprenda a usar o Teacher Datas 1.0!!!!!!\n\nDigite seu nome, seu salário por aula e sua quantidade de aulas efetuadas.\n\nClicando no botão 'Processar dados', será mostrado: o nome, o salário bruto, os descontos do INSS, do IRRF e o salário líquido.\n\nVocê pode limpar os campos também usando o botão 'Limpar'.\n\nBom uso!!!", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Calculus_Click(object sender, EventArgs e){
            nome = txt_Name.Text;
            AulasDadas = Convert.ToInt32(txt_NumAulas.Text);
            ValorAula = Convert.ToInt32(txt_AulaVal.Text);

            SalBrt = ValorAula * AulasDadas * 4.5;

            if (SalBrt <= 1399.12) { 
                INSS = Math.Round((SalBrt * 0.08),2);
                SalLiq1 = SalBrt * 0.92;
            }else if((SalBrt > 1399.12)&&(SalBrt <=2331.88)){
                INSS = Math.Round((SalBrt * 0.09),2);
                SalLiq1 = SalBrt * 0.91;
            }
            else if ((SalBrt > 2331.88) && (SalBrt <= 4159)){
                INSS = Math.Round((SalBrt * 0.11),2);
                SalLiq1 = SalBrt * 0.89;
            }
            else {
                INSS = 513.01;
                SalLiq1 = SalBrt - 513.01;
            }

            if (SalLiq1 <= 1787.87) {
                SalLiq2 = SalLiq1;
            }else if ((SalLiq1 >= 1787.78) && (SalLiq1 <= 2679.29)){
                IRRF = Math.Round((SalLiq1 * 0.075),2);
                IRRF += 134.08;
                SalLiq2 = SalLiq1 - IRRF;
            }else if ((SalLiq1 >= 2679.3) && (SalLiq1 <= 3572.43)) {
                IRRF = Math.Round((SalLiq1 * 0.15),2);
                IRRF += 335.03;
                SalLiq2 = SalLiq1 - IRRF;
            }else if ((SalLiq1 >= 3572.44) && (SalLiq1 <= 4463.81)){
                IRRF = Math.Round((SalLiq1 * 0.225),2);
                IRRF += 602.96;
                SalLiq2 = SalLiq1 - IRRF;
            }else{
                IRRF = Math.Round((SalLiq1 * 0.275),2);
                IRRF += 826.15;
                SalLiq2 = SalLiq1 - IRRF;
            }

            MessageBox.Show("Nome do professor: "+nome+"\nSalário Bruto: R$"+SalBrt+"\nValor de Desconto do INSS: R$"+INSS+"\nValor de Desconto do IRRF: R$"+IRRF+"\nSalário Líquido: R$"+SalLiq2, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Clear_Click(object sender, EventArgs e){
            txt_Name.Text = "";
            txt_NumAulas.Text = "";
            txt_AulaVal.Text = "";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
