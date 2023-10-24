namespace QuanLyBanPC.Views
{
    partial class UserControlTK
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbbmonth = new System.Windows.Forms.ComboBox();
            this.cbbyear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanPC.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 70);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(950, 545);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // cbbmonth
            // 
            this.cbbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmonth.FormattingEnabled = true;
            this.cbbmonth.Items.AddRange(new object[] {
            "Cả năm",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbbmonth.Location = new System.Drawing.Point(175, 20);
            this.cbbmonth.Margin = new System.Windows.Forms.Padding(0);
            this.cbbmonth.Name = "cbbmonth";
            this.cbbmonth.Size = new System.Drawing.Size(236, 28);
            this.cbbmonth.TabIndex = 1;
            this.cbbmonth.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectedIndexChanged);
            // 
            // cbbyear
            // 
            this.cbbyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbyear.FormattingEnabled = true;
            this.cbbyear.Location = new System.Drawing.Point(503, 20);
            this.cbbyear.Margin = new System.Windows.Forms.Padding(0);
            this.cbbyear.Name = "cbbyear";
            this.cbbyear.Size = new System.Drawing.Size(236, 28);
            this.cbbyear.TabIndex = 1;
            this.cbbyear.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectedIndexChanged);
            // 
            // UserControlTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbyear);
            this.Controls.Add(this.cbbmonth);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlTK";
            this.Size = new System.Drawing.Size(950, 615);
            this.Load += new System.EventHandler(this.UserControlTK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbbmonth;
        private System.Windows.Forms.ComboBox cbbyear;
    }
}
