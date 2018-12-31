using racer.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racer.Server.Controllers
{
    [Route("api/[controller]")]
    public class RaceController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<RaceCardView> Races()
        {
            return Enumerable.Range(1, 5).Select(_ => new RaceCardView
            {
                Description = "A Race",
                Title = "How is Blazor working for you?",
                Image = "images/winners-500.jpg",
                Link = "details",
            });
        }
    }
}
