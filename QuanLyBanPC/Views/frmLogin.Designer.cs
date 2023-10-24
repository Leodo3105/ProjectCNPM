namespace QuanLyBanPC
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.transition = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnhidepass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnshowpass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnhidepass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshowpass)).BeginInit();
            this.SuspendLayout();
            // 
            // transition
            // 
            this.transition.Interval = 10;
            this.transition.Tick += new System.EventHandler(this.transition_Tick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2ControlBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(890, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(50, 35);
            this.guna2ControlBox1.TabIndex = 33;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btnhidepass
            // 
            this.btnhidepass.BackColor = System.Drawing.Color.White;
            this.btnhidepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhidepass.Image = ((System.Drawing.Image)(resources.GetObject("btnhidepass.Image")));
            this.btnhidepass.ImageRotate = 0F;
            this.btnhidepass.Location = new System.Drawing.Point(833, 182);
            this.btnhidepass.Margin = new System.Windows.Forms.Padding(0);
            this.btnhidepass.Name = "btnhidepass";
            this.btnhidepass.Size = new System.Drawing.Size(26, 16);
            this.btnhidepass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnhidepass.TabIndex = 35;
            this.btnhidepass.TabStop = false;
            this.btnhidepass.Visible = false;
            this.btnhidepass.Click += new System.EventHandler(this.btnhidepass_Click);
            // 
            // btnshowpass
            // 
            this.btnshowpass.BackColor = System.Drawing.Color.White;
            this.btnshowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowpass.Image = ((System.Drawing.Image)(resources.GetObject("btnshowpass.Image")));
            this.btnshowpass.ImageRotate = 0F;
            this.btnshowpass.Location = new System.Drawing.Point(833, 182);
            this.btnshowpass.Margin = new System.Windows.Forms.Padding(0);
            this.btnshowpass.Name = "btnshowpass";
            this.btnshowpass.Size = new System.Drawing.Size(26, 16);
            this.btnshowpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnshowpass.TabIndex = 36;
            this.btnshowpass.TabStop = false;
            this.btnshowpass.Click += new System.EventHandler(this.btnshowpass_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BorderColor = System.Drawing.Color.Silver;
            this.btnlogin.BorderRadius = 16;
            this.btnlogin.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnlogin.FocusedColor = System.Drawing.Color.Transparent;
            this.btnlogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.btnlogin.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageSize = new System.Drawing.Size(25, 25);
            this.btnlogin.Location = new System.Drawing.Point(730, 307);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.PressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnlogin.Size = new System.Drawing.Size(52, 52);
            this.btnlogin.TabIndex = 34;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnlogin.MouseEnter += new System.EventHandler(this.btnlogin_MouseHover);
            this.btnlogin.MouseLeave += new System.EventHandler(this.btnlogin_MouseHover);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.guna2CheckBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CheckBox1.Location = new System.Drawing.Point(644, 227);
            this.guna2CheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(104, 19);
            this.guna2CheckBox1.TabIndex = 2;
            this.guna2CheckBox1.Text = "Nhớ mật khẩu";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // txtpass
            // 
            this.txtpass.Animated = true;
            this.txtpass.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtpass.BorderColor = System.Drawing.Color.Gray;
            this.txtpass.BorderRadius = 15;
            this.txtpass.BorderThickness = 3;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpass.IconLeft")));
            this.txtpass.IconLeftOffset = new System.Drawing.Point(5, -1);
            this.txtpass.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtpass.IconRightSize = new System.Drawing.Size(0, 0);
            this.txtpass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtpass.Location = new System.Drawing.Point(640, 170);
            this.txtpass.Margin = new System.Windows.Forms.Padding(0);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '●';
            this.txtpass.PlaceholderText = "Mật khẩu";
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(232, 40);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // txtuser
            // 
            this.txtuser.Animated = true;
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtuser.BorderColor = System.Drawing.Color.Gray;
            this.txtuser.BorderRadius = 15;
            this.txtuser.BorderThickness = 3;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.DefaultText = "";
            this.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuser.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtuser.IconLeft")));
            this.txtuser.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtuser.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtuser.Location = new System.Drawing.Point(640, 110);
            this.txtuser.Margin = new System.Windows.Forms.Padding(0);
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.PlaceholderText = "Tên đăng nhập";
            this.txtuser.SelectedText = "";
            this.txtuser.Size = new System.Drawing.Size(232, 40);
            this.txtuser.TabIndex = 0;
            this.txtuser.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(678, 36);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(150, 34);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "ĐĂNG NHẬP";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(940, 420);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnhidepass);
            this.Controls.Add(this.btnshowpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnhidepass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshowpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer transition;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox btnhidepass;
        private Guna.UI2.WinForms.Guna2PictureBox btnshowpass;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2TextBox txtuser;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}

