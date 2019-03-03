namespace SportsMeet
{
    partial class AddMultipleEventsToPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMultipleEventsToPlayer));
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAddEventsPlayerNumber = new System.Windows.Forms.Label();
            this.labelAddEventsPlayerFullName = new System.Windows.Forms.Label();
            this.labelAddEventsPlayerGender = new System.Windows.Forms.Label();
            this.labelAddEventsPlayerAge = new System.Windows.Forms.Label();
            this.newEventsListBox = new System.Windows.Forms.ListBox();
            this.groupBoxPlayerDetails = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bindingSourceEventsBelongToPlayer = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxNewEvents = new System.Windows.Forms.GroupBox();
            this.textBoxAddEventEventFilter = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAddEventsToPlayer = new System.Windows.Forms.Button();
            this.btnRemoveEventFromPlayer = new System.Windows.Forms.Button();
            this.bindingSourceEventsDoesNotBelongToPlayer = new System.Windows.Forms.BindingSource(this.components);
            this.playerevents = new System.Windows.Forms.Label();
            this.groupBoxPlayerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsBelongToPlayer)).BeginInit();
            this.groupBoxNewEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsDoesNotBelongToPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(8, 22);
            this.lblPlayerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(76, 13);
            this.lblPlayerNumber.TabIndex = 3;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // labelAddEventsPlayerNumber
            // 
            this.labelAddEventsPlayerNumber.AutoSize = true;
            this.labelAddEventsPlayerNumber.Location = new System.Drawing.Point(91, 22);
            this.labelAddEventsPlayerNumber.Name = "labelAddEventsPlayerNumber";
            this.labelAddEventsPlayerNumber.Size = new System.Drawing.Size(35, 13);
            this.labelAddEventsPlayerNumber.TabIndex = 7;
            this.labelAddEventsPlayerNumber.Text = "label4";
            // 
            // labelAddEventsPlayerFullName
            // 
            this.labelAddEventsPlayerFullName.AutoSize = true;
            this.labelAddEventsPlayerFullName.Location = new System.Drawing.Point(91, 35);
            this.labelAddEventsPlayerFullName.Name = "labelAddEventsPlayerFullName";
            this.labelAddEventsPlayerFullName.Size = new System.Drawing.Size(35, 13);
            this.labelAddEventsPlayerFullName.TabIndex = 8;
            this.labelAddEventsPlayerFullName.Text = "label5";
            // 
            // labelAddEventsPlayerGender
            // 
            this.labelAddEventsPlayerGender.AutoSize = true;
            this.labelAddEventsPlayerGender.Location = new System.Drawing.Point(91, 49);
            this.labelAddEventsPlayerGender.Name = "labelAddEventsPlayerGender";
            this.labelAddEventsPlayerGender.Size = new System.Drawing.Size(35, 13);
            this.labelAddEventsPlayerGender.TabIndex = 9;
            this.labelAddEventsPlayerGender.Text = "label6";
            // 
            // labelAddEventsPlayerAge
            // 
            this.labelAddEventsPlayerAge.AutoSize = true;
            this.labelAddEventsPlayerAge.Location = new System.Drawing.Point(91, 62);
            this.labelAddEventsPlayerAge.Name = "labelAddEventsPlayerAge";
            this.labelAddEventsPlayerAge.Size = new System.Drawing.Size(35, 13);
            this.labelAddEventsPlayerAge.TabIndex = 10;
            this.labelAddEventsPlayerAge.Text = "label7";
            // 
            // newEventsListBox
            // 
            this.newEventsListBox.FormattingEnabled = true;
            this.newEventsListBox.Items.AddRange(new object[] {
            "t1",
            "t2",
            "t3",
            "t4",
            "t5",
            "t6"});
            this.newEventsListBox.Location = new System.Drawing.Point(76, 155);
            this.newEventsListBox.Name = "newEventsListBox";
            this.newEventsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.newEventsListBox.Size = new System.Drawing.Size(207, 134);
            this.newEventsListBox.TabIndex = 11;
            // 
            // groupBoxPlayerDetails
            // 
            this.groupBoxPlayerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPlayerDetails.Controls.Add(this.playerevents);
            this.groupBoxPlayerDetails.Controls.Add(this.listBox1);
            this.groupBoxPlayerDetails.Controls.Add(this.newEventsListBox);
            this.groupBoxPlayerDetails.Controls.Add(this.lblPlayerNumber);
            this.groupBoxPlayerDetails.Controls.Add(this.label1);
            this.groupBoxPlayerDetails.Controls.Add(this.labelAddEventsPlayerAge);
            this.groupBoxPlayerDetails.Controls.Add(this.label2);
            this.groupBoxPlayerDetails.Controls.Add(this.labelAddEventsPlayerGender);
            this.groupBoxPlayerDetails.Controls.Add(this.label3);
            this.groupBoxPlayerDetails.Controls.Add(this.labelAddEventsPlayerFullName);
            this.groupBoxPlayerDetails.Controls.Add(this.labelAddEventsPlayerNumber);
            this.groupBoxPlayerDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlayerDetails.Name = "groupBoxPlayerDetails";
            this.groupBoxPlayerDetails.Size = new System.Drawing.Size(352, 433);
            this.groupBoxPlayerDetails.TabIndex = 13;
            this.groupBoxPlayerDetails.TabStop = false;
            this.groupBoxPlayerDetails.Text = "Player Details";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.DataSource = this.bindingSourceEventsBelongToPlayer;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(344, 329);
            this.listBox1.TabIndex = 14;
            // 
            // bindingSourceEventsBelongToPlayer
            // 
            this.bindingSourceEventsBelongToPlayer.DataSource = typeof(SportsMeet.Models.Event);
            // 
            // groupBoxNewEvents
            // 
            this.groupBoxNewEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNewEvents.Controls.Add(this.textBoxAddEventEventFilter);
            this.groupBoxNewEvents.Controls.Add(this.listBox2);
            this.groupBoxNewEvents.Location = new System.Drawing.Point(423, 12);
            this.groupBoxNewEvents.Name = "groupBoxNewEvents";
            this.groupBoxNewEvents.Size = new System.Drawing.Size(365, 433);
            this.groupBoxNewEvents.TabIndex = 14;
            this.groupBoxNewEvents.TabStop = false;
            this.groupBoxNewEvents.Text = "New Events";
            // 
            // textBoxAddEventEventFilter
            // 
            this.textBoxAddEventEventFilter.Location = new System.Drawing.Point(6, 16);
            this.textBoxAddEventEventFilter.Name = "textBoxAddEventEventFilter";
            this.textBoxAddEventEventFilter.Size = new System.Drawing.Size(353, 20);
            this.textBoxAddEventEventFilter.TabIndex = 16;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "t1",
            "t2",
            "t3",
            "t4",
            "t5",
            "t6"});
            this.listBox2.Location = new System.Drawing.Point(6, 56);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(353, 368);
            this.listBox2.TabIndex = 15;
            // 
            // btnAddEventsToPlayer
            // 
            this.btnAddEventsToPlayer.Location = new System.Drawing.Point(371, 251);
            this.btnAddEventsToPlayer.Name = "btnAddEventsToPlayer";
            this.btnAddEventsToPlayer.Size = new System.Drawing.Size(46, 23);
            this.btnAddEventsToPlayer.TabIndex = 15;
            this.btnAddEventsToPlayer.Text = "<<";
            this.btnAddEventsToPlayer.UseVisualStyleBackColor = true;
            this.btnAddEventsToPlayer.Click += new System.EventHandler(this.btnAddEventsToPlayer_Click);
            // 
            // btnRemoveEventFromPlayer
            // 
            this.btnRemoveEventFromPlayer.Location = new System.Drawing.Point(370, 301);
            this.btnRemoveEventFromPlayer.Name = "btnRemoveEventFromPlayer";
            this.btnRemoveEventFromPlayer.Size = new System.Drawing.Size(46, 23);
            this.btnRemoveEventFromPlayer.TabIndex = 16;
            this.btnRemoveEventFromPlayer.Text = ">>";
            this.btnRemoveEventFromPlayer.UseVisualStyleBackColor = true;
            // 
            // playerevents
            // 
            this.playerevents.AutoSize = true;
            this.playerevents.Location = new System.Drawing.Point(125, 82);
            this.playerevents.Name = "playerevents";
            this.playerevents.Size = new System.Drawing.Size(107, 13);
            this.playerevents.TabIndex = 15;
            this.playerevents.Text = "Current player events";
            // 
            // AddMultipleEventsToPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveEventFromPlayer);
            this.Controls.Add(this.btnAddEventsToPlayer);
            this.Controls.Add(this.groupBoxNewEvents);
            this.Controls.Add(this.groupBoxPlayerDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMultipleEventsToPlayer";
            this.Text = "Add Player to Events";
            this.Load += new System.EventHandler(this.AddMultipleEventsToPlayer_Load);
            this.groupBoxPlayerDetails.ResumeLayout(false);
            this.groupBoxPlayerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsBelongToPlayer)).EndInit();
            this.groupBoxNewEvents.ResumeLayout(false);
            this.groupBoxNewEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventsDoesNotBelongToPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerNumber;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAddEventsPlayerNumber;
        private System.Windows.Forms.Label labelAddEventsPlayerFullName;
        private System.Windows.Forms.Label labelAddEventsPlayerGender;
        private System.Windows.Forms.Label labelAddEventsPlayerAge;
        private System.Windows.Forms.ListBox newEventsListBox;
        private System.Windows.Forms.GroupBox groupBoxPlayerDetails;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxNewEvents;
        private System.Windows.Forms.TextBox textBoxAddEventEventFilter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAddEventsToPlayer;
        private System.Windows.Forms.Button btnRemoveEventFromPlayer;
        private System.Windows.Forms.BindingSource bindingSourceEventsDoesNotBelongToPlayer;
        private System.Windows.Forms.BindingSource bindingSourceEventsBelongToPlayer;
        private System.Windows.Forms.Label playerevents;
    }
}