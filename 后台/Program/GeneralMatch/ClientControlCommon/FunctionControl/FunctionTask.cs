using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientCommon;

namespace ClientControlCommon
{
    public class FunctionsTask : ToolStrip
    {
        public FunctionsTask()
        {
            base.GripStyle = ToolStripGripStyle.Hidden;
            base.AutoSize = false;
            base.Height = 32;
        }

        public void AddFunctions(Functions f)
        {
            System.Drawing.Image img;
            try
            {
                img = SystemImages.OnImageList.Images[f.IMAGEINDEX];
            }
            catch { img = null; }
            FunctionsTaskButton bt = new FunctionsTaskButton(f.ToString(), img);
            bt.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            bt.Tag = f;
            bt.Click += new EventHandler(bt_Click);
            bt.CloseClick += new FunctionsTaskButton.CloseClickCallback(CloseClick);
            bt.CloseOtherClick += new FunctionsTaskButton.CloseOtherClickCallback(bt_CloseOtherClick);
            bt.AddFastMenu += new FunctionsTaskButton.AddFastMenuCallback(bt_AddFastMenu);
            base.Items.Add(bt);
        }

        public delegate void AddFastMenuCallback();
        public event AddFastMenuCallback AddFastMenu;
        void bt_AddFastMenu()
        {
            if (AddFastMenu != null)
                AddFastMenu();
        }

        void bt_CloseOtherClick(FunctionsTaskButton bt)
        {
            List<FunctionsTaskButton> lst = new List<FunctionsTaskButton>();
            foreach (ToolStripItem item in base.Items)
            {
                FunctionsTaskButton bto = item as FunctionsTaskButton;
                if (bto != null && bto != bt)
                    lst.Add(bto);
            }
            foreach (FunctionsTaskButton bto in lst)
                CloseClick(bto.Tag as Functions, bto);
        }

        public delegate void CloseClickCallback(Functions f);
        public event CloseClickCallback OnClose;
        public virtual void CloseClick(Functions f, FunctionsTaskButton bt)
        {
            bt.Dispose();
            if (OnClose != null)
                OnClose(f);
        }

        public virtual void CloseClick(Functions f)
        {
            foreach (ToolStripItem item in base.Items)
            {
                FunctionsTaskButton bt = item as FunctionsTaskButton;
                if (bt != null && bt.Tag as Functions == f)
                {
                    CloseClick(f, bt);
                    break;
                }
            }
        }

        public delegate void FunctionsClickCallback(Functions f);
        public event FunctionsClickCallback OnFunctionsClick;
        void bt_Click(object sender, EventArgs e)
        {
            //FunctionsTaskButton bt = sender as FunctionsTaskButton;
            //List<FunctionsTaskButton> lst = new List<FunctionsTaskButton>();
            //foreach (ToolStripItem item in base.Items)
            //{
            //    FunctionsTaskButton bto = item as FunctionsTaskButton;
            //    if (bto != null && bto != bt)
            //        lst.Add(bto);
            //}
            //foreach (FunctionsTaskButton bo in lst)
            //{
            //    if (bo != bt)
            //        bo.BackgroundImage = null;
            //    else
            //    {
            //        bo.BackgroundImage = Properties.Resources.SelectButton;
            //        bo.BackgroundImageLayout = ImageLayout.Stretch;
            //    }
            //}n
            if (OnFunctionsClick != null)
                OnFunctionsClick(((FunctionsTaskButton)sender).Tag as Functions);
        }

    }
}
