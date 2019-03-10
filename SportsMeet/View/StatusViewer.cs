using System;
using System.Drawing;
using System.Windows.Forms;

namespace SportsMeet.View
{
    internal enum Status
    {
        INFO,
        WARNING,
        ERROR
    }

    internal class StatusViewer
    {
        private System.Windows.Forms.ToolStripLabel stripLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Timer statusTime;

        public StatusViewer(System.Windows.Forms.ToolStripLabel toolsStripLabel, 
            System.Windows.Forms.Timer formStatusTime, System.Windows.Forms.ToolStrip formsToolStrip)
        {
            stripLabel = toolsStripLabel;
            statusTime = formStatusTime;
            toolStrip = formsToolStrip;
        }

        private void SetText(String text)
        {
            stripLabel.Text = text;
        }

        private void SetWarning()
        {
            stripLabel.BackColor = Color.LightYellow;
        }

        private void SetInfo()
        {
            toolStrip.BackColor = Color.GreenYellow;
            stripLabel.ForeColor = Color.Green;
        }

        private void SetError()
        {
            toolStrip.BackColor = Color.MistyRose;
            stripLabel.ForeColor = Color.Red;
        }

        private void SetDefault()
        {
            toolStrip.BackColor = Control.DefaultBackColor;
            stripLabel.ForeColor = Control.DefaultForeColor;
            SetText("");
        }

        public void Reset()
        {
            SetDefault();
        }

        public void Update(String text, Status level)
        {
            SetText(text);

            if (level == Status.WARNING)
            {
                SetWarning();
            }
            else if (level == Status.INFO)
            {
                SetInfo();
            }
            else
            {
                SetError();
            }
            this.statusTime.Start();
        }
    }
}