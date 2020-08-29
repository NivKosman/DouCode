using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace DouCode
{
    internal class GameEngine
    {
        public Player m_Player;

        private static GameEngine s_Instance = null;
        private static readonly Object sr_Lock = new object();

        private readonly HashSet<Question> r_Questions = new HashSet<Question>();

        private GameEngine(string i_UserName)
        {
            m_Player = new Player(i_UserName);
            r_Questions = LoadQuestions();
        }


        public static GameEngine Instance(string i_UserName)
        {
            if (s_Instance == null)
            {
                lock (sr_Lock)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new GameEngine(i_UserName);
                        return s_Instance;

                    }
                    else
                        throw new UnexpectedGameEngineInitiallizationException();
                }
            }
            else
                throw new UnexpectedGameEngineInitiallizationException();

        }

        public GameEngine Instance()
        {
            if (s_Instance == null)
                throw new UnexpectedGameEngineInitiallizationException();
            else
                return s_Instance;
        }

        public Question GetQuestion()
        {
            Question question = null;
            return question;

        }

        public HashSet<Question> GetAllQuestions()
        {
            return r_Questions;
        }

        private HashSet<Question> LoadQuestions()
        {
            HashSet<Question> questions = new HashSet<Question>();

            String questionsString = File.ReadAllText(@"D:\Studies\Workshop\DouCode\questionDB.db");
            String[] questionDelim = { "\n$$$" };
            String[] allQuestions = questionsString.Split(questionDelim, StringSplitOptions.RemoveEmptyEntries);

            foreach (String str in allQuestions)
            {
                List<String> questionList = new List<string>();
                string[] delims = { "$-$" };
                String[] singleQuestionParts = str.Split(delims, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (String questionPart in singleQuestionParts)
                {
                    questionList.Add(questionPart);
                }
                String[] questionArr = questionList.ToArray();
                questions.Add(new Question(questionArr));
            }
            return questions; 
        }
    }
}
