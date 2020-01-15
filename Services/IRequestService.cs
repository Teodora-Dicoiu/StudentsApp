using StudentsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Services
{
    public interface IRequestService
    {
        IEnumerable<Request> Get(Filter filter = null);
        void Add(Request request);
    }
}
