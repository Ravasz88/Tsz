using Microsoft.AspNetCore.Http.HttpResults;
using TSzKapu.Data;
using TSzKapu.Interfaces;

namespace TSzKapu.Repositories
{
    public class SoilDataRepository : ISoilDataRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SoilDataRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task NewMeasurement(SoilData data)   
        {
            try
            {
                data.MeasuredTime = DateTime.UtcNow;
                dbContext.Soilsensor.Add(data);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }
    }
}
