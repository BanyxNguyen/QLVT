
namespace QLVT.Views
{
    partial class UCNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNhanVien));
            this.pnControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttxoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnControl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.label1);
            this.pnControl.Controls.Add(this.cmbBranch);
            this.pnControl.Controls.Add(this.btnReload);
            this.pnControl.Controls.Add(this.btnAdd);
            this.pnControl.Controls.Add(this.btnDelete);
            this.pnControl.Controls.Add(this.btnEdit);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1040, 60);
            this.pnControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chi Nhanh";
            // 
            // cmbBranch
            // 
            this.cmbBranch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(748, 15);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(263, 28);
            this.cmbBranch.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(163, 6);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(45, 45);
            this.btnReload.TabIndex = 5;
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
            this.btnAdd.TabIndex = 3;
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
            this.btnDelete.TabIndex = 2;
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
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 525);
            this.panel2.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manvDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.cmndDataGridViewTextBoxColumn,
            this.phaiDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.ttxoaDataGridViewTextBoxColumn});
            this.dgvNhanVien.DataSource = this.nhanvienBindingSource;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1040, 525);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // manvDataGridViewTextBoxColumn
            // 
            this.manvDataGridViewTextBoxColumn.DataPropertyName = "Manv";
            this.manvDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.manvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            this.manvDataGridViewTextBoxColumn.ReadOnly = true;
            this.manvDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoDataGridViewTextBoxColumn
            // 
            this.hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn.HeaderText = "Họ";
            this.hoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            this.hoDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "Luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "Lương";
            this.luongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            this.luongDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "Sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sdtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.ReadOnly = true;
            this.sdtDataGridViewTextBoxColumn.Width = 125;
            // 
            // cmndDataGridViewTextBoxColumn
            // 
            this.cmndDataGridViewTextBoxColumn.DataPropertyName = "Cmnd";
            this.cmndDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cmndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cmndDataGridViewTextBoxColumn.Name = "cmndDataGridViewTextBoxColumn";
            this.cmndDataGridViewTextBoxColumn.ReadOnly = true;
            this.cmndDataGridViewTextBoxColumn.Width = 125;
            // 
            // phaiDataGridViewTextBoxColumn
            // 
            this.phaiDataGridViewTextBoxColumn.DataPropertyName = "Phai";
            this.phaiDataGridViewTextBoxColumn.HeaderText = "Phái";
            this.phaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phaiDataGridViewTextBoxColumn.Name = "phaiDataGridViewTextBoxColumn";
            this.phaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.phaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            this.ngaysinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaysinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diachiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ttxoaDataGridViewTextBoxColumn
            // 
            this.ttxoaDataGridViewTextBoxColumn.DataPropertyName = "Ttxoa";
            this.ttxoaDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.ttxoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ttxoaDataGridViewTextBoxColumn.Name = "ttxoaDataGridViewTextBoxColumn";
            this.ttxoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ttxoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataSource = typeof(QLVT.Models.Nhanvien);
            // 
            // UCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnControl);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(1040, 585);
            this.Load += new System.EventHandler(this.UCNhanVien_Load);
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttxoaDataGridViewTextBoxColumn;
    }
}
