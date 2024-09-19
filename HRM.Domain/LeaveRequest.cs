using System;
using HRM.Domain.Common;

namespace HRM.Domain
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestComment { get; set; }
        public DateTime ActionDate { get; set; }
        public bool? Aproved { get; set; }
        public bool Canceled { get; set; }
    }
}
