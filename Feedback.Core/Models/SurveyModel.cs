using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Core.Models
{
    public class SurveyModel : BaseModel
    {
        public long EntityId { get; set; }

        public string EntityName { get; set; }

        public long BranchId { get; set; }

        public string BranchName { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int ActivePassiveId { get; set; }
    }
}
