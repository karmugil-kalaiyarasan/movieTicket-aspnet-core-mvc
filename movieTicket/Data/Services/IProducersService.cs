using movieTicket.Data.Base;
using movieTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieTicket.Data.Services
{
    public interface IProducersService:IEntityBaseRepository<Producer>
    {
    }
}
