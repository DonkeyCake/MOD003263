﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.Core;

namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI form that displays all vacancies from the database.
    /// </summary>
    public partial class ViewVacancies : Form
    {
        private VacancyBank vacancyBank = VacancyBank.getInst();
        private QuestionBank questionBank = QuestionBank.getInst();
        //variable that acts as a toggle. used by the edit button event handler
        private byte flag;

        public ViewVacancies()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// Enables fields on the form for edits to take place.
        /// A flag is in place to toggle the enabled and disabled states.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                p_editToolbox.Enabled = true;
                tb_vacancyName.ReadOnly = false;
                tb_role.Enabled = false;
                lb_questionBank.Enabled = false;
                lb_questionsUsed.Enabled = false;
                nud_acceptance.ReadOnly = false;
                nud_slots.ReadOnly = false;
                btn_moveQuestion.Enabled = true;
                btn_removeQuestion.Enabled = true;
                flag++;

            }
            else
            {
                p_editToolbox.Enabled = false;
                tb_vacancyName.ReadOnly = true;
                tb_role.Enabled = true;
                lb_questionBank.Enabled = true;
                lb_questionsUsed.Enabled = true;
                nud_acceptance.ReadOnly = true;
                nud_slots.ReadOnly = true;
                btn_moveQuestion.Enabled = false;
                btn_removeQuestion.Enabled = false;
                flag--;
            }

        }

        private void lb_vacancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_interviews.Items.Clear();
            lb_questionsUsed.Items.Clear();
            try
            {
                Vacancy v = (Vacancy)lb_vacancy.SelectedItem;
                tb_vacancyName.Text = v.VacancyName;
                tb_role.Text = v.Role;
                nud_acceptance.Value = v.MinumumScore;
                nud_slots.Value = v.PositionsAvailable;
                lb_questionBank.DataSource = questionBank.getQuestionList;

                int index = 0;
                foreach (Question q in questionBank.getQuestionList)
                {
                    if (q.GetID == v.getQuestionsToBeUsed[index])
                    {
                        lb_questionsUsed.Items.Add(q.ToString());
                    }
                    index++;
                }


                foreach (Interview I in vacancyBank.getInterviewList)
                {
                    if (I.getUsedVacancyID == v.GetID)
                    {
                        lb_interviews.Items.Add(I);
                    } 
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void ViewVacancies_Load(object sender, EventArgs e)
        {
            lb_vacancy.DataSource = vacancyBank.getVacancyList;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewVacancies_FormClosing(object sender, FormClosingEventArgs e)
        {
            lb_interviews.Items.Clear();
            lb_questionsUsed.Items.Clear();
        }
    }
}
