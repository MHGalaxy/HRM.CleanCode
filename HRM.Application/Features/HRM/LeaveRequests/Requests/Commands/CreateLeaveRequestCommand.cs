﻿using HRM.Application.DTOs.HRM.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Application.Features.HRM.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public CreateLeaveRequestDTO CreateLeaveRequestDTO { get; set; }
    }
}
