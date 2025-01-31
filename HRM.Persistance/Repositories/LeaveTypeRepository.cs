using HRM.Application.Contracts.Persistance.HRM;
using HRM.Domain.Entities.HRM;
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
