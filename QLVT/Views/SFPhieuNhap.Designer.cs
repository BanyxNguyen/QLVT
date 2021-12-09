
namespace QLVT.Views
{
    partial class SFPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFPhieuNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnControl = new System.Windows.Forms.Panel();
            this.lbFormName = new System.Windows.Forms.Label();
            this.dgvDataVatTu = new System.Windows.Forms.DataGridView();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lbIdHoaDon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuNhapDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenhhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPhieuNhapDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnControl);
            this.panel1.Controls.Add(this.lbFormName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 130);
            this.panel1.TabIndex = 41;
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btnReload);
            this.pnControl.Controls.Add(this.btnAdd);
            this.pnControl.Controls.Add(this.btnDelete);
            this.pnControl.Controls.Add(this.btnEdit);
            this.pnControl.Controls.Add(this.label1);
            this.pnControl.Controls.Add(this.lbIdHoaDon);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 70);
            this.pnControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1134, 60);
            this.pnControl.TabIndex = 41;
            // 
            // lbFormName
            // 
            this.lbFormName.AutoSize = true;
            this.lbFormName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormName.Location = new System.Drawing.Point(449, 9);
            this.lbFormName.Name = "lbFormName";
            this.lbFormName.Size = new System.Drawing.Size(218, 45);
            this.lbFormName.TabIndex = 33;
            this.lbFormName.Text = "Phieu Nhap";
            // 
            // dgvDataVatTu
            // 
            this.dgvDataVatTu.AutoGenerateColumns = false;
            this.dgvDataVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataVatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenhhDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn,
            this.sLDaNhapDataGridViewTextBoxColumn});
            this.dgvDataVatTu.DataSource = this.cTPhieuNhapDTOBindingSource;
            this.dgvDataVatTu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDataVatTu.Location = new System.Drawing.Point(0, 513);
            this.dgvDataVatTu.Name = "dgvDataVatTu";
            this.dgvDataVatTu.ReadOnly = true;
            this.dgvDataVatTu.RowHeadersWidth = 51;
            this.dgvDataVatTu.RowTemplate.Height = 24;
            this.dgvDataVatTu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataVatTu.Size = new System.Drawing.Size(1134, 212);
            this.dgvDataVatTu.TabIndex = 42;
            // 
            // dgvData
            // 
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ngaylapDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.tenKhoDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.phieuNhapDTOBindingSource;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 130);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1134, 383);
            this.dgvData.TabIndex = 43;
            // 
            // lbIdHoaDon
            // 
            this.lbIdHoaDon.AutoSize = true;
            this.lbIdHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdHoaDon.Location = new System.Drawing.Point(785, 16);
            this.lbIdHoaDon.Name = "lbIdHoaDon";
            this.lbIdHoaDon.Size = new System.Drawing.Size(25, 22);
            this.lbIdHoaDon.TabIndex = 36;
            this.lbIdHoaDon.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Hoa Don: ";
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(163, 6);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(45, 45);
            this.btnReload.TabIndex = 41;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(4, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(110, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(57, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 45);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaylapDataGridViewTextBoxColumn
            // 
            this.ngaylapDataGridViewTextBoxColumn.DataPropertyName = "Ngaylap";
            this.ngaylapDataGridViewTextBoxColumn.HeaderText = "Ngaylap";
            this.ngaylapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaylapDataGridViewTextBoxColumn.Name = "ngaylapDataGridViewTextBoxColumn";
            this.ngaylapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKhoDataGridViewTextBoxColumn
            // 
            this.tenKhoDataGridViewTextBoxColumn.DataPropertyName = "TenKho";
            this.tenKhoDataGridViewTextBoxColumn.HeaderText = "TenKho";
            this.tenKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKhoDataGridViewTextBoxColumn.Name = "tenKhoDataGridViewTextBoxColumn";
            this.tenKhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phieuNhapDTOBindingSource
            // 
            this.phieuNhapDTOBindingSource.DataSource = typeof(QLVT.DTO.PhieuNhapDTO);
            // 
            // tenhhDataGridViewTextBoxColumn
            // 
            this.tenhhDataGridViewTextBoxColumn.DataPropertyName = "Tenhh";
            this.tenhhDataGridViewTextBoxColumn.HeaderText = "Tenhh";
            this.tenhhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenhhDataGridViewTextBoxColumn.Name = "tenhhDataGridViewTextBoxColumn";
            this.tenhhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            this.dongiaDataGridViewTextBoxColumn.DataPropertyName = "Dongia";
            this.dongiaDataGridViewTextBoxColumn.HeaderText = "Dongia";
            this.dongiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            this.dongiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slDataGridViewTextBoxColumn
            // 
            this.slDataGridViewTextBoxColumn.DataPropertyName = "Sl";
            this.slDataGridViewTextBoxColumn.HeaderText = "Sl";
            this.slDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.slDataGridViewTextBoxColumn.Name = "slDataGridViewTextBoxColumn";
            this.slDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLDaNhapDataGridViewTextBoxColumn
            // 
            this.sLDaNhapDataGridViewTextBoxColumn.DataPropertyName = "SLDaNhap";
            this.sLDaNhapDataGridViewTextBoxColumn.HeaderText = "SLDaNhap";
            this.sLDaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLDaNhapDataGridViewTextBoxColumn.Name = "sLDaNhapDataGridViewTextBoxColumn";
            this.sLDaNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTPhieuNhapDTOBindingSource
            // 
            this.cTPhieuNhapDTOBindingSource.DataSource = typeof(QLVT.DTO.CTPhieuNhapDTO);
            // 
            // SFPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 725);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dgvDataVatTu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SFPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFPhieuNhap";
            this.Load += new System.EventHandler(this.SFPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Label lbFormName;
        private System.Windows.Forms.DataGridView dgvDataVatTu;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource cTPhieuNhapDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phieuNhapDTOBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}