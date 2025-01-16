﻿using HRM.Domain.DTOs.Common;

namespace HRM.Domain.DTOs.LeaveType
{
    public class CreateLeaveTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public string DefaultDay { get; set; }
    }
}
