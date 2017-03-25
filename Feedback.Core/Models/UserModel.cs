using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Core.Models
{
    [Table("UserSet")]
    public class UserModel : BaseModel
    {
        public string Name { get; set; }
    }
}
