using HRM.Application.DTOs.LeaveAllocation;
using MediatR;
using System.Collections.Generic;

namespace HRM.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDTO>>
    {
    }
}
