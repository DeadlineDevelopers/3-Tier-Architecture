using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Core.Models
{
    public class EntityModel : BaseModel
    {
        [Required]
        public string Code { get; set; }

        public string EntityName { get; set; }

        public long CompanyId { get; set; }

        public string CompanyName { get; set; }

        public int ActivePassiveId { get; set; }
    }
}
