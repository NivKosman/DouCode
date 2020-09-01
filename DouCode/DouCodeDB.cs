using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouCode
{
    class DouCodeDB
    {
        private List<Question> m_QuestionsDB = new List<Question>();

        public void AddQuestion(Question question)
        {
            try
            {
                m_QuestionsDB.Add(question);
            }
            catch (Exception e)
            {
                throw new CannotAddQuestionToDBException();
            }
        }

        public Question GetQuestion()
        {
            Random rand = new Random();
            int questionIndex = rand.Next(m_QuestionsDB.Count - 1);
            Question question = m_QuestionsDB[questionIndex];
            m_QuestionsDB[questionIndex] = m_QuestionsDB[m_QuestionsDB.Count - 1];
            m_QuestionsDB.RemoveAt(m_QuestionsDB.Count - 1);
            return question;
        }
    }
}
