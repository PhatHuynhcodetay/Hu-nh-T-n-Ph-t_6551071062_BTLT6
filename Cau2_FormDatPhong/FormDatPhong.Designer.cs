namespace Cau2_FormDatPhong;

partial class FormDatPhong
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
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.lblCCCD = new System.Windows.Forms.Label();
        this.txtCCCD = new System.Windows.Forms.TextBox();
        this.lblNgayNhan = new System.Windows.Forms.Label();
        this.txtNgayNhan = new System.Windows.Forms.TextBox();
        this.lblNgayTra = new System.Windows.Forms.Label();
        this.txtNgayTra = new System.Windows.Forms.TextBox();
        this.lblSoNguoiLon = new System.Windows.Forms.Label();
        this.txtSoNguoiLon = new System.Windows.Forms.TextBox();
        this.lblSoTreEm = new System.Windows.Forms.Label();
        this.txtSoTreEm = new System.Windows.Forms.TextBox();
        this.btnDatPhong = new System.Windows.Forms.Button();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();
        // 
        // lblHoTen
        // 
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Location = new System.Drawing.Point(30, 15);
        this.lblHoTen.Text = "Họ tên";
        this.lblHoTen.TabStop = false;
        this.lblHoTen.TabIndex = 0;
        // 
        // txtHoTen
        // 
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Location = new System.Drawing.Point(30, 37);
        this.txtHoTen.Size = new System.Drawing.Size(320, 23);
        this.txtHoTen.TabIndex = 1;
        this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
        this.txtHoTen.Validated += new System.EventHandler(this.Txt_Validated);
        // 
        // lblCCCD
        // 
        this.lblCCCD.Name = "lblCCCD";
        this.lblCCCD.AutoSize = true;
        this.lblCCCD.Location = new System.Drawing.Point(30, 75);
        this.lblCCCD.Text = "Số CCCD";
        this.lblCCCD.TabStop = false;
        this.lblCCCD.TabIndex = 2;
        // 
        // txtCCCD
        // 
        this.txtCCCD.Name = "txtCCCD";
        this.txtCCCD.Location = new System.Drawing.Point(30, 97);
        this.txtCCCD.Size = new System.Drawing.Size(320, 23);
        this.txtCCCD.TabIndex = 3;
        this.txtCCCD.Validating += new System.ComponentModel.CancelEventHandler(this.txtCCCD_Validating);
        this.txtCCCD.Validated += new System.EventHandler(this.Txt_Validated);
        // 
        // lblNgayNhan
        // 
        this.lblNgayNhan.Name = "lblNgayNhan";
        this.lblNgayNhan.AutoSize = true;
        this.lblNgayNhan.Location = new System.Drawing.Point(30, 135);
        this.lblNgayNhan.Text = "Ngày nhận phòng";
        this.lblNgayNhan.TabStop = false;
        this.lblNgayNhan.TabIndex = 4;
        // 
        // txtNgayNhan
        // 
        this.txtNgayNhan.Name = "txtNgayNhan";
        this.txtNgayNhan.Location = new System.Drawing.Point(30, 157);
        this.txtNgayNhan.Size = new System.Drawing.Size(320, 23);
        this.txtNgayNhan.PlaceholderText = "dd/MM/yyyy";
        this.txtNgayNhan.TabIndex = 5;
        this.txtNgayNhan.Validating += new System.ComponentModel.CancelEventHandler(this.txtNgayNhan_Validating);
        this.txtNgayNhan.Validated += new System.EventHandler(this.Txt_Validated);
        // 
        // lblNgayTra
        // 
        this.lblNgayTra.Name = "lblNgayTra";
        this.lblNgayTra.AutoSize = true;
        this.lblNgayTra.Location = new System.Drawing.Point(30, 195);
        this.lblNgayTra.Text = "Ngày trả phòng";
        this.lblNgayTra.TabStop = false;
        this.lblNgayTra.TabIndex = 6;
        // 
        // txtNgayTra
        // 
        this.txtNgayTra.Name = "txtNgayTra";
        this.txtNgayTra.Location = new System.Drawing.Point(30, 217);
        this.txtNgayTra.Size = new System.Drawing.Size(320, 23);
        this.txtNgayTra.PlaceholderText = "dd/MM/yyyy";
        this.txtNgayTra.TabIndex = 7;
        this.txtNgayTra.Validating += new System.ComponentModel.CancelEventHandler(this.txtNgayTra_Validating);
        this.txtNgayTra.Validated += new System.EventHandler(this.Txt_Validated);
        // 
        // lblSoNguoiLon
        // 
        this.lblSoNguoiLon.Name = "lblSoNguoiLon";
        this.lblSoNguoiLon.AutoSize = true;
        this.lblSoNguoiLon.Location = new System.Drawing.Point(30, 255);
        this.lblSoNguoiLon.Text = "Số người lớn (1–4)";
        this.lblSoNguoiLon.TabStop = false;
        this.lblSoNguoiLon.TabIndex = 8;
        // 
        // txtSoNguoiLon
        // 
        this.txtSoNguoiLon.Name = "txtSoNguoiLon";
        this.txtSoNguoiLon.Location = new System.Drawing.Point(30, 277);
        this.txtSoNguoiLon.Size = new System.Drawing.Size(320, 23);
        this.txtSoNguoiLon.TabIndex = 9;
        this.txtSoNguoiLon.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoNguoiLon_Validating);
        this.txtSoNguoiLon.Validated += new System.EventHandler(this.Txt_Validated);
        // 
        // lblSoTreEm
        // 
        this.lblSoTreEm.Name = "lblSoTreEm";
        this.lblSoTreEm.AutoSize = true;
        this.lblSoTreEm.Location = new System.Drawing.Point(30, 315);
        this.lblSoTreEm.Text = "Số trẻ em (0–3)";
        this.lblSoTreEm.TabStop = false;
        this.lblSoTreEm.TabIndex = 10;
        // 
        // txtSoTreEm
        // 
        this.txtSoTreEm.Name = "txtSoTreEm";
        this.txtSoTreEm.Location = new System.Drawing.Point(30, 337);
        this.txtSoTreEm.Size = new System.Drawing.Size(320, 23);
        this.txtSoTreEm.TabIndex = 11;
        this.txtSoTreEm.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoTreEm_Validating);
        this.txtSoTreEm.Validated += new System.EventHandler(this.Txt_Validated);
        // 
        // btnDatPhong
        // 
        this.btnDatPhong.Name = "btnDatPhong";
        this.btnDatPhong.BackColor = System.Drawing.Color.RoyalBlue;
        this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDatPhong.ForeColor = System.Drawing.Color.White;
        this.btnDatPhong.Location = new System.Drawing.Point(30, 385);
        this.btnDatPhong.Size = new System.Drawing.Size(320, 38);
        this.btnDatPhong.Text = "Đặt Phòng";
        this.btnDatPhong.UseVisualStyleBackColor = false;
        this.btnDatPhong.TabIndex = 12;
        this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
        // 
        // errorProvider1
        // 
        this.errorProvider1.ContainerControl = this;
        // 
        // FormDatPhong
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(420, 450);
        this.Text = "Đặt phòng khách sạn";
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Controls.Add(this.lblHoTen);
        this.Controls.Add(this.txtHoTen);
        this.Controls.Add(this.lblCCCD);
        this.Controls.Add(this.txtCCCD);
        this.Controls.Add(this.lblNgayNhan);
        this.Controls.Add(this.txtNgayNhan);
        this.Controls.Add(this.lblNgayTra);
        this.Controls.Add(this.txtNgayTra);
        this.Controls.Add(this.lblSoNguoiLon);
        this.Controls.Add(this.txtSoNguoiLon);
        this.Controls.Add(this.lblSoTreEm);
        this.Controls.Add(this.txtSoTreEm);
        this.Controls.Add(this.btnDatPhong);
        this.Name = "FormDatPhong";
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblCCCD;
    private System.Windows.Forms.TextBox txtCCCD;
    private System.Windows.Forms.Label lblNgayNhan;
    private System.Windows.Forms.TextBox txtNgayNhan;
    private System.Windows.Forms.Label lblNgayTra;
    private System.Windows.Forms.TextBox txtNgayTra;
    private System.Windows.Forms.Label lblSoNguoiLon;
    private System.Windows.Forms.TextBox txtSoNguoiLon;
    private System.Windows.Forms.Label lblSoTreEm;
    private System.Windows.Forms.TextBox txtSoTreEm;
    private System.Windows.Forms.Button btnDatPhong;
    private System.Windows.Forms.ErrorProvider errorProvider1;
}
