using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Common
{
    public class ScheduleOperate
    {
        private DataRow ScheduleRow;

        public ScheduleOperate(DataRow scheduleRow)
        {
            ScheduleRow = scheduleRow;
        }

        public ScheduleOperate(string scheduleGuid)
        {
            DataTable dt = ClientCommon.SqlHelper.GetDataTable(string.Format(
                "SELECT * FROM V_Schedule WHERE GUID = '{0}'", scheduleGuid));
         
            if (dt.Rows.Count > 0)
            {
                ScheduleRow = dt.Rows[0];
            }
        }

        public SubStance.Schedule OnSchedule
        {
            get
            {
                return (SubStance.Schedule)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(ScheduleRow, typeof(SubStance.Schedule));
            }
        }

        public string ScheduleName
        {
            get
            {
                return ScheduleRow["Name"].ToString();
            }
        }

        public bool IsTeamMatch
        {
            get
            {
                DataTable temp = ClientCommon.SqlHelper.GetDataTable(string.Format(
                    "SELECT * FROM Schedule WHERE PGuid = '{0}'", ScheduleRow["Guid"]));
                if (temp.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        public SubStance.Teams GetTeamA()
        {
            SubStance.Teams t = new SubStance.Teams();
            DataTable temp = ClientCommon.SqlHelper.GetDataTable(string.Format(
                "SELECT * FROM TEAMS WHERE GUID = '{0}'", ScheduleRow["TeamAGuid"]));
            if (temp.Rows.Count > 0)
                t = (SubStance.Teams)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(temp.Rows[0],
                    typeof(SubStance.Teams));
            return t;
        }

        public SubStance.Teams GetTeamB()
        {
            SubStance.Teams t = new SubStance.Teams();
            DataTable temp = ClientCommon.SqlHelper.GetDataTable(string.Format(
                "SELECT * FROM TEAMS WHERE GUID = '{0}'", ScheduleRow["TeamBGuid"]));
            if (temp.Rows.Count > 0)
                t = (SubStance.Teams)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(temp.Rows[0],
                    typeof(SubStance.Teams));
            return t;
        }

        public System.Drawing.Image GetTeamAFlag()
        {
            return ApplicationCommon.BinaryHelper.ByteToImage(GetTeamA().FLAG,string.Format(@"{0}\{1}.jpg",
                ApplicationCommon.DirectoryHelper.TempDirectory,Guid.NewGuid()));
        }

        public System.Drawing.Image GetTeamBFlag()
        {
            return ApplicationCommon.BinaryHelper.ByteToImage(GetTeamB().FLAG, string.Format(@"{0}\{1}.jpg",
                ApplicationCommon.DirectoryHelper.TempDirectory, Guid.NewGuid()));
        }

        public List<SubStance.Athletes> GetTeamAList()
        {
            List<SubStance.Athletes> lst = new List<SubStance.Athletes>();
            DataTable temp = ClientCommon.SqlHelper.GetDataTable(string.Format(
                "SELECT * FROM V_ScheduleTeamAAthletes WHERE SCHEDULEGUID = '{0}' ORDER BY SID", ScheduleRow["Guid"]));
            foreach (DataRow dr in temp.Rows)
            {
                SubStance.Athletes a = (SubStance.Athletes)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(
                    dr, typeof(SubStance.Athletes));
                lst.Add(a);
            }
            return lst;
        }

        public DataTable GetTeamATable()
        {
            DataTable dt = ClientCommon.SqlHelper.GetDataTable(string.Format(
                "SELECT * FROM V_ScheduleTeamAAthletes WHERE SCHEDULEGUID = '{0}' ORDER BY SID", ScheduleRow["Guid"]));
            dt.TableName = "TeamAAthletes";
            #region 按号码排序
            dt.Columns.Add("INUM", typeof(int));
            foreach (DataRow dr in dt.Rows)
            {
                dr["INUM"] = dr["BIBNUM"];
            }
            dt.DefaultView.Sort = "INUM ASC";
            dt = dt.DefaultView.ToTable();
            #endregion
            return dt;
        }

        public string TeamAListForString
        {
            get
            {
                string str = string.Empty;
                foreach (SubStance.Athletes a in GetTeamAList())
                {
                    str += string.Format("{0}   ", a.NAME);
                }
                return str.Trim();
            }
        }

        public List<SubStance.Athletes> GetTeamBList()
        {
            List<SubStance.Athletes> lst = new List<SubStance.Athletes>();
            DataTable temp = ClientCommon.SqlHelper.GetDataTable(string.Format(
                "SELECT * FROM V_ScheduleTeamBAthletes WHERE SCHEDULEGUID = '{0}' ORDER BY SID", ScheduleRow["Guid"]));
            foreach (DataRow dr in temp.Rows)
            {
                SubStance.Athletes a = (SubStance.Athletes)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(
                    dr, typeof(SubStance.Athletes));
                lst.Add(a);
            }
            return lst;
        }

        public DataTable GetTeamBTable()
        {
            DataTable dt = ClientCommon.SqlHelper.GetDataTable(string.Format(
               "SELECT * FROM V_ScheduleTeamBAthletes WHERE SCHEDULEGUID = '{0}' ORDER BY SID", ScheduleRow["Guid"]));
            dt.TableName = "TeamBAthletes";
            #region 按号码排序
            dt.Columns.Add("INUM", typeof(int));
            foreach (DataRow dr in dt.Rows)
            {
                dr["INUM"] = dr["BIBNUM"];
            }
            dt.DefaultView.Sort = "INUM ASC";
            dt = dt.DefaultView.ToTable();
            #endregion
            return dt;
        }

        public string TeamBListForString
        {
            get
            {
                string str = string.Empty;
                foreach (SubStance.Athletes a in GetTeamBList())
                {
                    str += string.Format("{0}   ", a.NAME);
                }
                return str.Trim();
            }
        }
    }
}
