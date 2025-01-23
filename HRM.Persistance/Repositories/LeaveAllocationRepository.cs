using HRM.Application.Persistance.Contracts;
using HRM.Domain.Entities;
using HRM.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HRM.Persistance.Repositories
{
    public class LeaveAllocationRepository : BaseRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly HrmDbContext _context;
        public LeaveAllocationRepository(HrmDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails()
        {
            var leaveAllocations = await _context.LeaveAllocations
                .Include(la => la.LeaveType)
                .ToListAsync();

            return leaveAllocations;
        }

        public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
        {
            var leaveAllocation = await _context.LeaveAllocations
                .Include(la => la.LeaveType)
                .FirstOrDefaultAsync(la => la.Id == id);

            return leaveAllocation;
        }
    }
}
