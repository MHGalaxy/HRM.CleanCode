using HRM.Application.DTOs.HRM.LeaveAllocation;
using MediatR;
using System.Collections.Generic;

namespace HRM.Application.Features.HRM.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDTO>>
    {
    }
}
