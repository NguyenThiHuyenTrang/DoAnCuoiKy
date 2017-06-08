using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        DuLieuDataContext dulieu = new DuLieuDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
           
                var KTDangNhap = (from login in dulieu.logins
                                  where login.username == tb_username.Text.Trim() && login.pass == tb_pass.Text
                                  select login).SingleOrDefault();
                if (KTDangNhap == null)
                {
                    MessageBox.Show("Username hoặc Password không đúng. Vui lòng kiểm tra lại!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!");
                   ribbonControl1.Visible = true;
                   panel1.Visible = false;
                   this.IsMdiContainer = true;
                  if(checkRememer.Checked == true)
                  {
                    DoAnCuoiKy.Properties.Settings.Default.Username = tb_username.Text;
                    DoAnCuoiKy.Properties.Settings.Default.Passsword = tb_pass.Text;
                    DoAnCuoiKy.Properties.Settings.Default.Remember = true;
                    DoAnCuoiKy.Properties.Settings.Default.Save();
                  }
                  else
                  {
                    DoAnCuoiKy.Properties.Settings.Default.Username = "";
                    DoAnCuoiKy.Properties.Settings.Default.Passsword = "";
                    DoAnCuoiKy.Properties.Settings.Default.Remember = false;
                }

                }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ribbonControl1.Visible = false;
            tb_username.Text = DoAnCuoiKy.Properties.Settings.Default.Username;
            tb_pass.Text = DoAnCuoiKy.Properties.Settings.Default.Passsword;
            checkRememer.Checked = DoAnCuoiKy.Properties.Settings.Default.Remember;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new NhapHang();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new BanHang();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ChuyenKho();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new SoDuDauKy();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ThuTien();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new TraTien();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ThongTin();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ThayDoiMatKhau();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new NhatKyHeThong();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new SaoLuuDuLieu();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new PhucHoiDuLieu();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
    }
}
