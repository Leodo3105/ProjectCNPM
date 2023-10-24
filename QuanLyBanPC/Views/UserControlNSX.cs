using QuanLyBanPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanPC.Views
{
    public partial class UserControlNSX : UserControl
    {
        public UserControlNSX()
        {
            InitializeComponent();
        }

        Model1 context = new Model1();

        private void UserControlNSX_Load(object sender, EventArgs e)
        {
            List<NSX> listnsx = context.NSXes.ToList();
            BindGrid(listnsx);
            dgvnsx.CurrentCell = null;
            btnaddupdate.Enabled = false;
            btndelete.Enabled = false;
            btncancel.Enabled = false;
        }

        public void ResetTextBox()
        {
            txtmansx.Text = "";
            txttennsx.Text = "";
            txtdcnsx.Text = "";
            txtmansx.Focus();
            btncancel.Enabled = false;
            btnaddupdate.Enabled = false;
        }

        private void BindGrid(List<NSX> listnsx)
        {
            dgvnsx.Rows.Clear();
            foreach (var item in listnsx)
            {
                int index = dgvnsx.Rows.Add();
                dgvnsx.Rows[index].Cells["Column1"].Value = item.maNSX;
                dgvnsx.Rows[index].Cells["Column2"].Value = item.tenNSX;
                dgvnsx.Rows[index].Cells["Column3"].Value = item.diachiNSX;
            }
            txttongkh.Text = dgvnsx.Rows.Count.ToString();
        }

        private void btnupdateandfix_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmansx.Text.Trim()) || string.IsNullOrEmpty(txttennsx.Text.Trim()) || string.IsNullOrEmpty(txtdcnsx.Text.Trim()))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhà sản xuất!");
                if (!txttennsx.Text.All(char.IsLetter))
                    throw new Exception("Vui lòng nhập chính xác tên nhà sản xuất!");
                NSX updateNSX = context.NSXes.FirstOrDefault(p => p.maNSX == txtmansx.Text.Trim());
                if (updateNSX == null)
                {
                    NSX s = new NSX
                    {
                        maNSX = txtmansx.Text,
                        tenNSX = txttennsx.Text,
                        diachiNSX = txtdcnsx.Text
                    };
                    context.NSXes.Add(s);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    updateNSX.tenNSX = txttennsx.Text;
                    updateNSX.diachiNSX = txtdcnsx.Text;
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                context.SaveChanges();
                BindGrid(context.NSXes.ToList());
                ResetTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvnsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvnsx.Rows[e.RowIndex];

                    txtmansx.Text = row.Cells["Column1"].Value.ToString();
                    txttennsx.Text = row.Cells["Column2"].Value.ToString();
                    txtdcnsx.Text = row.Cells["Column3"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtfindsp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalRow = 0;
                string findText = txtfindsp.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(findText))
                {
                    foreach (DataGridViewRow row in dgvnsx.Rows)
                    {
                        string cellValue1 = row.Cells["Column1"].Value.ToString().ToLower();
                        string cellValue2 = row.Cells["Column2"].Value.ToString().ToLower();
                        string cellValue3 = row.Cells["Column3"].Value.ToString().ToLower();
                        if (cellValue1.Equals(findText) || cellValue2.Contains(findText) || cellValue3.Contains(findText))
                        {
                            row.Visible = true;
                            totalRow++;
                        }
                        else
                            row.Visible = false;
                    }
                    txttongkh.Text = totalRow.ToString();
                }
                else
                {
                    foreach (DataGridViewRow row in dgvnsx.Rows)
                        row.Visible = true;
                    txttongkh.Text = dgvnsx.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                NSX delete = context.NSXes.FirstOrDefault(p => p.maNSX == txtmansx.Text.Trim());
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin nhà sản xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.NSXes.Remove(delete);
                    MessageBox.Show("Xóa nhà sản xuất thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                context.SaveChanges();
                BindGrid(context.NSXes.ToList());
                ResetTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }

        private void txtmansx_TextChanged(object sender, EventArgs e)
        {
            NSX nsx = context.NSXes.FirstOrDefault(p => p.maNSX == txtmansx.Text.Trim());
            if (nsx == null)
            {
                btnaddupdate.Enabled = true;
                btnaddupdate.Text = "&Thêm";
                btndelete.Enabled = false;
            }
            else
            {
                btnaddupdate.Enabled = true;
                btnaddupdate.Text = "&Sửa";
                btndelete.Enabled = true;
            }
            if (txtmansx.Text.Trim() == null)
                btncancel.Enabled = false;
            else
                btncancel.Enabled = true;
        }
    }
}
