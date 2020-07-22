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
     public partial class GameActionForm : Form
     {
          private Player User;

          public GameActionForm(string i_Name)
          {
               InitializeComponent();
               CreatePlayer(i_Name);
               this.NamePlayerLabel.Text = "Hello " + User.Name + " Welcome to our game";
          }

          private void CreatePlayer(string i_Name)
          {
               User = new Player(i_Name);
          }

          private void BackButton_Click(object sender, EventArgs e)
          {
               this.Hide();
               MainMenu mainMenu = new MainMenu();
               mainMenu.ShowDialog();
               this.Close();
          }
     }
}
