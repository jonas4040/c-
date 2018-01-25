using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bdCapacitacao
{
    public partial class form_Principal : Form
    {

        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;

        string strSql;


        public form_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                objCnx.ConnectionString = "Server='localhost'; Database='bdCapacitacao'; User='root'; Pwd='root'";
                objCnx.Open();
            }
            catch (Exception Erro) {
                MessageBox.Show("Erro ==> "+Erro.Message);
            }
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            if(txt_Codigo.Text != "" && txt_Nome.Text != "" && txt_Email.Text != "" && txt_Telefone.Text != "" && txt_CPF.Text != ""){
            try {

                strSql = "SELECT * FROM Agenda WHERE id = " + txt_Codigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;

                objDados = objCmd.ExecuteReader();

                if (objDados.HasRows)
                {
                    MessageBox.Show("Código existente!!");
                    txt_Codigo.Focus();
                }
                else { 
                    if(!objDados.IsClosed) { objDados.Close(); }

                    strSql = "INSERT INTO Agenda VALUES(";
                    strSql += "'"+txt_Codigo.Text+"',";
                    strSql += "'"+txt_Nome.Text+"',";
                    strSql += "'"+txt_Email.Text+"',";
                    strSql += "'"+txt_Telefone.Text+"',";
                    strSql += "'"+txt_CPF.Text+"')";

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();

                    MessageBox.Show("REGISTRO REALIZADO COM SUCESSO!");
                    Clean();
                }

                if(!objDados.IsClosed){ objDados.Close(); }
            }
            catch (Exception Erro) {
                MessageBox.Show("Erro ==> "+Erro.Message);
            }

            }
            else {
                MessageBox.Show("Não deixe campos vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {

            if (txt_Codigo.Text != "")
            {
            try
            {

                strSql = "SELECT * FROM Agenda WHERE id = " + txt_Codigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código INexistente!!");
                    txt_Codigo.Focus();
                    objDados.Close();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }

                    strSql = "UPDATE Agenda SET ";
                    strSql += "nome='" + txt_Nome.Text + "', ";
                    strSql += "email='" + txt_Email.Text + "', ";
                    strSql += "telefone='" + txt_Telefone.Text + "', ";
                    strSql += "cpf='" + txt_CPF.Text + "' ";
                    strSql += "WHERE id="+txt_Codigo.Text;

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();

                    MessageBox.Show("ALTERAÇÃO REALIZADA COM SUCESSO!");
                    objDados.Close();
                    Clean();
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message);
            }

            }
            else
            {
                MessageBox.Show("Não deixe o campo CÓDIGO vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Codigo.Focus();
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text != "")
            {

                try
                {

                    strSql = "SELECT * FROM Agenda WHERE id = " + txt_Codigo.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();

                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Código inexistente");
                        txt_Codigo.Focus();
                    }
                    else
                    {

                        objDados.Read();

                        txt_Codigo.Text = objDados["id"].ToString();
                        txt_Nome.Text = objDados["nome"].ToString();
                        txt_Email.Text = objDados["email"].ToString();
                        txt_Telefone.Text = objDados["telefone"].ToString();
                        txt_CPF.Text = objDados["cpf"].ToString();
                    }

                    objDados.Close();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ==> " + Erro.Message);
                }

            }
            else {
                MessageBox.Show("Não deixe o campo CÓDIGO vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Codigo.Focus();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if(txt_Codigo.Text != ""){

            try {
                strSql = "SELECT * FROM Agenda WHERE id = "+txt_Codigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();

                if(!objDados.HasRows){
                    MessageBox.Show("Código inexistente");
                    txt_Codigo.Focus();
                } else {
                    if(MessageBox.Show("Você realmente deseja deletar esta linha?", "DELETAR LINHA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                        if (!objDados.IsClosed) { objDados.Close(); }
                        strSql = "DELETE FROM Agenda WHERE id = " + txt_Codigo.Text;
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objDados = objCmd.ExecuteReader();

                        btn_Limpar_Click(sender, e);
                        Clean();
                    }
                }

                objDados.Close();

            }
            catch (Exception Erro) {
                MessageBox.Show("Erro ==> " + Erro.Message);
            }

            }
            else {
                MessageBox.Show("Não deixe o campo CÓDIGO vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Codigo.Focus();
            }
        }

        private void txt_ConsultarLista_Click(object sender, EventArgs e)
        {
             strSql = "SELECT * FROM Agenda";
             objCmd.Connection = objCnx;
             objCmd.CommandText = strSql;
             objDados = objCmd.ExecuteReader();

             if (objDados.HasRows)
             {
                 form_Lista Form = new form_Lista();
                 Form.Show();
             }
             else {
                 MessageBox.Show("Não existem campos para serem mostrados!!");
             }

             objDados.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            objCnx.Close();
            Close();
        }

        public void Clean()
        {
            txt_Codigo.Text = txt_CPF.Text = txt_Email.Text = txt_Nome.Text = txt_Telefone.Text = "";
            txt_Codigo.Focus();
        }
    }
}
