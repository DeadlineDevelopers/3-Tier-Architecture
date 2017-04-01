using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Core.Models
{
    public class CompanyModel : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        int ActivePassiveId { get; set; }
    }
}
