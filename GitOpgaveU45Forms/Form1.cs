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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //jkhvc
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_datamatikerDataSet.Ordre' table. You can move, or remove it, as needed.
            this.ordreTableAdapter.Fill(this.kaspermark_dk_db_datamatikerDataSet.Ordre);

        }
    }
}
