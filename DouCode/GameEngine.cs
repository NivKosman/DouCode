using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


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
           // r_Questions = LoadQuestions();
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

        public static GameEngine Instance()
        {
            if (s_Instance == null)
                throw new UnexpectedGameEngineInitiallizationException();
            else
                return s_Instance;
        }

        public Question GetQuestion()
        {
            //TODO: return random question
            return new Question();

        }

        private HashSet<Question> LoadQuestions()
        {
            String questionString = File.ReadAllText("\\questionDB.json");
            HashSet<Question> questions = JsonSerializer.Deserialize<HashSet<Question>>(questionString);
            return questions; 
        }
    }
}
