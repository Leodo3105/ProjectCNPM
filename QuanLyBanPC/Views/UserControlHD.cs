using QuanLyBanPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanPC.Views
{
    public partial class UserControlHD : UserControl
    {
        public UserControlHD()
        {
            InitializeComponent();
        }

        Model1 context = new Model1();

        private void UserControlHD_Load(object sender, EventArgs e)
        {
            List<InvoiceDetail> listcthd = context.InvoiceDetails.ToList();
            FillComboboxMaKH();
            BindGrid(listcthd);
            FillComboboxTenSP();
            dgvhd.CurrentCell = null;
            btnaddupdate.Enabled = false;
            btndelete.Enabled = false;
            btncancel.Enabled = false;
        }

        public void ResetTextBox()
        {
            txtmahd.Text = "";
            cbbmakh.SelectedIndex = 0;
            cbbtensp.SelectedIndex = 0;
            txtgiaban.Text = "";
            txtsoluong.Text = "";
            txtngaylap.Text = "";
            txtmahd.Focus();
            btncancel.Enabled = false;
            btnaddupdate.Enabled = false;
        }

        private void BindGrid(List<InvoiceDetail> listcthd)
        {
            dgvhd.Rows.Clear();
            foreach (var item in listcthd)
            {
                int index = dgvhd.Rows.Add();
                dgvhd.Rows[index].Cells["Column1"].Value = item.maHD;
                dgvhd.Rows[index].Cells["Column2"].Value = item.Invoice.maKH;
                InvoiceDetail detailInvoice = context.InvoiceDetails.FirstOrDefault(d => d.maSP == item.maSP);
                dgvhd.Rows[index].Cells["Column3"].Value = detailInvoice.Product.tenSP;
                dgvhd.Rows[index].Cells["Column4"].Value = item.giaban;
                dgvhd.Rows[index].Cells["Column5"].Value = item.soluong;
                dgvhd.Rows[index].Cells["Column6"].Value = item.soluong * item.giaban;
                dgvhd.Rows[index].Cells["Column7"].Value = item.Invoice.ngaylap;
            }
            txttonghd.Text = dgvhd.Rows.Count.ToString();
        }

        public void FillComboboxMaKH()
        {
            List<Customer> listkh = context.Customers.ToList();
            this.cbbmakh.DataSource = listkh;
            this.cbbmakh.DisplayMember = "maKH";
            this.cbbmakh.ValueMember = "maKH";
        }

        public void FillComboboxTenSP()
        {
            List<Product> listsp = context.Products.ToList();
            this.cbbtensp.DataSource = listsp;
            this.cbbtensp.DisplayMember = "tenSP";
            this.cbbtensp.ValueMember = "maSP";
        }

        private void btnupdateandfix_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmahd.Text.Trim()) || string.IsNullOrEmpty(txtgiaban.Text.Trim()) || string.IsNullOrEmpty(txtsoluong.Text.Trim()))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin hóa đơn!");
                if (!txtgiaban.Text.All(char.IsDigit) || int.Parse(txtgiaban.Text) < 0)
                    throw new Exception("Vui lòng nhập chính xác đơn giá!");
                if (!txtsoluong.Text.All(char.IsDigit) || int.Parse(txtgiaban.Text) <= 0)
                    throw new Exception("Vui lòng nhập chính xác số lượng!");
                Invoice updateInvoice = context.Invoices.FirstOrDefault(p => p.maHD == txtmahd.Text.Trim());
                if (updateInvoice == null)
                {
                    InvoiceDetail s = new InvoiceDetail
                    {
                        maHD = txtmahd.Text,
                        maSP = cbbtensp.SelectedValue.ToString(),
                        soluong = int.Parse(txtsoluong.Text.ToString()),
                        giaban = int.Parse(txtgiaban.Text.ToString())
                    };
                    Invoice s1 = new Invoice
                    {
                        maHD = txtmahd.Text,
                        ngaylap = txtngaylap.Value,
                        dongia = s.soluong * s.giaban,
                        maKH = cbbmakh.SelectedValue.ToString()
                    };
                    context.Invoices.Add(s1);
                    context.InvoiceDetails.Add(s);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InvoiceDetail updateInvoiceDetail = context.InvoiceDetails.FirstOrDefault(p => p.maHD == txtmahd.Text.Trim());
                    updateInvoice.ngaylap = txtngaylap.Value;
                    updateInvoice.dongia = int.Parse(txtsoluong.Text.ToString()) * int.Parse(txtgiaban.Text.ToString());
                    updateInvoice.maKH = cbbmakh.SelectedValue.ToString();
                    InvoiceDetail newInvoiceDetail = new InvoiceDetail
                    {
                        maHD = txtmahd.Text,
                        maSP = cbbtensp.SelectedValue.ToString(),
                        soluong = int.Parse(txtsoluong.Text.ToString()),
                        giaban = int.Parse(txtgiaban.Text.ToString())
                    };
                    context.InvoiceDetails.Remove(updateInvoiceDetail);
                    context.InvoiceDetails.Add(newInvoiceDetail);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                context.SaveChanges();
                BindGrid(context.InvoiceDetails.ToList());
                ResetTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvhd.Rows[e.RowIndex];

                    txtmahd.Text = row.Cells["Column1"].Value.ToString();
                    cbbmakh.Text = row.Cells["Column2"].Value.ToString();
                    cbbtensp.Text = row.Cells["Column3"].Value.ToString();
                    txtgiaban.Text = row.Cells["Column4"].Value.ToString();
                    txtsoluong.Text = row.Cells["Column5"].Value.ToString();
                    txtngaylap.Text = row.Cells["Column7"].Value.ToString();
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
                    foreach (DataGridViewRow row in dgvhd.Rows)
                    {
                        string cellValue1 = row.Cells["Column1"].Value.ToString().ToLower();
                        string cellValue2 = row.Cells["Column2"].Value.ToString().ToLower();
                        string cellValue3 = row.Cells["Column3"].Value.ToString().ToLower();
                        string cellValue6 = row.Cells["Column6"].Value.ToString().ToLower();
                        string cellValue7 = row.Cells["Column7"].Value.ToString().ToLower();

                        if (cellValue1.Equals(findText) || cellValue2.Equals(findText) || cellValue3.Contains(findText) || cellValue6.Equals(findText) || cellValue7.Contains(findText))
                        {
                            row.Visible = true;
                            totalRow++;
                        }
                        else
                            row.Visible = false;
                    }
                    txttonghd.Text = totalRow.ToString();
                }
                else
                {
                    foreach (DataGridViewRow row in dgvhd.Rows)
                        row.Visible = true;
                    txttonghd.Text = dgvhd.Rows.Count.ToString();
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
                Invoice delete = context.Invoices.FirstOrDefault(p => p.maHD == txtmahd.Text.Trim());
                InvoiceDetail delete1 = context.InvoiceDetails.FirstOrDefault(p => p.maHD == txtmahd.Text.Trim());
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin hóa đơn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    context.Invoices.Remove(delete);
                    context.InvoiceDetails.Remove(delete1);
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                context.SaveChanges();
                BindGrid(context.InvoiceDetails.ToList());
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

        private void txtmahd_TextChanged(object sender, EventArgs e)
        {
            Invoice invoice = context.Invoices.FirstOrDefault(p => p.maHD == txtmahd.Text.Trim());
            if (invoice == null)
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
            if (txtmahd.Text.Trim() == null)
                btncancel.Enabled = false;
            else
                btncancel.Enabled = true;
        }
    }
}
