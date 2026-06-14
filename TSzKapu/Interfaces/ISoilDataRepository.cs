using TSzKapu.Data;
namespace TSzKapu.Interfaces
{
    public interface ISoilDataRepository
    {
        Task NewMeasurement(SoilData data);
    }
}
