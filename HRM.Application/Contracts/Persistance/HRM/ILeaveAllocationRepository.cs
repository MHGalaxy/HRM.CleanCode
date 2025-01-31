using HRM.Domain.Entities.HRM;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRM.Application.Contracts.Persistance.HRM
{
    public interface ILeaveAllocationRepository : IBaseRepository<LeaveAllocation>
    {
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
    }
}
