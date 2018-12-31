using System;
using System.Collections.Generic;
using System.Text;

namespace racer.Shared
{
    public class TeamCardView
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public IList<TeamParticipantView> Participants { get; set; }
    }

    public class TeamParticipantView
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
