using HRM.Application.DTOs.HRM.LeaveType;
using MediatR;

namespace HRM.Application.Features.HRM.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDTO>
    {
        public int Id { get; set; }

    }
}
