using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouCode
{
    internal class Player
     {
          public string Name { get; private set; }
          private int Score { get; set; }

          public Player(string i_Name)
          {
               this.Name = i_Name;
               this.Score = 0;
          }
          
          public void RightAnswer() { Score++; }          

          public void BadAnswer()
          {
               if (Score > 0) { Score--; }
          }
     }
}
