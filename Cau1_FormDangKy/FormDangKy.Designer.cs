namespace Cau1_FormDangKy;

partial class FormDangKy
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.lblTieuDe = new System.Windows.Forms.Label();
        this.lblMoTa = new System.Windows.Forms.Label();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.lblSDT = new System.Windows.Forms.Label();
        this.txtSDT = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblMatKhau = new System.Windows.Forms.Label();
        this.txtMatKhau = new System.Windows.Forms.TextBox();
        this.lblXacNhanMK = new System.Windows.Forms.Label();
        this.txtXacNhanMK = new System.Windows.Forms.TextBox();
        this.btnDangKy = new System.Windows.Forms.Button();
        this.btnHuy = new System.Windows.Forms.Button();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();
        // 
        // lblTieuDe
        // 
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.AutoSize = true;
        this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTieuDe.Location = new System.Drawing.Point(20, 15);
        this.lblTieuDe.Text = "Đăng ký tài khoản mới";
        this.lblTieuDe.TabStop = false;
        this.lblTieuDe.TabIndex = 0;
        // 
        // lblMoTa
        // 
        this.lblMoTa.Name = "lblMoTa";
        this.lblMoTa.AutoSize = true;
        this.lblMoTa.Location = new System.Drawing.Point(22, 50);
        this.lblMoTa.Text = "Vui lòng nhập đầy đủ thông tin";
        this.lblMoTa.TabStop = false;
        this.lblMoTa.TabIndex = 1;
        // 
        // lblHoTen
        // 
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.AutoSize = false;
        this.lblHoTen.Location = new System.Drawing.Point(20, 90);
        this.lblHoTen.Size = new System.Drawing.Size(120, 23);
        this.lblHoTen.Text = "Họ tên";
        this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.lblHoTen.TabStop = false;
        this.lblHoTen.TabIndex = 2;
        // 
        // txtHoTen
        // 
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Location = new System.Drawing.Point(150, 90);
        this.txtHoTen.Size = new System.Drawing.Size(200, 23);
        this.txtHoTen.TabIndex = 3;
        // 
        // lblSDT
        // 
        this.lblSDT.Name = "lblSDT";
        this.lblSDT.AutoSize = false;
        this.lblSDT.Location = new System.Drawing.Point(20, 135);
        this.lblSDT.Size = new System.Drawing.Size(120, 23);
        this.lblSDT.Text = "Số điện thoại";
        this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.lblSDT.TabStop = false;
        this.lblSDT.TabIndex = 4;
        // 
        // txtSDT
        // 
        this.txtSDT.Name = "txtSDT";
        this.txtSDT.Location = new System.Drawing.Point(150, 135);
        this.txtSDT.Size = new System.Drawing.Size(200, 23);
        this.txtSDT.TabIndex = 5;
        // 
        // lblEmail
        // 
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.AutoSize = false;
        this.lblEmail.Location = new System.Drawing.Point(20, 180);
        this.lblEmail.Size = new System.Drawing.Size(120, 23);
        this.lblEmail.Text = "Email";
        this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.lblEmail.TabStop = false;
        this.lblEmail.TabIndex = 6;
        // 
        // txtEmail
        // 
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Location = new System.Drawing.Point(150, 180);
        this.txtEmail.Size = new System.Drawing.Size(200, 23);
        this.txtEmail.TabIndex = 7;
        // 
        // lblMatKhau
        // 
        this.lblMatKhau.Name = "lblMatKhau";
        this.lblMatKhau.AutoSize = false;
        this.lblMatKhau.Location = new System.Drawing.Point(20, 225);
        this.lblMatKhau.Size = new System.Drawing.Size(120, 23);
        this.lblMatKhau.Text = "Mật khẩu";
        this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.lblMatKhau.TabStop = false;
        this.lblMatKhau.TabIndex = 8;
        // 
        // txtMatKhau
        // 
        this.txtMatKhau.Name = "txtMatKhau";
        this.txtMatKhau.Location = new System.Drawing.Point(150, 225);
        this.txtMatKhau.Size = new System.Drawing.Size(200, 23);
        this.txtMatKhau.PasswordChar = '*';
        this.txtMatKhau.TabIndex = 9;
        // 
        // lblXacNhanMK
        // 
        this.lblXacNhanMK.Name = "lblXacNhanMK";
        this.lblXacNhanMK.AutoSize = false;
        this.lblXacNhanMK.Location = new System.Drawing.Point(20, 270);
        this.lblXacNhanMK.Size = new System.Drawing.Size(120, 23);
        this.lblXacNhanMK.Text = "Xác nhận mật khẩu";
        this.lblXacNhanMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.lblXacNhanMK.TabStop = false;
        this.lblXacNhanMK.TabIndex = 10;
        // 
        // txtXacNhanMK
        // 
        this.txtXacNhanMK.Name = "txtXacNhanMK";
        this.txtXacNhanMK.Location = new System.Drawing.Point(150, 270);
        this.txtXacNhanMK.Size = new System.Drawing.Size(200, 23);
        this.txtXacNhanMK.PasswordChar = '*';
        this.txtXacNhanMK.TabIndex = 11;
        // 
        // btnDangKy
        // 
        this.btnDangKy.Name = "btnDangKy";
        this.btnDangKy.Location = new System.Drawing.Point(150, 325);
        this.btnDangKy.Size = new System.Drawing.Size(95, 32);
        this.btnDangKy.Text = "Đăng Ký";
        this.btnDangKy.UseVisualStyleBackColor = true;
        this.btnDangKy.TabIndex = 12;
        this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
        // 
        // btnHuy
        // 
        this.btnHuy.Name = "btnHuy";
        this.btnHuy.CausesValidation = false;
        this.btnHuy.Location = new System.Drawing.Point(255, 325);
        this.btnHuy.Size = new System.Drawing.Size(95, 32);
        this.btnHuy.Text = "Hủy";
        this.btnHuy.UseVisualStyleBackColor = true;
        this.btnHuy.TabIndex = 13;
        this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
        // 
        // errorProvider1
        // 
        this.errorProvider1.ContainerControl = this;
        this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
        // 
        // FormDangKy
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 380);
        this.Text = "Đăng ký tài khoản";
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.AcceptButton = this.btnDangKy;
        this.Controls.Add(this.lblTieuDe);
        this.Controls.Add(this.lblMoTa);
        this.Controls.Add(this.lblHoTen);
        this.Controls.Add(this.txtHoTen);
        this.Controls.Add(this.lblSDT);
        this.Controls.Add(this.txtSDT);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.lblMatKhau);
        this.Controls.Add(this.txtMatKhau);
        this.Controls.Add(this.lblXacNhanMK);
        this.Controls.Add(this.txtXacNhanMK);
        this.Controls.Add(this.btnDangKy);
        this.Controls.Add(this.btnHuy);
        this.Name = "FormDangKy";
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.Label lblMoTa;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblMatKhau;
    private System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.Label lblXacNhanMK;
    private System.Windows.Forms.TextBox txtXacNhanMK;
    private System.Windows.Forms.Button btnDangKy;
    private System.Windows.Forms.Button btnHuy;
    private System.Windows.Forms.ErrorProvider errorProvider1;
}
