﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.DB;
using HappyTechSystem.Core;

namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI form to let the user view interview records from the database.
    /// </summary>
    public partial class ViewInterview : Form
    {
        private VacancyBank vacancyBank = VacancyBank.getInst();
        private QuestionBank questionBank = QuestionBank.getInst();
        private EmailBank emailBank = EmailBank.getInst();
        private List<Interview> vacInterviews = new List<Interview>();
        private string path;
        private int pass;

        public ViewInterview()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// Button event handler to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Created By Dan. 
        /// Whenever a new interview is selected in the list, update the relevant fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_interviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qText;
            wipeAllFields();
            try
            {
                Interview I = (Interview) lb_interviews.SelectedItem;
                tb_title.Text = I.getApplicantTitle;
                tb_applicantName.Text = I.getApplicantName;
                tb_emailAddress.Text = I.getApplicantEmail;
                tb_interviewerName.Text = I.getInterviewerName;
                tb_notes.Text = I.getAdditionalNotes;
                lbl_score.Text = I.getTotal.ToString();

                int interviewIndex = vacInterviews.IndexOf(vacInterviews[lb_interviews.SelectedIndex]);
                int indexAdjust = interviewIndex + 1;

                lbl_rank.Text = indexAdjust.ToString();
                rankAdjuster();

                if (I.getTotal > pass)
                {
                    lbl_status.ForeColor = Color.Green;
                    lbl_status.Text = "Above Minimum";
                }
                else if (I.getTotal == pass)
                {
                    lbl_status.ForeColor = Color.Orange;
                    lbl_status.Text = "Equal to Minimum";
                }
                else
                {
                    lbl_status.ForeColor = Color.Red;
                    lbl_status.Text = "Below Minimum";
                }
                path = I.getCVPath;

                List<string> questionsAndRanks = new List<string>(); //final list to display to the textbox
                Vacancy v2 = vacancyBank.getVacancyList[I.getUsedVacancyID - 1];
                //assigns a local vacancy with the vacancy associated with the interview
                int[] questionIDs = v2.getQuestionsToBeUsed.ToArray();
                //an array of the question IDs that are used by the vacancy
                List<Question> questions = questionBank.getQuestionList; //localised question list


                int index = 0;
                int count = questionIDs.Length;
                do
                {
                    foreach (Question q in questions)
                    {
                        if (index == count)
                        {
                            break;
                        }

                        if (q.GetID == questionIDs[index])
                        {
                            qText = q.GetText;
                            questionsAndRanks.Add("Scored: " + I.Answers[index] + " on Question: " + qText);
                            index++;
                        }
                    }
                } while (index != count);

                lb_questionRanks.DataSource = questionsAndRanks;
            }
            catch (Exception)
            {
            }

        }

        /// <summary>
        /// Createed By Dan. 
        /// Event handler for form loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewInterview_Load(object sender, EventArgs e)
        {
            wipeAllFields();
            lb_vacancies.DataSource = vacancyBank.getVacancyList;
            EmailTemplate etTest = emailBank.getTemplateList.FirstOrDefault(em => em.getType == "Accept");
            if (emailBank.getTemplateList.Contains(etTest))
            {
                etTest = emailBank.getTemplateList.FirstOrDefault(em => em.getType == "Reject");
                if (emailBank.getTemplateList.Contains(etTest))
                {
                    btn_generateEmails.Enabled = true;
                }
            }
            else
            {
                btn_generateEmails.Enabled = false;
            }

            try
            {
                lb_vacancies.SelectedIndex = 0;
                lb_interviews.SelectedIndex = 0;
            }
            catch (Exception)
            {
                btn_generateEmails.Enabled = false;
                wipeAllFields();
            }

        }

        private void btn_cvOpen_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "The CV file cannot be found at the specified path.\n" +
                    "Ensure it still exists and hasn't been deleted or moved." +
                    "\n\nPath: " + path,
                    "Cannot Open CV");
            }
        }

        private void lb_vacancies_SelectedIndexChanged(object sender, EventArgs e)
        {
            wipeAllFields();
            vacInterviews.Clear();
            lb_interviews.Items.Clear();
            try
            {
                Vacancy v = (Vacancy)lb_vacancies.SelectedItem;
                pass = v.MinumumScore;
                //lbl_rank.Text = v.MinumumScore.ToString();
                foreach (Interview i in vacancyBank.getInterviewList)
                {
                    if (i.getUsedVacancyID == v.GetID)
                    { 
                        vacInterviews.Add(i);
                        vacInterviews.Sort((p, q) => q.getTotal.CompareTo(p.getTotal)); //sorts list by highest scorer first
                    }
                }
                lb_interviews.Items.Clear();
                foreach (Interview I in vacInterviews)
                {
                    lb_interviews.Items.Add(I);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void ViewInterview_FormClosing(object sender, FormClosingEventArgs e)
        {
            lb_interviews.Items.Clear();
        }

        private void btn_generateEmails_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Doing this will generate emails for each interview, selecting the top scorers in each interview to fill the " +
                                                        "vacancy slots.\n\n" +
                                                        "WARNING: Continuing with this procedure will close the vacancy permenantly, so as to avoid duplicate emails.\n\n" +
                                                        "Would you like to proceed?", "Generate Emails?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                gb_selectInterview.Enabled = false;
                gb_vacancies.Enabled = false;
                p_interviewData.Enabled = false;
                p_scoreLabels.Enabled = false;
                btn_close.Enabled = false;
                cb_accept.DataSource = emailBank.getTemplateList.Where(em => em.getType == "Accept").ToList();
                cb_reject.DataSource = emailBank.getTemplateList.Where(em => em.getType == "Reject").ToList();
                p_templates.Enabled = true;
                btn_generateEmails.Enabled = false;
                btn_emailHelp.Enabled = false;
            }
        }

        private void rankAdjuster()
        {
            if (lbl_rank.Text.EndsWith("1"))
            {
                lbl_rank.Text = "1st";
            }
            else if (lbl_rank.Text.EndsWith("2"))
            {
                lbl_rank.Text = "2nd";
            }
            else if (lbl_rank.Text.EndsWith("3"))
            {
                lbl_rank.Text = "3rd";
            }
            else
            {
                string str = lbl_rank.Text;
                lbl_rank.Text = str + "th";
            }
        }

        private void wipeAllFields()
        {
            tb_title.Text = "";
            tb_applicantName.Text = "";
            tb_interviewerName.Text = "";
            tb_emailAddress.Text = "";
            tb_notes.Text = "";
            lb_questionRanks.DataSource = null;
            lb_questionRanks.Items.Clear();
            lbl_rank.Text = "";
            lbl_score.Text = "";
            lbl_status.Text = "";

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //email creation!
            Vacancy v = (Vacancy)lb_vacancies.SelectedItem;
            //Interview i = (Interview) lb_interviews.SelectedItem;

            EmailCreator emailCreator = EmailCreator.getInst();
            List<EmailTemplate> let = emailBank.getTemplateList;

            int nextID = emailBank.getHighestEmailID() + 1;
            int positions = v.PositionsAvailable;
            int acceptChecker = 0;

            EmailTemplate et = new EmailTemplate();
            

            foreach (Interview I in vacInterviews)
            {
                if (acceptChecker < positions)
                {
                    et = (EmailTemplate)cb_accept.SelectedItem;
                    emailCreator.GenerateEmail(nextID, v, et, I, MdiParent.Text);
                }
                else
                {
                    et = (EmailTemplate)cb_reject.SelectedItem;
                    emailCreator.GenerateEmail(nextID, v, et, I, MdiParent.Text);
                }
                nextID++;
                acceptChecker++;
                vacancyBank.RemoveInterviewFromList(I.getInterviewID);
            }
            int count = vacInterviews.Count;
            string vacName = v.VacancyName;

            vacancyBank.RemoveVacancyFromList(v.GetID);
            MessageBox.Show(count + " emails have been generated for the vacancy: " + vacName + ".\n" +
                            "To view these Emails, check the 'View Emails' form!\n\n" +
                            "The vacancy (" + vacName + ") will now be removed safely, as all emails are generated.", "Email Generation Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_emailHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To generate emails, you need to ensure that there is at least one 'Accept' and one 'Reject' Template " +
                            "within the system.", "Why can't I generate any emails?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
