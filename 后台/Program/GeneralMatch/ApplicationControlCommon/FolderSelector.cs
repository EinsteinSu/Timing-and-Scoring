using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationCommon;
using System.Windows.Forms;

namespace ApplicationControlCommon
{
    public class FolderSelector : DevExpress.XtraEditors.ButtonEdit
    {
        public FolderSelector()
        {

        }

        protected override void OnClickButton(DevExpress.XtraEditors.Drawing.EditorButtonObjectInfoArgs buttonInfo)
        {
            FolderDialog sfd = new FolderDialog();
            if (sfd.DisplayDialog() == DialogResult.OK)
            {
                this.Text = sfd.Path;
            }
            else
                this.Text = ""; 
        }
    }
}
