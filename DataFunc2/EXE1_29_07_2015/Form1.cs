using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXE1_29_07_2015
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int Num_horas_trab = Convert.ToInt32(txt_Nhtrab.Text);
            int Valor_hora = Convert.ToInt32(txt_valhora.Text);
            double Sal_bruto = Num_horas_trab * Valor_hora;
            double Desc_semanal;
            
            double INSS;
            double IRRF;
            double SalLiq;
            string Perc1;
            double Perc2;
            Desc_semanal = Sal_bruto * 0.2;         

            Sal_bruto += Desc_semanal;
            if (Sal_bruto <= 1399.12) {
                INSS = Sal_bruto * 0.08;
                Perc1 = "8%";
                Sal_bruto -= INSS;
            }
            else if (Sal_bruto >= 1399.13 && Sal_bruto <= 2331.88) {
                INSS = Sal_bruto * 0.09;
                Perc1 = "9%";
                Sal_bruto -= INSS;
            }
            else if (Sal_bruto >= 2331.89 && Sal_bruto <= 4663.75){
                INSS = Sal_bruto * 0.11;
                Perc1 = "11%";
                Sal_bruto -= INSS;
            }
            else {
                INSS = 0;
                Perc1 = "0%";
                Sal_bruto -= INSS;
            }

            

            if (Sal_bruto <= 1903.98) {
                IRRF =  0;
                Perc2 = 0;
                SalLiq = Sal_bruto - IRRF;
            }
            else if (Sal_bruto >= 1903.99 && Sal_bruto <= 2826.65){
                IRRF = Sal_bruto * 0.075 + 140.12;
                Perc2 = 7.5;
                SalLiq = Sal_bruto - IRRF;
            }
            else if (Sal_bruto >= 2826.66 && Sal_bruto <= 3751.05){
                IRRF = Sal_bruto * 0.15 + 350.11;
                Perc2 = 15;
                SalLiq = Sal_bruto - IRRF;
            }
            else if (Sal_bruto >= 3751.06 && Sal_bruto <= 4664.68){
                IRRF = Sal_bruto * 0.225 + 630.10;
                Perc2 = 22.5;
                SalLiq = Sal_bruto - IRRF;
            }else{
                IRRF = Sal_bruto * 0.275 + 863.33;
                Perc2 = 27.5;
                SalLiq = Sal_bruto - IRRF;
            }            
            
            //Aqui termina o processamento

            lbl_SalBR.Text += "R$"+Sal_bruto;
            lbl_INSS.Text += Perc1;
            lbl_IRRF.Text += Perc2 + "%";
            lbl_SalLIQ.Text += "R$"+SalLiq;

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Nome.Text = "";
            txt_Cargo.Text = "";
            txt_Nhtrab.Text = "";
            txt_valhora.Text = "";
            lbl_INSS.Text = "INSS: ";
            lbl_IRRF.Text = "IRRF: ";
            lbl_SalBR.Text = "Salário bruto: ";
            lbl_SalLIQ.Text = "Salário líquido: ";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
