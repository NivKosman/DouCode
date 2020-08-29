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
            RightAnswer = questionsStrings[2];
            for (int i = 3; i < questionsStrings.Length - 1; i++)
            {
                wrong.Add(questionsStrings[i]);
            }
            WrongAnswers = wrong.ToArray();
            Explanation = questionsStrings[questionsStrings.Length - 1].Trim();
        }

        public override String ToString()
        {
            return $"Title: {this.Title}\nQuestion: {this.QuestionString}\nRight Answer: {this.RightAnswer}\nWrong Answers: [{this.WrongAnswers[0]}, {this.WrongAnswers[1]}, {this.WrongAnswers[2]}]\nExplanation: {this.Explanation}.";
        }

    }
}
