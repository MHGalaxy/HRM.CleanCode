﻿using HRM.Application.DTOs.Common;
using System;

namespace HRM.Application.DTOs.HRM.LeaveRequest
{
    public class UpdateLeaveRequestDTO : BaseDTO, ILeaveRequestDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public int RequestComment { get; set; }
        public bool Canceled { get; set; }
    }
}
