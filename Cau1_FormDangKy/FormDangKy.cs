using System.Text.RegularExpressions;

namespace Cau1_FormDangKy;

public partial class FormDangKy : Form
{
    private bool _hopLe;
    private Control _oLoiDauTien;

    public FormDangKy()
    {
        InitializeComponent();
    }

    // Đánh dấu field bị lỗi: hiện icon lỗi + tooltip bên cạnh field.
    private void BaoLoi(Control ctl, string thongBao)
    {
        errorProvider1.SetError(ctl, thongBao);
        _hopLe = false;
        if (_oLoiDauTien == null) _oLoiDauTien = ctl;
    }

    // Field hợp lệ: xóa lỗi cũ (nếu có).
    private void XoaLoi(Control ctl)
    {
        errorProvider1.SetError(ctl, "");
    }

    /// <summary>
    /// Kiểm tra lần lượt 5 field. Field nào sai thì SetError, field nào đúng thì SetError(control, "").
    /// </summary>
    private bool KiemTraHopLe()
    {
        _hopLe = true;
        _oLoiDauTien = null;

        // (1) Họ tên: không để trống, tối thiểu 3 ký tự
        string hoTen = txtHoTen.Text.Trim();
        if (hoTen.Length == 0)
            BaoLoi(txtHoTen, "Họ tên không được để trống");
        else if (hoTen.Length < 3)
            BaoLoi(txtHoTen, "Họ tên phải có tối thiểu 3 ký tự");
        else
            XoaLoi(txtHoTen);

        // (2) Số điện thoại: đúng 10 chữ số, bắt đầu bằng "0"
        string sdt = txtSDT.Text.Trim();
        if (!Regex.IsMatch(sdt, "^0[0-9]{9}$"))
            BaoLoi(txtSDT, "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng 0");
        else
            XoaLoi(txtSDT);

        // (3) Email: chứa "@" và có "." phía sau "@"
        string email = txtEmail.Text.Trim();
        int viTriAt = email.IndexOf('@');
        bool emailOk = viTriAt > 0
                       && email.IndexOf('.', viTriAt + 1) > viTriAt + 1
                       && !email.EndsWith(".");
        if (email.Length == 0)
            BaoLoi(txtEmail, "Email không được để trống");
        else if (!emailOk)
            BaoLoi(txtEmail, "Email không đúng định dạng");
        else
            XoaLoi(txtEmail);

        // (4) Mật khẩu: tối thiểu 6 ký tự
        if (txtMatKhau.Text.Length < 6)
            BaoLoi(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự");
        else
            XoaLoi(txtMatKhau);

        // (5) Xác nhận mật khẩu: phải khớp với mật khẩu
        if (txtXacNhanMK.Text.Length == 0)
            BaoLoi(txtXacNhanMK, "Vui lòng nhập xác nhận mật khẩu");
        else if (txtXacNhanMK.Text != txtMatKhau.Text)
            BaoLoi(txtXacNhanMK, "Mật khẩu xác nhận không khớp");
        else
            XoaLoi(txtXacNhanMK);

        if (!_hopLe && _oLoiDauTien != null)
            _oLoiDauTien.Focus();

        return _hopLe;
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        if (!KiemTraHopLe())
            return;

        MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text, "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        btnHuy.CausesValidation = false;
        errorProvider1.Clear();
        Close();
    }
}
