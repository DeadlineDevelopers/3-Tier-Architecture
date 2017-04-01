using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Core.Models
{
    public class SurveyQuestionModel : BaseModel
    {
        public long SurveyId { get; set; }

        public string Description { get; set; }

        public int QuestionTypeId { get; set; }
    }
}
