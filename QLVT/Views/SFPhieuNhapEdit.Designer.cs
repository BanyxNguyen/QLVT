
namespace QLVT.Views
{
    partial class SFPhieuNhapEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnControl = new System.Windows.Forms.Panel();
            this.pnXetSL = new System.Windows.Forms.Panel();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.lbXetSL = new System.Windows.Forms.Label();
            this.btnXetSL = new System.Windows.Forms.Button();
            this.cbxKho = new System.Windows.Forms.ComboBox();
            this.lbFormName = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIdPhieuNhap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cTPhieuNhapDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenhhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhapCuaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.pnXetSL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1060, 140);
            this.panel1.TabIndex = 40;
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.lbIdPhieuNhap);
            this.pnControl.Controls.Add(this.label3);
            this.pnControl.Controls.Add(this.pnXetSL);
            this.pnControl.Controls.Add(this.cbxKho);
            this.pnControl.Controls.Add(this.label1);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 80);
            this.pnControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1060, 60);
            this.pnControl.TabIndex = 41;
            // 
            // pnXetSL
            // 
            this.pnXetSL.Controls.Add(this.nudSL);
            this.pnXetSL.Controls.Add(this.lbXetSL);
            this.pnXetSL.Controls.Add(this.btnXetSL);
            this.pnXetSL.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnXetSL.Enabled = false;
            this.pnXetSL.Location = new System.Drawing.Point(818, 0);
            this.pnXetSL.Name = "pnXetSL";
            this.pnXetSL.Size = new System.Drawing.Size(242, 60);
            this.pnXetSL.TabIndex = 45;
            // 
            // nudSL
            // 
            this.nudSL.Location = new System.Drawing.Point(110, 3);
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(120, 28);
            this.nudSL.TabIndex = 43;
            // 
            // lbXetSL
            // 
            this.lbXetSL.AutoSize = true;
            this.lbXetSL.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXetSL.Location = new System.Drawing.Point(118, 34);
            this.lbXetSL.Name = "lbXetSL";
            this.lbXetSL.Size = new System.Drawing.Size(96, 22);
            this.lbXetSL.TabIndex = 44;
            this.lbXetSL.Text = "0<SL<=10";
            // 
            // btnXetSL
            // 
            this.btnXetSL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXetSL.Location = new System.Drawing.Point(4, 7);
            this.btnXetSL.Margin = new System.Windows.Forms.Padding(4);
            this.btnXetSL.Name = "btnXetSL";
            this.btnXetSL.Size = new System.Drawing.Size(77, 45);
            this.btnXetSL.TabIndex = 42;
            this.btnXetSL.Text = "Xet SL";
            this.btnXetSL.UseVisualStyleBackColor = true;
            this.btnXetSL.Click += new System.EventHandler(this.btnXetSL_Click);
            // 
            // cbxKho
            // 
            this.cbxKho.FormattingEnabled = true;
            this.cbxKho.Location = new System.Drawing.Point(551, 16);
            this.cbxKho.Name = "cbxKho";
            this.cbxKho.Size = new System.Drawing.Size(231, 28);
            this.cbxKho.TabIndex = 40;
            // 
            // lbFormName
            // 
            this.lbFormName.AutoSize = true;
            this.lbFormName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormName.Location = new System.Drawing.Point(286, 21);
            this.lbFormName.Name = "lbFormName";
            this.lbFormName.Size = new System.Drawing.Size(463, 45);
            this.lbFormName.TabIndex = 33;
            this.lbFormName.Text = "CHI TIET PHIEU NHAP";
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
            this.SLNhapCuaPhieuNhap,
            this.sLNhapDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.cTPhieuNhapDTOBindingSource;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 140);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1060, 422);
            this.dgvData.TabIndex = 41;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 100);
            this.panel2.TabIndex = 42;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(551, 26);
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
            this.btnSubmit.Location = new System.Drawing.Point(275, 26);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(227, 50);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Xac Nhan";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kho";
            // 
            // lbIdPhieuNhap
            // 
            this.lbIdPhieuNhap.AutoSize = true;
            this.lbIdPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPhieuNhap.Location = new System.Drawing.Point(143, 19);
            this.lbIdPhieuNhap.Name = "lbIdPhieuNhap";
            this.lbIdPhieuNhap.Size = new System.Drawing.Size(27, 22);
            this.lbIdPhieuNhap.TabIndex = 48;
            this.lbIdPhieuNhap.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Id Don Hang: ";
            // 
            // cTPhieuNhapDTOBindingSource
            // 
            this.cTPhieuNhapDTOBindingSource.DataSource = typeof(QLVT.DTO.CTPhieuNhapDTO);
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
            this.slDataGridViewTextBoxColumn.HeaderText = "Sl Tren HD";
            this.slDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.slDataGridViewTextBoxColumn.Name = "slDataGridViewTextBoxColumn";
            this.slDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLDaNhapDataGridViewTextBoxColumn
            // 
            this.sLDaNhapDataGridViewTextBoxColumn.DataPropertyName = "SLDaNhap";
            this.sLDaNhapDataGridViewTextBoxColumn.HeaderText = "SL Nhap HD";
            this.sLDaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLDaNhapDataGridViewTextBoxColumn.Name = "sLDaNhapDataGridViewTextBoxColumn";
            this.sLDaNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SLNhapCuaPhieuNhap
            // 
            this.SLNhapCuaPhieuNhap.DataPropertyName = "SLNhapCuaPhieuNhap";
            this.SLNhapCuaPhieuNhap.HeaderText = "SL Nhap Cu";
            this.SLNhapCuaPhieuNhap.MinimumWidth = 6;
            this.SLNhapCuaPhieuNhap.Name = "SLNhapCuaPhieuNhap";
            this.SLNhapCuaPhieuNhap.ReadOnly = true;
            // 
            // sLNhapDataGridViewTextBoxColumn
            // 
            this.sLNhapDataGridViewTextBoxColumn.DataPropertyName = "SLNhap";
            this.sLNhapDataGridViewTextBoxColumn.HeaderText = "SL Nhap";
            this.sLNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLNhapDataGridViewTextBoxColumn.Name = "sLNhapDataGridViewTextBoxColumn";
            this.sLNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SFEditPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SFEditPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFEditPhieuNhap";
            this.Load += new System.EventHandler(this.SFEditPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.pnXetSL.ResumeLayout(false);
            this.pnXetSL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuNhapDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.ComboBox cbxKho;
        private System.Windows.Forms.Label lbFormName;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource cTPhieuNhapDTOBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnXetSL;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.Label lbXetSL;
        private System.Windows.Forms.Panel pnXetSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhapCuaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLNhapDataGridViewTextBoxColumn;
    }
}