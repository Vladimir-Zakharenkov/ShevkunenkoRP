using System;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    class HeadModel
    {
        [Key]
        public Guid HeadId { get; set; }

        [Required]
        public uint PageId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }
    }
}
