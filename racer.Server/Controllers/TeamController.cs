using racer.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racer.Server.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<TeamCardView> Teams()
        {
            return Enumerable.Range(1, 5).Select(_ => new TeamCardView
            {
                Image = "images/teamsky.png",
                Name = "Team Sky",
                Participants = Enumerable.Range(1, 5).Select(position =>
                     new TeamParticipantView
                     {
                         Country = "GBR",
                         Name = "Van Avermaet Greg",
                         Position = position
                     }
                ).ToArray()
            });
        }
    }
}
