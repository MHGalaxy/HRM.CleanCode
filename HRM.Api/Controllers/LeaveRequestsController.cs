using HRM.Application.DTOs.HRM.LeaveRequest;
using HRM.Application.Features.HRM.LeaveRequests.Requests.Commands;
using HRM.Application.Features.HRM.LeaveRequests.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<LeaveRequestsController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveRequestDTO>>> Get()
        {
            var leaveRequests = await _mediator.Send(new GetLeaveRequestListRequest());
            return Ok(leaveRequests);
        }

        // GET api/<LeaveRequestsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveRequestDTO>> Get(int id)
        {
            var leaveRequest = await _mediator.Send(new GetLeaveRequestDetailRequest() { Id = id });
            return Ok(leaveRequest);
        }

        // POST api/<LeaveRequestsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLeaveRequestDTO input)
        {
            var command = new CreateLeaveRequestCommand() { CreateLeaveRequestDTO = input };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<LeaveRequestsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveRequestDTO input)
        {
            var command = new UpdateLeaveRequestCommand() { UpdateLeaveRequestDTO = input };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // DELETE api/<LeaveRequestsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveRequestCommand() { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<LeaveRequestsController>/ChangeAproved/5
        [HttpPut("ChangeAproved/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ChangeLeaveRequestAprovedDTO ChangeAproved)
        {
            var command = new UpdateLeaveRequestCommand() { Id = id, ChangeLeaveRequestAprovedDTO = ChangeAproved };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
