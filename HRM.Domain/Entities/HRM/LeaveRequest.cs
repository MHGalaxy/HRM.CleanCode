using System;
using HRM.Domain.Entities.Common;

namespace HRM.Domain.Entities.HRM
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public int RequestComment { get; set; }
        public DateTime? ReactionDate { get; set; }
        public bool? Aproved { get; set; }
        public bool Canceled { get; set; }
    }
}
