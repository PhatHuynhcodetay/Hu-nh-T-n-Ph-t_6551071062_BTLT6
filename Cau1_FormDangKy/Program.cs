namespace Cau1_FormDangKy;

internal static class Program
{
    /// <summary>
    ///  Điểm khởi chạy của ứng dụng.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormDangKy());
    }
}
