using HRM.Application.DTOs.LeaveType;
using MediatR;

namespace HRM.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDTO>
    {
        public int Id { get; set; }

    }
}
