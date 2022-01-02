using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class HeadModel
    {
        [Key]
        public Guid HeadId { get; set; }

        [Required]
        public uint PageId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}
