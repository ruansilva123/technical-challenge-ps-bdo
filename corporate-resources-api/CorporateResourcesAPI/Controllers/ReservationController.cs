using CorporateResourcesAPI.Dtos;
using CorporateResourcesAPI.Exceptions;
using CorporateResourcesAPI.Models;
using CorporateResourcesAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CorporateResourcesAPI.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Reservation>> CreateReservation([FromForm] Reservation reservation)
        {
            try
            {
                return Ok(_reservationService.Create(reservation));
            }
            catch (BadRequestException ex)
            {
                return BadRequest(ex);
            }
            catch (InternalServerErrorException ex)
            {
                return StatusCode(ex.StatusCode, ex);
            }
        }

        [HttpGet]
        public async Task<List<ReservationDetailDto>> GetReservations([FromQuery] ReservationFilterDto Filters)
        {
            return await _reservationService.ListAll(Filters);
        }
    }
}
