using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadModel.Features.HeadToHead.Queries;
using ReadModel.Features.Predictions.Queries;
using WriteModel.Features.HeadToHead.Commands;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class HeadToHeadController: Controller
    {
        private readonly IMediator _mediator;
        
        public HeadToHeadController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        // GET api/headtohead/tournaments/
        [HttpGet("tournaments")]
        public async Task<IActionResult> GetAllPredictions()
        {
            var getTournaments = new GetHeadToHeadTournaments();
            var tournaments = await _mediator.Send(getTournaments);

            return Ok(tournaments);
        }
        
        // GET api/headtohead/matches/
        [HttpGet("matches")]
        public async Task<IActionResult> GetAllMatches()
        {
            var getMatches = new GetHeadToHeadMatches();
            var matches = await _mediator.Send(getMatches);

            return Ok(matches);
        }
        
        // GET api/headtohead/tours/
        [HttpGet("tours")]
        public async Task<IActionResult> GetAllTours()
        {
            var getHeadToHeadTours = new GetHeadToHeadTours();
            var tours = await _mediator.Send(getHeadToHeadTours);

            return Ok(tours);
        }
        
        // GET api/headtohead/tournaments/:id/schedule
        [HttpGet("tournaments/{id}/schedule")]
        public async Task<IActionResult> GetHeadToHeadTournamentSchedule(int id)
        {
            var getHeadToHeadTournamentSchedule = new GetHeadToHeadTournamentSchedule(id);

            var schedule =  await _mediator.Send(getHeadToHeadTournamentSchedule);

            return Ok(schedule);
        }
        
        // POST api/headtohead/tours/:id/evaluate
        [HttpPost("tours/{id}/evaluate")]
        public async Task<IActionResult> EvaluateHeadToHeadTour(int id)
        {
            var evaluateHeadToHeadTour = new EvaluateHeadToHeadTour(id);
            var isCompletedSuccessfully = await _mediator.Send(evaluateHeadToHeadTour);

            return isCompletedSuccessfully ? NoContent() : new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
}