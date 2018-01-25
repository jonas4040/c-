using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _25_03_2015_EXE1
{
    public partial class Form1 : Form
    {

        String nome, cod;
        double SpH, SLiq, SBrut, TSell, Cmss;
        int HQtd;

        public Form1()
        {
            InitializeComponent();
        
       }
        
        private void txt_Codex_TextChanged(object sender, EventArgs e)
        {
            cod = txt_Codex.Text;
        }


        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            nome = txt_Name.Text;
        }

        
        private void txt_Salphour_TextChanged(object sender, EventArgs e)
        {
            SpH = Convert.ToDouble(txt_Salphour.Text);
        }

        private void txt_JobQt_TextChanged(object sender, EventArgs e)
        {
            HQtd = Convert.ToInt32(txt_JobQt.Text);
        }

        private void txt_TtlSell_TextChanged(object sender, EventArgs e)
        {
            TSell = Convert.ToDouble(txt_TtlSell.Text);
            if (TSell <= 2000){
                Cmss = 0;
            }
            else if ((TSell > 2000) && (TSell <= 6000)){
                Cmss = TSell * 0.10;
            }
            else {
                Cmss = TSell * 0.20;
            }
        }

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aprenda a usar o Data_Shower 2.0!!!!!!\n\nDigite seu nome, seu código, seu salário por hora e sua quantidade de horas trabalhadas.\n\nClicando no botão 'Exibir salário', será mostrado: o nome, o código e o salário líquido.","Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ShowSal_Click(object sender, EventArgs e)
        {
            SBrut = Convert.ToDouble(Math.Round(((SpH * HQtd) + Cmss), 2));
            if (SBrut <= 1200)
            {
                SLiq = Math.Round((SBrut * 0.85), 2);
            }
            else
            {
                SLiq = Math.Round(((SBrut * 0.75) - 130), 2);
            }

            MessageBox.Show("Nome: " + nome + "\nCódigo: " + cod + "\nSalário Líquido: R$" + SLiq, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
