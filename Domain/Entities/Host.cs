using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("TB_HOST")]
    public class Host
    {
        [Key]
        public int Id { get; set; }

        [Column("host_email")]
        [Required]
        [EmailAddress]
        public string HostEmail { get; set; }

        [Column("host_name")]
        [Required]
        [MaxLength(100)]
        public string HostName { get; set; }

        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
