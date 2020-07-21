using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DouCode
{
     public partial class MainMenu : Form
     {
          private Player User;
          public MainMenu()
          {
               InitializeComponent();
          }

          private void StartButton_Click(object sender, EventArgs e)
          {
               User = new Player(NametextBox.Text);              
          }

     }
}
