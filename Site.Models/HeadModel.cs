using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Site.Models
{
    public class HeadModel
    {
        [Key]
        public Guid HeadId { get; set; }

        [Required]
        public uint PageNumber { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string KeyWords { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime LastReviewed { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public Uri Canonical { get; set; }
    }
}
