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
            this.nhatKyHeThongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAnLTUDDataSet = new DoAnCuoiKy.DoAnLTUDDataSet();
            this.nhatKyHeThongTableAdapter = new DoAnCuoiKy.DoAnLTUDDataSetTableAdapters.NhatKyHeThongTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.doiTuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanhDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucNangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nhatKyHeThongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnLTUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nhatKyHeThongBindingSource
            // 
            this.nhatKyHeThongBindingSource.DataMember = "NhatKyHeThong";
            this.nhatKyHeThongBindingSource.DataSource = this.doAnLTUDDataSet;
            // 
            // doAnLTUDDataSet
            // 
            this.doAnLTUDDataSet.DataSetName = "DoAnLTUDDataSet";
            this.doAnLTUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhatKyHeThongTableAdapter
            // 
            this.nhatKyHeThongTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xem", null, "Preview;Size16x16"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa", null, "Delete;Size16x16"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu vào tập tin", null, "Save;Size16x16"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Đọc từ tập tin ", null, "Open;Size16x16"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất", null, "ExportToXLS;Size16x16"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Đóng", null, "Close;Size16x16")});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(672, 390);
            this.groupControl1.TabIndex = 1;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 359);
            this.dataGridView1.TabIndex = 5;
            // 
            // NhatKyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 390);
            this.Controls.Add(this.groupControl1);
            this.Name = "NhatKyHeThong";
            this.Text = "Nhật ký hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.nhatKyHeThongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnLTUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nhatKyHeThongBindingSource;
        private DoAnLTUDDataSet doAnLTUDDataSet;
        private DoAnLTUDDataSetTableAdapters.NhatKyHeThongTableAdapter nhatKyHeThongTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucNangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhDongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doiTuongDataGridViewTextBoxColumn;
    }
}