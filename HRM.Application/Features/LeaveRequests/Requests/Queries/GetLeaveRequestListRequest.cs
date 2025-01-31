﻿using HRM.Application.DTOs.HRM.LeaveRequest;
using MediatR;
using System.Collections.Generic;

namespace HRM.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDTO>>
    {
    }
}
