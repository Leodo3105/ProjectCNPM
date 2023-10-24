using QuanLyBanPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanPC.Views
{
    public partial class UserControlKH : UserControl
    {
        public UserControlKH()
        {
            InitializeComponent();
        }

        Model1 context = new Model1();

        private void UserControlKH_Load(object sender, EventArgs e)
        {
            List<Customer> listkh = context.Customers.ToList();
            BindGrid(listkh);
            dgvkh.CurrentCell = null;
            btnaddupdate.Enabled = false;
            btndelete.Enabled = false;
            btncancel.Enabled = false;
        }

        public void ResetTextBox()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            rbtnnu.Checked = true;
            txtsdtkh.Text = "";
            txtdckh.Text = "";
            txtmakh.Focus();
            btncancel.Enabled = false;
            btnaddupdate.Enabled = false;
        }

        private void BindGrid(List<Customer> listkh)
        {
            dgvkh.Rows.Clear();
            foreach (var item in listkh)
            {
                int index = dgvkh.Rows.Add();
                dgvkh.Rows[index].Cells["Column1"].Value = item.maKH;
                dgvkh.Rows[index].Cells["Column2"].Value = item.tenKH;
                dgvkh.Rows[index].Cells["Column3"].Value = item.gioitinh;
                dgvkh.Rows[index].Cells["Column4"].Value = item.sdt;
                dgvkh.Rows[index].Cells["Column5"].Value = item.diachiKH;
            }
            txttongkh.Text = dgvkh.Rows.Count.ToString();
        }

        private void btnupdateandfix_Click(object sender, EventArgs e)
        {
            try
            {
                List<Customer> listkh = context.Customers.ToList();
                if (string.IsNullOrEmpty(txtmakh.Text.Trim()) || string.IsNullOrEmpty(txttenkh.Text.Trim()) || string.IsNullOrEmpty(txtsdtkh.Text.Trim()) || string.IsNullOrEmpty(txtdckh.Text.Trim()))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng!");
                if (!txttenkh.Text.All(char.IsLetter))
                    throw new Exception("Vui lòng nhập chính xác tên khách hàng!");
                if (txtsdtkh.Text.Length != 10 || !txtsdtkh.Text.All(char.IsDigit))
                    throw new Exception("Vui lòng nhập chính xác số điện thoại!");
                Customer updateCustomer = context.Customers.FirstOrDefault(p => p.maKH == txtmakh.Text.Trim());
                if (updateCustomer == null)
                {
                    Customer s = new Customer
                    {
                        maKH = txtmakh.Text,
                        tenKH = txttenkh.Text,
                        gioitinh = rbtnnu.Checked ? "Nữ" : "Nam",
                        sdt = txtsdtkh.Text,
                        diachiKH = txtdckh.Text
                    };
                    context.Customers.Add(s);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    updateCustomer.tenKH = txttenkh.Text;
                    updateCustomer.gioitinh = rbtnnu.Checked ? "Nữ" : "Nam";
                    updateCustomer.sdt = txtsdtkh.Text;
                    updateCustomer.diachiKH = txtdckh.Text;
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                context.SaveChanges();
                BindGrid(context.Customers.ToList());
                ResetTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvkh.Rows[e.RowIndex];
                    txtmakh.Text = row.Cells["Column1"].Value.ToString();
                    txttenkh.Text = row.Cells["Column2"].Value.ToString();
                    string gioitinh = row.Cells["Column3"].Value.ToString();
                    if (gioitinh == "Nữ")
                        rbtnnu.Checked = true;
                    else
                        rbtnnam.Checked = true;
                    txtsdtkh.Text = row.Cells["Column4"].Value.ToString();
                    txtdckh.Text = row.Cells["Column5"].Value.ToString();
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
                    foreach (DataGridViewRow row in dgvkh.Rows)
                    {
                        string cellValue1 = row.Cells["Column1"].Value.ToString().ToLower();
                        string cellValue2 = row.Cells["Column2"].Value.ToString().ToLower();
                        string cellValue3 = row.Cells["Column3"].Value.ToString().ToLower();
                        if (cellValue1.Equals(findText) || cellValue2.Contains(findText) || cellValue3.Equals(findText))
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
                    foreach (DataGridViewRow row in dgvkh.Rows)
                        row.Visible = true;
                    txttongkh.Text = dgvkh.Rows.Count.ToString();
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
                Customer delete = context.Customers.FirstOrDefault(p => p.maKH == txtmakh.Text.Trim());
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin khách hàng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.Customers.Remove(delete);
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                context.SaveChanges();
                BindGrid(context.Customers.ToList());
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

        private void txtmakh_TextChanged(object sender, EventArgs e)
        {
            Customer customer = context.Customers.FirstOrDefault(p => p.maKH == txtmakh.Text.Trim());
            if (customer == null)
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
            if (txtmakh.Text.Trim() == null)
                btncancel.Enabled = false;
            else
                btncancel.Enabled = true;
        }
    }
}
