namespace DPM235436_HuynhHungKien_Adapter_Read_NhanVien_DP.Interfaces
{
    /// <summary>
    /// Target: Giao diện chuẩn mà hệ thống bán hàng của công ty nông dược sử dụng (Client mong muốn).
    /// </summary>
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
}
