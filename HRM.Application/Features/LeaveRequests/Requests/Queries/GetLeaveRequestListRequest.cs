using HRM.Domain.DTOs.LeaveRequest;
using MediatR;
using System.Collections.Generic;

namespace HRM.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDTO>>
    {
    }
}
