﻿using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        List<TeamModel> GetTeams_All();
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();
    }
}
