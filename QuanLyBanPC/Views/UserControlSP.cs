using QuanLyBanPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanPC.Views
{
    public partial class UserControlSP : UserControl
    {
        public UserControlSP()
        {
            InitializeComponent();
        }

        Model1 context = new Model1();

        private void UserControlSP_Load(object sender, EventArgs e)
        {
            List<Product> listsps = context.Products.ToList();
            FillNSXCombobox();
            BindGrid(listsps);
            dgvsp.CurrentCell = null;
            btnaddupdate.Enabled = false;
            btndelete.Enabled = false;
            btncancel.Enabled = false;
        }

        public void ResetTextBox()
        {
            txtmasp.Text = "";
            txttensp.Text = "";
            txtbh.Text = "";
            cbbNSX.SelectedIndex = 0;
            txtmota.Text = "";
            txtmasp.Focus();
            btncancel.Enabled = false;
            btnaddupdate.Enabled = false;
        }

        public void FillNSXCombobox()
        {
            List<NSX> listnsxes = context.NSXes.ToList();
            this.cbbNSX.DataSource = listnsxes;
            this.cbbNSX.DisplayMember = "tenNSX";
            this.cbbNSX.ValueMember = "maNSX";
        }

        public void BindGrid(List<Product> listsps)
        {
            dgvsp.Rows.Clear();
            foreach (var item in listsps)
            {
                int index = dgvsp.Rows.Add();
                dgvsp.Rows[index].Cells["Column1"].Value = item.maSP;
                dgvsp.Rows[index].Cells["Column2"].Value = item.tenSP;
                dgvsp.Rows[index].Cells["Column3"].Value = item.baohanh;
                dgvsp.Rows[index].Cells["Column4"].Value = item.NSX.tenNSX;
                dgvsp.Rows[index].Cells["Column5"].Value = item.mota;
            }
            txttongsp.Text = dgvsp.Rows.Count.ToString();
        }

        private void btnaddupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmasp.Text.Trim()) || string.IsNullOrEmpty(txttensp.Text.Trim()) || string.IsNullOrEmpty(txtbh.Text.Trim()) || string.IsNullOrEmpty(txtmota.Text.Trim()))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                if (int.Parse(txtbh.Text) < 0 || !txtbh.Text.All(char.IsDigit))
                    throw new Exception("Vui lòng nhập chính xác bảo hành!");
                Product updateProduct = context.Products.FirstOrDefault(p => p.maSP == txtmasp.Text.Trim());
                if (updateProduct == null)
                {
                    Product s = new Product
                    {
                        maSP = txtmasp.Text,
                        tenSP = txttensp.Text,
                        baohanh = int.Parse(txtbh.Text),
                        maNSX = cbbNSX.SelectedValue.ToString(),
                        mota = txtmota.Text
                    };
                    context.Products.Add(s);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    updateProduct.tenSP = txttensp.Text;
                    updateProduct.baohanh = int.Parse(txtbh.Text);
                    updateProduct.maNSX = cbbNSX.SelectedValue.ToString();
                    updateProduct.mota = txtmota.Text;
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                context.SaveChanges();
                BindGrid(context.Products.ToList());
                ResetTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvsp.Rows[e.RowIndex];
                    txtmasp.Text = row.Cells["Column1"].Value.ToString();
                    txttensp.Text = row.Cells["Column2"].Value.ToString();
                    txtbh.Text = row.Cells["Column3"].Value.ToString();
                    cbbNSX.Text = row.Cells["Column4"].Value.ToString();
                    txtmota.Text = row.Cells["Column5"].Value.ToString();
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
                    foreach (DataGridViewRow row in dgvsp.Rows)
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
                    txttongsp.Text = totalRow.ToString();
                }
                else
                {
                    foreach (DataGridViewRow row in dgvsp.Rows)
                        row.Visible = true;
                    txttongsp.Text = dgvsp.Rows.Count.ToString();
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
                Product delete = context.Products.FirstOrDefault(p => p.maSP == txtmasp.Text.Trim());
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin sản phẩm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.Products.Remove(delete);
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                context.SaveChanges();
                BindGrid(context.Products.ToList());
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

        private void txtmasp_TextChanged(object sender, EventArgs e)
        {
            Product product = context.Products.FirstOrDefault(p => p.maSP == txtmasp.Text.Trim());
            if (product == null)
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
            if (txtmasp.Text.Trim() == null)
                btncancel.Enabled = false;
            else
                btncancel.Enabled = true;
        }
    }
}
