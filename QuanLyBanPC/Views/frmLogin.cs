using QuanLyBanPC.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanPC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {
            // Hiện mật khẩu
            txtpass.Multiline = true;
            txtpass.Focus();
            btnshowpass.Visible = false;
            btnhidepass.Visible = true;
        }

        private void btnhidepass_Click(object sender, EventArgs e)
        {
            // Ẩn mật khẩu
            txtpass.Multiline = false;
            txtpass.Focus();
            btnshowpass.Visible = true;
            btnhidepass.Visible = false;
        }

        private void setbtnLogin()
        {
            // Set button đăng nhập khi bị vô hiệu hóa
            btnlogin.Enabled = false;
            btnlogin.Image = Properties.Resources._13;
            btnlogin.FillColor = Color.Transparent;
            btnlogin.BorderThickness = 2;
            btnlogin.BorderColor = Color.Silver;
            btnlogin.Cursor = Cursors.Default;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            setbtnLogin();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            // Set button đăng nhập khi textbox thay đổi
            if (!string.IsNullOrEmpty(txtuser.Text.Trim()) && !string.IsNullOrEmpty(txtpass.Text.Trim()))
            {
                btnlogin.Enabled = true;
                btnlogin.Image = Properties.Resources._14;
                btnlogin.FillColor = Color.FromArgb(0, 132, 255);
                btnlogin.BorderThickness = 0;
                btnlogin.Cursor = Cursors.Hand;
                btnlogin.HoverState.FillColor = Color.RoyalBlue;
            }
            else
                setbtnLogin();
        }

        bool state = false;

        private void transition_Tick(object sender, EventArgs e)
        {
            // Tạo animation cho button đăng nhập
            if (state == false)
            {
                btnlogin.Width += 20;
                btnlogin.Location = new Point(btnlogin.Location.X - 10, 307);
                btnlogin.TextAlign = HorizontalAlignment.Center;
                btnlogin.ImageAlign = HorizontalAlignment.Left;
                btnlogin.Focus();
                btnlogin.BorderRadius = 25;
                if (btnlogin.Width == 232 && btnlogin.Location == new Point(640, 307))
                {
                    btnlogin.Text = "Đăng nhập";
                    transition.Stop();
                    state = true;
                }
            }
            else
            {
                btnlogin.Width -= 20;
                btnlogin.Location = new Point(btnlogin.Location.X + 10, 307);
                btnlogin.ImageAlign = HorizontalAlignment.Center;
                btnlogin.BorderRadius = 16;
                btnlogin.Text = null;
                if (btnlogin.Width == 52 && btnlogin.Location == new Point(730, 307))
                {
                    transition.Stop();
                    state = false;
                }
            }
        }

        private void btnlogin_MouseHover(object sender, EventArgs e)
        {
            transition.Start();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (btnlogin.Enabled)
            {
                if (txtpass.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtpass.Focus();
                    txtpass.Clear();
                }
                else if (txtpass.Text.Contains(" ") || txtuser.Text.Contains(" "))
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuser.Focus();
                    txtuser.Clear();
                    txtpass.Clear();
                }
                else
                {
                    frmMain main = new frmMain();
                    main.DataFromForm1 = txtuser.Text.Trim();
                    main.Show();
                    this.Hide();
                }
            }
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tạo phím tắt dẫn đến button đăng nhập
            if (e.KeyChar == (char)Keys.Enter)
                btnlogin.PerformClick();
        }
    }
}
