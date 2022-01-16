using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models
{
    public class PageModel
    {
        [Key]
        public Guid PageModelId { get; set; }

        public uint PageNumber { get; set; }

        public string Description { get; set; }
    }
}
