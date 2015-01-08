﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
namespace WebApplicationManagementFootballLeague.Models
{
    
    public partial class BaseSZLPEntities : DbContext
    {
        public BaseSZLPEntities()
            : base("name=BaseSZLPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<COMMENT> COMMENTS { get; set; }
        public DbSet<EVENT> EVENTs { get; set; }
        public DbSet<MATCH> MATCHes { get; set; }
        public DbSet<NEWS> NEWS { get; set; }
        public DbSet<PLAYER> PLAYERs { get; set; }
        public DbSet<STAFF> STAFFs { get; set; }
        public DbSet<STAFF_IN_MATCHES> STAFF_IN_MATCHES { get; set; }
        public DbSet<STAFF_IN_TEAMS> STAFF_IN_TEAMS { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TEAM> TEAMs { get; set; }
        public DbSet<TEAMS_IN_MATCH> TEAMS_IN_MATCH { get; set; }
        public DbSet<TEAMS_IN_MATCH_PLAYERS_ALLOCATION> TEAMS_IN_MATCH_PLAYERS_ALLOCATION { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }
        public DbSet<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }
    
        public virtual ObjectResult<commentsForTheNews_Result> commentsForTheNews(Nullable<int> newsID)
        {
            var newsIDParameter = newsID.HasValue ?
                new ObjectParameter("newsID", newsID) :
                new ObjectParameter("newsID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<commentsForTheNews_Result>("commentsForTheNews", newsIDParameter);
        }
    
        public virtual ObjectResult<eventsInMatches_Result> eventsInMatches(Nullable<int> matchID)
        {
            var matchIDParameter = matchID.HasValue ?
                new ObjectParameter("matchID", matchID) :
                new ObjectParameter("matchID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<eventsInMatches_Result>("eventsInMatches", matchIDParameter);
        }
    
        public virtual ObjectResult<getOponentOfHostByMatchID_Result> getOponentOfHostByMatchID(Nullable<int> matchID)
        {
            var matchIDParameter = matchID.HasValue ?
                new ObjectParameter("matchID", matchID) :
                new ObjectParameter("matchID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getOponentOfHostByMatchID_Result>("getOponentOfHostByMatchID", matchIDParameter);
        }
    
        public virtual ObjectResult<getUserByUserName_Result> getUserByUserName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getUserByUserName_Result>("getUserByUserName", nameParameter);
        }
    
        public virtual ObjectResult<guestsInMatches_Result> guestsInMatches()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<guestsInMatches_Result>("guestsInMatches");
        }
    
        public virtual ObjectResult<hostsInMatches_Result> hostsInMatches()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hostsInMatches_Result>("hostsInMatches");
        }
    
        public virtual ObjectResult<leagueMatches_Result> leagueMatches()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<leagueMatches_Result>("leagueMatches");
        }
    
        public virtual ObjectResult<leagueStatistics_Result> leagueStatistics()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<leagueStatistics_Result>("leagueStatistics");
        }
    
