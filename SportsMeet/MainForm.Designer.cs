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
            this.tbPlayers = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPlayerNumber = new System.Windows.Forms.TextBox();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.mtbAge = new System.Windows.Forms.MaskedTextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.tcMainForm.SuspendLayout();
            this.tbPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainForm
            // 
            this.tcMainForm.Controls.Add(this.tpEvents);
            this.tcMainForm.Controls.Add(this.tbPlayers);
            this.tcMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMainForm.Location = new System.Drawing.Point(0, 0);
            this.tcMainForm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tcMainForm.Name = "tcMainForm";
            this.tcMainForm.SelectedIndex = 0;
            this.tcMainForm.Size = new System.Drawing.Size(1327, 731);
            this.tcMainForm.TabIndex = 0;
            // 
            // tpEvents
            // 
            this.tpEvents.AutoScroll = true;
            this.tpEvents.Location = new System.Drawing.Point(8, 39);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(2452, 1041);
            this.tpEvents.TabIndex = 0;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // tbPlayers
            // 
            this.tbPlayers.Controls.Add(this.cbxGender);
            this.tbPlayers.Controls.Add(this.lblGender);
            this.tbPlayers.Controls.Add(this.lblAge);
            this.tbPlayers.Controls.Add(this.lblLastName);
            this.tbPlayers.Controls.Add(this.lbFirstName);
            this.tbPlayers.Controls.Add(this.mtbAge);
            this.tbPlayers.Controls.Add(this.tbLastName);
            this.tbPlayers.Controls.Add(this.tbFirstName);
            this.tbPlayers.Controls.Add(this.lblPlayerNumber);
            this.tbPlayers.Controls.Add(this.tbPlayerNumber);
            this.tbPlayers.Controls.Add(this.button1);
            this.tbPlayers.Location = new System.Drawing.Point(8, 39);
            this.tbPlayers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPlayers.Name = "tbPlayers";
            this.tbPlayers.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbPlayers.Size = new System.Drawing.Size(1311, 684);
            this.tbPlayers.TabIndex = 1;
            this.tbPlayers.Text = "Players";
            this.tbPlayers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbPlayerNumber
            // 
            this.tbPlayerNumber.Location = new System.Drawing.Point(265, 73);
            this.tbPlayerNumber.Name = "tbPlayerNumber";
            this.tbPlayerNumber.Size = new System.Drawing.Size(244, 31);
            this.tbPlayerNumber.TabIndex = 1;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(43, 73);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(154, 25);
            this.lblPlayerNumber.TabIndex = 2;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(265, 151);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(244, 31);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(265, 243);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(244, 31);
            this.tbLastName.TabIndex = 4;
            // 
            // mtbAge
            // 
            this.mtbAge.Location = new System.Drawing.Point(265, 314);
            this.mtbAge.Name = "mtbAge";
            this.mtbAge.Size = new System.Drawing.Size(100, 31);
            this.mtbAge.TabIndex = 6;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(43, 154);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(116, 25);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(43, 246);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(43, 320);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 25);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(43, 392);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(265, 392);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(121, 33);
            this.cbxGender.TabIndex = 11;
            this.cbxGender.Text = "Male";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1327, 731);
            this.Controls.Add(this.tcMainForm);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Sports Meet";
            this.tcMainForm.ResumeLayout(false);
            this.tbPlayers.ResumeLayout(false);
            this.tbPlayers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMainForm;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.TabPage tbPlayers;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.MaskedTextBox mtbAge;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.TextBox tbPlayerNumber;
        private System.Windows.Forms.Button button1;
    }
}

