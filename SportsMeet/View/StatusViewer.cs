using System;
using System.Drawing;

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
        private System.Windows.Forms.Timer statusTime;

        public StatusViewer(System.Windows.Forms.ToolStripLabel toolsStripLabel, 
            System.Windows.Forms.Timer formStatusTime)
        {
            stripLabel = toolsStripLabel;
            statusTime = formStatusTime;
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
            stripLabel.ForeColor = Color.Green;
        }

        private void SetError()
        {
//            stripLabel.BackColor = Color.Red;
            stripLabel.ForeColor = Color.Red;
        }

        private void SetDefault()
        {
            stripLabel.BackColor = Color.Gray;
            stripLabel.ForeColor = Color.Black;
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