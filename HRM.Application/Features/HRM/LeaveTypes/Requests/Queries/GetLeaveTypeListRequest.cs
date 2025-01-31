using HRM.Application.DTOs.HRM.LeaveType;
using MediatR;
using System.Collections.Generic;

namespace HRM.Application.Features.HRM.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDTO>>
    {
    }
}
