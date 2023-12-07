namespace Proiect
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheltuieliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheltuieliContinutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.dataGridViewProduse = new System.Windows.Forms.DataGridView();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.produseTableAdapter = new Proiect.DataSet1TableAdapters.ProduseTableAdapter();
            this.dataGridViewCategorii = new System.Windows.Forms.DataGridView();
            this.idCategorieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorieTableAdapter = new Proiect.DataSet1TableAdapters.CategorieTableAdapter();
            this.dataGridViewCheltuieli = new System.Windows.Forms.DataGridView();
            this.idCheltuialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUtilizator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cheltuieliTableAdapter = new Proiect.DataSet1TableAdapters.CheltuieliTableAdapter();
            this.dataGridViewCheltuieliContinut = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCheltuialaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieliContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cheltuieliContinutTableAdapter = new Proiect.DataSet1TableAdapters.CheltuieliContinutTableAdapter();
            this.lblHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.btnAdaugaCategorie = new System.Windows.Forms.Button();
            this.btnAdaugaCheltuiala = new System.Windows.Forms.Button();
            this.btnAdaugaCheltuieliContinut = new System.Windows.Forms.Button();
            this.btnModificareCheltuiala = new System.Windows.Forms.Button();
            this.btnSalvareCheltuieli = new System.Windows.Forms.Button();
            this.btnAnulareCheltuieli = new System.Windows.Forms.Button();
            this.lblConfirmare = new System.Windows.Forms.Label();
            this.btnModificareCheltuialaContinut = new System.Windows.Forms.Button();
            this.btnSalvareCheltuieliContinut = new System.Windows.Forms.Button();
            this.btnAnulareCheltuieliContinut = new System.Windows.Forms.Button();
            this.btnStergeCheltuiala = new System.Windows.Forms.Button();
            this.comboBoxCheltuieli = new System.Windows.Forms.ComboBox();
            this.lblAlege = new System.Windows.Forms.Label();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheltuieli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheltuieliContinut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.categoriiToolStripMenuItem,
            this.cheltuieliToolStripMenuItem,
            this.cheltuieliContinutToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // categoriiToolStripMenuItem
            // 
            this.categoriiToolStripMenuItem.Name = "categoriiToolStripMenuItem";
            this.categoriiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoriiToolStripMenuItem.Text = "Categorii";
            this.categoriiToolStripMenuItem.Click += new System.EventHandler(this.categoriiToolStripMenuItem_Click);
            // 
            // cheltuieliToolStripMenuItem
            // 
            this.cheltuieliToolStripMenuItem.Name = "cheltuieliToolStripMenuItem";
            this.cheltuieliToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cheltuieliToolStripMenuItem.Text = "Cheltuieli";
            this.cheltuieliToolStripMenuItem.Click += new System.EventHandler(this.cheltuieliToolStripMenuItem_Click);
            // 
            // cheltuieliContinutToolStripMenuItem
            // 
            this.cheltuieliContinutToolStripMenuItem.Name = "cheltuieliContinutToolStripMenuItem";
            this.cheltuieliContinutToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.cheltuieliContinutToolStripMenuItem.Text = "CheltuieliContinut";
            this.cheltuieliContinutToolStripMenuItem.Click += new System.EventHandler(this.cheltuieliContinutToolStripMenuItem_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridViewProduse
            // 
            this.dataGridViewProduse.AllowUserToDeleteRows = false;
            this.dataGridViewProduse.AutoGenerateColumns = false;
            this.dataGridViewProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdusDataGridViewTextBoxColumn,
            this.denumireProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn,
            this.idCategorieDataGridViewTextBoxColumn});
            this.dataGridViewProduse.DataSource = this.produseBindingSource;
            this.dataGridViewProduse.Location = new System.Drawing.Point(59, 94);
            this.dataGridViewProduse.Name = "dataGridViewProduse";
            this.dataGridViewProduse.ReadOnly = true;
            this.dataGridViewProduse.Size = new System.Drawing.Size(649, 334);
            this.dataGridViewProduse.TabIndex = 1;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireProdusDataGridViewTextBoxColumn
            // 
            this.denumireProdusDataGridViewTextBoxColumn.DataPropertyName = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.HeaderText = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.Name = "denumireProdusDataGridViewTextBoxColumn";
            this.denumireProdusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCategorieDataGridViewTextBoxColumn
            // 
            this.idCategorieDataGridViewTextBoxColumn.DataPropertyName = "IdCategorie";
            this.idCategorieDataGridViewTextBoxColumn.HeaderText = "IdCategorie";
            this.idCategorieDataGridViewTextBoxColumn.Name = "idCategorieDataGridViewTextBoxColumn";
            this.idCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCategorii
            // 
            this.dataGridViewCategorii.AllowUserToDeleteRows = false;
            this.dataGridViewCategorii.AutoGenerateColumns = false;
            this.dataGridViewCategorii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorii.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategorieDataGridViewTextBoxColumn1,
            this.denumireCategorieDataGridViewTextBoxColumn});
            this.dataGridViewCategorii.DataSource = this.categorieBindingSource;
            this.dataGridViewCategorii.Location = new System.Drawing.Point(398, 94);
            this.dataGridViewCategorii.Name = "dataGridViewCategorii";
            this.dataGridViewCategorii.ReadOnly = true;
            this.dataGridViewCategorii.Size = new System.Drawing.Size(262, 334);
            this.dataGridViewCategorii.TabIndex = 2;
            // 
            // idCategorieDataGridViewTextBoxColumn1
            // 
            this.idCategorieDataGridViewTextBoxColumn1.DataPropertyName = "IdCategorie";
            this.idCategorieDataGridViewTextBoxColumn1.HeaderText = "IdCategorie";
            this.idCategorieDataGridViewTextBoxColumn1.Name = "idCategorieDataGridViewTextBoxColumn1";
            this.idCategorieDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // denumireCategorieDataGridViewTextBoxColumn
            // 
            this.denumireCategorieDataGridViewTextBoxColumn.DataPropertyName = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.HeaderText = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.Name = "denumireCategorieDataGridViewTextBoxColumn";
            this.denumireCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.dataSet1;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCheltuieli
            // 
            this.dataGridViewCheltuieli.AllowUserToDeleteRows = false;
            this.dataGridViewCheltuieli.AutoGenerateColumns = false;
            this.dataGridViewCheltuieli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheltuieli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCheltuialaDataGridViewTextBoxColumn,
            this.IdUtilizator,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridViewCheltuieli.DataSource = this.cheltuieliBindingSource;
            this.dataGridViewCheltuieli.Location = new System.Drawing.Point(342, 94);
            this.dataGridViewCheltuieli.Name = "dataGridViewCheltuieli";
            this.dataGridViewCheltuieli.ReadOnly = true;
            this.dataGridViewCheltuieli.Size = new System.Drawing.Size(353, 334);
            this.dataGridViewCheltuieli.TabIndex = 3;
            // 
            // idCheltuialaDataGridViewTextBoxColumn
            // 
            this.idCheltuialaDataGridViewTextBoxColumn.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.Name = "idCheltuialaDataGridViewTextBoxColumn";
            this.idCheltuialaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdUtilizator
            // 
            this.IdUtilizator.DataPropertyName = "IdUtilizator";
            this.IdUtilizator.HeaderText = "IdUtilizator";
            this.IdUtilizator.Name = "IdUtilizator";
            this.IdUtilizator.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cheltuieliBindingSource
            // 
            this.cheltuieliBindingSource.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource.DataSource = this.dataSet1;
            // 
            // cheltuieliTableAdapter
            // 
            this.cheltuieliTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCheltuieliContinut
            // 
            this.dataGridViewCheltuieliContinut.AllowUserToDeleteRows = false;
            this.dataGridViewCheltuieliContinut.AutoGenerateColumns = false;
            this.dataGridViewCheltuieliContinut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheltuieliContinut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn1,
            this.pretDataGridViewTextBoxColumn1,
            this.cantitateDataGridViewTextBoxColumn,
            this.idCheltuialaDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewCheltuieliContinut.DataSource = this.cheltuieliContinutBindingSource;
            this.dataGridViewCheltuieliContinut.Location = new System.Drawing.Point(190, 94);
            this.dataGridViewCheltuieliContinut.Name = "dataGridViewCheltuieliContinut";
            this.dataGridViewCheltuieliContinut.ReadOnly = true;
            this.dataGridViewCheltuieliContinut.Size = new System.Drawing.Size(667, 334);
            this.dataGridViewCheltuieliContinut.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProdusDataGridViewTextBoxColumn1
            // 
            this.idProdusDataGridViewTextBoxColumn1.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.Name = "idProdusDataGridViewTextBoxColumn1";
            this.idProdusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn1
            // 
            this.pretDataGridViewTextBoxColumn1.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn1.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn1.Name = "pretDataGridViewTextBoxColumn1";
            this.pretDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCheltuialaDataGridViewTextBoxColumn1
            // 
            this.idCheltuialaDataGridViewTextBoxColumn1.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn1.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn1.Name = "idCheltuialaDataGridViewTextBoxColumn1";
            this.idCheltuialaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUtilizator";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUtilizator";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cheltuieliContinutBindingSource
            // 
            this.cheltuieliContinutBindingSource.DataMember = "CheltuieliContinut";
            this.cheltuieliContinutBindingSource.DataSource = this.dataSet1;
            // 
            // cheltuieliContinutTableAdapter
            // 
            this.cheltuieliContinutTableAdapter.ClearBeforeFill = true;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(341, 214);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(367, 55);
            this.lblHello.TabIndex = 5;
            this.lblHello.Text = "Bun venit, U01!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.produseBindingSource, "SpImagine", true));
            this.pictureBox1.Location = new System.Drawing.Point(752, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaProdus.Location = new System.Drawing.Point(59, 57);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(114, 23);
            this.btnAdaugaProdus.TabIndex = 7;
            this.btnAdaugaProdus.Text = "Adauga produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = true;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // btnAdaugaCategorie
            // 
            this.btnAdaugaCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaCategorie.Location = new System.Drawing.Point(398, 57);
            this.btnAdaugaCategorie.Name = "btnAdaugaCategorie";
            this.btnAdaugaCategorie.Size = new System.Drawing.Size(130, 23);
            this.btnAdaugaCategorie.TabIndex = 8;
            this.btnAdaugaCategorie.Text = "Adauga categorie";
            this.btnAdaugaCategorie.UseVisualStyleBackColor = true;
            this.btnAdaugaCategorie.Click += new System.EventHandler(this.btnAdaugaCategorie_Click);
            // 
            // btnAdaugaCheltuiala
            // 
            this.btnAdaugaCheltuiala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaCheltuiala.Location = new System.Drawing.Point(292, 57);
            this.btnAdaugaCheltuiala.Name = "btnAdaugaCheltuiala";
            this.btnAdaugaCheltuiala.Size = new System.Drawing.Size(130, 23);
            this.btnAdaugaCheltuiala.TabIndex = 9;
            this.btnAdaugaCheltuiala.Text = "Adauga cheltuiala";
            this.btnAdaugaCheltuiala.UseVisualStyleBackColor = true;
            this.btnAdaugaCheltuiala.Click += new System.EventHandler(this.btnAdaugaCheltuiala_Click);
            // 
            // btnAdaugaCheltuieliContinut
            // 
            this.btnAdaugaCheltuieliContinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaCheltuieliContinut.Location = new System.Drawing.Point(190, 57);
            this.btnAdaugaCheltuieliContinut.Name = "btnAdaugaCheltuieliContinut";
            this.btnAdaugaCheltuieliContinut.Size = new System.Drawing.Size(194, 23);
            this.btnAdaugaCheltuieliContinut.TabIndex = 10;
            this.btnAdaugaCheltuieliContinut.Text = "Adauga continut la cheltuiala";
            this.btnAdaugaCheltuieliContinut.UseVisualStyleBackColor = true;
            this.btnAdaugaCheltuieliContinut.Click += new System.EventHandler(this.btnAdaugaCheltuieliContinut_Click);
            // 
            // btnModificareCheltuiala
            // 
            this.btnModificareCheltuiala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificareCheltuiala.Location = new System.Drawing.Point(428, 57);
            this.btnModificareCheltuiala.Name = "btnModificareCheltuiala";
            this.btnModificareCheltuiala.Size = new System.Drawing.Size(100, 23);
            this.btnModificareCheltuiala.TabIndex = 11;
            this.btnModificareCheltuiala.Text = "Modificare";
            this.btnModificareCheltuiala.UseVisualStyleBackColor = true;
            this.btnModificareCheltuiala.Click += new System.EventHandler(this.btnModificareCheltuiala_Click);
            // 
            // btnSalvareCheltuieli
            // 
            this.btnSalvareCheltuieli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvareCheltuieli.Location = new System.Drawing.Point(534, 57);
            this.btnSalvareCheltuieli.Name = "btnSalvareCheltuieli";
            this.btnSalvareCheltuieli.Size = new System.Drawing.Size(75, 23);
            this.btnSalvareCheltuieli.TabIndex = 12;
            this.btnSalvareCheltuieli.Text = "Salvare";
            this.btnSalvareCheltuieli.UseVisualStyleBackColor = true;
            this.btnSalvareCheltuieli.Click += new System.EventHandler(this.btnSalvareCheltuieli_Click);
            // 
            // btnAnulareCheltuieli
            // 
            this.btnAnulareCheltuieli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulareCheltuieli.Location = new System.Drawing.Point(615, 57);
            this.btnAnulareCheltuieli.Name = "btnAnulareCheltuieli";
            this.btnAnulareCheltuieli.Size = new System.Drawing.Size(75, 23);
            this.btnAnulareCheltuieli.TabIndex = 13;
            this.btnAnulareCheltuieli.Text = "Anulare";
            this.btnAnulareCheltuieli.UseVisualStyleBackColor = true;
            this.btnAnulareCheltuieli.Click += new System.EventHandler(this.btnAnulareCheltuieli_Click);
            // 
            // lblConfirmare
            // 
            this.lblConfirmare.AutoSize = true;
            this.lblConfirmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmare.Location = new System.Drawing.Point(364, 450);
            this.lblConfirmare.Name = "lblConfirmare";
            this.lblConfirmare.Size = new System.Drawing.Size(305, 20);
            this.lblConfirmare.TabIndex = 14;
            this.lblConfirmare.Text = "Acum poti sa editezi datele din tabel!";
            // 
            // btnModificareCheltuialaContinut
            // 
            this.btnModificareCheltuialaContinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificareCheltuialaContinut.Location = new System.Drawing.Point(390, 57);
            this.btnModificareCheltuialaContinut.Name = "btnModificareCheltuialaContinut";
            this.btnModificareCheltuialaContinut.Size = new System.Drawing.Size(100, 23);
            this.btnModificareCheltuialaContinut.TabIndex = 15;
            this.btnModificareCheltuialaContinut.Text = "Modificare";
            this.btnModificareCheltuialaContinut.UseVisualStyleBackColor = true;
            this.btnModificareCheltuialaContinut.Click += new System.EventHandler(this.btnModificareCheltuialaContinut_Click);
            // 
            // btnSalvareCheltuieliContinut
            // 
            this.btnSalvareCheltuieliContinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvareCheltuieliContinut.Location = new System.Drawing.Point(496, 57);
            this.btnSalvareCheltuieliContinut.Name = "btnSalvareCheltuieliContinut";
            this.btnSalvareCheltuieliContinut.Size = new System.Drawing.Size(75, 23);
            this.btnSalvareCheltuieliContinut.TabIndex = 16;
            this.btnSalvareCheltuieliContinut.Text = "Salvare";
            this.btnSalvareCheltuieliContinut.UseVisualStyleBackColor = true;
            this.btnSalvareCheltuieliContinut.Click += new System.EventHandler(this.btnSalvareCheltuieliContinut_Click);
            // 
            // btnAnulareCheltuieliContinut
            // 
            this.btnAnulareCheltuieliContinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulareCheltuieliContinut.Location = new System.Drawing.Point(577, 57);
            this.btnAnulareCheltuieliContinut.Name = "btnAnulareCheltuieliContinut";
            this.btnAnulareCheltuieliContinut.Size = new System.Drawing.Size(75, 23);
            this.btnAnulareCheltuieliContinut.TabIndex = 17;
            this.btnAnulareCheltuieliContinut.Text = "Anulare";
            this.btnAnulareCheltuieliContinut.UseVisualStyleBackColor = true;
            this.btnAnulareCheltuieliContinut.Click += new System.EventHandler(this.btnAnulareCheltuieliContinut_Click);
            // 
            // btnStergeCheltuiala
            // 
            this.btnStergeCheltuiala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeCheltuiala.Location = new System.Drawing.Point(819, 290);
            this.btnStergeCheltuiala.Name = "btnStergeCheltuiala";
            this.btnStergeCheltuiala.Size = new System.Drawing.Size(181, 23);
            this.btnStergeCheltuiala.TabIndex = 18;
            this.btnStergeCheltuiala.Text = "Stergere";
            this.btnStergeCheltuiala.UseVisualStyleBackColor = true;
            this.btnStergeCheltuiala.Click += new System.EventHandler(this.btnStergeCheltuiala_Click_1);
            // 
            // comboBoxCheltuieli
            // 
            this.comboBoxCheltuieli.FormattingEnabled = true;
            this.comboBoxCheltuieli.Location = new System.Drawing.Point(819, 248);
            this.comboBoxCheltuieli.Name = "comboBoxCheltuieli";
            this.comboBoxCheltuieli.Size = new System.Drawing.Size(181, 21);
            this.comboBoxCheltuieli.TabIndex = 19;
            // 
            // lblAlege
            // 
            this.lblAlege.AutoSize = true;
            this.lblAlege.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlege.Location = new System.Drawing.Point(798, 232);
            this.lblAlege.Name = "lblAlege";
            this.lblAlege.Size = new System.Drawing.Size(224, 13);
            this.lblAlege.TabIndex = 20;
            this.lblAlege.Text = "Alege data pe care doresti sa o stergi:";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 514);
            this.Controls.Add(this.lblAlege);
            this.Controls.Add(this.comboBoxCheltuieli);
            this.Controls.Add(this.btnStergeCheltuiala);
            this.Controls.Add(this.btnAnulareCheltuieliContinut);
            this.Controls.Add(this.btnSalvareCheltuieliContinut);
            this.Controls.Add(this.btnModificareCheltuialaContinut);
            this.Controls.Add(this.lblConfirmare);
            this.Controls.Add(this.btnAnulareCheltuieli);
            this.Controls.Add(this.btnSalvareCheltuieli);
            this.Controls.Add(this.btnModificareCheltuiala);
            this.Controls.Add(this.btnAdaugaCheltuieliContinut);
            this.Controls.Add(this.btnAdaugaCheltuiala);
            this.Controls.Add(this.btnAdaugaCategorie);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.dataGridViewCheltuieliContinut);
            this.Controls.Add(this.dataGridViewCheltuieli);
            this.Controls.Add(this.dataGridViewCategorii);
            this.Controls.Add(this.dataGridViewProduse);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheltuieli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheltuieliContinut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheltuieliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheltuieliContinutToolStripMenuItem;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataGridView dataGridViewProduse;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCategorii;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private DataSet1TableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategorieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewCheltuieli;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource;
        private DataSet1TableAdapters.CheltuieliTableAdapter cheltuieliTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCheltuieliContinut;
        private System.Windows.Forms.BindingSource cheltuieliContinutBindingSource;
        private DataSet1TableAdapters.CheltuieliContinutTableAdapter cheltuieliContinutTableAdapter;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUtilizator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnAdaugaCategorie;
        private System.Windows.Forms.Button btnAdaugaCheltuiala;
        private System.Windows.Forms.Button btnAdaugaCheltuieliContinut;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnModificareCheltuiala;
        private System.Windows.Forms.Button btnSalvareCheltuieli;
        private System.Windows.Forms.Button btnAnulareCheltuieli;
        private System.Windows.Forms.Label lblConfirmare;
        private System.Windows.Forms.Button btnModificareCheltuialaContinut;
        private System.Windows.Forms.Button btnSalvareCheltuieliContinut;
        private System.Windows.Forms.Button btnAnulareCheltuieliContinut;
        private System.Windows.Forms.Button btnStergeCheltuiala;
        private System.Windows.Forms.ComboBox comboBoxCheltuieli;
        private System.Windows.Forms.Label lblAlege;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}