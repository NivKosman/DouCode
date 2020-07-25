using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public GameEngine Instance(string i_UserName)
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

        private HashSet<Question> LoadQuestions()
        {
            HashSet<Question> questions = new HashSet<Question>();
            
            using (File.Open("\\questionDB.json",FileMode.Open))
            {
                //TODO: Implement desiriallization of json from file into HashSet.
            }
            return questions; 
        }
    }
}
