using e_Tickets.Data.Base;
using e_Tickets.Models;
using eTickets.Data;

namespace e_Tickets.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context)
            : base(context)
        {
        } 
    }
}
