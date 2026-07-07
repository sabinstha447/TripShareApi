using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripShare.API.Data;
using TripShare.API.DTOs;
using TripShare.API.Models;

namespace TripShare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly AppDbContext _tcontext;

        public TripController(AppDbContext tcontext)
        {
            _tcontext = tcontext;


        }
        [HttpGet]
        public async Task<IActionResult> TripList()
        {
            var tripList = await _tcontext.Trips.Select(tripDetails => new TripDto
            {
                TripId = tripDetails.TripId,
                StartLocation = tripDetails.StartLocation,
                Destination = tripDetails.Destination,
                TravelDate = tripDetails.TravelDate,
                SeatAvailable= tripDetails.SeatAvailable,
                Status = tripDetails.Status,
                UserId = tripDetails.UserId
            }).ToListAsync();
            return Ok(tripList);

        }

        [HttpPost("TripRegister")]

        public async Task<IActionResult> tripRegister([FromBody] TripCreateDto createPlan)
        {
            var newTrip = new Trip
            {
                StartLocation= createPlan.StartLocation,
                Destination = createPlan.Destination,
                TravelDate = createPlan.TravelDate,
                SeatAvailable = createPlan.SeatAvailable,
                Status = createPlan.Status,
                UserId = createPlan.UserId

            };
            _tcontext.Add(newTrip);
            await _tcontext.SaveChangesAsync();
            return Ok($"New Trip Added Succesfully User:{newTrip.UserId} is going from " +
                $"{ newTrip.StartLocation} to  {newTrip.Destination} on {newTrip.TravelDate} and has {newTrip.SeatAvailable} seat available and the status is " +
                $"{newTrip.Status}");

        }

    }
}
