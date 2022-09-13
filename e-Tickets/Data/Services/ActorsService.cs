using e_Tickets.Data.Base;
using e_Tickets.Models;
using eTickets.Data;

namespace e_Tickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
