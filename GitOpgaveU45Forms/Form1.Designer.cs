
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundetlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tekstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaspermark_dk_db_datamatikerDataSet = new GitOpgaveU45Forms.kaspermark_dk_db_datamatikerDataSet();
            this.ordreTableAdapter = new GitOpgaveU45Forms.kaspermark_dk_db_datamatikerDataSetTableAdapters.OrdreTableAdapter();
            this.maskedOIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedKtlfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTekstBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedPrisTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_datamatikerDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(479, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 428);
            this.dataGridView1.TabIndex = 1;
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
            // ordreBindingSource
            // 
            this.ordreBindingSource.DataMember = "Ordre";
            this.ordreBindingSource.DataSource = this.kaspermark_dk_db_datamatikerDataSet;
            // 
            // kaspermark_dk_db_datamatikerDataSet
            // 
            this.kaspermark_dk_db_datamatikerDataSet.DataSetName = "kaspermark_dk_db_datamatikerDataSet";
            this.kaspermark_dk_db_datamatikerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordreTableAdapter
            // 
            this.ordreTableAdapter.ClearBeforeFill = true;
            // 
            // maskedOIDTextBox
            // 
            this.maskedOIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedOIDTextBox.Location = new System.Drawing.Point(112, 115);
            this.maskedOIDTextBox.Name = "maskedOIDTextBox";
            this.maskedOIDTextBox.Size = new System.Drawing.Size(189, 26);
            this.maskedOIDTextBox.TabIndex = 2;
            // 
            // maskedKtlfTextBox
            // 
            this.maskedKtlfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedKtlfTextBox.Location = new System.Drawing.Point(112, 206);
            this.maskedKtlfTextBox.Name = "maskedKtlfTextBox";
            this.maskedKtlfTextBox.Size = new System.Drawing.Size(174, 26);
            this.maskedKtlfTextBox.TabIndex = 3;
            // 
            // maskedTekstBox
            // 
            this.maskedTekstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTekstBox.Location = new System.Drawing.Point(112, 262);
            this.maskedTekstBox.Name = "maskedTekstBox";
            this.maskedTekstBox.Size = new System.Drawing.Size(231, 26);
            this.maskedTekstBox.TabIndex = 4;
            // 
            // maskedPrisTextBox
            // 
            this.maskedPrisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedPrisTextBox.Location = new System.Drawing.Point(112, 318);
            this.maskedPrisTextBox.Name = "maskedPrisTextBox";
            this.maskedPrisTextBox.Size = new System.Drawing.Size(174, 26);
            this.maskedPrisTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 53);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordre Håndtering";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(323, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Auto-Udfyld";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(26, 424);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(127, 56);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Opret Ordre";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(159, 423);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(127, 56);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Opdater Ordre";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(292, 424);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(127, 56);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Slet Ordre";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ordre Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kunde Tlf.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tekst";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pris";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 526);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskedPrisTextBox);
            this.Controls.Add(this.maskedTekstBox);
            this.Controls.Add(this.maskedKtlfTextBox);
            this.Controls.Add(this.maskedOIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaspermark_dk_db_datamatikerDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private kaspermark_dk_db_datamatikerDataSet kaspermark_dk_db_datamatikerDataSet;
        private System.Windows.Forms.BindingSource ordreBindingSource;
        private kaspermark_dk_db_datamatikerDataSetTableAdapters.OrdreTableAdapter ordreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundetlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedOIDTextBox;
        private System.Windows.Forms.MaskedTextBox maskedKtlfTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTekstBox;
        private System.Windows.Forms.MaskedTextBox maskedPrisTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

