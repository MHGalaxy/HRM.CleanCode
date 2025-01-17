using AutoMapper;
using HRM.Domain.DTOs.LeaveAllocation;
using HRM.Domain.DTOs.LeaveRequest;
using HRM.Domain.DTOs.LeaveType;
using HRM.Domain.Entities;

namespace HRM.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType,LeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveType,CreateLeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveType,UpdateLeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveRequest,LeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveRequest,CreateLeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveRequest, UpdateLeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDTO>().ReverseMap();
            CreateMap<LeaveAllocation, CreateLeaveAllocationDTO>().ReverseMap();
            CreateMap<LeaveAllocation, UpdateLeaveAllocationDTO>().ReverseMap();
        }
    }
}
