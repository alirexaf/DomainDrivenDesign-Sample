using Domain.Exceptions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class WebinarNotFoundException:NotFoundException
    {
        public WebinarNotFoundException(Guid webinarId)
            : base($"The webinar with identifier {webinarId} was not found!")
        {
            
        }
    }
}
