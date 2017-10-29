using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationControlCommon
{
    public partial class SimpleApplicationForm : Form
    {
        #region Attributes
        public GroupBox TitleGroupBox
        {
            get
            {
                return gbTitle;
            }
            set
            {
                gbTitle = value;
            }
        }

        public PictureBox TitlePictureBox
        {
            get
            {
                return pbTitle;
            }
            set
            {
                pbTitle = value;
            }
        }

        public Label TitleLabel
        {
            get
            {
                return lbTitle;
            }
            set
            {
                lbTitle = value;
            }
        }

        public GroupBox FunctionGroupBox
        {
            get
            {
                return gbFunctions;
            }
            set
            {
                gbFunctions = value;
            }
        }

        private int _functionCount;
        public int FunctionCount
        {
            get
            {
                return _functionCount;
            }
            set
            {
                _functionCount = value;
                tlpFunctions.ColumnCount = 1;
                tlpFunctions.RowStyles.Clear();
                tlpFunctions.RowCount = value;
                for (int i = 0; i < value; i++)
                {
                    tlpFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                }
            }
        }

        public delegate void FunctionClickCallback(string functionName);
        public event FunctionClickCallback FunctionClick;
        public void AddFunctionButton(float functionFont, string functionName,ContentAlignment functionTextAlign, int index,Image functionImage,ContentAlignment functionImageAlign)
        {
            MyButton bt = new MyButton();
            bt.Text = functionName;
            bt.TextAlign = functionTextAlign;
            bt.Font = new System.Drawing.Font("宋体", functionFont, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            bt.UNFOCUSFONT = new System.Drawing.Font("宋体", functionFont, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            bt.FOCUSFONT = new System.Drawing.Font("宋体", functionFont, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            if(functionImage!=null)
            {
                bt.Image = functionImage;
                bt.ImageAlign = functionImageAlign;
            }
            bt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            tlpFunctions.Controls.Add(bt, 0, index);
            bt.Click += new EventHandler(bt_Click);
        }

        void bt_Click(object sender, EventArgs e)
        {
            MyButton bt = sender as MyButton;
            if (bt != null && FunctionClick != null)
                FunctionClick(bt.Text);
        }

        public Label FunctionTitle
        {
            get
            {
                return lbFunctionTitle;
            }
            set
            {
                lbFunctionTitle = value;
            }
        }

        public ParentControl FunctionParent
        {
            get
            {
                return plParent;
            }
            set
            {
                plParent = value;
            }
        }

        public void ShowControl(Type t, DockStyle d)
        {
            plParent.ShowControl(t, d);
        }

        private bool _closedQuestions = false;
        public bool ClosedQuestions
        {
            get
            {
                return _closedQuestions;
            }
            set
            {
                _closedQuestions = value;
            }
        }
        #endregion
        public SimpleApplicationForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    CloseApplication();
                    break;
            }
        }

        public void CloseApplication()
        {
            if (_closedQuestions)
            {
                if (MessageBox.Show("是否退出该程序？", "退出", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
                Application.Exit();
        }

        private void plParent_ShowControled(Control ctrl)
        {
            lbFunctionTitle.Text = ctrl.Text;
        }

    }
}
