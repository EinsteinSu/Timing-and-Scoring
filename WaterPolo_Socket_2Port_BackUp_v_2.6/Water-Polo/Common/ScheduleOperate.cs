using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using ApplicationCommon;
using ClientCommon;
using SubStance;

namespace Common
{
    public class ScheduleOperate
    {
        private readonly DataRow _scheduleRow;

        public ScheduleOperate(DataRow scheduleRow)
        {
            _scheduleRow = scheduleRow;
        }

        public ScheduleOperate(string scheduleGuid)
        {
            var dt = SqlHelper.GetDataTable(
                $"SELECT * FROM V_Schedule WHERE GUID = '{scheduleGuid}'");

            if (dt.Rows.Count > 0)
                _scheduleRow = dt.Rows[0];
        }

        public Schedule OnSchedule => (Schedule)ReflectionHelper.ReflectionFromDataRow(_scheduleRow, typeof(Schedule));

        public string ScheduleName => _scheduleRow["Name"].ToString();

        public bool IsTeamMatch
        {
            get
            {
                var temp = SqlHelper.GetDataTable($"SELECT * FROM Schedule WHERE PGuid = '{_scheduleRow["Guid"]}'");
                if (temp.Rows.Count > 0)
                    return true;
                return false;
            }
        }

        public enum TeamType
        {
            Host, Guest
        }

        public Teams GetTeam(TeamType type)
        {
            var t = new Teams();
            var id = type == TeamType.Host ? _scheduleRow["TeamAGuid"] : _scheduleRow["TeamBGuid"];
            var temp = SqlHelper.GetDataTable(
                $"SELECT * FROM TEAMS WHERE GUID = '{id}'");
            if (temp.Rows.Count > 0)
                t = (Teams)ReflectionHelper.ReflectionFromDataRow(temp.Rows[0],
                    typeof(Teams));
            return t;
        }

        public Teams GetTeamA()
        {
            return GetTeam(TeamType.Host);
        }

        public Teams GetTeamB()
        {
            return GetTeam(TeamType.Guest);
        }

        public Image GetTeamFlag(TeamType type)
        {
            return BinaryHelper.ByteToImage(GetTeam(type).FLAG, string.Format(@"{0}\{1}.jpg",
                DirectoryHelper.TempDirectory, Guid.NewGuid()));
        }

       
        public DataTable GetTeamATable()
        {
            var dt = SqlHelper.GetDataTable(
                $"SELECT * FROM V_ScheduleTeamAAthletes WHERE SCHEDULEGUID = '{_scheduleRow["Guid"]}'");
            dt.TableName = "TeamAAthletes";

            #region 按号码排序

            dt.Columns.Add("INUM", typeof(int));
            foreach (DataRow dr in dt.Rows)
                //todo: try convert to int
                dr["INUM"] = dr["BIBNUM"];
            dt.DefaultView.Sort = "INUM ASC";
            dt = dt.DefaultView.ToTable();

            #endregion

            return dt;
        }

        public DataTable GetTeamBTable()
        {
            var dt = SqlHelper.GetDataTable(
                $"SELECT * FROM V_ScheduleTeamBAthletes WHERE SCHEDULEGUID = '{_scheduleRow["Guid"]}' ORDER BY SID");
            dt.TableName = "TeamBAthletes";

            #region 按号码排序

            dt.Columns.Add("INUM", typeof(int));
            foreach (DataRow dr in dt.Rows)
                dr["INUM"] = dr["BIBNUM"];
            dt.DefaultView.Sort = "INUM ASC";
            dt = dt.DefaultView.ToTable();

            #endregion

            return dt;
        }
    }
}