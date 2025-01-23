using HRM.Application.Persistance.Contracts;
using HRM.Domain.Entities;
using HRM.Persistance.Contexts;

namespace HRM.Persistance.Repositories
{
    public class LeaveTypeRepository : BaseRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly HrmDbContext _context;

        public LeaveTypeRepository(HrmDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
