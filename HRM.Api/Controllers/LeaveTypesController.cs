using HRM.Application.DTOs.HRM.LeaveType;
using HRM.Application.Features.LeaveTypes.Requests.Commands;
using HRM.Application.Features.LeaveTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<LeaveTypesController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveTypeDTO>>> Get()
        {
            var leaveTypes = await _mediator.Send(new GetLeaveTypeListRequest());
            return Ok(leaveTypes);
        }

        // GET api/<LeaveTypesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveTypeDTO>> Get(int id)
        {
            var leaveType = await _mediator.Send(new GetLeaveTypeDetailRequest() { Id = id });
            return Ok(leaveType);
        }

        // POST api/<LeaveTypesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLeaveTypeDTO input)
        {
            var command = new CreateLeaveTypeCommand() { CreateLeaveTypeDTO = input };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<LeaveTypesController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateLeaveTypeDTO input)
        {
            var command = new UpdateLeaveTypeCommand() { UpdateLeaveTypeDTO = input };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // DELETE api/<LeaveTypesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveTypeCommand() { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
