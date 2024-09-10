using DoctorNearby.Business.CRUD.Doctor.CreateDoctor;
using DoctorNearby.Business.CRUD.Doctor.DeleteDoctor;
using DoctorNearby.Business.CRUD.Doctor.ReadDoctors;
using DoctorNearby.Business.CRUD.Doctor.UpdateDoctor;
using DoctorNearby.Business.Models.DTO.Doctor;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace DoctorNearby.API.Controllers
{
    [ApiController]
    [Route("api/doctor")]
    public class DoctorController : DoctorNearbyServiceController
    {
        /// <summary>
        /// Endpoint for create doctor.
        /// </summary>
        /// <param name="request">Set of parameters.</param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<ActionResult> Create([FromBody] CreateDoctorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await Mediator.Send(request, cancellationToken);
                return StatusCode(response.Status, response);
            }
            catch (ValidationException ex)
            {
                return StatusCode(400, $"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }
        /// <summary>
        /// Endpoint to retrieve doctors with linked fields with sorting and pagination.
        /// </summary>
        /// <param name="request">Set of parameter.s</param>
        /// <returns>List of sorted doctors.</returns>
        [HttpGet("getall/{DoctorSortFileds}/{SortType}/{Page}/{PageSize}")]
        public async Task<ActionResult> GetAll([FromRoute] ReadDoctorsRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await Mediator.Send(request, cancellationToken);
                return StatusCode(response.Status, response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }
        /// <summary>
        /// Endpoint for update doctor.
        /// </summary>
        /// <param name="id">Id of doctor.</param>
        /// <param name="doctorDto">Doctor new fields.</param>
        /// <returns>response message and status code.</returns>
        [HttpPut("update/{id}")]
        public async Task<ActionResult> Update([FromRoute] Guid id,UpdateDoctorDto doctorDto, CancellationToken cancellationToken)
        {
            try
            {
                var request = new UpdateDoctorByIdRequest(id, doctorDto);
                var response = await Mediator.Send(request, cancellationToken);
                return StatusCode(response.Status, response);
            }
            catch (ValidationException ex)
            {
                return StatusCode(400, $"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Endpoint for delete doctor.
        /// </summary>
        /// <returns>response message and status code.</returns>
        [HttpDelete("delete/{Id}")]
        public async Task<ActionResult> Delete([FromRoute] DeleteDoctorByIdRequest request,CancellationToken cancellationToken)
        {
            try
            {
                var response = await Mediator.Send(request, cancellationToken);
                return StatusCode(response.Status, response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }
    }
}
