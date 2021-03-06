﻿namespace HappyTechSystem
{
    partial class ViewInterview
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
            this.lb_interviews = new System.Windows.Forms.ListBox();
            this.tb_applicantName = new System.Windows.Forms.TextBox();
            this.lbl_intervieweeName = new System.Windows.Forms.Label();
            this.btn_cvOpen = new System.Windows.Forms.Button();
            this.gb_selectInterview = new System.Windows.Forms.GroupBox();
            this.lbl_interviewer = new System.Windows.Forms.Label();
            this.tb_interviewerName = new System.Windows.Forms.TextBox();
            this.lb_questionRanks = new System.Windows.Forms.ListBox();
            this.lbl_totalScore = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_intervieweeStatus = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_questionsAsked = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_emailAddress = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.lbl_additionalNotes = new System.Windows.Forms.Label();
            this.tb_notes = new System.Windows.Forms.TextBox();
            this.gb_vacancies = new System.Windows.Forms.GroupBox();
            this.lb_vacancies = new System.Windows.Forms.ListBox();
            this.btn_generateEmails = new System.Windows.Forms.Button();
            this.lbl_ranking = new System.Windows.Forms.Label();
            this.lbl_rank = new System.Windows.Forms.Label();
            this.cb_reject = new System.Windows.Forms.ComboBox();
            this.cb_accept = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_accept = new System.Windows.Forms.Label();
            this.p_templates = new System.Windows.Forms.Panel();
            this.btn_emailHelp = new System.Windows.Forms.Button();
            this.p_interviewData = new System.Windows.Forms.Panel();
            this.p_scoreLabels = new System.Windows.Forms.Panel();
            this.gb_selectInterview.SuspendLayout();
            this.gb_vacancies.SuspendLayout();
            this.p_templates.SuspendLayout();
            this.p_interviewData.SuspendLayout();
            this.p_scoreLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_interviews
            // 
            this.lb_interviews.FormattingEnabled = true;
            this.lb_interviews.HorizontalScrollbar = true;
            this.lb_interviews.Location = new System.Drawing.Point(6, 19);
            this.lb_interviews.Name = "lb_interviews";
            this.lb_interviews.Size = new System.Drawing.Size(187, 355);
            this.lb_interviews.TabIndex = 1;
            this.lb_interviews.SelectedIndexChanged += new System.EventHandler(this.lb_interviews_SelectedIndexChanged);
            // 
            // tb_applicantName
            // 
            this.tb_applicantName.Location = new System.Drawing.Point(106, 15);
            this.tb_applicantName.Name = "tb_applicantName";
            this.tb_applicantName.ReadOnly = true;
            this.tb_applicantName.Size = new System.Drawing.Size(162, 20);
            this.tb_applicantName.TabIndex = 2;
            // 
            // lbl_intervieweeName
            // 
            this.lbl_intervieweeName.AutoSize = true;
            this.lbl_intervieweeName.Location = new System.Drawing.Point(135, -1);
            this.lbl_intervieweeName.Name = "lbl_intervieweeName";
            this.lbl_intervieweeName.Size = new System.Drawing.Size(96, 13);
            this.lbl_intervieweeName.TabIndex = 3;
            this.lbl_intervieweeName.Text = "Interviewee Name:";
            // 
            // btn_cvOpen
            // 
            this.btn_cvOpen.Location = new System.Drawing.Point(274, 9);
            this.btn_cvOpen.Name = "btn_cvOpen";
            this.btn_cvOpen.Size = new System.Drawing.Size(75, 31);
            this.btn_cvOpen.TabIndex = 6;
            this.btn_cvOpen.Text = "Open CV";
            this.btn_cvOpen.UseVisualStyleBackColor = true;
            this.btn_cvOpen.Click += new System.EventHandler(this.btn_cvOpen_Click);
            // 
            // gb_selectInterview
            // 
            this.gb_selectInterview.Controls.Add(this.lb_interviews);
            this.gb_selectInterview.Location = new System.Drawing.Point(210, 13);
            this.gb_selectInterview.Name = "gb_selectInterview";
            this.gb_selectInterview.Size = new System.Drawing.Size(201, 387);
            this.gb_selectInterview.TabIndex = 7;
            this.gb_selectInterview.TabStop = false;
            this.gb_selectInterview.Text = "Select Interview";
            // 
            // lbl_interviewer
            // 
            this.lbl_interviewer.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lbl_interviewer.AutoSize = true;
            this.lbl_interviewer.Location = new System.Drawing.Point(135, 84);
            this.lbl_interviewer.Name = "lbl_interviewer";
            this.lbl_interviewer.Size = new System.Drawing.Size(105, 13);
            this.lbl_interviewer.TabIndex = 9;
            this.lbl_interviewer.Text = "Name of Interviewer:";
            // 
            // tb_interviewerName
            // 
            this.tb_interviewerName.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.tb_interviewerName.Location = new System.Drawing.Point(106, 100);
            this.tb_interviewerName.Name = "tb_interviewerName";
            this.tb_interviewerName.ReadOnly = true;
            this.tb_interviewerName.Size = new System.Drawing.Size(162, 20);
            this.tb_interviewerName.TabIndex = 8;
            // 
            // lb_questionRanks
            // 
            this.lb_questionRanks.FormattingEnabled = true;
            this.lb_questionRanks.HorizontalScrollbar = true;
            this.lb_questionRanks.Location = new System.Drawing.Point(6, 263);
            this.lb_questionRanks.Name = "lb_questionRanks";
            this.lb_questionRanks.Size = new System.Drawing.Size(354, 108);
            this.lb_questionRanks.TabIndex = 10;
            // 
            // lbl_totalScore
            // 
            this.lbl_totalScore.AutoSize = true;
            this.lbl_totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalScore.Location = new System.Drawing.Point(4, 40);
            this.lbl_totalScore.Name = "lbl_totalScore";
            this.lbl_totalScore.Size = new System.Drawing.Size(237, 25);
            this.lbl_totalScore.TabIndex = 11;
            this.lbl_totalScore.Text = "Interviewee\'s Total Score:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(247, 40);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(48, 25);
            this.lbl_score.TabIndex = 12;
            this.lbl_score.Text = "???";
            // 
            // lbl_intervieweeStatus
            // 
            this.lbl_intervieweeStatus.AutoSize = true;
            this.lbl_intervieweeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervieweeStatus.Location = new System.Drawing.Point(4, 77);
            this.lbl_intervieweeStatus.Name = "lbl_intervieweeStatus";
            this.lbl_intervieweeStatus.Size = new System.Drawing.Size(235, 25);
            this.lbl_intervieweeStatus.TabIndex = 13;
            this.lbl_intervieweeStatus.Text = "Interviewee Score Status:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(247, 77);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(48, 25);
            this.lbl_status.TabIndex = 14;
            this.lbl_status.Text = "???";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(9, 528);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(771, 29);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_questionsAsked
            // 
            this.lbl_questionsAsked.AutoSize = true;
            this.lbl_questionsAsked.Location = new System.Drawing.Point(115, 247);
            this.lbl_questionsAsked.Name = "lbl_questionsAsked";
            this.lbl_questionsAsked.Size = new System.Drawing.Size(131, 13);
            this.lbl_questionsAsked.TabIndex = 16;
            this.lbl_questionsAsked.Text = "Scores for Each Question:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(115, 41);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(141, 13);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "Interviewee\'s Email Address:";
            // 
            // tb_emailAddress
            // 
            this.tb_emailAddress.Location = new System.Drawing.Point(106, 57);
            this.tb_emailAddress.Name = "tb_emailAddress";
            this.tb_emailAddress.ReadOnly = true;
            this.tb_emailAddress.Size = new System.Drawing.Size(162, 20);
            this.tb_emailAddress.TabIndex = 19;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(65, 15);
            this.tb_title.Name = "tb_title";
            this.tb_title.ReadOnly = true;
            this.tb_title.Size = new System.Drawing.Size(35, 20);
            this.tb_title.TabIndex = 21;
            // 
            // lbl_additionalNotes
            // 
            this.lbl_additionalNotes.AutoSize = true;
            this.lbl_additionalNotes.Location = new System.Drawing.Point(144, 127);
            this.lbl_additionalNotes.Name = "lbl_additionalNotes";
            this.lbl_additionalNotes.Size = new System.Drawing.Size(87, 13);
            this.lbl_additionalNotes.TabIndex = 22;
            this.lbl_additionalNotes.Text = "Additional Notes:";
            // 
            // tb_notes
            // 
            this.tb_notes.Location = new System.Drawing.Point(65, 143);
            this.tb_notes.Multiline = true;
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.ReadOnly = true;
            this.tb_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_notes.Size = new System.Drawing.Size(244, 92);
            this.tb_notes.TabIndex = 23;
            // 
            // gb_vacancies
            // 
            this.gb_vacancies.Controls.Add(this.lb_vacancies);
            this.gb_vacancies.Location = new System.Drawing.Point(3, 13);
            this.gb_vacancies.Name = "gb_vacancies";
            this.gb_vacancies.Size = new System.Drawing.Size(201, 387);
            this.gb_vacancies.TabIndex = 8;
            this.gb_vacancies.TabStop = false;
            this.gb_vacancies.Text = "Select Vacancy";
            // 
            // lb_vacancies
            // 
            this.lb_vacancies.FormattingEnabled = true;
            this.lb_vacancies.HorizontalScrollbar = true;
            this.lb_vacancies.Location = new System.Drawing.Point(6, 19);
            this.lb_vacancies.Name = "lb_vacancies";
            this.lb_vacancies.Size = new System.Drawing.Size(187, 355);
            this.lb_vacancies.TabIndex = 1;
            this.lb_vacancies.SelectedIndexChanged += new System.EventHandler(this.lb_vacancies_SelectedIndexChanged);
            // 
            // btn_generateEmails
            // 
            this.btn_generateEmails.Enabled = false;
            this.btn_generateEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateEmails.Location = new System.Drawing.Point(423, 393);
            this.btn_generateEmails.Name = "btn_generateEmails";
            this.btn_generateEmails.Size = new System.Drawing.Size(317, 31);
            this.btn_generateEmails.TabIndex = 24;
            this.btn_generateEmails.Text = "Generate Emails for Vacancy";
            this.btn_generateEmails.UseVisualStyleBackColor = true;
            this.btn_generateEmails.Click += new System.EventHandler(this.btn_generateEmails_Click);
            // 
            // lbl_ranking
            // 
            this.lbl_ranking.AutoSize = true;
            this.lbl_ranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ranking.Location = new System.Drawing.Point(4, 8);
            this.lbl_ranking.Name = "lbl_ranking";
            this.lbl_ranking.Size = new System.Drawing.Size(171, 25);
            this.lbl_ranking.TabIndex = 25;
            this.lbl_ranking.Text = "Interview Ranking:";
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank.Location = new System.Drawing.Point(247, 8);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(48, 25);
            this.lbl_rank.TabIndex = 26;
            this.lbl_rank.Text = "???";
            // 
            // cb_reject
            // 
            this.cb_reject.FormattingEnabled = true;
            this.cb_reject.Location = new System.Drawing.Point(161, 25);
            this.cb_reject.Name = "cb_reject";
            this.cb_reject.Size = new System.Drawing.Size(142, 21);
            this.cb_reject.TabIndex = 31;
            // 
            // cb_accept
            // 
            this.cb_accept.FormattingEnabled = true;
            this.cb_accept.Location = new System.Drawing.Point(13, 25);
            this.cb_accept.Name = "cb_accept";
            this.cb_accept.Size = new System.Drawing.Size(142, 21);
            this.cb_accept.TabIndex = 30;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(13, 52);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(290, 36);
            this.btn_confirm.TabIndex = 29;
            this.btn_confirm.Text = "Confirm Templates and Proceed";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Choose a Rejection Template:";
            // 
            // lbl_accept
            // 
            this.lbl_accept.AutoSize = true;
            this.lbl_accept.Location = new System.Drawing.Point(10, 9);
            this.lbl_accept.Name = "lbl_accept";
            this.lbl_accept.Size = new System.Drawing.Size(145, 13);
            this.lbl_accept.TabIndex = 27;
            this.lbl_accept.Text = "Choose an Accept Template:";
            // 
            // p_templates
            // 
            this.p_templates.Controls.Add(this.btn_confirm);
            this.p_templates.Controls.Add(this.cb_reject);
            this.p_templates.Controls.Add(this.lbl_accept);
            this.p_templates.Controls.Add(this.cb_accept);
            this.p_templates.Controls.Add(this.label1);
            this.p_templates.Enabled = false;
            this.p_templates.Location = new System.Drawing.Point(444, 430);
            this.p_templates.Name = "p_templates";
            this.p_templates.Size = new System.Drawing.Size(313, 91);
            this.p_templates.TabIndex = 32;
            // 
            // btn_emailHelp
            // 
            this.btn_emailHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emailHelp.Location = new System.Drawing.Point(746, 393);
            this.btn_emailHelp.Name = "btn_emailHelp";
            this.btn_emailHelp.Size = new System.Drawing.Size(31, 31);
            this.btn_emailHelp.TabIndex = 33;
            this.btn_emailHelp.Text = "?";
            this.btn_emailHelp.UseVisualStyleBackColor = true;
            this.btn_emailHelp.Click += new System.EventHandler(this.btn_emailHelp_Click);
            // 
            // p_interviewData
            // 
            this.p_interviewData.Controls.Add(this.lb_questionRanks);
            this.p_interviewData.Controls.Add(this.tb_applicantName);
            this.p_interviewData.Controls.Add(this.lbl_intervieweeName);
            this.p_interviewData.Controls.Add(this.tb_interviewerName);
            this.p_interviewData.Controls.Add(this.lbl_interviewer);
            this.p_interviewData.Controls.Add(this.lbl_questionsAsked);
            this.p_interviewData.Controls.Add(this.tb_emailAddress);
            this.p_interviewData.Controls.Add(this.lbl_email);
            this.p_interviewData.Controls.Add(this.btn_cvOpen);
            this.p_interviewData.Controls.Add(this.tb_title);
            this.p_interviewData.Controls.Add(this.tb_notes);
            this.p_interviewData.Controls.Add(this.lbl_additionalNotes);
            this.p_interviewData.Location = new System.Drawing.Point(417, 12);
            this.p_interviewData.Name = "p_interviewData";
            this.p_interviewData.Size = new System.Drawing.Size(363, 375);
            this.p_interviewData.TabIndex = 34;
            // 
            // p_scoreLabels
            // 
            this.p_scoreLabels.Controls.Add(this.lbl_status);
            this.p_scoreLabels.Controls.Add(this.lbl_totalScore);
            this.p_scoreLabels.Controls.Add(this.lbl_score);
            this.p_scoreLabels.Controls.Add(this.lbl_intervieweeStatus);
            this.p_scoreLabels.Controls.Add(this.lbl_rank);
            this.p_scoreLabels.Controls.Add(this.lbl_ranking);
            this.p_scoreLabels.Location = new System.Drawing.Point(12, 412);
            this.p_scoreLabels.Name = "p_scoreLabels";
            this.p_scoreLabels.Size = new System.Drawing.Size(426, 110);
            this.p_scoreLabels.TabIndex = 35;
            // 
            // ViewInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 560);
            this.Controls.Add(this.p_interviewData);
            this.Controls.Add(this.btn_emailHelp);
            this.Controls.Add(this.p_templates);
            this.Controls.Add(this.btn_generateEmails);
            this.Controls.Add(this.gb_vacancies);
            this.Controls.Add(this.gb_selectInterview);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.p_scoreLabels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewInterview";
            this.Text = "View Interviews";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewInterview_FormClosing);
            this.Load += new System.EventHandler(this.ViewInterview_Load);
            this.gb_selectInterview.ResumeLayout(false);
            this.gb_vacancies.ResumeLayout(false);
            this.p_templates.ResumeLayout(false);
            this.p_templates.PerformLayout();
            this.p_interviewData.ResumeLayout(false);
            this.p_interviewData.PerformLayout();
            this.p_scoreLabels.ResumeLayout(false);
            this.p_scoreLabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_interviews;
        private System.Windows.Forms.TextBox tb_applicantName;
        private System.Windows.Forms.Label lbl_intervieweeName;
        private System.Windows.Forms.Button btn_cvOpen;
        private System.Windows.Forms.GroupBox gb_selectInterview;
        private System.Windows.Forms.Label lbl_interviewer;
        private System.Windows.Forms.TextBox tb_interviewerName;
        private System.Windows.Forms.ListBox lb_questionRanks;
        private System.Windows.Forms.Label lbl_totalScore;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_intervieweeStatus;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_questionsAsked;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_emailAddress;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label lbl_additionalNotes;
        private System.Windows.Forms.TextBox tb_notes;
        private System.Windows.Forms.GroupBox gb_vacancies;
        private System.Windows.Forms.ListBox lb_vacancies;
        private System.Windows.Forms.Button btn_generateEmails;
        private System.Windows.Forms.Label lbl_ranking;
        private System.Windows.Forms.Label lbl_rank;
        private System.Windows.Forms.ComboBox cb_reject;
        private System.Windows.Forms.ComboBox cb_accept;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_accept;
        private System.Windows.Forms.Panel p_templates;
        private System.Windows.Forms.Button btn_emailHelp;
        private System.Windows.Forms.Panel p_interviewData;
        private System.Windows.Forms.Panel p_scoreLabels;
    }
}