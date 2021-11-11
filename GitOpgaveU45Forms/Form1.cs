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
    public partial class Form1 : Form
    {
        string strconn = @"Server=mssql6.unoeuro.com; Database=kaspermark_dk_db_datamatiker; User ID=kaspermark_dk; Password=69qom3u9PW";
        private const bool test = false;

        public Form1()
        {
            InitializeComponent();//test 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_datamatikerDataSet.Ordre' table. You can move, or remove it, as needed.
            this.ordreTableAdapter.Fill(this.kaspermark_dk_db_datamatikerDataSet.Ordre);

        }

        private void CreateButton_Click(object sender, EventArgs e) //Create funktionen virker
        {
            string OrdreId = maskedOIDTextBox.Text;
            string KundeTlf = maskedKtlfTextBox.Text;
            string Tekst = maskedTekstBox.Text;
            string Pris = maskedPrisTextBox.Text;

            // assumption:
            bool KundeTlf_ok = true, Tekst_ok = true, Pris_ok = true;

            // length check:
            if (KundeTlf.Length > 11) KundeTlf_ok = false;
            if (Tekst.Length > 50) Tekst_ok = false;
            if (Pris.Length > 20) Pris_ok = false;

            // "<" check for JS tags ... NO cross site scripting here.:
            if (KundeTlf.Contains("<")) KundeTlf_ok = false;
            if (Tekst.Contains("<")) Tekst_ok = false;
            if (Pris.Contains("<")) Pris_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(KundeTlf)) KundeTlf_ok = false;

            // Check for alphanumeric characters
            Regex dectal = new Regex(@"(^[0-9 ]*.?[0-9]*$)");
            if (!dectal.IsMatch(Pris)) Pris_ok = false;

            // action
            if (KundeTlf_ok && Tekst_ok && Pris_ok)
            {
                // database med kundetabel:
                SqlConnection conn = new SqlConnection(strconn);

                //C(RUD):
                string sqlCom = "INSERT INTO Ordre VALUES (@kundetlf, @tekst, @pris);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@kundetlf", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@kundetlf"].Value = Convert.ToString(KundeTlf);
                cmd.Parameters.Add("@tekst", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@tekst"].Value = Convert.ToString(Tekst);
                cmd.Parameters.Add("@pris", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@pris"].Value = Convert.ToDecimal(Pris);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@kundetlf"].Value + ", " +
                                    cmd.Parameters["@tekst"].Value + ", " +
                                    cmd.Parameters["@pris"].Value +
                                    ")");
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                    this.ordreTableAdapter.Fill(this.kaspermark_dk_db_datamatikerDataSet.Ordre);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                }
            }
            else if (!KundeTlf_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Kunde Tlf. feltet, samt maks 11 tegn.");
                maskedOIDTextBox.Text = "";
                maskedKtlfTextBox.Text = "";
            }

            else if (!Tekst_ok)
            {
                MessageBox.Show("Der må maks være 50 tegn i Tekst feltet.");
                maskedOIDTextBox.Text = "";
                maskedTekstBox.Text = "";
            }

            else if (!Pris_ok)
            {
                MessageBox.Show("Der må kun indtastes tal og et komma/punktum i Pris feltet, samt maks 50 tegn og maks 2 decimaler.");
                maskedOIDTextBox.Text = "";
                maskedPrisTextBox.Text = "";
            }
        }

        private void ReadButton_Click(object sender, EventArgs e) //Læg de resterende funktioner i classes 
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

    }
}
