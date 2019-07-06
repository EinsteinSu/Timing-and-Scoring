using System.Collections.Generic;
using WaterPolo.Simple.Core.Control;
using WaterPolo.Simple.Core.Display.RawData;

namespace WaterPolo.Simple.Core
{
    public class TransferDataConvert
    {
        public static MatchRaw ConvertToMatchRaw(MatchModel model)
        {
            return new MatchRaw
            {
                TotalTime = model.TotalTime,
                Court = model.Court,
                IsTimeout = model.IsTimeout,
                ThirtySeconds = model.ThirtySeconds,
                TeamA = ConvertToTeamRaw(model.TeamA),
                TeamB = ConvertToTeamRaw(model.TeamB)
            };
        }

        public static MatchModel ConvertToMatchModel(MatchRaw raw)
        {
            return new MatchModel
            {
                TotalTime = raw.TotalTime,
                Court = raw.Court,
                IsTimeout = raw.IsTimeout,
                ThirtySeconds = raw.ThirtySeconds,
                TeamA = ConvertToTeamModel(raw.TeamA),
                TeamB = ConvertToTeamModel(raw.TeamB)
            };
        }

        #region Convert from model to raw data

        private static TeamRaw ConvertToTeamRaw(TeamModel model)
        {
            var team = new TeamRaw
            {
                Name = model.Name,
                CapColor = model.CapColor,
                PauseTime = model.PauseTime,
                Score = model.Score,
                Timeout = model.Timeout
            };
            var list = new List<PlayerRaw>();
            foreach (var modelPlayer in model.Players) list.Add(ConvertToPlayerRaw(modelPlayer));

            team.Players = list;
            return team;
        }

        private static PlayerRaw ConvertToPlayerRaw(PlayerModel model)
        {
            return new PlayerRaw
            {
                Name = model.Name,
                FoulTime = model.FoulTime,
                Fouls = model.Fouls,
                Number = model.Number
            };
        }

        #endregion

        #region Convert raw data to model

        private static TeamModel ConvertToTeamModel(TeamRaw raw)
        {
            var team = new TeamModel
            {
                Name = raw.Name,
                CapColor = raw.CapColor,
                PauseTime = raw.PauseTime,
                Score = raw.Score,
                Timeout = raw.Timeout
            };
            var list = new List<PlayerModel>();
            foreach (var rawPlayer in raw.Players) list.Add(ConvertToPlayerModel(rawPlayer));

            team.Players = list;
            return team;
        }

        private static PlayerModel ConvertToPlayerModel(PlayerRaw raw)
        {
            return new PlayerModel
            {
                Name = raw.Name,
                FoulTime = raw.FoulTime,
                Fouls = raw.Fouls,
                Number = raw.Number
            };
        }

        #endregion
    }
}