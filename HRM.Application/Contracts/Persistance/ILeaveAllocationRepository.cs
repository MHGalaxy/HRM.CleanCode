using HRM.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRM.Application.Contracts.Persistance
{
    public interface ILeaveAllocationRepository : IBaseRepository<LeaveAllocation>
    {
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
    }
}
