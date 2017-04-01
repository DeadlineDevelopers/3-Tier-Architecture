using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Core.Models
{
    public class SurveyChoiceModel : BaseModel
    {
        public long SurveyQuestionId { get; set; }

        public string Description { get; set; }
    }
}
