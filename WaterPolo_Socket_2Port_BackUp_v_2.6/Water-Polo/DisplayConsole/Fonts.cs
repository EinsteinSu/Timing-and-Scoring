using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisplayConsole
{
    public partial class Fonts : ApplicationControlCommon.DialogForm
    {
        public Fonts()
        {
            InitializeComponent();

            lbBIBNumber.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.BIBNUMBERFont);
            lbBIBNumber.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.BIBNUMBERCOLOR);
            tbBIBFont.Text = lbBIBNumber.Font.FontFamily.Name;

            lbName.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.NAMEFont);
            lbName.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.NAMECOLOR);
            tbNameFont.Text = lbName.Font.FontFamily.Name;

            lbFouls.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.FOULSFont);
            lbFouls.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.FOULSCOLOR);
            tbFoulsFont.Text = lbFouls.Font.FontFamily.Name;

            lbSerious.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.SERIOUSFont);
            lbSerious.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.SERIOUSCOLOR);
            tbSeriousFont.Text = lbSerious.Font.FontFamily.Name;

            lbSeconds.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.SECONDSFont);
            lbSeconds.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.SECONDSCOLOR);
            tbSecondsFont.Text = lbSeconds.Font.FontFamily.Name;
        }

        private void btBIBFonts_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = lbBIBNumber.Font;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbBIBNumber.Font = fd.Font;
            }
        }

        private void btBIBColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = lbBIBNumber.ForeColor;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbBIBNumber.ForeColor = cd.Color;
            }
        }


        private void btNameFonts_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = lbName.Font;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbName.Font = fd.Font;
            }
        }

        private void btNameColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = lbName.ForeColor;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbName.ForeColor = cd.Color;
            }
        }

        private void btFoulsFonts_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = lbFouls.Font;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbFouls.Font = fd.Font;
            }
        }

        private void btFoulsColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = lbFouls.ForeColor;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbFouls.ForeColor = cd.Color;
            }
        }

        private void btSeriousFonts_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = lbSerious.Font;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbSerious.Font = fd.Font;
            }
        }

        private void btSeriousColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = lbSerious.ForeColor;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbSerious.ForeColor = cd.Color;
            }
        }

        private void btSecondsFonts_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = lbSeconds.Font;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbSeconds.Font = fd.Font;
            }
        }

        private void btSecondsColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = lbSeconds.ForeColor;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbSeconds.ForeColor = cd.Color;
            }
        }

        private void Fonts_OkClick()
        {
            StyleSettings.ONSETTINGS.BIBNUMBERFont = StyleSettings.FontToString(lbBIBNumber.Font);
            StyleSettings.ONSETTINGS.BIBNUMBERCOLOR = StyleSettings.ColorToString(lbBIBNumber.ForeColor);

            StyleSettings.ONSETTINGS.NAMEFont = StyleSettings.FontToString(lbName.Font);
            StyleSettings.ONSETTINGS.NAMECOLOR = StyleSettings.ColorToString(lbName.ForeColor);

            StyleSettings.ONSETTINGS.FOULSFont = StyleSettings.FontToString(lbFouls.Font);
            StyleSettings.ONSETTINGS.FOULSCOLOR = StyleSettings.ColorToString(lbFouls.ForeColor);

            StyleSettings.ONSETTINGS.SERIOUSFont = StyleSettings.FontToString(lbSerious.Font);
            StyleSettings.ONSETTINGS.SERIOUSCOLOR = StyleSettings.ColorToString(lbSerious.ForeColor);

            StyleSettings.ONSETTINGS.SECONDSFont = StyleSettings.FontToString(lbSeconds.Font);
            StyleSettings.ONSETTINGS.SECONDSCOLOR = StyleSettings.ColorToString(lbSeconds.ForeColor);

            StyleSettings.ONSETTINGS = StyleSettings.ONSETTINGS;
            StyleSettings.ONSETTINGS.Load();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void tbBIBFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBIBNumber.Font = new Font(tbBIBFont.Text, lbBIBNumber.Font.Size, lbBIBNumber.Font.Style);
        }

        private void tbNameFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbName.Font = new Font(tbNameFont.Text, lbName.Font.Size, lbName.Font.Style);
        }

        private void tbFoulsFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFouls.Font = new Font(tbFoulsFont.Text, lbFouls.Font.Size, lbFouls.Font.Style);
        }

        private void tbSeriousFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSerious.Font = new Font(tbSeriousFont.Text, lbSerious.Font.Size, lbSerious.Font.Style);
        }

        private void tbSecondsFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSeconds.Font = new Font(tbSecondsFont.Text, lbSeconds.Font.Size, lbSeconds.Font.Style);
        }

    }
}
