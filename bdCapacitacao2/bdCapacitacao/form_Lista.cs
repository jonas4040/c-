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
    public partial class form_Lista : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;

        string strSql;

        public form_Lista()
        {
            InitializeComponent();
        }

        private void form_Lista_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server='127.0.0.1'; Database='bdCapacitacao'; User='root';Pwd='root'";
                objCnx.Open();

                strSql = "SELECT * FROM Agenda";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();

                    while (objDados.Read())
                    {
                        dgv_Lista.Rows.Add(bdCapacitacao.Properties.Resources.icone_seta, objDados["id"], objDados["nome"], objDados["email"], objDados["telefone"], objDados["cpf"]);
                    }

                objDados.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message);
            }
        }
    }
}
