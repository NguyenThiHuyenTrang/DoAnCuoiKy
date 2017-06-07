namespace DoAnCuoiKy
{
    partial class NhatKyHeThong
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.doAnLTUDDataSet = new DoAnCuoiKy.DoAnLTUDDataSet();
            this.nhatKyHeThongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhatKyHeThongTableAdapter = new DoAnCuoiKy.DoAnLTUDDataSetTableAdapters.NhatKyHeThongTableAdapter();
            this.doiTuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanhDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucNangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnLTUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhatKyHeThongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataGridView1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(674, 334);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(674, 334);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNguoiDungDataGridViewTextBoxColumn,
            this.mayTinhDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn,
            this.chucNangDataGridViewTextBoxColumn,
            this.hanhDongDataGridViewTextBoxColumn,
            this.doiTuongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhatKyHeThongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 310);
            this.dataGridView1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataGridView1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(654, 314);
            this.layoutControlItem1.Text = " ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(3, 13);
            // 
            // doAnLTUDDataSet
            // 
            this.doAnLTUDDataSet.DataSetName = "DoAnLTUDDataSet";
            this.doAnLTUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhatKyHeThongBindingSource
            // 
            this.nhatKyHeThongBindingSource.DataMember = "NhatKyHeThong";
            this.nhatKyHeThongBindingSource.DataSource = this.doAnLTUDDataSet;
            this.nhatKyHeThongBindingSource.CurrentChanged += new System.EventHandler(this.nhatKyHeThongBindingSource_CurrentChanged);
            // 
            // nhatKyHeThongTableAdapter
            // 
            this.nhatKyHeThongTableAdapter.ClearBeforeFill = true;
            // 
            // doiTuongDataGridViewTextBoxColumn
            // 
            this.doiTuongDataGridViewTextBoxColumn.DataPropertyName = "DoiTuong";
            this.doiTuongDataGridViewTextBoxColumn.HeaderText = "Đối tượng";
            this.doiTuongDataGridViewTextBoxColumn.Name = "doiTuongDataGridViewTextBoxColumn";
            // 
            // hanhDongDataGridViewTextBoxColumn
            // 
            this.hanhDongDataGridViewTextBoxColumn.DataPropertyName = "HanhDong";
            this.hanhDongDataGridViewTextBoxColumn.HeaderText = "Hành động";
            this.hanhDongDataGridViewTextBoxColumn.Name = "hanhDongDataGridViewTextBoxColumn";
            // 
            // chucNangDataGridViewTextBoxColumn
            // 
            this.chucNangDataGridViewTextBoxColumn.DataPropertyName = "ChucNang";
            this.chucNangDataGridViewTextBoxColumn.HeaderText = "Chức năng";
            this.chucNangDataGridViewTextBoxColumn.Name = "chucNangDataGridViewTextBoxColumn";
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            // 
            // mayTinhDataGridViewTextBoxColumn
            // 
            this.mayTinhDataGridViewTextBoxColumn.DataPropertyName = "MayTinh";
            this.mayTinhDataGridViewTextBoxColumn.HeaderText = "Máy tính";
            this.mayTinhDataGridViewTextBoxColumn.Name = "mayTinhDataGridViewTextBoxColumn";
            // 
            // maNguoiDungDataGridViewTextBoxColumn
            // 
            this.maNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNguoiDung";
            this.maNguoiDungDataGridViewTextBoxColumn.HeaderText = "Mã người dùng";
            this.maNguoiDungDataGridViewTextBoxColumn.Name = "maNguoiDungDataGridViewTextBoxColumn";
            // 
            // NhatKyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 334);
            this.Controls.Add(this.layoutControl1);
            this.Name = "NhatKyHeThong";
            this.Text = "Nhật ký hệ thống";
            this.Load += new System.EventHandler(this.NhatKyHeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnLTUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhatKyHeThongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DoAnLTUDDataSet doAnLTUDDataSet;
        private System.Windows.Forms.BindingSource nhatKyHeThongBindingSource;
        private DoAnLTUDDataSetTableAdapters.NhatKyHeThongTableAdapter nhatKyHeThongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucNangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doiTuongDataGridViewTextBoxColumn;
    }
}