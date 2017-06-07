using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAnCuoiKy
{
    public partial class PhucHoiDuLieu : DevExpress.XtraEditors.XtraForm
    {
        public PhucHoiDuLieu()
        {
            InitializeComponent();
        }

        private void buttonEdit1_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn file bạn lưu";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                buttonEdit1.Text = fbd.SelectedPath;

            }
        }
    }
}