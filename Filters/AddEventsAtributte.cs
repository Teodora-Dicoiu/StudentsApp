using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Filters
{
    public class AddEventsAtributte : Attribute, IFilterFactory
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            return new EventsFilter();
        }
    }
}
