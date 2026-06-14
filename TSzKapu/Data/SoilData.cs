using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TSzKapu.Data
{
    [Table("soilsensor")]
    public class SoilData
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserID { get; set; }
        [Column("value")]
        public double Value { get; set; }
        [JsonIgnore]
        [Column("measured_at")]
        public DateTime MeasuredTime { get; set; } 
    }
}
