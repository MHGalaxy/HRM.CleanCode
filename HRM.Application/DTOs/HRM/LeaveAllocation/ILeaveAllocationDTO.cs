namespace HRM.Application.DTOs.HRM.LeaveAllocation
{
    public interface ILeaveAllocationDTO
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}
