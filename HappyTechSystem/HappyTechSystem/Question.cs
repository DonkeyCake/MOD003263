﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechSystem
{
    public class Question
    {       
        private int ID;
        private string tag;
        private string text;
        //even numbers will store criteria, and the consecutive odd number stores the feedback for email use.
        private string[] criteriaAndFeedback = new string[10];

        public Question(int m_ID, string m_tag, string m_text, string[] m_textboxes)
        {
            ID = m_ID;
            tag = m_tag;
            text = m_text;
            for (int i = 0; i <= 9; i++)
            {
               criteriaAndFeedback[i] = m_textboxes[i];
            }
        }

        public int getID()
        {
            return ID;
        }
        public string getTag()
        {
            return tag;
        }

        public string getText()
        {
            return text;
        }
         public override string ToString()
        {
            return ID.ToString() + "                                           " + tag;
        }
        public string GetCriteriaAndFeedback(int index)
        {
            return criteriaAndFeedback[index];
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem
{
    public class Question
    {
        private string Text;
        private int ID;
        private string Tag;

        public String GetText {  get { return Text; } set { Text = value; }  }

        public String GetTag { get { return Tag; } set { Tag = value; } }
        public int GetID { get { return ID; } set { ID = value; } }

        public override string ToString()
        {
            return Text;
        }
    }
}
