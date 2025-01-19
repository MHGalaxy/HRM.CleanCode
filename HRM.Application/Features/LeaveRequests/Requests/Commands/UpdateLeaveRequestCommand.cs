using HRM.Application.DTOs.LeaveRequest;
using MediatR;

namespace HRM.Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDTO UpdateLeaveRequestDTO { get; set; }
        public ChangeLeaveRequestAprovedDTO ChangeLeaveRequestAprovedDTO { get; set; }
    }
}
