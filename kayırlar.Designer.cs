namespace _5_ocak_2023_çalışma2
{
    partial class kayırlar
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
            this.cenazeVeriTabanıDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenazeVeriTabanıDataSet = new _5_ocak_2023_çalışma2.CenazeVeriTabanıDataSet();
            this.ölüveritabanıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ölü_veritabanıTableAdapter = new _5_ocak_2023_çalışma2.CenazeVeriTabanıDataSetTableAdapters.ölü_veritabanıTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.yaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenazeVeriTabanıDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenazeVeriTabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ölüveritabanıBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewCheckBoxColumn,
            this.yaşDataGridViewTextBoxColumn,
            this.şehirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ölüveritabanıBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 871);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cenazeVeriTabanıDataSetBindingSource
            // 
            this.cenazeVeriTabanıDataSetBindingSource.DataSource = this.cenazeVeriTabanıDataSet;
            this.cenazeVeriTabanıDataSetBindingSource.Position = 0;
            // 
            // cenazeVeriTabanıDataSet
            // 
            this.cenazeVeriTabanıDataSet.DataSetName = "CenazeVeriTabanıDataSet";
            this.cenazeVeriTabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ölüveritabanıBindingSource
            // 
            this.ölüveritabanıBindingSource.DataMember = "ölü_veritabanı";
            this.ölüveritabanıBindingSource.DataSource = this.cenazeVeriTabanıDataSetBindingSource;
            // 
            // ölü_veritabanıTableAdapter
            // 
            this.ölü_veritabanıTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewCheckBoxColumn
            // 
            this.cinsiyetDataGridViewCheckBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewCheckBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewCheckBoxColumn.Name = "cinsiyetDataGridViewCheckBoxColumn";
            this.cinsiyetDataGridViewCheckBoxColumn.Width = 125;
            // 
            // yaşDataGridViewTextBoxColumn
            // 
            this.yaşDataGridViewTextBoxColumn.DataPropertyName = "yaş";
            this.yaşDataGridViewTextBoxColumn.HeaderText = "yaş";
            this.yaşDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yaşDataGridViewTextBoxColumn.Name = "yaşDataGridViewTextBoxColumn";
            this.yaşDataGridViewTextBoxColumn.Width = 125;
            // 
            // şehirDataGridViewTextBoxColumn
            // 
            this.şehirDataGridViewTextBoxColumn.DataPropertyName = "şehir";
            this.şehirDataGridViewTextBoxColumn.HeaderText = "şehir";
            this.şehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.şehirDataGridViewTextBoxColumn.Name = "şehirDataGridViewTextBoxColumn";
            this.şehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayırlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 871);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "kayırlar";
            this.Text = "kayırlar";
            this.Load += new System.EventHandler(this.kayırlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenazeVeriTabanıDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenazeVeriTabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ölüveritabanıBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cenazeVeriTabanıDataSetBindingSource;
        private CenazeVeriTabanıDataSet cenazeVeriTabanıDataSet;
        private System.Windows.Forms.BindingSource ölüveritabanıBindingSource;
        private CenazeVeriTabanıDataSetTableAdapters.ölü_veritabanıTableAdapter ölü_veritabanıTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cinsiyetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şehirDataGridViewTextBoxColumn;
    }
}