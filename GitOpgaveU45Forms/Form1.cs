using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitOpgaveU45Forms
{
    public partial class Form1 : Form
    {
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
