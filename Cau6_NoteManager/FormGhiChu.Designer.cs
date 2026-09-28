namespace Cau6_NoteManager;

partial class FormGhiChu
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
        components = new System.ComponentModel.Container();
        lblTieuDeForm = new Label();
        lblTieuDe = new Label();
        txtTieuDe = new TextBox();
        lblNoiDung = new Label();
        lblDem = new Label();
        txtNoiDung = new TextBox();
        lblUuTien = new Label();
        cboMucDoUuTien = new ComboBox();
        btnLuuGhiChu = new Button();
        errorProvider1 = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // lblTieuDeForm
        // 
        lblTieuDeForm.BackColor = Color.SteelBlue;
        lblTieuDeForm.Dock = DockStyle.Top;
        lblTieuDeForm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTieuDeForm.ForeColor = Color.White;
        lblTieuDeForm.Location = new Point(0, 0);
        lblTieuDeForm.Name = "lblTieuDeForm";
        lblTieuDeForm.Size = new Size(526, 43);
        lblTieuDeForm.TabIndex = 0;
        lblTieuDeForm.Text = "GHI CHÚ CÔNG VIỆC  (nhấp đúp để phóng to / thu nhỏ)";
        lblTieuDeForm.TextAlign = ContentAlignment.MiddleCenter;
        lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Location = new Point(17, 60);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(58, 20);
        lblTieuDe.TabIndex = 1;
        lblTieuDe.Text = "Tiêu đề";
        // 
        // txtTieuDe
        // 
        txtTieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtTieuDe.Location = new Point(17, 87);
        txtTieuDe.Margin = new Padding(3, 4, 3, 4);
        txtTieuDe.Name = "txtTieuDe";
        txtTieuDe.Size = new Size(491, 27);
        txtTieuDe.TabIndex = 2;
        txtTieuDe.TextChanged += NoiDungThayDoi;
        txtTieuDe.Validating += txtTieuDe_Validating;
        txtTieuDe.Validated += txtTieuDe_Validated;
        // 
        // lblNoiDung
        // 
        lblNoiDung.AutoSize = true;
        lblNoiDung.Location = new Point(17, 133);
        lblNoiDung.Name = "lblNoiDung";
        lblNoiDung.Size = new Size(71, 20);
        lblNoiDung.TabIndex = 3;
        lblNoiDung.Text = "Nội dung";
        // 
        // lblDem
        // 
        lblDem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblDem.Location = new Point(394, 133);
        lblDem.Name = "lblDem";
        lblDem.Size = new Size(114, 20);
        lblDem.TabIndex = 4;
        lblDem.Text = "0/500";
        lblDem.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtNoiDung
        // 
        txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtNoiDung.Location = new Point(17, 160);
        txtNoiDung.Margin = new Padding(3, 4, 3, 4);
        txtNoiDung.MaxLength = 500;
        txtNoiDung.Multiline = true;
        txtNoiDung.Name = "txtNoiDung";
        txtNoiDung.ScrollBars = ScrollBars.Vertical;
        txtNoiDung.Size = new Size(491, 199);
        txtNoiDung.TabIndex = 5;
        txtNoiDung.TextChanged += txtNoiDung_TextChanged;
        txtNoiDung.KeyPress += txtNoiDung_KeyPress;
        // 
        // lblUuTien
        // 
        lblUuTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblUuTien.AutoSize = true;
        lblUuTien.Location = new Point(17, 376);
        lblUuTien.Name = "lblUuTien";
        lblUuTien.Size = new Size(59, 20);
        lblUuTien.TabIndex = 6;
        lblUuTien.Text = "Priority:";
        // 
        // cboMucDoUuTien
        // 
        cboMucDoUuTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
        cboMucDoUuTien.FormattingEnabled = true;
        cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
        cboMucDoUuTien.Location = new Point(17, 403);
        cboMucDoUuTien.Margin = new Padding(3, 4, 3, 4);
        cboMucDoUuTien.Name = "cboMucDoUuTien";
        cboMucDoUuTien.Size = new Size(182, 28);
        cboMucDoUuTien.TabIndex = 7;
        cboMucDoUuTien.SelectedIndexChanged += NoiDungThayDoi;
        // 
        // btnLuuGhiChu
        // 
        btnLuuGhiChu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnLuuGhiChu.BackColor = Color.LightGray;
        btnLuuGhiChu.FlatStyle = FlatStyle.Flat;
        btnLuuGhiChu.Location = new Point(406, 400);
        btnLuuGhiChu.Margin = new Padding(3, 4, 3, 4);
        btnLuuGhiChu.Name = "btnLuuGhiChu";
        btnLuuGhiChu.Size = new Size(103, 37);
        btnLuuGhiChu.TabIndex = 8;
        btnLuuGhiChu.Text = "Lưu";
        btnLuuGhiChu.UseVisualStyleBackColor = false;
        btnLuuGhiChu.Click += btnLuuGhiChu_Click;
        btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
        btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // FormGhiChu
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(526, 460);
        Controls.Add(lblTieuDeForm);
        Controls.Add(lblTieuDe);
        Controls.Add(txtTieuDe);
        Controls.Add(lblNoiDung);
        Controls.Add(lblDem);
        Controls.Add(txtNoiDung);
        Controls.Add(lblUuTien);
        Controls.Add(cboMucDoUuTien);
        Controls.Add(btnLuuGhiChu);
        KeyPreview = true;
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormGhiChu";
        Text = "Ghi chú";
        KeyDown += FormGhiChu_KeyDown;
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDeForm;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.TextBox txtTieuDe;
    private System.Windows.Forms.Label lblNoiDung;
    private System.Windows.Forms.Label lblDem;
    private System.Windows.Forms.TextBox txtNoiDung;
    private System.Windows.Forms.Label lblUuTien;
    private System.Windows.Forms.ComboBox cboMucDoUuTien;
    private System.Windows.Forms.Button btnLuuGhiChu;
    private System.Windows.Forms.ErrorProvider errorProvider1;
}
