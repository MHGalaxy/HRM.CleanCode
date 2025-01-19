using HRM.Application.DTOs.LeaveType;
using MediatR;
using System.Collections.Generic;

namespace HRM.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDTO>>
    {
    }
}
