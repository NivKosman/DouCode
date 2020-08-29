using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace DouCode
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            List<Question> qList = new List<Question>();
            for (int i = 0; i < 7; i++)
            {
                string[] str = { "a", "b", "c", "d", "e", "f", "g" };
                Question question = new Question(str);
                qList.Add(question);
            }
            string output = JsonConvert.SerializeObject(qList);
            System.Console.WriteLine(output);
            File.WriteAllText(@"c:\try.json", output);

            string input = File.ReadAllText(@"c:\try.json");
            String[] questionsString = (String[]) JsonConvert.DeserializeObject(input);
            */

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"\questionDB.json");
            String questionString = File.ReadAllText(@"D:\Studies\Workshop\DouCode\questionDB.json");
            String[] arrayString = questionString.Split('\n');
            foreach (String str in arrayString)
            {
                System.Console.WriteLine(str);
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu());
        }
    }
}
