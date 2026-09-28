# BÀI TẬP LẬP TRÌNH WINDOWS FORM - CHƯƠNG 5

**Họ và tên:** Huỳnh Tấn Phát  
**Mã sinh viên:** 6551071062  
**Môn học:** Lập trình Windows Form / C# .NET  

---

## 📋 Danh sách các bài tập

### 🔹 Câu 1: Form Đăng Ký (`Cau1_FormDangKy`)
- **Mô tả:** Form đăng ký tài khoản người dùng với chức năng kiểm tra hợp lệ dữ liệu (validation) sử dụng `ErrorProvider`.
- **Chức năng:**
  - Kiểm tra họ tên (tối thiểu 3 ký tự, không để trống).
  - Kiểm tra định dạng Email hợp lệ bằng biểu thức chính quy (Regex).
  - Kiểm tra Số điện thoại (10 chữ số, bắt đầu bằng 0).
  - Kiểm tra Mật khẩu (độ dài tối thiểu, độ phức tạp) và Xác nhận mật khẩu trùng khớp.

---

### 🔹 Câu 2: Form Đặt Phòng Khách Sạn (`Cau2_FormDatPhong`)
- **Mô tả:** Ứng dụng đặt phòng khách sạn, tính toán chi phí lưu trú và dịch vụ đi kèm.
- **Chức năng:**
  - Lựa chọn loại phòng (Đơn, Đôi, VIP).
  - Lựa chọn số ngày thuê, số lượng khách.
  - Chọn các tiện ích / dịch vụ bổ sung (Ăn sáng, Giặt là, Đưa đón sân bay,...).
  - Tự động tính toán tổng tiền thanh toán.

---

### 🔹 Câu 3: Form Quản Lý & Nhập Điểm (`Cau3_FormNhapDiem`)
- **Mô tả:** Quản lý điểm số sinh viên theo môn học.
- **Chức năng:**
  - Nhập thông tin sinh viên, điểm quá trình, điểm thi kết thúc học phần.
  - Tính điểm trung bình và xếp loại học tập (Xuất sắc, Giỏi, Khá, Trung bình, Yếu).
  - Hiển thị danh sách kết quả trực quan trên Grid/List.

---

### 🔹 Câu 4: Form Quản Lý Danh Bạ (`Cau4_FormDanhBa`)
- **Mô tả:** Ứng dụng quản lý sổ danh bạ điện thoại cá nhân.
- **Chức năng:**
  - Thêm, sửa, xóa thông tin liên hệ (Họ tên, Số điện thoại, Email, Địa chỉ).
  - Tìm kiếm liên hệ theo tên hoặc số điện thoại.
  - Lưu trữ và hiển thị danh bạ dạng danh sách.

---

### 🔹 Câu 5: Form Bán Vé Rạp Chiếu Phim (`Cau5_FormBanVe`)
- **Mô tả:** Hệ thống đặt vé và sơ đồ chọn chỗ ngồi xem phim.
- **Chức năng:**
  - Hiển thị sơ đồ ghế ngồi trực quan (Ghế trống, Ghế đang chọn, Ghế đã bán).
  - Phân loại ghế: Ghế thường, ghế VIP.
  - Chọn phim, suất chiếu và tự động tính tổng tiền vé theo số ghế đã chọn.

---

### 🔹 Câu 6: Ứng Dụng Quản Lý Ghi Chú - Note Manager (`Cau6_NoteManager`)
- **Mô tả:** Ứng dụng soạn thảo và quản lý ghi chú đa tài liệu (MDI Form).
- **Chức năng:**
  - Tạo mới ghi chú, mở và lưu tập tin text.
  - Quản lý nhiều cửa sổ con (MDI Child) cùng lúc.
  - Định dạng văn bản (Font chữ, màu sắc) và tìm kiếm nội dung.

---

## 🛠 Hướng dẫn cài đặt và chạy ứng dụng

1. **Yêu cầu hệ thống:**
   - Visual Studio 2022 (khuyến nghị) hoặc Visual Studio 2019 có cài đặt workload **.NET desktop development**.
   - .NET SDK (phiên bản tương thích với project).

2. **Cách mở và chạy:**
   - Mở file solution: [`BaiTapChuong5.sln`](./BaiTapChuong5.sln) bằng Visual Studio.
   - Nhấp chuột phải vào Project muốn chạy (ví dụ `Cau1_FormDangKy`), chọn **Set as Startup Project**.
   - Nhấn **F5** hoặc nút **Start** để biên dịch và chạy chương trình.
