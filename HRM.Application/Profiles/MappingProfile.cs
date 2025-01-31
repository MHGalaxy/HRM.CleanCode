using AutoMapper;
using HRM.Application.DTOs.HRM.LeaveAllocation;
using HRM.Application.DTOs.HRM.LeaveRequest;
using HRM.Application.DTOs.HRM.LeaveType;
using HRM.Domain.Entities.HRM;

namespace HRM.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region LeaveType
            CreateMap<LeaveType, LeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveType, UpdateLeaveTypeDTO>().ReverseMap();
            #endregion

            #region LeaveRequest
            CreateMap<LeaveRequest, LeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDTO>().ReverseMap();
            CreateMap<LeaveRequest, CreateLeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveRequest, UpdateLeaveRequestDTO>().ReverseMap();
            #endregion

            #region LeaveAllocation
            CreateMap<LeaveAllocation, LeaveAllocationDTO>().ReverseMap();
            CreateMap<LeaveAllocation, CreateLeaveAllocationDTO>().ReverseMap();
            CreateMap<LeaveAllocation, UpdateLeaveAllocationDTO>().ReverseMap();
            #endregion
        }
    }
}
