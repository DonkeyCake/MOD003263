﻿namespace HappyTechSystem
{
    partial class ViewVacancies
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
            this.lb_vacancy = new System.Windows.Forms.ListBox();
            this.lbl_selectVacancy = new System.Windows.Forms.Label();
            this.lbl_minScore = new System.Windows.Forms.Label();
            this.nud_acceptance = new System.Windows.Forms.NumericUpDown();
            this.lbl_slots = new System.Windows.Forms.Label();
            this.nud_slots = new System.Windows.Forms.NumericUpDown();
            this.lb_questionsUsed = new System.Windows.Forms.ListBox();
            this.lbl_usedQuestions = new System.Windows.Forms.Label();
            this.btn_removeQuestion = new System.Windows.Forms.Button();
            this.btn_moveQuestion = new System.Windows.Forms.Button();
            this.lbl_questionBank = new System.Windows.Forms.Label();
            this.lb_questionBank = new System.Windows.Forms.ListBox();
            this.lbl_vacancyName = new System.Windows.Forms.Label();
            this.tb_vacancyName = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.p_editToolbox = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_role = new System.Windows.Forms.Label();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_interviews = new System.Windows.Forms.Label();
            this.lb_interviews = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_acceptance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_slots)).BeginInit();
            this.p_editToolbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_vacancy
            // 
            this.lb_vacancy.FormattingEnabled = true;
            this.lb_vacancy.Location = new System.Drawing.Point(12, 25);
            this.lb_vacancy.Name = "lb_vacancy";
            this.lb_vacancy.Size = new System.Drawing.Size(214, 199);
            this.lb_vacancy.TabIndex = 0;
            this.lb_vacancy.SelectedIndexChanged += new System.EventHandler(this.lb_vacancy_SelectedIndexChanged);
            // 
            // lbl_selectVacancy
            // 
            this.lbl_selectVacancy.AutoSize = true;
            this.lbl_selectVacancy.Location = new System.Drawing.Point(9, 9);
            this.lbl_selectVacancy.Name = "lbl_selectVacancy";
            this.lbl_selectVacancy.Size = new System.Drawing.Size(186, 13);
            this.lbl_selectVacancy.TabIndex = 1;
            this.lbl_selectVacancy.Text = "Choose a vacancy from the list below:";
            // 
            // lbl_minScore
            // 
            this.lbl_minScore.AutoSize = true;
            this.lbl_minScore.Location = new System.Drawing.Point(177, 31);
            this.lbl_minScore.Name = "lbl_minScore";
            this.lbl_minScore.Size = new System.Drawing.Size(158, 13);
            this.lbl_minScore.TabIndex = 2;
            this.lbl_minScore.Text = "Minimum Score for Acceptance:";
            // 
            // nud_acceptance
            // 
            this.nud_acceptance.Location = new System.Drawing.Point(353, 29);
            this.nud_acceptance.Name = "nud_acceptance";
            this.nud_acceptance.ReadOnly = true;
            this.nud_acceptance.Size = new System.Drawing.Size(77, 20);
            this.nud_acceptance.TabIndex = 3;
            // 
            // lbl_slots
            // 
            this.lbl_slots.AutoSize = true;
            this.lbl_slots.Location = new System.Drawing.Point(177, 58);
            this.lbl_slots.Name = "lbl_slots";
            this.lbl_slots.Size = new System.Drawing.Size(73, 13);
            this.lbl_slots.TabIndex = 4;
            this.lbl_slots.Text = "Position Slots:";
            // 
            // nud_slots
            // 
            this.nud_slots.Location = new System.Drawing.Point(353, 58);
            this.nud_slots.Name = "nud_slots";
            this.nud_slots.ReadOnly = true;
            this.nud_slots.Size = new System.Drawing.Size(77, 20);
            this.nud_slots.TabIndex = 5;
            // 
            // lb_questionsUsed
            // 
            this.lb_questionsUsed.Enabled = false;
            this.lb_questionsUsed.FormattingEnabled = true;
            this.lb_questionsUsed.Location = new System.Drawing.Point(272, 121);
            this.lb_questionsUsed.Name = "lb_questionsUsed";
            this.lb_questionsUsed.Size = new System.Drawing.Size(211, 134);
            this.lb_questionsUsed.TabIndex = 6;
            // 
            // lbl_usedQuestions
            // 
            this.lbl_usedQuestions.AutoSize = true;
            this.lbl_usedQuestions.Location = new System.Drawing.Point(323, 104);
            this.lbl_usedQuestions.Name = "lbl_usedQuestions";
            this.lbl_usedQuestions.Size = new System.Drawing.Size(107, 13);
            this.lbl_usedQuestions.TabIndex = 7;
            this.lbl_usedQuestions.Text = "Questions to be used";
            // 
            // btn_removeQuestion
            // 
            this.btn_removeQuestion.Enabled = false;
            this.btn_removeQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeQuestion.Location = new System.Drawing.Point(219, 218);
            this.btn_removeQuestion.Name = "btn_removeQuestion";
            this.btn_removeQuestion.Size = new System.Drawing.Size(47, 37);
            this.btn_removeQuestion.TabIndex = 13;
            this.btn_removeQuestion.Text = "[R]";
            this.btn_removeQuestion.UseVisualStyleBackColor = true;
            // 
            // btn_moveQuestion
            // 
            this.btn_moveQuestion.Enabled = false;
            this.btn_moveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moveQuestion.Location = new System.Drawing.Point(219, 132);
            this.btn_moveQuestion.Name = "btn_moveQuestion";
            this.btn_moveQuestion.Size = new System.Drawing.Size(47, 37);
            this.btn_moveQuestion.TabIndex = 12;
            this.btn_moveQuestion.Text = "-->";
            this.btn_moveQuestion.UseVisualStyleBackColor = true;
            // 
            // lbl_questionBank
            // 
            this.lbl_questionBank.AutoSize = true;
            this.lbl_questionBank.Location = new System.Drawing.Point(70, 105);
            this.lbl_questionBank.Name = "lbl_questionBank";
            this.lbl_questionBank.Size = new System.Drawing.Size(77, 13);
            this.lbl_questionBank.TabIndex = 11;
            this.lbl_questionBank.Text = "Question Bank";
            // 
            // lb_questionBank
            // 
            this.lb_questionBank.Enabled = false;
            this.lb_questionBank.FormattingEnabled = true;
            this.lb_questionBank.Location = new System.Drawing.Point(2, 121);
            this.lb_questionBank.Name = "lb_questionBank";
            this.lb_questionBank.Size = new System.Drawing.Size(211, 134);
            this.lb_questionBank.TabIndex = 10;
            // 
            // lbl_vacancyName
            // 
            this.lbl_vacancyName.AutoSize = true;
            this.lbl_vacancyName.Location = new System.Drawing.Point(33, 8);
            this.lbl_vacancyName.Name = "lbl_vacancyName";
            this.lbl_vacancyName.Size = new System.Drawing.Size(80, 13);
            this.lbl_vacancyName.TabIndex = 9;
            this.lbl_vacancyName.Text = "Vacancy Name";
            // 
            // tb_vacancyName
            // 
            this.tb_vacancyName.Location = new System.Drawing.Point(23, 26);
            this.tb_vacancyName.Name = "tb_vacancyName";
            this.tb_vacancyName.ReadOnly = true;
            this.tb_vacancyName.Size = new System.Drawing.Size(100, 20);
            this.tb_vacancyName.TabIndex = 8;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(974, 9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(63, 48);
            this.btn_edit.TabIndex = 57;
            this.btn_edit.Text = "Toggle Edit Mode";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // p_editToolbox
            // 
            this.p_editToolbox.Controls.Add(this.btn_delete);
            this.p_editToolbox.Controls.Add(this.btn_save);
            this.p_editToolbox.Location = new System.Drawing.Point(974, 63);
            this.p_editToolbox.Name = "p_editToolbox";
            this.p_editToolbox.Size = new System.Drawing.Size(63, 100);
            this.p_editToolbox.TabIndex = 58;
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(0, 51);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(63, 48);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Delete Vacancy";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(0, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(63, 48);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 232);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(214, 32);
            this.btn_close.TabIndex = 59;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(47, 49);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(49, 13);
            this.lbl_role.TabIndex = 14;
            this.lbl_role.Text = "Job Role";
            // 
            // tb_role
            // 
            this.tb_role.Location = new System.Drawing.Point(23, 65);
            this.tb_role.Name = "tb_role";
            this.tb_role.ReadOnly = true;
            this.tb_role.Size = new System.Drawing.Size(100, 20);
            this.tb_role.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_interviews);
            this.panel1.Controls.Add(this.lb_interviews);
            this.panel1.Controls.Add(this.tb_role);
            this.panel1.Controls.Add(this.lb_questionsUsed);
            this.panel1.Controls.Add(this.lbl_role);
            this.panel1.Controls.Add(this.lbl_slots);
            this.panel1.Controls.Add(this.btn_removeQuestion);
            this.panel1.Controls.Add(this.nud_acceptance);
            this.panel1.Controls.Add(this.btn_moveQuestion);
            this.panel1.Controls.Add(this.lbl_minScore);
            this.panel1.Controls.Add(this.lbl_questionBank);
            this.panel1.Controls.Add(this.lbl_usedQuestions);
            this.panel1.Controls.Add(this.lb_questionBank);
            this.panel1.Controls.Add(this.nud_slots);
            this.panel1.Controls.Add(this.lbl_vacancyName);
            this.panel1.Controls.Add(this.tb_vacancyName);
            this.panel1.Location = new System.Drawing.Point(232, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 255);
            this.panel1.TabIndex = 60;
            // 
            // lbl_interviews
            // 
            this.lbl_interviews.AutoSize = true;
            this.lbl_interviews.Location = new System.Drawing.Point(558, 8);
            this.lbl_interviews.Name = "lbl_interviews";
            this.lbl_interviews.Size = new System.Drawing.Size(113, 13);
            this.lbl_interviews.TabIndex = 17;
            this.lbl_interviews.Text = "Associated Interviews:";
            // 
            // lb_interviews
            // 
            this.lb_interviews.Enabled = false;
            this.lb_interviews.FormattingEnabled = true;
            this.lb_interviews.Location = new System.Drawing.Point(506, 30);
            this.lb_interviews.Name = "lb_interviews";
            this.lb_interviews.Size = new System.Drawing.Size(212, 225);
            this.lb_interviews.TabIndex = 16;
            // 
            // ViewVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.p_editToolbox);
            this.Controls.Add(this.lbl_selectVacancy);
            this.Controls.Add(this.lb_vacancy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewVacancies";
            this.Text = "Modify and View Vacancies";
            this.Load += new System.EventHandler(this.ViewVacancies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_acceptance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_slots)).EndInit();
            this.p_editToolbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_vacancy;
        private System.Windows.Forms.Label lbl_selectVacancy;
        private System.Windows.Forms.Label lbl_minScore;
        private System.Windows.Forms.NumericUpDown nud_acceptance;
        private System.Windows.Forms.Label lbl_slots;
        private System.Windows.Forms.NumericUpDown nud_slots;
        private System.Windows.Forms.ListBox lb_questionsUsed;
        private System.Windows.Forms.Label lbl_usedQuestions;
        private System.Windows.Forms.Label lbl_vacancyName;
        private System.Windows.Forms.TextBox tb_vacancyName;
        private System.Windows.Forms.Label lbl_questionBank;
        private System.Windows.Forms.ListBox lb_questionBank;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel p_editToolbox;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_removeQuestion;
        private System.Windows.Forms.Button btn_moveQuestion;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_interviews;
        private System.Windows.Forms.ListBox lb_interviews;
    }
}