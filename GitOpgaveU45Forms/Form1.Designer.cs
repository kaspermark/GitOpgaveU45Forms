
namespace GitOpgaveU45Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kaspermark_dk_db_datamatikerDataSet = new GitOpgaveU45Forms.kaspermark_dk_db_datamatikerDataSet();
            this.ordreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordreTableAdapter = new GitOpgaveU45Forms.kaspermark_dk_db_datamatikerDataSetTableAdapters.OrdreTableAdapter();
            this.ordreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundetlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tekstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_datamatikerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordreIdDataGridViewTextBoxColumn,
            this.kundetlfDataGridViewTextBoxColumn,
            this.tekstDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(479, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 483);
            this.dataGridView1.TabIndex = 1;
            // 
            // kaspermark_dk_db_datamatikerDataSet
            // 
            this.kaspermark_dk_db_datamatikerDataSet.DataSetName = "kaspermark_dk_db_datamatikerDataSet";
            this.kaspermark_dk_db_datamatikerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordreBindingSource
            // 
            this.ordreBindingSource.DataMember = "Ordre";
            this.ordreBindingSource.DataSource = this.kaspermark_dk_db_datamatikerDataSet;
            // 
            // ordreTableAdapter
            // 
            this.ordreTableAdapter.ClearBeforeFill = true;
            // 
            // ordreIdDataGridViewTextBoxColumn
            // 
            this.ordreIdDataGridViewTextBoxColumn.DataPropertyName = "OrdreId";
            this.ordreIdDataGridViewTextBoxColumn.HeaderText = "OrdreId";
            this.ordreIdDataGridViewTextBoxColumn.Name = "ordreIdDataGridViewTextBoxColumn";
            this.ordreIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundetlfDataGridViewTextBoxColumn
            // 
            this.kundetlfDataGridViewTextBoxColumn.DataPropertyName = "kundetlf";
            this.kundetlfDataGridViewTextBoxColumn.HeaderText = "kundetlf";
            this.kundetlfDataGridViewTextBoxColumn.Name = "kundetlfDataGridViewTextBoxColumn";
            // 
            // tekstDataGridViewTextBoxColumn
            // 
            this.tekstDataGridViewTextBoxColumn.DataPropertyName = "tekst";
            this.tekstDataGridViewTextBoxColumn.HeaderText = "tekst";
            this.tekstDataGridViewTextBoxColumn.Name = "tekstDataGridViewTextBoxColumn";
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_datamatikerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_datamatikerDataSet kaspermark_dk_db_datamatikerDataSet;
        private System.Windows.Forms.BindingSource ordreBindingSource;
        private kaspermark_dk_db_datamatikerDataSetTableAdapters.OrdreTableAdapter ordreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundetlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
    }
}

