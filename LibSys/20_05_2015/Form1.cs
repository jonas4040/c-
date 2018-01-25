using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20_05_2015
{
    public partial class Form1 : Form
    {
        DateTime dt1, dt2;
        int meses, anos;
        String soma, subtracao, registro1, registro2, r_dias, r_meses, r_anos;

        public Form1()
        {
            InitializeComponent();           
        }

        private void btn_Somar_Click(object sender, EventArgs e){
            dt1 = DateTime.Parse(msk_Data1.Text);
            int days = Convert.ToInt32(txt_Dias.Text);
            
            DateTime dt3 = dt1.AddDays(days);
            soma = String.Format("{0:dd/MM/yyyy}", dt3);

            msk_Data2.Text = soma;
            lbl_Resultados.Text = "O usuário " + txt_Nome.Text + " de código " + txt_Codigo.Text;
            lbl_Resultados2.Text = "Tem que devolver o livro na data " + soma;
        }

        private void btn_Subtrair_Click(object sender, EventArgs e){
            dt1 = DateTime.Parse(msk_Data1.Text);
            dt2 = DateTime.Parse(msk_Data2.Text);

            lbl_Resultados.Text = "O usuário " + txt_Nome.Text + " de código " + txt_Codigo.Text;

            if ((dt1 > dt2) || (dt1 == dt2)){
                TimeSpan dt3 = dt1 - dt2;
                r_dias = String.Format("{0:dd}", dt3);                
                lbl_Resultados2.Text = "Tem que devolver o livro daqui a " + r_dias + " dias.";

                txt_Dias.Text = r_dias;
            }
            else if (dt2 > dt1){
                TimeSpan dt3 = dt2 - dt1;
                r_dias = String.Format("{0:dd}", dt3);
                lbl_Resultados2.Text = "Tem que devolver o livro daqui a " + r_dias + " dias.";

                txt_Dias.Text = r_dias;
            }                       
        }

        private void btn_Conferir_Click(object sender, EventArgs e){
            dt1 = DateTime.Parse(msk_Data2.Text);
            lbl_Batata.Text = Convert.ToString(DateTime.Now);
            DateTime data_atual = DateTime.Parse(lbl_Batata.Text);

            if (dt1 >= data_atual)
            {
                int dia1 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", dt1)));
                int mes1 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", dt1)));
                int ano1 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", dt1)));

                int dia2 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", data_atual)));
                int mes2 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", data_atual)));
                int ano2 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", data_atual)));

                int resultado = (dia1 + mes1 + ano1) - (dia2 + mes2 + ano2);

                lbl_Resultados.Text = "O usuário " + txt_Nome.Text + " de código " + txt_Codigo.Text;
                lbl_Resultados2.Text = "";

                lbl_Resultados2.Text = "Está faltando " + resultado + " dias para devolver o livro.";
            }
            else if (data_atual > dt1)
            {
                int dia1 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", dt1)));
                int mes1 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", dt1)));
                int ano1 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", dt1)));

                int dia2 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", data_atual)));
                int mes2 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", data_atual)));
                int ano2 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", data_atual)));

                int resultado = (dia2 + mes2 + ano2) - (dia1 + mes1 + ano1);

                lbl_Resultados2.Text = "Está atrasado em " + resultado + " dias para devolver o livro.";
            }
        }        

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            msk_Data1.Text = "";
            msk_Data2.Text = "";
            txt_Dias.Text = "";
            txt_Nome.Text = "";
            txt_Codigo.Text = "";
            lbl_Resultados.Text = "";
            lbl_Resultados2.Text = "";
            msk_DataDevolucao.Text = "";
        }

        private void btn_Devolucao_Click(object sender, EventArgs e)
        {
            dt1 = DateTime.Parse(msk_Data2.Text);
            dt2 = DateTime.Parse(msk_DataDevolucao.Text);

            int dia1 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", dt1)));
            int mes1 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", dt1)));
            int ano1 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", dt1)));

            int dia2 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", dt2)));
            int mes2 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", dt2)));
            int ano2 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", dt2)));

            int resultado = (dia2 + mes2 + ano2) - (dia1 + mes1 + ano1);            

            if (resultado <= 0 )
            {
                lbl_Resultados2.Text = "Devolveu dentro do prazo";
            }
            else if ((resultado > 0) && (resultado <= 7))
            {
                double multa = Math.Round((Convert.ToDouble((resultado * 2))), 2);
                lbl_Resultados2.Text = "Não devolveu por " + resultado + " dia(s), e terá que pagar R$" + multa + ".";
            }
            else {
                double multa = Math.Round((Convert.ToDouble((resultado * 2))), 2);
                lbl_Resultados2.Text = "Não devolveu por " + resultado + " dia(s), terá que pagar R$" + multa + " e terá a carteira anulada.";
            }
        }
    }
}
