
namespace QLVT.Views
{
    partial class SFSuaPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFSuaPhieuNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.lbFormName = new System.Windows.Forms.Label();
            this.btnPhieuXuat = new System.Windows.Forms.Button();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.lbSL = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tenhhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLNhapCuaPhieuNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPhieuNhapDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnSL = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapDTOBindingSource)).BeginInit();
            this.pnSL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnControl);
            this.panel1.Controls.Add(this.lbFormName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 140);
            this.panel1.TabIndex = 41;
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.pnSL);
            this.pnControl.Controls.Add(this.btnReload);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 80);
            this.pnControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1051, 60);
            this.pnControl.TabIndex = 41;
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(13, 6);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(45, 45);
            this.btnReload.TabIndex = 5;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lbFormName
            // 
            this.lbFormName.AutoSize = true;
            this.lbFormName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormName.Location = new System.Drawing.Point(286, 18);
            this.lbFormName.Name = "lbFormName";
            this.lbFormName.Size = new System.Drawing.Size(463, 45);
            this.lbFormName.TabIndex = 33;
            this.lbFormName.Text = "CHI TIET PHIEU NHAP";
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhieuXuat.Location = new System.Drawing.Point(0, 8);
            this.btnPhieuXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Size = new System.Drawing.Size(103, 45);
            this.btnPhieuXuat.TabIndex = 7;
            this.btnPhieuXuat.Text = "Nhap SL";
            this.btnPhieuXuat.UseVisualStyleBackColor = true;
            this.btnPhieuXuat.Click += new System.EventHandler(this.btnPhieuXuat_Click);
            // 
            // nudSL
            // 
            this.nudSL.Location = new System.Drawing.Point(116, 3);
            this.nudSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(120, 28);
            this.nudSL.TabIndex = 8;
            this.nudSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.Location = new System.Drawing.Point(112, 34);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(0, 22);
            this.lbSL.TabIndex = 37;
            // 
            // dgvData
            // 
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenhhDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn,
            this.sLDaNhapDataGridViewTextBoxColumn,
            this.sLNhapCuaPhieuNhapDataGridViewTextBoxColumn,
            this.sLNhapDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.cTPhieuNhapDTOBindingSource;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 140);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1051, 342);
            this.dgvData.TabIndex = 42;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 100);
            this.panel2.TabIndex = 43;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(534, 26);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(227, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Huy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(258, 26);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(227, 50);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Xac Nhan";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            // sLNhapCuaPhieuNhapDataGridViewTextBoxColumn
            // 
            this.sLNhapCuaPhieuNhapDataGridViewTextBoxColumn.DataPropertyName = "SLNhapCuaPhieuNhap";
            this.sLNhapCuaPhieuNhapDataGridViewTextBoxColumn.HeaderText = "SLNhapCuaPhieuNhap";
            this.sLNhapCuaPhieuNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLNhapCuaPhieuNhapDataGridViewTextBoxColumn.Name = "sLNhapCuaPhieuNhapDataGridViewTextBoxColumn";
            this.sLNhapCuaPhieuNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLNhapDataGridViewTextBoxColumn
            // 
            this.sLNhapDataGridViewTextBoxColumn.DataPropertyName = "SLNhap";
            this.sLNhapDataGridViewTextBoxColumn.HeaderText = "SLNhap";
            this.sLNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLNhapDataGridViewTextBoxColumn.Name = "sLNhapDataGridViewTextBoxColumn";
            this.sLNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTPhieuNhapDTOBindingSource
            // 
            this.cTPhieuNhapDTOBindingSource.DataSource = typeof(QLVT.DTO.CTPhieuNhapDTO);
            // 
            // pnSL
            // 
            this.pnSL.Controls.Add(this.btnPhieuXuat);
            this.pnSL.Controls.Add(this.lbSL);
            this.pnSL.Controls.Add(this.nudSL);
            this.pnSL.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSL.Enabled = false;
            this.pnSL.Location = new System.Drawing.Point(798, 0);
            this.pnSL.Name = "pnSL";
            this.pnSL.Size = new System.Drawing.Size(253, 60);
            this.pnSL.TabIndex = 38;
            // 
            // SFSuaPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SFSuaPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFSuaPhieuNhap";
            this.Load += new System.EventHandler(this.SFSuaPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapDTOBindingSource)).EndInit();
            this.pnSL.ResumeLayout(false);
            this.pnSL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lbFormName;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.Button btnPhieuXuat;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLNhapCuaPhieuNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cTPhieuNhapDTOBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnSL;
    }
}