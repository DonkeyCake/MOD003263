﻿namespace HappyTechSystem
{
    partial class CreateQuestion
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
            this.lbl_questionID = new System.Windows.Forms.Label();
            this.tb_questionID = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.questionBankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_questionText = new System.Windows.Forms.Label();
            this.tb_questionText = new System.Windows.Forms.TextBox();
            this.tb_response1 = new System.Windows.Forms.TextBox();
            this.tb_feedback1 = new System.Windows.Forms.TextBox();
            this.tb_feedback2 = new System.Windows.Forms.TextBox();
            this.tb_response2 = new System.Windows.Forms.TextBox();
            this.tb_feedback3 = new System.Windows.Forms.TextBox();
            this.tb_response3 = new System.Windows.Forms.TextBox();
            this.tb_feedback4 = new System.Windows.Forms.TextBox();
            this.tb_response4 = new System.Windows.Forms.TextBox();
            this.tb_feedback5 = new System.Windows.Forms.TextBox();
            this.tb_response5 = new System.Windows.Forms.TextBox();
            this.lbl_rank1 = new System.Windows.Forms.Label();
            this.lbl_rank2 = new System.Windows.Forms.Label();
            this.lbl_rank3 = new System.Windows.Forms.Label();
            this.lbl_rank4 = new System.Windows.Forms.Label();
            this.lbl_rank5 = new System.Windows.Forms.Label();
            this.btn_createQuestion = new System.Windows.Forms.Button();
            this.btn_createQuestionHelp = new System.Windows.Forms.Button();
            this.gb_category = new System.Windows.Forms.GroupBox();
            this.btn_categoryDone = new System.Windows.Forms.Button();
            this.lbl_deleteConfirmation = new System.Windows.Forms.Label();
            this.lbl_deleteCategory = new System.Windows.Forms.Label();
            this.btn_deleteCategory = new System.Windows.Forms.Button();
            this.lbl_addNewCategory = new System.Windows.Forms.Label();
            this.cb_deleteCategory = new System.Windows.Forms.ComboBox();
            this.lbl_addConfimation = new System.Windows.Forms.Label();
            this.tb_addCategory = new System.Windows.Forms.TextBox();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_manageCategories = new System.Windows.Forms.Button();
            this.gb_question = new System.Windows.Forms.GroupBox();
            this.btn_categoryManagerHelp = new System.Windows.Forms.Button();
            this.p_respFeed = new System.Windows.Forms.Panel();
            this.gb_feedback = new System.Windows.Forms.GroupBox();
            this.gb_responses = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.questionBankBindingSource)).BeginInit();
            this.gb_category.SuspendLayout();
            this.gb_question.SuspendLayout();
            this.p_respFeed.SuspendLayout();
            this.gb_feedback.SuspendLayout();
            this.gb_responses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_questionID
            // 
            this.lbl_questionID.AutoSize = true;
            this.lbl_questionID.Location = new System.Drawing.Point(11, 22);
            this.lbl_questionID.Name = "lbl_questionID";
            this.lbl_questionID.Size = new System.Drawing.Size(63, 13);
            this.lbl_questionID.TabIndex = 0;
            this.lbl_questionID.Text = "Question ID";
            // 
            // tb_questionID
            // 
            this.tb_questionID.Location = new System.Drawing.Point(27, 38);
            this.tb_questionID.Name = "tb_questionID";
            this.tb_questionID.ReadOnly = true;
            this.tb_questionID.Size = new System.Drawing.Size(28, 20);
            this.tb_questionID.TabIndex = 1;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(117, 21);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(208, 13);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "Select a Category to tag this question with:";
            // 
            // cb_category
            // 
            this.cb_category.DataSource = this.questionBankBindingSource;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(140, 37);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(145, 21);
            this.cb_category.TabIndex = 4;
            // 
            // questionBankBindingSource
            // 
            this.questionBankBindingSource.DataSource = typeof(HappyTechSystem.Core.QuestionBank);
            // 
            // lbl_questionText
            // 
            this.lbl_questionText.AutoSize = true;
            this.lbl_questionText.Location = new System.Drawing.Point(10, 79);
            this.lbl_questionText.Name = "lbl_questionText";
            this.lbl_questionText.Size = new System.Drawing.Size(120, 13);
            this.lbl_questionText.TabIndex = 5;
            this.lbl_questionText.Text = "Enter the question here:";
            // 
            // tb_questionText
            // 
            this.tb_questionText.Location = new System.Drawing.Point(140, 79);
            this.tb_questionText.Multiline = true;
            this.tb_questionText.Name = "tb_questionText";
            this.tb_questionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_questionText.Size = new System.Drawing.Size(394, 99);
            this.tb_questionText.TabIndex = 6;
            this.tb_questionText.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_response1
            // 
            this.tb_response1.Location = new System.Drawing.Point(6, 31);
            this.tb_response1.Multiline = true;
            this.tb_response1.Name = "tb_response1";
            this.tb_response1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response1.Size = new System.Drawing.Size(237, 84);
            this.tb_response1.TabIndex = 7;
            this.tb_response1.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_feedback1
            // 
            this.tb_feedback1.Location = new System.Drawing.Point(6, 19);
            this.tb_feedback1.Multiline = true;
            this.tb_feedback1.Name = "tb_feedback1";
            this.tb_feedback1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback1.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback1.TabIndex = 8;
            this.tb_feedback1.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_feedback2
            // 
            this.tb_feedback2.Location = new System.Drawing.Point(249, 19);
            this.tb_feedback2.Multiline = true;
            this.tb_feedback2.Name = "tb_feedback2";
            this.tb_feedback2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback2.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback2.TabIndex = 10;
            this.tb_feedback2.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_response2
            // 
            this.tb_response2.Location = new System.Drawing.Point(249, 31);
            this.tb_response2.Multiline = true;
            this.tb_response2.Name = "tb_response2";
            this.tb_response2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response2.Size = new System.Drawing.Size(237, 84);
            this.tb_response2.TabIndex = 9;
            this.tb_response2.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_feedback3
            // 
            this.tb_feedback3.Location = new System.Drawing.Point(492, 19);
            this.tb_feedback3.Multiline = true;
            this.tb_feedback3.Name = "tb_feedback3";
            this.tb_feedback3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback3.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback3.TabIndex = 12;
            this.tb_feedback3.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_response3
            // 
            this.tb_response3.Location = new System.Drawing.Point(492, 31);
            this.tb_response3.Multiline = true;
            this.tb_response3.Name = "tb_response3";
            this.tb_response3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response3.Size = new System.Drawing.Size(237, 84);
            this.tb_response3.TabIndex = 11;
            this.tb_response3.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_feedback4
            // 
            this.tb_feedback4.Location = new System.Drawing.Point(735, 19);
            this.tb_feedback4.Multiline = true;
            this.tb_feedback4.Name = "tb_feedback4";
            this.tb_feedback4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback4.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback4.TabIndex = 14;
            this.tb_feedback4.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_response4
            // 
            this.tb_response4.Location = new System.Drawing.Point(735, 31);
            this.tb_response4.Multiline = true;
            this.tb_response4.Name = "tb_response4";
            this.tb_response4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response4.Size = new System.Drawing.Size(237, 84);
            this.tb_response4.TabIndex = 13;
            this.tb_response4.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_feedback5
            // 
            this.tb_feedback5.Location = new System.Drawing.Point(978, 19);
            this.tb_feedback5.Multiline = true;
            this.tb_feedback5.Name = "tb_feedback5";
            this.tb_feedback5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_feedback5.Size = new System.Drawing.Size(237, 84);
            this.tb_feedback5.TabIndex = 16;
            this.tb_feedback5.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // tb_response5
            // 
            this.tb_response5.Location = new System.Drawing.Point(978, 31);
            this.tb_response5.Multiline = true;
            this.tb_response5.Name = "tb_response5";
            this.tb_response5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_response5.Size = new System.Drawing.Size(237, 84);
            this.tb_response5.TabIndex = 15;
            this.tb_response5.TextChanged += new System.EventHandler(this.CreateQuestionUnlocker);
            // 
            // lbl_rank1
            // 
            this.lbl_rank1.AutoSize = true;
            this.lbl_rank1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank1.Location = new System.Drawing.Point(59, 8);
            this.lbl_rank1.Name = "lbl_rank1";
            this.lbl_rank1.Size = new System.Drawing.Size(124, 18);
            this.lbl_rank1.TabIndex = 19;
            this.lbl_rank1.Text = "Rank 1 (Worst)";
            // 
            // lbl_rank2
            // 
            this.lbl_rank2.AutoSize = true;
            this.lbl_rank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank2.Location = new System.Drawing.Point(309, 8);
            this.lbl_rank2.Name = "lbl_rank2";
            this.lbl_rank2.Size = new System.Drawing.Size(115, 18);
            this.lbl_rank2.TabIndex = 20;
            this.lbl_rank2.Text = "Rank 2 (Poor)";
            // 
            // lbl_rank3
            // 
            this.lbl_rank3.AutoSize = true;
            this.lbl_rank3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank3.Location = new System.Drawing.Point(537, 8);
            this.lbl_rank3.Name = "lbl_rank3";
            this.lbl_rank3.Size = new System.Drawing.Size(148, 18);
            this.lbl_rank3.TabIndex = 21;
            this.lbl_rank3.Text = "Rank 3 (Mediocre)";
            // 
            // lbl_rank4
            // 
            this.lbl_rank4.AutoSize = true;
            this.lbl_rank4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank4.Location = new System.Drawing.Point(792, 8);
            this.lbl_rank4.Name = "lbl_rank4";
            this.lbl_rank4.Size = new System.Drawing.Size(120, 18);
            this.lbl_rank4.TabIndex = 22;
            this.lbl_rank4.Text = "Rank 4 (Good)";
            // 
            // lbl_rank5
            // 
            this.lbl_rank5.AutoSize = true;
            this.lbl_rank5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank5.Location = new System.Drawing.Point(1044, 8);
            this.lbl_rank5.Name = "lbl_rank5";
            this.lbl_rank5.Size = new System.Drawing.Size(112, 18);
            this.lbl_rank5.TabIndex = 23;
            this.lbl_rank5.Text = "Rank 5 (Best)";
            // 
            // btn_createQuestion
            // 
            this.btn_createQuestion.Enabled = false;
            this.btn_createQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createQuestion.Location = new System.Drawing.Point(12, 532);
            this.btn_createQuestion.Name = "btn_createQuestion";
            this.btn_createQuestion.Size = new System.Drawing.Size(1176, 35);
            this.btn_createQuestion.TabIndex = 24;
            this.btn_createQuestion.Text = "Create Question";
            this.btn_createQuestion.UseVisualStyleBackColor = true;
            this.btn_createQuestion.Click += new System.EventHandler(this.btn_createQuestion_Click);
            // 
            // btn_createQuestionHelp
            // 
            this.btn_createQuestionHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createQuestionHelp.Location = new System.Drawing.Point(1194, 532);
            this.btn_createQuestionHelp.Name = "btn_createQuestionHelp";
            this.btn_createQuestionHelp.Size = new System.Drawing.Size(63, 35);
            this.btn_createQuestionHelp.TabIndex = 25;
            this.btn_createQuestionHelp.Text = "?";
            this.btn_createQuestionHelp.UseVisualStyleBackColor = true;
            this.btn_createQuestionHelp.Click += new System.EventHandler(this.btn_createQuestionHelp_Click);
            // 
            // gb_category
            // 
            this.gb_category.Controls.Add(this.btn_categoryDone);
            this.gb_category.Controls.Add(this.lbl_deleteConfirmation);
            this.gb_category.Controls.Add(this.lbl_deleteCategory);
            this.gb_category.Controls.Add(this.btn_deleteCategory);
            this.gb_category.Controls.Add(this.lbl_addNewCategory);
            this.gb_category.Controls.Add(this.cb_deleteCategory);
            this.gb_category.Controls.Add(this.lbl_addConfimation);
            this.gb_category.Controls.Add(this.tb_addCategory);
            this.gb_category.Controls.Add(this.btn_addCategory);
            this.gb_category.Enabled = false;
            this.gb_category.Location = new System.Drawing.Point(760, 50);
            this.gb_category.Name = "gb_category";
            this.gb_category.Size = new System.Drawing.Size(450, 131);
            this.gb_category.TabIndex = 26;
            this.gb_category.TabStop = false;
            this.gb_category.Text = "Category Manager";
            // 
            // btn_categoryDone
            // 
            this.btn_categoryDone.Location = new System.Drawing.Point(148, 93);
            this.btn_categoryDone.Name = "btn_categoryDone";
            this.btn_categoryDone.Size = new System.Drawing.Size(158, 32);
            this.btn_categoryDone.TabIndex = 8;
            this.btn_categoryDone.Text = "Done";
            this.btn_categoryDone.UseVisualStyleBackColor = true;
            this.btn_categoryDone.Click += new System.EventHandler(this.btn_categoryDone_Click);
            // 
            // lbl_deleteConfirmation
            // 
            this.lbl_deleteConfirmation.AutoSize = true;
            this.lbl_deleteConfirmation.ForeColor = System.Drawing.Color.Green;
            this.lbl_deleteConfirmation.Location = new System.Drawing.Point(226, 73);
            this.lbl_deleteConfirmation.Name = "lbl_deleteConfirmation";
            this.lbl_deleteConfirmation.Size = new System.Drawing.Size(16, 13);
            this.lbl_deleteConfirmation.TabIndex = 7;
            this.lbl_deleteConfirmation.Text = "...";
            // 
            // lbl_deleteCategory
            // 
            this.lbl_deleteCategory.AutoSize = true;
            this.lbl_deleteCategory.Location = new System.Drawing.Point(259, 29);
            this.lbl_deleteCategory.Name = "lbl_deleteCategory";
            this.lbl_deleteCategory.Size = new System.Drawing.Size(94, 13);
            this.lbl_deleteCategory.TabIndex = 6;
            this.lbl_deleteCategory.Text = "Delete a category:";
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.Enabled = false;
            this.btn_deleteCategory.Location = new System.Drawing.Point(380, 47);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(48, 23);
            this.btn_deleteCategory.TabIndex = 5;
            this.btn_deleteCategory.Text = "Delete";
            this.btn_deleteCategory.UseVisualStyleBackColor = true;
            this.btn_deleteCategory.Click += new System.EventHandler(this.btn_deleteCategory_Click);
            // 
            // lbl_addNewCategory
            // 
            this.lbl_addNewCategory.AutoSize = true;
            this.lbl_addNewCategory.Location = new System.Drawing.Point(44, 29);
            this.lbl_addNewCategory.Name = "lbl_addNewCategory";
            this.lbl_addNewCategory.Size = new System.Drawing.Size(106, 13);
            this.lbl_addNewCategory.TabIndex = 4;
            this.lbl_addNewCategory.Text = "Add a new Category:";
            // 
            // cb_deleteCategory
            // 
            this.cb_deleteCategory.FormattingEnabled = true;
            this.cb_deleteCategory.Location = new System.Drawing.Point(229, 49);
            this.cb_deleteCategory.Name = "cb_deleteCategory";
            this.cb_deleteCategory.Size = new System.Drawing.Size(145, 21);
            this.cb_deleteCategory.TabIndex = 3;
            this.cb_deleteCategory.SelectedIndexChanged += new System.EventHandler(this.categoryCheck);
            // 
            // lbl_addConfimation
            // 
            this.lbl_addConfimation.AutoSize = true;
            this.lbl_addConfimation.ForeColor = System.Drawing.Color.Green;
            this.lbl_addConfimation.Location = new System.Drawing.Point(11, 72);
            this.lbl_addConfimation.Name = "lbl_addConfimation";
            this.lbl_addConfimation.Size = new System.Drawing.Size(16, 13);
            this.lbl_addConfimation.TabIndex = 2;
            this.lbl_addConfimation.Text = "...";
            // 
            // tb_addCategory
            // 
            this.tb_addCategory.Location = new System.Drawing.Point(14, 49);
            this.tb_addCategory.Name = "tb_addCategory";
            this.tb_addCategory.Size = new System.Drawing.Size(145, 20);
            this.tb_addCategory.TabIndex = 1;
            this.tb_addCategory.TextChanged += new System.EventHandler(this.CatergoryAddUnlocker);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Enabled = false;
            this.btn_addCategory.Location = new System.Drawing.Point(165, 47);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(48, 23);
            this.btn_addCategory.TabIndex = 0;
            this.btn_addCategory.Text = "Add";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_manageCategories
            // 
            this.btn_manageCategories.Location = new System.Drawing.Point(456, 19);
            this.btn_manageCategories.Name = "btn_manageCategories";
            this.btn_manageCategories.Size = new System.Drawing.Size(144, 35);
            this.btn_manageCategories.TabIndex = 27;
            this.btn_manageCategories.Text = "Manage Categories";
            this.btn_manageCategories.UseVisualStyleBackColor = true;
            this.btn_manageCategories.Click += new System.EventHandler(this.btn_manageCategories_Click);
            // 
            // gb_question
            // 
            this.gb_question.Controls.Add(this.btn_categoryManagerHelp);
            this.gb_question.Controls.Add(this.tb_questionID);
            this.gb_question.Controls.Add(this.btn_manageCategories);
            this.gb_question.Controls.Add(this.lbl_questionID);
            this.gb_question.Controls.Add(this.lbl_category);
            this.gb_question.Controls.Add(this.lbl_questionText);
            this.gb_question.Controls.Add(this.tb_questionText);
            this.gb_question.Controls.Add(this.cb_category);
            this.gb_question.Location = new System.Drawing.Point(12, 12);
            this.gb_question.Name = "gb_question";
            this.gb_question.Size = new System.Drawing.Size(685, 222);
            this.gb_question.TabIndex = 28;
            this.gb_question.TabStop = false;
            this.gb_question.Text = "Question Creation";
            // 
            // btn_categoryManagerHelp
            // 
            this.btn_categoryManagerHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categoryManagerHelp.Location = new System.Drawing.Point(602, 19);
            this.btn_categoryManagerHelp.Name = "btn_categoryManagerHelp";
            this.btn_categoryManagerHelp.Size = new System.Drawing.Size(35, 35);
            this.btn_categoryManagerHelp.TabIndex = 29;
            this.btn_categoryManagerHelp.Text = "?";
            this.btn_categoryManagerHelp.UseVisualStyleBackColor = true;
            this.btn_categoryManagerHelp.Click += new System.EventHandler(this.btn_categoryManagerHelp_Click);
            // 
            // p_respFeed
            // 
            this.p_respFeed.Controls.Add(this.gb_feedback);
            this.p_respFeed.Controls.Add(this.gb_responses);
            this.p_respFeed.Controls.Add(this.lbl_rank5);
            this.p_respFeed.Controls.Add(this.lbl_rank4);
            this.p_respFeed.Controls.Add(this.lbl_rank3);
            this.p_respFeed.Controls.Add(this.lbl_rank1);
            this.p_respFeed.Controls.Add(this.lbl_rank2);
            this.p_respFeed.Location = new System.Drawing.Point(12, 240);
            this.p_respFeed.Name = "p_respFeed";
            this.p_respFeed.Size = new System.Drawing.Size(1251, 286);
            this.p_respFeed.TabIndex = 29;
            // 
            // gb_feedback
            // 
            this.gb_feedback.Controls.Add(this.tb_feedback5);
            this.gb_feedback.Controls.Add(this.tb_feedback3);
            this.gb_feedback.Controls.Add(this.tb_feedback1);
            this.gb_feedback.Controls.Add(this.tb_feedback4);
            this.gb_feedback.Controls.Add(this.tb_feedback2);
            this.gb_feedback.Location = new System.Drawing.Point(3, 164);
            this.gb_feedback.Name = "gb_feedback";
            this.gb_feedback.Size = new System.Drawing.Size(1226, 118);
            this.gb_feedback.TabIndex = 31;
            this.gb_feedback.TabStop = false;
            this.gb_feedback.Text = "Feedback (for Emails)";
            // 
            // gb_responses
            // 
            this.gb_responses.Controls.Add(this.tb_response2);
            this.gb_responses.Controls.Add(this.tb_response1);
            this.gb_responses.Controls.Add(this.tb_response4);
            this.gb_responses.Controls.Add(this.tb_response5);
            this.gb_responses.Controls.Add(this.tb_response3);
            this.gb_responses.Location = new System.Drawing.Point(3, 29);
            this.gb_responses.Name = "gb_responses";
            this.gb_responses.Size = new System.Drawing.Size(1226, 129);
            this.gb_responses.TabIndex = 30;
            this.gb_responses.TabStop = false;
            this.gb_responses.Text = "Response Criteria";
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 573);
            this.Controls.Add(this.p_respFeed);
            this.Controls.Add(this.gb_question);
            this.Controls.Add(this.gb_category);
            this.Controls.Add(this.btn_createQuestionHelp);
            this.Controls.Add(this.btn_createQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateQuestion";
            this.Text = "Create a Question";
            this.Load += new System.EventHandler(this.CreateQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionBankBindingSource)).EndInit();
            this.gb_category.ResumeLayout(false);
            this.gb_category.PerformLayout();
            this.gb_question.ResumeLayout(false);
            this.gb_question.PerformLayout();
            this.p_respFeed.ResumeLayout(false);
            this.p_respFeed.PerformLayout();
            this.gb_feedback.ResumeLayout(false);
            this.gb_feedback.PerformLayout();
            this.gb_responses.ResumeLayout(false);
            this.gb_responses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_questionID;
        private System.Windows.Forms.TextBox tb_questionID;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label lbl_questionText;
        private System.Windows.Forms.TextBox tb_questionText;
        private System.Windows.Forms.TextBox tb_response1;
        private System.Windows.Forms.TextBox tb_feedback1;
        private System.Windows.Forms.TextBox tb_feedback2;
        private System.Windows.Forms.TextBox tb_response2;
        private System.Windows.Forms.TextBox tb_feedback3;
        private System.Windows.Forms.TextBox tb_response3;
        private System.Windows.Forms.TextBox tb_feedback4;
        private System.Windows.Forms.TextBox tb_response4;
        private System.Windows.Forms.TextBox tb_feedback5;
        private System.Windows.Forms.TextBox tb_response5;
        private System.Windows.Forms.Label lbl_rank1;
        private System.Windows.Forms.Label lbl_rank2;
        private System.Windows.Forms.Label lbl_rank3;
        private System.Windows.Forms.Label lbl_rank4;
        private System.Windows.Forms.Label lbl_rank5;
        private System.Windows.Forms.Button btn_createQuestion;
        private System.Windows.Forms.Button btn_createQuestionHelp;
        private System.Windows.Forms.GroupBox gb_category;
        private System.Windows.Forms.TextBox tb_addCategory;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Label lbl_addConfimation;
        private System.Windows.Forms.Label lbl_deleteCategory;
        private System.Windows.Forms.Button btn_deleteCategory;
        private System.Windows.Forms.Label lbl_addNewCategory;
        private System.Windows.Forms.ComboBox cb_deleteCategory;
        private System.Windows.Forms.Button btn_manageCategories;
        private System.Windows.Forms.Label lbl_deleteConfirmation;
        private System.Windows.Forms.Button btn_categoryDone;
        private System.Windows.Forms.GroupBox gb_question;
        private System.Windows.Forms.Button btn_categoryManagerHelp;
        private System.Windows.Forms.BindingSource questionBankBindingSource;
        private System.Windows.Forms.Panel p_respFeed;
        private System.Windows.Forms.GroupBox gb_responses;
        private System.Windows.Forms.GroupBox gb_feedback;
    }
}