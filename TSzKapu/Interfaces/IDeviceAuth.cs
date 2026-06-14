using TSzKapu.Data;

namespace TSzKapu.Interfaces
{
    public interface IDeviceAuth
    {
        Task<User?> GetDevice(string deviceId);
    }
}
