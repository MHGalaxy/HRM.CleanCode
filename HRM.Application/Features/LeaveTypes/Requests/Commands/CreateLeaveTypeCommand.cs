using HRM.Application.DTOs.LeaveType;
using MediatR;

namespace HRM.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public CreateLeaveTypeDTO CreateLeaveTypeDTO { get; set; }
    }
}
