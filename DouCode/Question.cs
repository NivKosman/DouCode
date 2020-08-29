using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouCode
{
    class Question
    {
        public string Title { get; set; }
        public string QuestionString { get; set; }
        public string Explanation { get; set; }
        public string RightAnswer { get; set; }
        public String[] WrongAnswers { get; set; }

        public Question(String[] questionsStrings)
        {
            List<String> wrong = new List<String>();
            Title = questionsStrings[0];
            QuestionString = questionsStrings[1];
            Explanation = questionsStrings[2];
            RightAnswer = questionsStrings[3];
            for (int i = 4; i < questionsStrings.Length; i++)
            {
                wrong.Add(questionsStrings[i]);
                System.Console.WriteLine(wrong.Count);
            }
            WrongAnswers = wrong.ToArray();
        }

        public Question()
        {

        }

    }
}
