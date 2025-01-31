using HRM.Application.DTOs.HRM.LeaveType;
using MediatR;

namespace HRM.Application.Features.HRM.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public CreateLeaveTypeDTO CreateLeaveTypeDTO { get; set; }
    }
}
