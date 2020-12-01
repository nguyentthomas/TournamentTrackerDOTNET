using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace TrackerLibrary { 

    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public string EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } new List<List<MatchupModel>>();

    }
}
