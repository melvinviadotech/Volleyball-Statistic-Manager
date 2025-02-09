namespace Volleyball_Statistic_Manager
{
    partial class formPlayByPlay
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
            this.playByPlay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.teamOneDescription = new System.Windows.Forms.RichTextBox();
            this.teamTwoDescription = new System.Windows.Forms.RichTextBox();
            this.pointEarnedTeamOneButton = new Volleyball_Statistic_Manager.RJButton();
            this.pointEarnedTeamTwoButton = new Volleyball_Statistic_Manager.RJButton();
            this.rjButton4 = new Volleyball_Statistic_Manager.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.serve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamOneScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamTwoScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scroll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjButton1 = new Volleyball_Statistic_Manager.RJButton();
            this.serveTeamTwoButton = new Volleyball_Statistic_Manager.RJButton();
            this.serveTeamOneButton = new Volleyball_Statistic_Manager.RJButton();
            this.rjButton2 = new Volleyball_Statistic_Manager.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.playByPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // playByPlay
            // 
            this.playByPlay.AllowUserToAddRows = false;
            this.playByPlay.AllowUserToDeleteRows = false;
            this.playByPlay.AllowUserToResizeColumns = false;
            this.playByPlay.AllowUserToResizeRows = false;
            this.playByPlay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.playByPlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playByPlay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serve,
            this.teamOne,
            this.teamOneScore,
            this.teamTwoScore,
            this.teamTwo,
            this.scroll});
            this.playByPlay.Location = new System.Drawing.Point(12, 12);
            this.playByPlay.Name = "playByPlay";
            this.playByPlay.RowHeadersVisible = false;
            this.playByPlay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playByPlay.Size = new System.Drawing.Size(576, 383);
            this.playByPlay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serve";
            // 
            // teamOneDescription
            // 
            this.teamOneDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamOneDescription.Location = new System.Drawing.Point(93, 416);
            this.teamOneDescription.Name = "teamOneDescription";
            this.teamOneDescription.Size = new System.Drawing.Size(218, 96);
            this.teamOneDescription.TabIndex = 114;
            this.teamOneDescription.Text = "";
            // 
            // teamTwoDescription
            // 
            this.teamTwoDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamTwoDescription.Location = new System.Drawing.Point(370, 416);
            this.teamTwoDescription.Name = "teamTwoDescription";
            this.teamTwoDescription.Size = new System.Drawing.Size(218, 96);
            this.teamTwoDescription.TabIndex = 115;
            this.teamTwoDescription.Text = "";
            // 
            // pointEarnedTeamOneButton
            // 
            this.pointEarnedTeamOneButton.BackColor = System.Drawing.Color.DimGray;
            this.pointEarnedTeamOneButton.BackgroundColor = System.Drawing.Color.DimGray;
            this.pointEarnedTeamOneButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pointEarnedTeamOneButton.BorderRadius = 0;
            this.pointEarnedTeamOneButton.BorderSize = 0;
            this.pointEarnedTeamOneButton.FlatAppearance.BorderSize = 0;
            this.pointEarnedTeamOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointEarnedTeamOneButton.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointEarnedTeamOneButton.ForeColor = System.Drawing.Color.White;
            this.pointEarnedTeamOneButton.Location = new System.Drawing.Point(311, 416);
            this.pointEarnedTeamOneButton.Margin = new System.Windows.Forms.Padding(0);
            this.pointEarnedTeamOneButton.Name = "pointEarnedTeamOneButton";
            this.pointEarnedTeamOneButton.Size = new System.Drawing.Size(29, 96);
            this.pointEarnedTeamOneButton.TabIndex = 116;
            this.pointEarnedTeamOneButton.Text = "1";
            this.pointEarnedTeamOneButton.TextColor = System.Drawing.Color.White;
            this.pointEarnedTeamOneButton.UseVisualStyleBackColor = false;
            this.pointEarnedTeamOneButton.Click += new System.EventHandler(this.PointTeamOne);
            // 
            // pointEarnedTeamTwoButton
            // 
            this.pointEarnedTeamTwoButton.BackColor = System.Drawing.Color.DimGray;
            this.pointEarnedTeamTwoButton.BackgroundColor = System.Drawing.Color.DimGray;
            this.pointEarnedTeamTwoButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pointEarnedTeamTwoButton.BorderRadius = 0;
            this.pointEarnedTeamTwoButton.BorderSize = 0;
            this.pointEarnedTeamTwoButton.FlatAppearance.BorderSize = 0;
            this.pointEarnedTeamTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointEarnedTeamTwoButton.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointEarnedTeamTwoButton.ForeColor = System.Drawing.Color.White;
            this.pointEarnedTeamTwoButton.Location = new System.Drawing.Point(340, 416);
            this.pointEarnedTeamTwoButton.Margin = new System.Windows.Forms.Padding(0);
            this.pointEarnedTeamTwoButton.Name = "pointEarnedTeamTwoButton";
            this.pointEarnedTeamTwoButton.Size = new System.Drawing.Size(30, 96);
            this.pointEarnedTeamTwoButton.TabIndex = 117;
            this.pointEarnedTeamTwoButton.Text = "2";
            this.pointEarnedTeamTwoButton.TextColor = System.Drawing.Color.White;
            this.pointEarnedTeamTwoButton.UseVisualStyleBackColor = false;
            this.pointEarnedTeamTwoButton.Click += new System.EventHandler(this.PointTeamTwo);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.DimGray;
            this.rjButton4.BackgroundColor = System.Drawing.Color.DimGray;
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 0;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(12, 520);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(446, 23);
            this.rjButton4.TabIndex = 118;
            this.rjButton4.Text = "Add Point";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.AddPoint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 119;
            this.label2.Text = "Point Earned";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serve
            // 
            this.serve.HeaderText = "Serve";
            this.serve.Name = "serve";
            this.serve.Width = 64;
            // 
            // teamOne
            // 
            this.teamOne.HeaderText = "Team One";
            this.teamOne.Name = "teamOne";
            this.teamOne.Width = 217;
            // 
            // teamOneScore
            // 
            this.teamOneScore.HeaderText = " ";
            this.teamOneScore.Name = "teamOneScore";
            this.teamOneScore.Width = 30;
            // 
            // teamTwoScore
            // 
            this.teamTwoScore.HeaderText = " ";
            this.teamTwoScore.Name = "teamTwoScore";
            this.teamTwoScore.Width = 30;
            // 
            // teamTwo
            // 
            this.teamTwo.HeaderText = "Team Two";
            this.teamTwo.Name = "teamTwo";
            this.teamTwo.Width = 216;
            // 
            // scroll
            // 
            this.scroll.HeaderText = " ";
            this.scroll.Name = "scroll";
            this.scroll.Width = 17;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.DimGray;
            this.rjButton1.BackgroundColor = System.Drawing.Color.DimGray;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(529, 520);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(59, 23);
            this.rjButton1.TabIndex = 120;
            this.rjButton1.Text = "Export";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.ExportPlayByPlayCSV);
            // 
            // serveTeamTwoButton
            // 
            this.serveTeamTwoButton.BackColor = System.Drawing.Color.DimGray;
            this.serveTeamTwoButton.BackgroundColor = System.Drawing.Color.DimGray;
            this.serveTeamTwoButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.serveTeamTwoButton.BorderRadius = 0;
            this.serveTeamTwoButton.BorderSize = 0;
            this.serveTeamTwoButton.FlatAppearance.BorderSize = 0;
            this.serveTeamTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serveTeamTwoButton.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveTeamTwoButton.ForeColor = System.Drawing.Color.White;
            this.serveTeamTwoButton.Location = new System.Drawing.Point(53, 416);
            this.serveTeamTwoButton.Name = "serveTeamTwoButton";
            this.serveTeamTwoButton.Size = new System.Drawing.Size(40, 96);
            this.serveTeamTwoButton.TabIndex = 113;
            this.serveTeamTwoButton.Text = "2";
            this.serveTeamTwoButton.TextColor = System.Drawing.Color.White;
            this.serveTeamTwoButton.UseVisualStyleBackColor = false;
            this.serveTeamTwoButton.Click += new System.EventHandler(this.ServeTeamTwo);
            // 
            // serveTeamOneButton
            // 
            this.serveTeamOneButton.BackColor = System.Drawing.Color.DimGray;
            this.serveTeamOneButton.BackgroundColor = System.Drawing.Color.DimGray;
            this.serveTeamOneButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.serveTeamOneButton.BorderRadius = 0;
            this.serveTeamOneButton.BorderSize = 0;
            this.serveTeamOneButton.FlatAppearance.BorderSize = 0;
            this.serveTeamOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serveTeamOneButton.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveTeamOneButton.ForeColor = System.Drawing.Color.White;
            this.serveTeamOneButton.Location = new System.Drawing.Point(12, 416);
            this.serveTeamOneButton.Name = "serveTeamOneButton";
            this.serveTeamOneButton.Size = new System.Drawing.Size(41, 96);
            this.serveTeamOneButton.TabIndex = 112;
            this.serveTeamOneButton.Text = "1";
            this.serveTeamOneButton.TextColor = System.Drawing.Color.White;
            this.serveTeamOneButton.UseVisualStyleBackColor = false;
            this.serveTeamOneButton.Click += new System.EventHandler(this.ServeTeamOne);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.DimGray;
            this.rjButton2.BackgroundColor = System.Drawing.Color.DimGray;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(464, 520);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(59, 23);
            this.rjButton2.TabIndex = 121;
            this.rjButton2.Text = "Undo";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.Undo);
            // 
            // formPlayByPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.pointEarnedTeamTwoButton);
            this.Controls.Add(this.pointEarnedTeamOneButton);
            this.Controls.Add(this.teamTwoDescription);
            this.Controls.Add(this.teamOneDescription);
            this.Controls.Add(this.serveTeamTwoButton);
            this.Controls.Add(this.serveTeamOneButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playByPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPlayByPlay";
            this.Text = "formPlayByPlay";
            this.Load += new System.EventHandler(this.PlayByPlayLoad);
            ((System.ComponentModel.ISupportInitialize)(this.playByPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playByPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox teamOneDescription;
        private System.Windows.Forms.RichTextBox teamTwoDescription;
        private RJButton pointEarnedTeamOneButton;
        private RJButton pointEarnedTeamTwoButton;
        private RJButton rjButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serve;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamOneScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamTwoScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn scroll;
        private RJButton rjButton1;
        private RJButton serveTeamTwoButton;
        private RJButton serveTeamOneButton;
        private RJButton rjButton2;
    }
}