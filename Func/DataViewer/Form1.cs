using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _25_03_2015_EXE2
{
    public partial class Form1 : Form
    {

        String nome;
        int Hrs_Trb;
        double Sal_Hour;

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            nome = txt_Name.Text;
        }

        private void txt_Salphour_TextChanged(object sender, EventArgs e)
        {
            Sal_Hour = Convert.ToDouble(txt_Salphour.Text);
        }

        private void txt_JobQt_TextChanged(object sender, EventArgs e)
        {
            Hrs_Trb = Convert.ToInt32(txt_JobQt.Text);
        }

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aprenda a usar o Data_Shower 2.0!!!!!!\n\nDigite seu nome, seu código, seu salário por hora e sua quantidade de horas trabalhadas.\n\nClicando no botão 'Exibir salário', será mostrado: o nome, o código e o salário líquido.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ShowSal_Click(object sender, EventArgs e)
        {
            double Sal_Brt = Convert.ToDouble(Math.Round(Sal_Hour * Hrs_Trb)), Sal_Liq;

            if (Sal_Brt <= 970){
                Sal_Liq = Sal_Brt * 0.9;
            }
            else {
                Sal_Liq = Sal_Brt * 0.85;
            }

            MessageBox.Show("Nome: " + nome + "\nSalário Bruto: R$" + Sal_Brt, "\nSalário Líquido: R$" + Sal_Liq, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

               
    }
}
