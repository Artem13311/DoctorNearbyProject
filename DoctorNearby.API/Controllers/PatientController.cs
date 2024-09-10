using DoctorNearby.Business.CRUD.Patient.CreatePatient;
using DoctorNearby.Business.CRUD.Patient.DeletePatient;
using DoctorNearby.Business.CRUD.Patient.ReadPatients;
using DoctorNearby.Business.CRUD.Patient.UpdatePatient;
using DoctorNearby.Business.Models.DTO.Patient;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace DoctorNearby.API.Controllers
{
    [ApiController]
    [Route("api/patient")]
    public class PatientController : DoctorNearbyServiceController
    {
        /// <summary>
        /// Endpoint for create patient.
        /// </summary>
        /// <param name="request">Set of parameters.</param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<ActionResult> Create([FromBody] CreatePatientRequest request, CancellationToken cancellationToken)
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
        /// Endpoint to retrieve patients with linked fields with sorting and pagination.
        /// </summary>
        /// <param name="request">Set of parameters.</param>
        /// <returns>List of sorted patients</returns>
        [HttpGet("getall/{PatientSortFields}/{SortType}/{Page}/{PageSize}")]
        public async Task<ActionResult> GetAll([FromRoute] ReadPatientsRequest request, CancellationToken cancellationToken)
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
        /// Endpoint for update patient.
        /// </summary>
        /// <param name="id">Id of patient.</param>
        /// <param name="patientDto">Patient new fields.</param>
        /// <returns>response message and status code</returns>
        [HttpPut("update/{id}")]
        public async Task<ActionResult> Update([FromRoute] Guid id, UpdatePatientDto patientDto, CancellationToken cancellationToken)
        {
            try
            {
                var request = new UpdatePatientByIdRequest(id, patientDto);
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
        /// Endpoint for delete patient.
        /// </summary>
        /// <returns>response message and status code</returns>
        [HttpDelete("delete/{Id}")]
        public async Task<ActionResult> Delete([FromRoute] DeletePatientByIdRequest request, CancellationToken cancellationToken)
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
