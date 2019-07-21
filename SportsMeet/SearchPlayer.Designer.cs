namespace SportsMeet
{
    partial class SearchPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPlayer));
            this.tbxPlayerNumberSW = new System.Windows.Forms.TextBox();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSearchSW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOkaySW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPlayerNumberSW
            // 
            this.tbxPlayerNumberSW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbxPlayerNumberSW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxPlayerNumberSW.Location = new System.Drawing.Point(86, 6);
            this.tbxPlayerNumberSW.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPlayerNumberSW.Name = "tbxPlayerNumberSW";
            this.tbxPlayerNumberSW.Size = new System.Drawing.Size(127, 20);
            this.tbxPlayerNumberSW.TabIndex = 0;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(5, 9);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(76, 13);
            this.lblPlayerNumber.TabIndex = 3;
            this.lblPlayerNumber.Text = "Player Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "School";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(5, 130);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(49, 13);
            this.lblDistrict.TabIndex = 27;
            this.lblDistrict.Text = "Province";
            this.lblDistrict.Visible = false;
            this.lblDistrict.Click += new System.EventHandler(this.lblDistrict_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(5, 103);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 25;
            this.lblAge.Text = "Age";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // btnSearchSW
            // 
            this.btnSearchSW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSW.Location = new System.Drawing.Point(180, 182);
            this.btnSearchSW.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchSW.Name = "btnSearchSW";
            this.btnSearchSW.Size = new System.Drawing.Size(93, 24);
            this.btnSearchSW.TabIndex = 28;
            this.btnSearchSW.Text = "Search";
            this.btnSearchSW.UseVisualStyleBackColor = true;
            this.btnSearchSW.Click += new System.EventHandler(this.btnSearchSW_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Education Zone";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonOkaySW
            // 
            this.buttonOkaySW.Location = new System.Drawing.Point(83, 182);
            this.buttonOkaySW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOkaySW.Name = "buttonOkaySW";
            this.buttonOkaySW.Size = new System.Drawing.Size(93, 24);
            this.buttonOkaySW.TabIndex = 47;
            this.buttonOkaySW.Text = "OK";
            this.buttonOkaySW.UseVisualStyleBackColor = true;
            this.buttonOkaySW.Click += new System.EventHandler(this.buttonOkaySW_Click);
            // 
            // SearchPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPlayerNumberSW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOkaySW);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnSearchSW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchPlayer";
            this.Text = "Search Player";
            this.Load += new System.EventHandler(this.SearchPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPlayerNumberSW;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSearchSW;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buttonOkaySW;
    }
}