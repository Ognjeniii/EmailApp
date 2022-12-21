namespace EmailApp
{
    partial class Form3
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maticniBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfFajlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPdfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusMailaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposleniDataSet9 = new EmailApp.ZaposleniDataSet9();
            this.log1TableAdapter = new EmailApp.ZaposleniDataSet9TableAdapters.Log1TableAdapter();
            this.btnObrisiBazu = new System.Windows.Forms.Button();
            this.lbMatBr = new System.Windows.Forms.Label();
            this.tbMatBr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maticniBrojDataGridViewTextBoxColumn,
            this.pdfFajlDataGridViewTextBoxColumn,
            this.statusPdfaDataGridViewTextBoxColumn,
            this.statusMailaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.log1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 538);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // maticniBrojDataGridViewTextBoxColumn
            // 
            this.maticniBrojDataGridViewTextBoxColumn.DataPropertyName = "MaticniBroj";
            this.maticniBrojDataGridViewTextBoxColumn.HeaderText = "MaticniBroj";
            this.maticniBrojDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maticniBrojDataGridViewTextBoxColumn.Name = "maticniBrojDataGridViewTextBoxColumn";
            this.maticniBrojDataGridViewTextBoxColumn.Width = 125;
            // 
            // pdfFajlDataGridViewTextBoxColumn
            // 
            this.pdfFajlDataGridViewTextBoxColumn.DataPropertyName = "PdfFajl";
            this.pdfFajlDataGridViewTextBoxColumn.HeaderText = "PdfFajl";
            this.pdfFajlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pdfFajlDataGridViewTextBoxColumn.Name = "pdfFajlDataGridViewTextBoxColumn";
            this.pdfFajlDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPdfaDataGridViewTextBoxColumn
            // 
            this.statusPdfaDataGridViewTextBoxColumn.DataPropertyName = "StatusPdfa";
            this.statusPdfaDataGridViewTextBoxColumn.HeaderText = "StatusPdfa";
            this.statusPdfaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusPdfaDataGridViewTextBoxColumn.Name = "statusPdfaDataGridViewTextBoxColumn";
            this.statusPdfaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusMailaDataGridViewTextBoxColumn
            // 
            this.statusMailaDataGridViewTextBoxColumn.DataPropertyName = "StatusMaila";
            this.statusMailaDataGridViewTextBoxColumn.HeaderText = "StatusMaila";
            this.statusMailaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusMailaDataGridViewTextBoxColumn.Name = "statusMailaDataGridViewTextBoxColumn";
            this.statusMailaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 125;
            // 
            // log1BindingSource
            // 
            this.log1BindingSource.DataMember = "Log1";
            this.log1BindingSource.DataSource = this.zaposleniDataSet9;
            // 
            // zaposleniDataSet9
            // 
            this.zaposleniDataSet9.DataSetName = "ZaposleniDataSet9";
            this.zaposleniDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // log1TableAdapter
            // 
            this.log1TableAdapter.ClearBeforeFill = true;
            // 
            // btnObrisiBazu
            // 
            this.btnObrisiBazu.BackColor = System.Drawing.Color.Khaki;
            this.btnObrisiBazu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiBazu.ForeColor = System.Drawing.Color.Black;
            this.btnObrisiBazu.Location = new System.Drawing.Point(1086, 12);
            this.btnObrisiBazu.Name = "btnObrisiBazu";
            this.btnObrisiBazu.Size = new System.Drawing.Size(169, 39);
            this.btnObrisiBazu.TabIndex = 1;
            this.btnObrisiBazu.Text = "Obrisi log";
            this.btnObrisiBazu.UseVisualStyleBackColor = false;
            this.btnObrisiBazu.Click += new System.EventHandler(this.btnObrisiBazu_Click);
            // 
            // lbMatBr
            // 
            this.lbMatBr.AutoSize = true;
            this.lbMatBr.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatBr.Location = new System.Drawing.Point(1082, 64);
            this.lbMatBr.Name = "lbMatBr";
            this.lbMatBr.Size = new System.Drawing.Size(120, 23);
            this.lbMatBr.TabIndex = 2;
            this.lbMatBr.Text = " Maticni broj:";
            // 
            // tbMatBr
            // 
            this.tbMatBr.Location = new System.Drawing.Point(1086, 90);
            this.tbMatBr.Name = "tbMatBr";
            this.tbMatBr.Size = new System.Drawing.Size(169, 22);
            this.tbMatBr.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 541);
            this.Controls.Add(this.tbMatBr);
            this.Controls.Add(this.lbMatBr);
            this.Controls.Add(this.btnObrisiBazu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ZaposleniDataSet9 zaposleniDataSet9;
        private System.Windows.Forms.BindingSource log1BindingSource;
        private ZaposleniDataSet9TableAdapters.Log1TableAdapter log1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maticniBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfFajlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPdfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusMailaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnObrisiBazu;
        private System.Windows.Forms.Label lbMatBr;
        private System.Windows.Forms.TextBox tbMatBr;
    }
}