        public virtual ObjectResult<listOfMatchesOfGuests_Result> listOfMatchesOfGuests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfMatchesOfGuests_Result>("listOfMatchesOfGuests");
        }
    
        public virtual ObjectResult<listOfMatchesOfHosts_Result> listOfMatchesOfHosts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfMatchesOfHosts_Result>("listOfMatchesOfHosts");
        }
    
        public virtual ObjectResult<listOfMatchesWithTeamNamesAndScores_Result> listOfMatchesWithTeamNamesAndScores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfMatchesWithTeamNamesAndScores_Result>("listOfMatchesWithTeamNamesAndScores");
        }
    
        public virtual ObjectResult<listOfPlayersInTeam_Result> listOfPlayersInTeam(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersInTeam_Result>("listOfPlayersInTeam", teamIDParameter);
        }
    
        public virtual ObjectResult<listOfPlayersWithLongestTimeOnThePitch_Result> listOfPlayersWithLongestTimeOnThePitch(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithLongestTimeOnThePitch_Result>("listOfPlayersWithLongestTimeOnThePitch", teamIDParameter);
        }
    
        public virtual ObjectResult<listOfPlayersWithMostAssists_Result> listOfPlayersWithMostAssists(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostAssists_Result>("listOfPlayersWithMostAssists", teamIDParameter);
        }
    
        public virtual ObjectResult<listOfPlayersWithMostAssistsForTheWholeLeague_Result> listOfPlayersWithMostAssistsForTheWholeLeague()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostAssistsForTheWholeLeague_Result>("listOfPlayersWithMostAssistsForTheWholeLeague");
        }
    
        public virtual ObjectResult<listOfPlayersWithMostGoalsScored_Result> listOfPlayersWithMostGoalsScored(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostGoalsScored_Result>("listOfPlayersWithMostGoalsScored", teamIDParameter);
        }
    
        public virtual ObjectResult<listOfPlayersWithMostGoalsScoredForTheWholeLeague_Result> listOfPlayersWithMostGoalsScoredForTheWholeLeague()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostGoalsScoredForTheWholeLeague_Result>("listOfPlayersWithMostGoalsScoredForTheWholeLeague");
        }
    
        public virtual ObjectResult<listOfPlayersWithMostNumberOfRedCardsForTheWholeLeague_Result> listOfPlayersWithMostNumberOfRedCardsForTheWholeLeague()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostNumberOfRedCardsForTheWholeLeague_Result>("listOfPlayersWithMostNumberOfRedCardsForTheWholeLeague");
        }
    
        public virtual ObjectResult<listOfPlayersWithMostNumberOfYellowCardsForTheWholeLeague_Result> listOfPlayersWithMostNumberOfYellowCardsForTheWholeLeague()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostNumberOfYellowCardsForTheWholeLeague_Result>("listOfPlayersWithMostNumberOfYellowCardsForTheWholeLeague");
        }
    
        public virtual ObjectResult<listOfPlayersWithMostRedCards_Result> listOfPlayersWithMostRedCards(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostRedCards_Result>("listOfPlayersWithMostRedCards", teamIDParameter);
        }
    
        public virtual ObjectResult<listOfPlayersWithMostTimeOnThePitchForTheWholeLeague_Result> listOfPlayersWithMostTimeOnThePitchForTheWholeLeague()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostTimeOnThePitchForTheWholeLeague_Result>("listOfPlayersWithMostTimeOnThePitchForTheWholeLeague");
        }
    
        public virtual ObjectResult<listOfPlayersWithMostYellowCards_Result> listOfPlayersWithMostYellowCards(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfPlayersWithMostYellowCards_Result>("listOfPlayersWithMostYellowCards", teamIDParameter);
        }
    
        public virtual ObjectResult<listOfRefereesInMatches_Result> listOfRefereesInMatches()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfRefereesInMatches_Result>("listOfRefereesInMatches");
        }
    
        public virtual ObjectResult<listOfStaffInTeam_Result> listOfStaffInTeam(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfStaffInTeam_Result>("listOfStaffInTeam", teamIDParameter);
        }
    
        public virtual ObjectResult<string> listOfTeams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("listOfTeams");
        }
    
        public virtual ObjectResult<listOfUsers_Result> listOfUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listOfUsers_Result>("listOfUsers");
        }
    
        public virtual ObjectResult<matchesInRound_Result> matchesInRound(Nullable<int> round)
        {
            var roundParameter = round.HasValue ?
                new ObjectParameter("round", round) :
                new ObjectParameter("round", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<matchesInRound_Result>("matchesInRound", roundParameter);
        }
    
        public virtual ObjectResult<matchOpponent_Result> matchOpponent(Nullable<int> matchID, Nullable<int> teamID)
        {
            var matchIDParameter = matchID.HasValue ?
                new ObjectParameter("matchID", matchID) :
                new ObjectParameter("matchID", typeof(int));
    
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<matchOpponent_Result>("matchOpponent", matchIDParameter, teamIDParameter);
        }
    
        public virtual ObjectResult<newsForTheLeague_Result> newsForTheLeague()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<newsForTheLeague_Result>("newsForTheLeague");
        }
    
        public virtual ObjectResult<newsForTheTeam_Result> newsForTheTeam(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<newsForTheTeam_Result>("newsForTheTeam", teamIDParameter);
        }
    
        public virtual ObjectResult<playerWithLongestTimeOnThePitch_Result> playerWithLongestTimeOnThePitch(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<playerWithLongestTimeOnThePitch_Result>("playerWithLongestTimeOnThePitch", teamIDParameter);
        }
    
        public virtual ObjectResult<playerWithMostAssists_Result> playerWithMostAssists(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<playerWithMostAssists_Result>("playerWithMostAssists", teamIDParameter);
        }
    
        public virtual ObjectResult<playerWithMostGoalsScored_Result> playerWithMostGoalsScored(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<playerWithMostGoalsScored_Result>("playerWithMostGoalsScored", teamIDParameter);
        }
    
        public virtual ObjectResult<playerWithMostRedCards_Result> playerWithMostRedCards(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<playerWithMostRedCards_Result>("playerWithMostRedCards", teamIDParameter);
        }
    
        public virtual ObjectResult<playerWithMostYellowCards_Result> playerWithMostYellowCards(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<playerWithMostYellowCards_Result>("playerWithMostYellowCards", teamIDParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<staffInTeamByRole_Result> staffInTeamByRole(Nullable<int> teamID, string staffRole)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            var staffRoleParameter = staffRole != null ?
                new ObjectParameter("staffRole", staffRole) :
                new ObjectParameter("staffRole", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<staffInTeamByRole_Result>("staffInTeamByRole", teamIDParameter, staffRoleParameter);
        }
    
        public virtual ObjectResult<teamDataByID_Result> teamDataByID(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamDataByID_Result>("teamDataByID", teamIDParameter);
        }
    
        public virtual ObjectResult<teamGoalBalance_Result> teamGoalBalance(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamGoalBalance_Result>("teamGoalBalance", teamIDParameter);
        }
    
        public virtual ObjectResult<teamMatches_Result> teamMatches(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamMatches_Result>("teamMatches", teamIDParameter);
        }
    
        public virtual ObjectResult<teamScore_Result> teamScore(Nullable<int> teamID)
        {
            var teamIDParameter = teamID.HasValue ?
                new ObjectParameter("teamID", teamID) :
                new ObjectParameter("teamID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamScore_Result>("teamScore", teamIDParameter);
        }
    
        public virtual ObjectResult<teamsInMatches_Result> teamsInMatches()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamsInMatches_Result>("teamsInMatches");
        }
    
        public virtual ObjectResult<teamWithMostDraws_Result> teamWithMostDraws()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamWithMostDraws_Result>("teamWithMostDraws");
        }
    
        public virtual ObjectResult<teamWithMostGoalsLost_Result> teamWithMostGoalsLost()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamWithMostGoalsLost_Result>("teamWithMostGoalsLost");
        }
    
        public virtual ObjectResult<teamWithMostGoalsScored_Result> teamWithMostGoalsScored()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamWithMostGoalsScored_Result>("teamWithMostGoalsScored");
        }
    
        public virtual ObjectResult<teamWithMostLoses_Result> teamWithMostLoses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamWithMostLoses_Result>("teamWithMostLoses");
        }
    
        public virtual ObjectResult<teamWithMostMatches_Result> teamWithMostMatches()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamWithMostMatches_Result>("teamWithMostMatches");
        }
    
        public virtual ObjectResult<teamWithMostPoints_Result> teamWithMostPoints()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamWithMostPoints_Result>("teamWithMostPoints");
        }
    
        public virtual ObjectResult<teamWithMostWins_Result> teamWithMostWins()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<teamWithMostWins_Result>("teamWithMostWins");
        }
    }
}