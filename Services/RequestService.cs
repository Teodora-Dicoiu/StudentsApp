using StudentsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Services
{
    public class RequestService:IRequestService
    {
        private readonly List<Request> requests;

        public RequestService()
        {
            requests = new List<Request>();
        }

        public void Add(Request request)
        {
            lock (requests)
            {
                requests.Add(request);
            }
        }

        public IEnumerable<Request> Get(Filter filter = null)
        {
            return requests;
        }


    }
}
