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
    }
}
