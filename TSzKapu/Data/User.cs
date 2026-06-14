using System.ComponentModel.DataAnnotations.Schema;

namespace TSzKapu.Data
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("inside")]
        public bool Inside { get; set; }

        [Column("settlement")]
        public string Settlement { get; set; }

        [Column("created")]
        public DateTime Created { get; set; }

        [Column("apikey")]
        public string ApiKey { get; set; }

        [Column("devicename")]
        public string Devicename { get; set; }

    }
}
