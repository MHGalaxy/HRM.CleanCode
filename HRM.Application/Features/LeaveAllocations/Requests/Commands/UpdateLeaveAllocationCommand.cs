﻿using HRM.Application.DTOs.HRM.LeaveAllocation;
using MediatR;

namespace HRM.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public UpdateLeaveAllocationDTO UpdateLeaveAllocationDTO { get; set; }
    }
}
