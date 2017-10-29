using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientCommon;

namespace ClientControlCommon
{
    public class FunctionMenum : MenuStrip
    {
        public FunctionMenum()
        {

        }

        public void BuildMenum()
        {
            CreateMenum(base.Items, "0");
        }

        public void CreateMenum(ToolStripItemCollection tic, string parentGuid)
        {
            var function = from f in Functions.ONFUNCTIONS
                           from r in SystemUsers.ONROLES
                           where f.GUID == r.FUNCTIONGUID && f.PGUID == parentGuid
                           && r.ISHAVE == 1
                           select f;
            foreach (Functions f in function)
            {
                ToolStripMenuItem tsm = new ToolStripMenuItem();
                tsm.Text = f.ToString();
                tsm.Tag = f;
                //tsm.ForeColor = System.Drawing.Color.Yellow;
                tsm.Click += new EventHandler(tsm_Click);
                tic.Add(tsm);
            }
            foreach (ToolStripMenuItem tsmi in tic)
            {
                Functions fc = tsmi.Tag as Functions;
                CreateMenum(tsmi.DropDownItems, fc.GUID);
            }
        }

        public delegate void OnMenumClick(Functions f);
        public event OnMenumClick MenumClick;
        void tsm_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            Functions f = item.Tag as Functions;
            if (MenumClick != null)
                MenumClick(f);
        }
    }
}
