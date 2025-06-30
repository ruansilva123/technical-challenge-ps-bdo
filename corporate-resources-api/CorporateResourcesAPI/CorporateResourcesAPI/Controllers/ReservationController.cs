using CorporateResources.Communication.Responses;
using CorporateResources.Domain.Reservations.Models;
using CorporateResources.Domain.Reservations.Services;
using CorporateResources.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorporateResourcesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationsService _reservationsService;

        public ReservationController(IReservationsService reservationsService)
        {
            _reservationsService = reservationsService;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<GenericResponse<Reservation>>> CreateReservation([FromForm] Reservation reservation)
        {
            try
            {
                var response = _reservationsService.Create(reservation);
                return Ok(response);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(ex);
            }
            catch (InternalServerErrorException ex)
            {
                return StatusCode(500, new { error = ex.Message});
            }
        }
    }
}
