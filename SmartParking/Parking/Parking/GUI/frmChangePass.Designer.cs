
namespace Parking.GUI
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.check_show_hide = new System.Windows.Forms.CheckBox();
            this.btnChang_pass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bgwChangePass = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.check_show_hide);
            this.panel2.Controls.Add(this.btnChang_pass);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 552);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.BackColor = System.Drawing.Color.Peru;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Hủy";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Black;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SaddleBrown;
            this.btnCancel.Location = new System.Drawing.Point(340, 470);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 57);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // check_show_hide
            // 
            this.check_show_hide.AutoSize = true;
            this.check_show_hide.ForeColor = System.Drawing.Color.Black;
            this.check_show_hide.Location = new System.Drawing.Point(438, 270);
            this.check_show_hide.Name = "check_show_hide";
            this.check_show_hide.Size = new System.Drawing.Size(59, 21);
            this.check_show_hide.TabIndex = 7;
            this.check_show_hide.Text = "Hiện";
            this.check_show_hide.UseVisualStyleBackColor = true;
            this.check_show_hide.CheckedChanged += new System.EventHandler(this.check_show_hide_CheckedChanged);
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
            this.btnChang_pass.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChang_pass.ForeColor = System.Drawing.Color.Black;
            this.btnChang_pass.IdleBorderThickness = 1;
            this.btnChang_pass.IdleCornerRadius = 20;
            this.btnChang_pass.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnChang_pass.IdleForecolor = System.Drawing.Color.Black;
            this.btnChang_pass.IdleLineColor = System.Drawing.Color.SaddleBrown;
            this.btnChang_pass.Location = new System.Drawing.Point(83, 470);
            this.btnChang_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChang_pass.Name = "btnChang_pass";
            this.btnChang_pass.Size = new System.Drawing.Size(143, 57);
            this.btnChang_pass.TabIndex = 12;
            this.btnChang_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChang_pass.Click += new System.EventHandler(this.btnChang_pass_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chocolate;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 115);
            this.panel3.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Chocolate;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(517, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐỔI MẬT KHẨU TÀI KHOẢN";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.Peru;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbType.Location = new System.Drawing.Point(260, 362);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(237, 33);
            this.cbType.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel6.ForeColor = System.Drawing.Color.Sienna;
            this.panel6.Location = new System.Drawing.Point(83, 404);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(414, 10);
            this.panel6.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(83, 365);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 33);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Loại tài khoản";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Peru;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtUsername.Location = new System.Drawing.Point(83, 179);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(414, 29);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.Text = "Tên đăng nhập";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel5.ForeColor = System.Drawing.Color.Sienna;
            this.panel5.Location = new System.Drawing.Point(83, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(414, 10);
            this.panel5.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Peru;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtPass.Location = new System.Drawing.Point(83, 270);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(333, 27);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "Mật khẩu";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel7.ForeColor = System.Drawing.Color.Sienna;
            this.panel7.Location = new System.Drawing.Point(83, 303);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(414, 10);
            this.panel7.TabIndex = 5;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 552);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePass";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.CheckBox check_show_hide;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChang_pass;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel7;
        private System.ComponentModel.BackgroundWorker bgwChangePass;
        private System.Windows.Forms.Button btnExit;
    }
}