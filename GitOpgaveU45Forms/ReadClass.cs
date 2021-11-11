using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GitOpgaveU45Forms
{
    public class ReadClass : Form
    {
        /*public static void ReadButton(string OrdreId)
        {
            string strconn = @"Server=mssql6.unoeuro.com; Database=kaspermark_dk_db_datamatiker; User ID=kaspermark_dk; Password=69qom3u9PW";
            //private const bool test = false;
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            //string OrdreId = maskedOIDTextBox.Text;

            //(C)R(UD)

            string sSQL = "SELECT kundetlf FROM Ordre WHERE OrdreId = " + OrdreId + "; "; //Udfylder kunde tlf. feltet
            SqlCommand command = new SqlCommand(sSQL, conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            maskedKtlfTextBox.Text = reader.GetString(0);

            //Luk reader
            reader.Close();
            sSQL = "SELECT tekst FROM Ordre WHERE OrdreId = " + OrdreId + "; "; //Udfylder tekst feltet  
            command = new SqlCommand(sSQL, conn);
            SqlDataReader reader2 = command.ExecuteReader();

            reader2.Read();
            maskedTekstBox.Text = reader2.GetString(0);

            //Luk reader2
            reader2.Close();
            sSQL = "SELECT pris FROM Ordre WHERE OrdreId = " + OrdreId + "; "; //Udfylder pris feltet
            command = new SqlCommand(sSQL, conn);
            SqlDataReader reader3 = command.ExecuteReader();

            reader3.Read();
            maskedPrisTextBox.Text = Convert.ToString(reader3.GetDecimal(0));

            //Luk reader3
            reader3.Close();

            command.ExecuteNonQuery(); //Execute query

            this.ordreTableAdapter.Fill(this.u44DBAflDataSet.Ordre);
        }*/
    }
}
