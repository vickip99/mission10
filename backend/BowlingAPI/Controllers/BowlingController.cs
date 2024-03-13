using ASPMission10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPMission10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlingController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }
        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlersData = _bowlingRepository.Bowlers.ToArray();

            return bowlersData;
        }

    }
}
