using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanPC.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Tạo list chứa Guna2button và UserControl
        List<Guna2Button> btnList = new List<Guna2Button>();
        List<UserControl> btnUserControl = new List<UserControl>();

        // Tạo biến lấy dữ liệu từ tên đăng nhập của frmLogin
        public string DataFromForm1 { get; set; }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setbtn1();
            // Thêm item vào 2 list
            btnList.Add(btn1);
            btnList.Add(btn2);
            btnList.Add(btn3);
            btnList.Add(btn4);
            btnList.Add(btn5);
            btnList.Add(btn6);
            btnUserControl.Add(userControlTC1);
            btnUserControl.Add(userControlSP1);
            btnUserControl.Add(userControlKH1);
            btnUserControl.Add(userControlHD1);
            btnUserControl.Add(userControlNSX1);
            btnUserControl.Add(userControlTK1);
        }

        private void clickGradientButton(Guna2Button btn)
        {
            // Thay đổi button khi click
            btn.FillColor = Color.FromArgb(207, 217, 223);
            btn.ForeColor = Color.Black;
            panel.Visible = true;
            panel.Height = btn.Height;
            panel.Top = btn.Top;
            panel.BringToFront();
        }

        private void setbtn1()
        {
            // Set click cho btn1 khi load form
            labeluser.Text = "Xin chào " + DataFromForm1;
            clickGradientButton(btn1);
            userControlTC1.BringToFront();
            labeluser.BringToFront();
            btn1.Image = imageCollection1.Images[0];
        }

        private void btns_Click(object sender, EventArgs e)
        {
            // Tạo 1 button chung cho 6 button
            Guna2Button clickedButton = sender as Guna2Button;
            // Lấy vị trí button khi click
            int buttonIndex = btnList.IndexOf(clickedButton);
            // Set click riêng cho btn1
            if (buttonIndex == 0)
                setbtn1();
            // Set click chung cho các button còn lại
            for (int i = 0; i < btnList.Count; i++)
            {
                if (i == buttonIndex)
                {
                    if (i != 0)
                    {
                        btnList[i].Image = imageCollection1.Images[i];
                        clickGradientButton(btnList[i]);
                        btnUserControl[i].BringToFront();
                        btnUserControl[i].Focus();
                    }
                }
                else
                {
                    btnList[i].Image = imageCollection1.Images[i + 6];
                    btnList[i].FillColor = Color.FromArgb(40, 40, 40);
                    btnList[i].ForeColor = Color.White;
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Một số dữ liệu có thể chưa được lưu, bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            userControlSP1.FillNSXCombobox();
            userControlHD1.FillComboboxMaKH();
            userControlHD1.FillComboboxTenSP();
            userControlTK1.FillComboBoxYear();
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            frmLogin frm1 = new frmLogin();
            frm1.Show();
            this.Hide();
        }
    }
}
