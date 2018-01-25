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
            txt_Dias.Enabled=false;
            msk_Data2.Enabled=false;
            msk_DataDevolucao.Enabled = false;
        }
        private void txt_Dias_MouseMove(object sender, MouseEventArgs e)
        {
            txt_Dias.Enabled = true;
        }
        private void btn_Somar_Click(object sender, EventArgs e){
            dt1 = DateTime.Parse(msk_Data1.Text);
            int days = Convert.ToInt32(txt_Dias.Text);
            
            DateTime dt3 = dt1.AddDays(days);
            soma = String.Format("{0:dd/MM/yyyy}", dt3);

            msk_Data2.Text = soma;
            lbl_Resultados.Text = "O usuário " + txt_Nome.Text + " de código " + txt_Codigo.Text;
            lbl_Resultados2.Text = "Tem que devolver o livro na data " + soma;

            /*Esse botão serve para gerar a data de devolução a partir da data em que o livro foi pego e
              a partir do número de dias digitados*/
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

            /*Esse botão serve para mostrar o número de dias para devolução a partir das duas datas digitadas.
              Aqui foram dadas as condições para não haver enganos, mas alguns itens foram repetidos nas duas
              condições pois o Visual Studio dá erro se colocar depois dos "ifs"*/ 
        }

        private void btn_Devolucao_Click(object sender, EventArgs e)
        {
            dt1 = DateTime.Parse(msk_Data2.Text);
            dt2 = DateTime.Parse(msk_DataDevolucao.Text);

            int dia1 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", dt1)));
            int mes1 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", dt1)));
            int ano1 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", dt1)));

            /*Aqui se calcula o número de dias da data em que o livro tem que ser devolvido
              */

            int dia2 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", dt2)));
            int mes2 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", dt2)));
            int ano2 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", dt2)));

            /*Aqui se calcula o número de dias da data em que o livro foi devolvido
              */

            int resultado = (dia2 + mes2 + ano2) - (dia1 + mes1 + ano1);

            /*Aqui é gerado um número razoavelmente pequeno
              */

            if (resultado <= 0)
            {
                lbl_Resultados2.Text = "Devolveu dentro do prazo";
            }
            else if ((resultado > 0) && (resultado <= 7))
            {
                double multa = Math.Round((Convert.ToDouble((resultado * 2))), 2);
                lbl_Resultados2.ForeColor = System.Drawing.Color.Red;
                lbl_Resultados2.Text = "Não devolveu por " + resultado + " dia(s), e terá que pagar R$" + multa + ".";
            }
            else
            {
                double multa = Math.Round((Convert.ToDouble((resultado * 2))), 2);
                lbl_Resultados2.ForeColor = System.Drawing.Color.Red;
                lbl_Resultados2.Text = "Não devolveu por " + resultado + " dia(s), terá que pagar R$" + multa + " e terá a carteira anulada.";
            }

            /*Aqui se calcula se o usuário devolveu no prazo previsto, e quais são as multas e/ou punições que ele recebe
              */
        }

        private void btn_Conferir_Click(object sender, EventArgs e){
            dt1 = DateTime.Parse(msk_Data2.Text);
            lbl_Batata.Text = Convert.ToString(DateTime.Now);
            DateTime data_atual = DateTime.Parse(lbl_Batata.Text);

            /*Aqui gera a data atual, na qual uma label invisível receberá o valor
              */

            lbl_Resultados.Text = "O usuário " + txt_Nome.Text + " de código " + txt_Codigo.Text;
            lbl_Resultados2.Text = "";

            if (dt1 >= data_atual)
            {
                int dia1 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", dt1)));
                int mes1 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", dt1)));
                int ano1 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", dt1)));

                /*Aqui se calcula o número de dias da data em que o livro foi devolvido
              */

                int dia2 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", data_atual)));
                int mes2 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", data_atual)));
                int ano2 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", data_atual)));

                /*Aqui se calcula o número de dias da data atual
              */

                int resultado = (dia1 + mes1 + ano1) - (dia2 + mes2 + ano2);

                /*Aqui é gerado um número razoavelmente pequeno
              */                

                lbl_Resultados2.Text = "Está(ão) faltando " + resultado + " dia(s) para devolver o livro.";

                /*Aqui exibe a última parte da mensagem
              */
            }
            /*Esta condição serve para quando a data atual for maior ou igual à inicial
          */
            else if (data_atual > dt1)
            {
                int dia1 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", dt1)));
                int mes1 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", dt1)));
                int ano1 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", dt1)));

                /*Aqui se calcula o número de dias da data em que o livro foi devolvido
              */

                int dia2 = Convert.ToInt32(Convert.ToString(String.Format("{0:dd}", data_atual)));
                int mes2 = 30 * Convert.ToInt32(Convert.ToString(String.Format("{0:MM}", data_atual)));
                int ano2 = 365 * Convert.ToInt32(Convert.ToString(String.Format("{0:yyyy}", data_atual)));

                /*Aqui se calcula o número de dias da data atual
              */

                int resultado = (dia2 + mes2 + ano2) - (dia1 + mes1 + ano1);

                /*Aqui é gerado um número razoavelmente pequeno
              */
                lbl_Resultados2.ForeColor = System.Drawing.Color.Red;
                lbl_Resultados2.Text = "Está atrasado em " + resultado + " dias para devolver o livro.";

                /*Aqui exibe a última parte da mensagem
              */
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

            /*Aqui limpa todos os campos
              */
        }

        private void msk_Data2_MouseMove(object sender, MouseEventArgs e)
        {
            msk_Data2.Enabled = true;
        }

        private void msk_DataDevolucao_MouseMove(object sender, MouseEventArgs e)
        {
            msk_DataDevolucao.Enabled = true;
        }

       

        
    }
}
