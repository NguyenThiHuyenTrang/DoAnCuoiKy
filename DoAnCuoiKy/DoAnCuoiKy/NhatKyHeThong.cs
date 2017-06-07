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
    public partial class NhatKyHeThong : DevExpress.XtraEditors.XtraForm
    {
        public NhatKyHeThong()
        {
            InitializeComponent();
        }

        private void NhatKyHeThong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAnLTUDDataSet.NhatKyHeThong' table. You can move, or remove it, as needed.
            this.nhatKyHeThongTableAdapter.Fill(this.doAnLTUDDataSet.NhatKyHeThong);

        }

        private void nhatKyHeThongBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}