namespace Cau4_FormDanhBa;

internal static class Program
{
    /// <summary>
    ///  Điểm khởi chạy của ứng dụng.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormDanhBa());
    }
}
