using AutoMapper;
using HRM.Application.DTOs.LeaveAllocation;
using HRM.Application.DTOs.LeaveRequest;
using HRM.Application.DTOs.LeaveType;
using HRM.Domain;

namespace HRM.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType,LeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveRequest,LeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDTO>().ReverseMap();
        }
    }
}
