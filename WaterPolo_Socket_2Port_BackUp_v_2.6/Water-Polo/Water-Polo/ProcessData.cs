using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Water_Polo
{
    public partial class ProcessData : UserControl
    {
        public ProcessData()
        {
            InitializeComponent();
        }

        string InportType;
        DataTable dt;


        private void btInport_Click(object sender, EventArgs e)
        {
            try
            {
                switch (InportType)
                {
                    case "AthleticsCHN":
                        #region
                        if (dt != null)
                        {
                            DataTable temp = ClientCommon.SqlHelper.GetDataTable("SELECT * FROM Athletes");
                            foreach (DataRow dr in dt.Rows)
                            {
                                temp.DefaultView.RowFilter = string.Format("GUID = '{0}'", dr["Guid"].ToString());
                                if (temp.DefaultView.Count > 0)
                                {
                                    ClientCommon.SqlHelper.RunSql(string.Format("UPDATE Athletes SET NAME = '{0}',BIBNUM = '{1}',SEX = '{2}',TEAMGUID = '{3}' WHERE GUID = '{4}'"
                                         , dr["NAME"], dr["BIBNUM"], dr["SEX"], dr["TEAMGUID"], dr["GUID"]));
                                }
                                else
                                {
                                    ClientCommon.SqlHelper.RunSql(string.Format(@"INSERT INTO Athletes (GUID,NAME,BIBNUM,SEX,TEAMGUID) VALUES('{0}','{1}','{2}','{3}','{4}')"
                                      , dr["GUID"], dr["NAME"], dr["BIBNUM"], dr["SEX"], dr["TEAMGUID"]));
                                }
                            }
                            MessageBox.Show("导入完毕");
                        }
                        #endregion
                        break;
                    case "AthleticsENG":
                        #region
                        if (dt != null)
                        {
                            DataTable temp = ClientCommon.SqlHelper.GetDataTable("SELECT * FROM Athletes");
                            foreach (DataRow dr in dt.Rows)
                            {
                                temp.DefaultView.RowFilter = string.Format("GUID = '{0}'", dr["Guid"].ToString());
                                if (temp.DefaultView.Count > 0)
                                {
                                    ClientCommon.SqlHelper.RunSql(string.Format("UPDATE Athletes SET NAMEEN = '{0}',BIBNUM = '{1}',SEX = '{2}' WHERE GUID = '{3}'"
                                         , dr["NAME"], dr["BIBNUM"], dr["SEX"], dr["GUID"]));
                                }
                                else
                                {
                                    ClientCommon.SqlHelper.RunSql(string.Format(@"INSERT INTO Athletes (GUID,NAMEEN,BIBNUM,SEX,TEAMGUID) VALUES('{0}','{1}','{2}','{3}','{4}')"
                                      , dr["GUID"], dr["NAME"], dr["BIBNUM"], dr["SEX"], dr["TEAMGUID"]));
                                }
                            }
                            MessageBox.Show("导入完毕");
                        }
                        #endregion
                        break;
                    case "Team":
                        #region
                        if (dt != null)
                        {
                            DataTable temp = ClientCommon.SqlHelper.GetDataTable("SELECT * FROM Teams");
                            foreach (DataRow dr in dt.Rows)
                            {
                                temp.DefaultView.RowFilter = string.Format("GUID = '{0}'", dr["Guid"].ToString());
                                if (temp.DefaultView.Count > 0)
                                {
                                    ClientCommon.SqlHelper.RunSql(string.Format("UPDATE Teams SET NAME = '{0}',SHORTNAME = '{1}' WHERE GUID = '{2}'", dr["NAME"], dr["SHORTNAME"], dr["GUID"]));
                                }
                                else
                                {
                                    ClientCommon.SqlHelper.RunSql(string.Format("INSERT INTO Teams (GUID,NAME,SHORTNAME) VALUES('{0}','{1}','{2}')", dr["GUID"], dr["NAME"], dr["SHORTNAME"]));
                                }
                            }
                            MessageBox.Show("导入完毕");
                        }
                        #endregion
                        break;
                    case "Schedule":
                        #region
                        if (dt != null)
                        {
                            DataTable temp = ClientCommon.SqlHelper.GetDataTable("SELECT * FROM Schedule");
                            foreach (DataRow dr in dt.Rows)
                            {
                                temp.DefaultView.RowFilter = string.Format("GUID = '{0}'", dr["Guid"].ToString());
                                if (temp.DefaultView.Count > 0)
                                {
                                    ClientCommon.SqlHelper.RunSql(string.Format(@"UPDATE Schedule SET PGUID = '{0}',NAME = '{1}',GAMEDATE = '{2}',GAMETIME = '{3}',NUM = {4},TEAMAGUID = '{5}',TEAMACOLOR = '{6}',TEAMBGUID = '{7}',TEAMBCOLOR = '{8}',STATE = '{9}',MEMO = '{10}' WHERE GUID = '{11}'",
                                        dr["PGUID"], dr["NAME"], dr["GAMEDATE"], dr["GAMETIME"], dr["NUM"], dr["TEAMAGUID"],
                                        dr["TEAMACOLOR"], dr["TEAMBGUID"], dr["TEAMBCOLOR"], dr["STATE"], dr["MEMO"], dr["GUID"]));
                                }
                                else
                                {
                                    ClientCommon.SqlHelper.RunSql(string.Format(@"INSERT INTO Schedule (GUID,PGUID,NAME,GAMEDATE,GAMETIME,NUM,TEAMAGUID,TEAMACOLOR,TEAMBGUID,TEAMBCOLOR,STATE,MEMO) VALUES('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}')",
                                        dr["GUID"], dr["PGUID"], dr["NAME"], dr["GAMEDATE"], dr["GAMETIME"], dr["NUM"], dr["TEAMAGUID"],
                                        dr["TEAMACOLOR"], dr["TEAMBGUID"], dr["TEAMBCOLOR"], dr["STATE"],dr["MEMO"]));
                                }
                            }
                            MessageBox.Show("导入完毕");
                        }
                        #endregion
                        break;
                }
            }
            catch
            {
                MessageBox.Show("导入信息错误！");
            }
        }

        private void btTeamCHN_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Xml.文件 (*.xml)|*.xml";
            if (of.ShowDialog() == DialogResult.OK)
            {
                InportType = "Team";
                XmlDocument doc = new XmlDocument();
                doc.Load(of.FileName);
                string info = string.Empty;
                foreach (XmlAttribute atr in doc.DocumentElement.Attributes)
                {
                    info += atr.Name.ToString() + ":" + atr.Value.ToString() + "\r\n";
                }
                rtbInfo.Text = info;
                dt = new DataTable();
                dt.Columns.Add("GUID", typeof(string));
                dt.Columns.Add("NAME", typeof(string));
                dt.Columns.Add("SHORTNAME", typeof(string));
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    string guid = node.Attributes["GUID"].Value.ToString();
                    Console.Write(guid + "\r\n");
                    DataRow dr = dt.NewRow();
                    dr["GUID"] = node.Attributes["GUID"].Value.ToString();
                    dr["NAME"] = node.Attributes["Name"].Value.ToString();
                    dr["SHORTNAME"] = node.Attributes["Code"].Value.ToString();
                    dt.Rows.Add(dr);
                }
                gridView1.Columns.Clear();
                gcTable.DataSource = dt;
            }
        }

        private void btAthleticsCHN_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Xml.文件 (*.xml)|*.xml";
            if (of.ShowDialog() == DialogResult.OK)
            {
                InportType = "AthleticsCHN";
                XmlDocument doc = new XmlDocument();
                doc.Load(of.FileName);
                string info = string.Empty;
                foreach (XmlAttribute atr in doc.DocumentElement.Attributes)
                {
                    info += atr.Name.ToString() + ":" + atr.Value.ToString() + "\r\n";
                }
                rtbInfo.Text = info;
                dt = new DataTable();
                dt.Columns.Add("GUID", typeof(string));
                dt.Columns.Add("NAME", typeof(string));
                dt.Columns.Add("SEX", typeof(string));
                dt.Columns.Add("BIBNUM", typeof(string));
                dt.Columns.Add("TEAMGUID", typeof(string));
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    string guid = node.Attributes["GUID"].Value.ToString();
                    Console.Write(guid + "\r\n");
                    DataRow dr = dt.NewRow();
                    dr["GUID"] = node.Attributes["GUID"].Value.ToString();
                    dr["NAME"] = node.Attributes["Name"].Value.ToString();
                    if (node.Attributes["Sex"].Value.ToString() == "M")
                        dr["SEX"] = "男";
                    else
                        dr["SEX"] = "女";
                    dr["BIBNUM"] = node.Attributes["BibNum"].Value.ToString();
                    dr["TEAMGUID"] = node.Attributes["TeamGUID"].Value.ToString();
                    dt.Rows.Add(dr);
                }
                gridView1.Columns.Clear();
                gcTable.DataSource = dt;
            }
        }

        private void btAthleticsENG_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Xml.文件 (*.xml)|*.xml";
            if (of.ShowDialog() == DialogResult.OK)
            {
                InportType = "AthleticsENG";
                XmlDocument doc = new XmlDocument();
                doc.Load(of.FileName);
                string info = string.Empty;
                foreach (XmlAttribute atr in doc.DocumentElement.Attributes)
                {
                    info += atr.Name.ToString() + ":" + atr.Value.ToString() + "\r\n";
                }
                rtbInfo.Text = info;
                dt = new DataTable();
                dt.Columns.Add("GUID", typeof(string));
                dt.Columns.Add("NAME", typeof(string));
                dt.Columns.Add("SEX", typeof(string));
                dt.Columns.Add("BIBNUM", typeof(string));
                dt.Columns.Add("TEAMGUID", typeof(string));
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    string guid = node.Attributes["GUID"].Value.ToString();
                    Console.Write(guid + "\r\n");
                    DataRow dr = dt.NewRow();
                    dr["GUID"] = node.Attributes["GUID"].Value.ToString();
                    dr["NAME"] = node.Attributes["ShortName"].Value.ToString().Replace("'","''");
                    if (node.Attributes["Sex"].Value.ToString() == "M")
                        dr["SEX"] = "男";
                    else
                        dr["SEX"] = "女";
                    dr["BIBNUM"] = node.Attributes["BibNum"].Value.ToString();
                    dr["TEAMGUID"] = node.Attributes["TeamGUID"].Value.ToString();
                    dt.Rows.Add(dr);
                }
                gridView1.Columns.Clear();
                gcTable.DataSource = dt;
            }
        }

        private void btSchedule_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Xml.文件 (*.xml)|*.xml";
            if (of.ShowDialog() == DialogResult.OK)
            {
                InportType = "Schedule";
                XmlDocument doc = new XmlDocument();
                doc.Load(of.FileName);
                string info = string.Empty;
                foreach (XmlAttribute atr in doc.DocumentElement.Attributes)
                {
                    info += atr.Name.ToString() + ":" + atr.Value.ToString() + "\r\n";
                }
                rtbInfo.Text = info;
                dt = new DataTable();
                dt.Columns.Add("GUID", typeof(string));
                dt.Columns.Add("PGUID", typeof(string));
                dt.Columns.Add("NAME", typeof(string));
                dt.Columns.Add("GAMEDATE", typeof(DateTime));
                dt.Columns.Add("GAMETIME", typeof(DateTime));
                dt.Columns.Add("NUM", typeof(string));
                dt.Columns.Add("TEAMAGUID", typeof(string));
                dt.Columns.Add("TEAMACOLOR", typeof(string));
                dt.Columns.Add("TEAMBGUID", typeof(string));
                dt.Columns.Add("TEAMBCOLOR", typeof(string));
                dt.Columns.Add("STATE", typeof(string));
                dt.Columns.Add("MEMO", typeof(string));
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    string guid = node.Attributes["GUID"].Value.ToString();
                    Console.Write(guid + "\r\n");
                    DataRow dr = dt.NewRow();
                    dr["GUID"] = node.Attributes["GUID"].Value.ToString();
                    dr["PGUID"] = "-1";
                    dr["NAME"] = node.Attributes["Name"].Value.ToString();
                    string gameDate = node.Attributes["GameDate"].Value.ToString();
                    gameDate = string.Format("{0}-{1}-{2}", gameDate.Substring(0, 4), gameDate.Substring(4, 2), gameDate.Substring(6, 2));
                    dr["GAMEDATE"] = DateTime.Parse(gameDate);
                    string gameTime = node.Attributes["GameTime"].Value.ToString();
                    gameTime = string.Format("{0} {1}:{2}:00", DateTime.Now.ToString("yyyy-MM-dd"), gameTime.Substring(0, 2), gameTime.Substring(2, 2));
                    dr["GAMETIME"] = DateTime.Parse(gameTime);
                    dr["NUM"] = node.Attributes["Num"].Value.ToString();
                    dr["TEAMAGUID"] = node.Attributes["TeamAGUID"].Value.ToString();
                    string ColorA = node.Attributes["TeamAColor"].Value.ToString();
                    if (ColorA == "White")
                        dr["TEAMACOLOR"] = "W";
                    else
                        dr["TEAMACOLOR"] = "B";

                    dr["TEAMBGUID"] = node.Attributes["TeamBGUID"].Value.ToString();
                    string ColorB = node.Attributes["TeamBColor"].Value.ToString();
                    if (ColorB == "White")
                        dr["TEAMBCOLOR"] = "W";
                    else
                        dr["TEAMBCOLOR"] = "B";
                    dr["STATE"] = node.Attributes["State"].Value.ToString();
                    string memo = node.Attributes["Sex"].Value.ToString();
                    if (memo == "M")
                        dr["Memo"] = "男子";
                    else
                        dr["Memo"] = "女子";
                    dt.Rows.Add(dr);
                }
                gridView1.Columns.Clear();
                gcTable.DataSource = dt;
            }
        }
    }
}
