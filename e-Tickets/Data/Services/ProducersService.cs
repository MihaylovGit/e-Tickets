using e_Tickets.Data.Base;
using e_Tickets.Models;
using eTickets.Data;

namespace e_Tickets.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService 
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
