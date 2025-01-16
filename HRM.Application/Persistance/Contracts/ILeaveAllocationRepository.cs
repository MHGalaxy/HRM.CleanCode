using HRM.Domain.DTOs.LeaveAllocation;
using HRM.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRM.Application.Persistance.Contracts
{
    public interface ILeaveAllocationRepository : IBaseRepository<LeaveAllocation>
    {
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
    }
}
