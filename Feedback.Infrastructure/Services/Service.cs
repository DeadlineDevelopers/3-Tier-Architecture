using Feedback.Core.Models;
using Feedback.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Infrastructure.Services
{
    public abstract class Service<T> : IService<T> where T : IModel
    {
        public IList<T> All()
        {
            throw new NotImplementedException();
        }

        public T Create(T model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
