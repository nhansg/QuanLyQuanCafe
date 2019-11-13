namespace QuanLyQuanCafe
{
    partial class fLogin
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txbPassWord = new MetroFramework.Controls.MetroTextBox();
            this.txbTenDangNhap = new MetroFramework.Controls.MetroTextBox();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnDangNhap);
            this.metroPanel1.Controls.Add(this.txbPassWord);
            this.metroPanel1.Controls.Add(this.txbTenDangNhap);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(280, 198);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txbPassWord
            // 
            // 
            // 
            // 
            this.txbPassWord.CustomButton.Image = null;
            this.txbPassWord.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txbPassWord.CustomButton.Name = "";
            this.txbPassWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPassWord.CustomButton.TabIndex = 1;
            this.txbPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPassWord.CustomButton.UseSelectable = true;
            this.txbPassWord.CustomButton.Visible = false;
            this.txbPassWord.Lines = new string[0];
            this.txbPassWord.Location = new System.Drawing.Point(153, 58);
            this.txbPassWord.MaxLength = 32767;
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '\0';
            this.txbPassWord.PromptText = "Password";
            this.txbPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPassWord.SelectedText = "";
            this.txbPassWord.SelectionLength = 0;
            this.txbPassWord.SelectionStart = 0;
            this.txbPassWord.ShortcutsEnabled = true;
            this.txbPassWord.Size = new System.Drawing.Size(94, 23);
            this.txbPassWord.TabIndex = 3;
            this.txbPassWord.UseSelectable = true;
            this.txbPassWord.WaterMark = "Password";
            this.txbPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbTenDangNhap
            // 
            // 
            // 
            // 
            this.txbTenDangNhap.CustomButton.Image = null;
            this.txbTenDangNhap.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txbTenDangNhap.CustomButton.Name = "";
            this.txbTenDangNhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbTenDangNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbTenDangNhap.CustomButton.TabIndex = 1;
            this.txbTenDangNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTenDangNhap.CustomButton.UseSelectable = true;
            this.txbTenDangNhap.CustomButton.Visible = false;
            this.txbTenDangNhap.Lines = new string[0];
            this.txbTenDangNhap.Location = new System.Drawing.Point(153, 19);
            this.txbTenDangNhap.MaxLength = 32767;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.PasswordChar = '\0';
            this.txbTenDangNhap.PromptText = "Tên đăng nhập";
            this.txbTenDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTenDangNhap.SelectedText = "";
            this.txbTenDangNhap.SelectionLength = 0;
            this.txbTenDangNhap.SelectionStart = 0;
            this.txbTenDangNhap.ShortcutsEnabled = true;
            this.txbTenDangNhap.Size = new System.Drawing.Size(94, 23);
            this.txbTenDangNhap.TabIndex = 2;
            this.txbTenDangNhap.UseSelectable = true;
            this.txbTenDangNhap.WaterMark = "Tên đăng nhập";
            this.txbTenDangNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbTenDangNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(153, 99);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "metroButton1";
            this.btnDangNhap.UseSelectable = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // fLogin
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "fLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txbPassWord;
        private MetroFramework.Controls.MetroTextBox txbTenDangNhap;
        private MetroFramework.Controls.MetroButton btnDangNhap;
    }
}

