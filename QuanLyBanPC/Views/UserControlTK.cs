using Microsoft.Reporting.WinForms;
using QuanLyBanPC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanPC.Views
{
    public partial class UserControlTK : UserControl
    {
        public UserControlTK()
        {
            InitializeComponent();
        }

        Model1 context = new Model1();

        private void UserControlTK_Load(object sender, EventArgs e)
        {
            FillComboBoxYear();
        }

        public void FillComboBoxYear()
        {
            List<Invoice> listhd = context.Invoices.ToList();
            var distinctYears = listhd.Select(hd => hd.ngaylap.Year).Distinct().ToList();
            this.cbbyear.DataSource = distinctYears;
            this.cbbyear.DisplayMember = "NgayLapNam";
        }

        private void cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReportViewer();
        }

        private void RefreshReportViewer()
        {
            int selectedMonth = cbbmonth.SelectedIndex;
            int selectedYear = Convert.ToInt32(cbbyear.SelectedItem);
            if (selectedMonth == 0)
            {
                List<Invoice> allInvoices = context.Invoices.Where(hd => hd.ngaylap.Year == selectedYear).ToList();
                reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", allInvoices));
                reportViewer1.RefreshReport();
            }
            else
            {
                List<Invoice> invoices = context.Invoices.Where(hd => hd.ngaylap.Month == selectedMonth && hd.ngaylap.Year == selectedYear).ToList();
                reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", invoices));
                reportViewer1.RefreshReport();
            }
        }
    }
}
