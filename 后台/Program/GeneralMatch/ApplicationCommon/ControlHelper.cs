using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationCommon
{
    public class ControlHelper
    {
        private static List<Control> ctrls;
        public static void GetControl(Control Parent)
        {
            foreach (Control ctrl in Parent.Controls)
            {
                ctrls.Add(ctrl);
                GetControl(ctrl);
            }
        }

        public static List<Control> GetControls(Control parentControl)
        {
            ctrls = new List<Control>();
            GetControl(parentControl);
            return ctrls;
        }

        public static void DisposeBindingSource(Control Parent)
        {
            foreach (Control ctrl in GetControls(Parent))
            {
                if (ctrl.DataBindings != null)
                    ctrl.DataBindings.Clear();
            }
        }

        private static void GetParents(Control child)
        {
            if (child.Parent != null)
            {
                Control c = child.Parent;
                ctrls.Add(c);
                GetParents(c);
            }
        }

        public static List<Control> GetParentsControl(Control ctrl)
        {
            ctrls = new List<Control>();
            GetParents(ctrl);
            return ctrls;
        }
    }
}
