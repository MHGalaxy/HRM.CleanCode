using HRM.Application.DTOs.HRM.LeaveType;
using MediatR;
using System.Collections.Generic;

namespace HRM.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDTO>>
    {
    }
}
