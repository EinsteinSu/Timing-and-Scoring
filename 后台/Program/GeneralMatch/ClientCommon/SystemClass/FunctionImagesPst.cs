using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class FunctionImagesPst:PersistentBase
    {
        public FunctionImagesPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            FunctionImages info = (FunctionImages)Substance;
            return String.Format("INSERT INTO FunctionImages (GUID,IMAGEINDEX,NAME,IMAGE) VALUES('{0}',{1},'{2}',@IMAGE)", info.GUID, info.IMAGEINDEX, info.NAME);
        }

        protected override string UpdateSql()
        {
            FunctionImages info = (FunctionImages)Substance;
            return String.Format("UPDATE FunctionImages SET IMAGEINDEX = {0},NAME = '{1}',IMAGE = @IMAGE WHERE GUID = '{2}'", info.IMAGEINDEX, info.NAME, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM FunctionImages WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM FunctionImages ORDER BY IMAGEINDEX";
        }
    }
}
