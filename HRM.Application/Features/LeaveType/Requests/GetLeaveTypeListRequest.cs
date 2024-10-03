using HRM.Application.DTOs.LeaveType;
using MediatR;
using System.Collections.Generic;

namespace HRM.Application.Features.LeaveType.Requests
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDTO>>
    {
    }
}
