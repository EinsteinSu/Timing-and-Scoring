using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class GymnasiumPst : PersistentBase
    {
        public GymnasiumPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            Gymnasium info = (Gymnasium)Substance;
            return String.Format("INSERT INTO Gymnasium (GUID,NAME,PHOTO,IPADDRESS,PORT,MEMO) VALUES('{0}','{1}',@PHOTO,'{2}','{3}','{4}')", info.GUID, info.NAME, info.IPADDRESS, info.PORT, info.MEMO);
        }

        protected override string UpdateSql()
        {
            Gymnasium info = (Gymnasium)Substance;
            return String.Format("UPDATE Gymnasium SET NAME = '{0}',PHOTO = @PHOTO,IPADDRESS = '{1}',PORT = '{2}',MEMO = '{3}' WHERE GUID = '{4}'", info.NAME, info.IPADDRESS, info.PORT, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Gymnasium WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM Gymnasium";
        }
    }
}
