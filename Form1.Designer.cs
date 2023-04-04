namespace _5_ocak_2023_çalışma2
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxülke = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioerkek = new System.Windows.Forms.RadioButton();
            this.radiokadın = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.txtsoy = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.yaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ölüveritabanıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cenazeVeriTabanıDataSet1 = new _5_ocak_2023_çalışma2.CenazeVeriTabanıDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.nazi1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazi_kampı_kayıtDataSet = new _5_ocak_2023_çalışma2.Nazi_kampı_kayıtDataSet();
            this.nazi_1TableAdapter = new _5_ocak_2023_çalışma2.Nazi_kampı_kayıtDataSetTableAdapters.nazi_1TableAdapter();
            this.ölü_veritabanıTableAdapter = new _5_ocak_2023_çalışma2.CenazeVeriTabanıDataSet1TableAdapters.ölü_veritabanıTableAdapter();
            this.kaydet = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.buttonistatistik = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Guncellebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ölüveritabanıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenazeVeriTabanıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazi1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazi_kampı_kayıtDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Snow;
            groupBox1.Controls.Add(this.comboBoxülke);
            groupBox1.Controls.Add(this.label6);
            groupBox1.Controls.Add(this.label5);
            groupBox1.Controls.Add(this.radioerkek);
            groupBox1.Controls.Add(this.radiokadın);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.label3);
            groupBox1.Controls.Add(this.label2);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Controls.Add(this.txtyas);
            groupBox1.Controls.Add(this.txtsoy);
            groupBox1.Controls.Add(this.txtad);
            groupBox1.Controls.Add(this.txtid);
            groupBox1.Location = new System.Drawing.Point(12, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(336, 447);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cenaze kayıt";
            groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxülke
            // 
            this.comboBoxülke.FormattingEnabled = true;
            this.comboBoxülke.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.comboBoxülke.Location = new System.Drawing.Point(107, 332);
            this.comboBoxülke.Name = "comboBoxülke";
            this.comboBoxülke.Size = new System.Drawing.Size(102, 36);
            this.comboBoxülke.TabIndex = 13;
            this.comboBoxülke.SelectedIndexChanged += new System.EventHandler(this.comboBoxülke_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(34, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "ŞEHİR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(48, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "YAŞ";
            // 
            // radioerkek
            // 
            this.radioerkek.AutoSize = true;
            this.radioerkek.Location = new System.Drawing.Point(217, 223);
            this.radioerkek.Name = "radioerkek";
            this.radioerkek.Size = new System.Drawing.Size(102, 32);
            this.radioerkek.TabIndex = 10;
            this.radioerkek.TabStop = true;
            this.radioerkek.Text = "KADIN";
            this.radioerkek.UseVisualStyleBackColor = true;
            this.radioerkek.CheckedChanged += new System.EventHandler(this.radioerkek_CheckedChanged);
            // 
            // radiokadın
            // 
            this.radiokadın.AutoSize = true;
            this.radiokadın.Location = new System.Drawing.Point(109, 223);
            this.radiokadın.Name = "radiokadın";
            this.radiokadın.Size = new System.Drawing.Size(103, 32);
            this.radiokadın.TabIndex = 9;
            this.radiokadın.TabStop = true;
            this.radiokadın.Text = "ERKEK";
            this.radiokadın.UseVisualStyleBackColor = true;
            this.radiokadın.CheckedChanged += new System.EventHandler(this.radiokadın_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-5, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "CİNSİYET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(59, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "AD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(68, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(109, 277);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(100, 36);
            this.txtyas.TabIndex = 4;
            // 
            // txtsoy
            // 
            this.txtsoy.Location = new System.Drawing.Point(109, 168);
            this.txtsoy.Name = "txtsoy";
            this.txtsoy.Size = new System.Drawing.Size(100, 36);
            this.txtsoy.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(109, 116);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 36);
            this.txtad.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(109, 61);
            this.txtid.Name = "txtid";
            this.txtid.ShortcutsEnabled = false;
            this.txtid.Size = new System.Drawing.Size(100, 36);
            this.txtid.TabIndex = 0;
            this.txtid.WordWrap = false;
            // 
            // button2
            // 
            button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button2.Location = new System.Drawing.Point(230, 126);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(73, 58);
            button2.TabIndex = 8;
            button2.Text = "müzik kapa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(354, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(842, 476);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewCheckBoxColumn,
            this.yaşDataGridViewTextBoxColumn,
            this.şehirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ölüveritabanıBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(20, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(816, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.ContextMenuStrip = this.contextMenuStrip1;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // ölüveritabanıBindingSource
            // 
            this.ölüveritabanıBindingSource.DataMember = "ölü_veritabanı";
            this.ölüveritabanıBindingSource.DataSource = this.cenazeVeriTabanıDataSet1;
            // 
            // cenazeVeriTabanıDataSet1
            // 
            this.cenazeVeriTabanıDataSet1.DataSetName = "CenazeVeriTabanıDataSet1";
            this.cenazeVeriTabanıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Chartreuse;
            this.label8.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label8.Location = new System.Drawing.Point(542, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(443, 66);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cenaze Kayıt";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(230, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "müzik aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Desktop;
            this.label11.Font = new System.Drawing.Font("Corbel Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(564, -58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 28);
            this.label11.TabIndex = 9;
            this.label11.Text = "-Mabel Matiz";
            // 
            // nazi1BindingSource
            // 
            this.nazi1BindingSource.DataMember = "nazi_1";
            this.nazi1BindingSource.DataSource = this.nazi_kampı_kayıtDataSet;
            // 
            // nazi_kampı_kayıtDataSet
            // 
            this.nazi_kampı_kayıtDataSet.DataSetName = "Nazi_kampı_kayıtDataSet";
            this.nazi_kampı_kayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazi_1TableAdapter
            // 
            this.nazi_1TableAdapter.ClearBeforeFill = true;
            // 
            // ölü_veritabanıTableAdapter
            // 
            this.ölü_veritabanıTableAdapter.ClearBeforeFill = true;
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(6, 98);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(140, 38);
            this.kaydet.TabIndex = 0;
            this.kaydet.Text = "kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(6, 142);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(140, 34);
            this.buttonsil.TabIndex = 1;
            this.buttonsil.Text = "sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.button9_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(6, 55);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(140, 37);
            this.listelebtn.TabIndex = 2;
            this.listelebtn.Text = "listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(6, 226);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(140, 42);
            this.temizlebtn.TabIndex = 4;
            this.temizlebtn.Text = "temizle";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonistatistik
            // 
            this.buttonistatistik.Location = new System.Drawing.Point(6, 274);
            this.buttonistatistik.Name = "buttonistatistik";
            this.buttonistatistik.Size = new System.Drawing.Size(140, 37);
            this.buttonistatistik.TabIndex = 5;
            this.buttonistatistik.Text = "istatistik";
            this.buttonistatistik.UseVisualStyleBackColor = true;
            this.buttonistatistik.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Kayıtlar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkRed;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.ForeColor = System.Drawing.Color.DarkGray;
            this.button11.Location = new System.Drawing.Point(1364, 649);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(155, 85);
            this.button11.TabIndex = 7;
            this.button11.Text = "Çıkış yap";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox4.Controls.Add(this.Guncellebtn);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.buttonistatistik);
            this.groupBox4.Controls.Add(this.temizlebtn);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(button2);
            this.groupBox4.Controls.Add(this.listelebtn);
            this.groupBox4.Controls.Add(this.buttonsil);
            this.groupBox4.Controls.Add(this.kaydet);
            this.groupBox4.Location = new System.Drawing.Point(1202, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 447);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemeler";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Guncellebtn
            // 
            this.Guncellebtn.Location = new System.Drawing.Point(6, 182);
            this.Guncellebtn.Name = "Guncellebtn";
            this.Guncellebtn.Size = new System.Drawing.Size(140, 34);
            this.Guncellebtn.TabIndex = 9;
            this.Guncellebtn.Text = "Güncelle";
            this.Guncellebtn.UseVisualStyleBackColor = true;
            this.Guncellebtn.Click += new System.EventHandler(this.Guncellebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1561, 1015);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1561, 1015);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cenaze Kayıt";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ölüveritabanıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenazeVeriTabanıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazi1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazi_kampı_kayıtDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.TextBox txtsoy;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.ComboBox comboBoxülke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioerkek;
        private System.Windows.Forms.RadioButton radiokadın;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Nazi_kampı_kayıtDataSet nazi_kampı_kayıtDataSet;
        private System.Windows.Forms.BindingSource nazi1BindingSource;
        private Nazi_kampı_kayıtDataSetTableAdapters.nazi_1TableAdapter nazi_1TableAdapter;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private CenazeVeriTabanıDataSet1 cenazeVeriTabanıDataSet1;
        private System.Windows.Forms.BindingSource ölüveritabanıBindingSource;
        private CenazeVeriTabanıDataSet1TableAdapters.ölü_veritabanıTableAdapter ölü_veritabanıTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cinsiyetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.Button buttonistatistik;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Guncellebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

