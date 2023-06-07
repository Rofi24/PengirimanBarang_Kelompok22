namespace menu
{
    partial class Grid
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
            this.pengirimanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pengirimanBarangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pengirimanBarangDataSet = new menu.PengirimanBarangDataSet();
            this.pengirimanTableAdapter = new menu.PengirimanBarangDataSetTableAdapters.PengirimanTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.paketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paketTableAdapter = new menu.PengirimanBarangDataSetTableAdapters.PaketTableAdapter();
            this.idBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengirimanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengirimanBarangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengirimanBarangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.jenisBarangDataGridViewTextBoxColumn,
            this.kategoriBarangDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // pengirimanBindingSource
            // 
            this.pengirimanBindingSource.DataMember = "Pengiriman";
            this.pengirimanBindingSource.DataSource = this.pengirimanBarangDataSetBindingSource;
            // 
            // pengirimanBarangDataSetBindingSource
            // 
            this.pengirimanBarangDataSetBindingSource.DataSource = this.pengirimanBarangDataSet;
            this.pengirimanBarangDataSetBindingSource.Position = 0;
            // 
            // pengirimanBarangDataSet
            // 
            this.pengirimanBarangDataSet.DataSetName = "PengirimanBarangDataSet";
            this.pengirimanBarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pengirimanTableAdapter
            // 
            this.pengirimanTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paketBindingSource
            // 
            this.paketBindingSource.DataMember = "Paket";
            this.paketBindingSource.DataSource = this.pengirimanBarangDataSet;
            // 
            // paketTableAdapter
            // 
            this.paketTableAdapter.ClearBeforeFill = true;
            // 
            // idBarangDataGridViewTextBoxColumn
            // 
            this.idBarangDataGridViewTextBoxColumn.DataPropertyName = "Id_Barang";
            this.idBarangDataGridViewTextBoxColumn.HeaderText = "Id_Barang";
            this.idBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idBarangDataGridViewTextBoxColumn.Name = "idBarangDataGridViewTextBoxColumn";
            this.idBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "Nama_Barang";
            this.namaBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisBarangDataGridViewTextBoxColumn
            // 
            this.jenisBarangDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Barang";
            this.jenisBarangDataGridViewTextBoxColumn.HeaderText = "Jenis_Barang";
            this.jenisBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisBarangDataGridViewTextBoxColumn.Name = "jenisBarangDataGridViewTextBoxColumn";
            this.jenisBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriBarangDataGridViewTextBoxColumn
            // 
            this.kategoriBarangDataGridViewTextBoxColumn.DataPropertyName = "Kategori_Barang";
            this.kategoriBarangDataGridViewTextBoxColumn.HeaderText = "Kategori_Barang";
            this.kategoriBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriBarangDataGridViewTextBoxColumn.Name = "kategoriBarangDataGridViewTextBoxColumn";
            this.kategoriBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grid";
            this.Text = "Grid";
            this.Load += new System.EventHandler(this.Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengirimanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengirimanBarangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengirimanBarangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pengirimanBarangDataSetBindingSource;
        private PengirimanBarangDataSet pengirimanBarangDataSet;
        private System.Windows.Forms.BindingSource pengirimanBindingSource;
        private PengirimanBarangDataSetTableAdapters.PengirimanTableAdapter pengirimanTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource paketBindingSource;
        private PengirimanBarangDataSetTableAdapters.PaketTableAdapter paketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
    }
}