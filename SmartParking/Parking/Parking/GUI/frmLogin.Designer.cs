
namespace Parking.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.check_show_hide = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChang_pass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLongin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 115);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÃI GIỮ XE";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Chocolate;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(413, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // check_show_hide
            // 
            this.check_show_hide.AutoSize = true;
            this.check_show_hide.ForeColor = System.Drawing.Color.Black;
            this.check_show_hide.Location = new System.Drawing.Point(371, 278);
            this.check_show_hide.Name = "check_show_hide";
            this.check_show_hide.Size = new System.Drawing.Size(59, 21);
            this.check_show_hide.TabIndex = 5;
            this.check_show_hide.Text = "Hiện";
            this.check_show_hide.UseVisualStyleBackColor = true;
            this.check_show_hide.CheckedChanged += new System.EventHandler(this.check_show_hide_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel4.ForeColor = System.Drawing.Color.Sienna;
            this.panel4.Location = new System.Drawing.Point(44, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 10);
            this.panel4.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Peru;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtPass.Location = new System.Drawing.Point(44, 278);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(293, 22);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Mật khẩu";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.ForeColor = System.Drawing.Color.Sienna;
            this.panel3.Location = new System.Drawing.Point(44, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 10);
            this.panel3.TabIndex = 1;
            // 
            // btnChang_pass
            // 
            this.btnChang_pass.ActiveBorderThickness = 1;
            this.btnChang_pass.ActiveCornerRadius = 20;
            this.btnChang_pass.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.btnChang_pass.ActiveForecolor = System.Drawing.Color.White;
            this.btnChang_pass.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.btnChang_pass.BackColor = System.Drawing.Color.Peru;
            this.btnChang_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChang_pass.BackgroundImage")));
            this.btnChang_pass.ButtonText = "Đổi mật khẩu";
            this.btnChang_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChang_pass.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChang_pass.ForeColor = System.Drawing.Color.Black;
            this.btnChang_pass.IdleBorderThickness = 1;
            this.btnChang_pass.IdleCornerRadius = 20;
            this.btnChang_pass.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnChang_pass.IdleForecolor = System.Drawing.Color.Black;
            this.btnChang_pass.IdleLineColor = System.Drawing.Color.SaddleBrown;
            this.btnChang_pass.Location = new System.Drawing.Point(258, 374);
            this.btnChang_pass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnChang_pass.Name = "btnChang_pass";
            this.btnChang_pass.Size = new System.Drawing.Size(172, 61);
            this.btnChang_pass.TabIndex = 7;
            this.btnChang_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChang_pass.Click += new System.EventHandler(this.btnChang_pass_Click);
            // 
            // btnLongin
            // 
            this.btnLongin.ActiveBorderThickness = 1;
            this.btnLongin.ActiveCornerRadius = 20;
            this.btnLongin.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.btnLongin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLongin.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.btnLongin.BackColor = System.Drawing.Color.Peru;
            this.btnLongin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLongin.BackgroundImage")));
            this.btnLongin.ButtonText = "Đăng nhập";
            this.btnLongin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLongin.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongin.ForeColor = System.Drawing.Color.Black;
            this.btnLongin.IdleBorderThickness = 1;
            this.btnLongin.IdleCornerRadius = 20;
            this.btnLongin.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLongin.IdleForecolor = System.Drawing.Color.Black;
            this.btnLongin.IdleLineColor = System.Drawing.Color.SaddleBrown;
            this.btnLongin.Location = new System.Drawing.Point(44, 374);
            this.btnLongin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLongin.Name = "btnLongin";
            this.btnLongin.Size = new System.Drawing.Size(150, 61);
            this.btnLongin.TabIndex = 8;
            this.btnLongin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLongin.Click += new System.EventHandler(this.btnLongin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Peru;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtUsername.Location = new System.Drawing.Point(44, 176);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(386, 33);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.Text = "Tên đăng nhập";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(478, 490);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLongin);
            this.Controls.Add(this.btnChang_pass);
            this.Controls.Add(this.check_show_hide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Peru;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox check_show_hide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLongin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChang_pass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
    }
}