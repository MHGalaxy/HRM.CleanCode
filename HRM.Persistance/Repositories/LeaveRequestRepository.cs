using HRM.Application.Contracts.Persistance;
using HRM.Domain.Entities;
using HRM.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HRM.Persistance.Repositories
{
    public class LeaveRequestRepository : BaseRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly HrmDbContext _context;
        public LeaveRequestRepository(HrmDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task ChangeApprovedStatus(LeaveRequest leaveRequest, bool? status)
        {
            leaveRequest.Aproved = status;
            _context.Entry(leaveRequest).State = EntityState.Modified; // enable change tracker
            await _context.SaveChangesAsync();
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            var leaveRequests = await _context.LeaveRequests
                .Include(lr => lr.LeaveType)
                .ToListAsync();

            return leaveRequests;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            var leaveRequest = await _context.LeaveRequests
                .Include(lr => lr.LeaveType)
                .FirstOrDefaultAsync(lr => lr.Id == id);

            return leaveRequest;
        }
    }
}
