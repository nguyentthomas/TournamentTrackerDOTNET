using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace TrackerLibrary
{

    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }

    }
}