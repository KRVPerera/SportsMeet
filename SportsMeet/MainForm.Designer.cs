namespace SportsMeet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMainForm = new System.Windows.Forms.TabControl();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainForm
            // 
            this.tcMainForm.Controls.Add(this.tpEvents);
            this.tcMainForm.Controls.Add(this.tabPage2);
            this.tcMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMainForm.Location = new System.Drawing.Point(0, 0);
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(1234, 566);
            this.tcMainForm.TabIndex = 0;
            // 
            // tpEvents
            // 
            this.tpEvents.AutoScroll = true;
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(1226, 540);
            this.tpEvents.TabIndex = 0;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1234, 566);
            this.Controls.Add(this.tcMainForm);
            this.Name = "MainForm";
            this.Text = "Sports Meet";
            this.tcMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMainForm;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

