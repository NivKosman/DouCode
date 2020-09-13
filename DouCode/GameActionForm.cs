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
          // private Player User;
          // private GameEngine gameEngine;
          private int rightAnswer;
          private string[] answers;
          private Question question;
          private int amountOfRightAnswers;

          public GameActionForm()
          {
               amountOfRightAnswers = 0;
               InitializeComponent();
               this.NamePlayerLabel.Text = "Hello " +GameEngine.Instance().m_Player.Name + " Welcome to our game";
               newQuestion();
          }

         // private void CreatePlayer(string i_Name)
         // {
         //      User = new Player(i_Name);
         // }

          private void BackButton_Click(object sender, EventArgs e)
          {
               this.Hide();

               MainMenu mainMenu = new MainMenu();
               mainMenu.ShowDialog();
               this.Close();
          }

          private void ShowFinalResult()
          {
               this.buttonNewQuestion.Hide();
               this.BackButton.Hide();
               foreach(Control control in this.panelGame.Controls)
               {
                    control.Hide();
               }

               this.labelExplanation.Text = "You got " + amountOfRightAnswers + " right answers\n"
                    + "Thank you for your participation";
               this.labelExplanation.Show();
          }

          private void newQuestion()
          {
               this.labelExplanation.Text = "";
               this.buttonGetExplanation.Enabled = true;
               this.buttonAnswer0.Enabled = true;
               this.buttonAnswer1.Enabled = true;
               this.buttonAnswer2.Enabled = true;
               this.buttonAnswer3.Enabled = true;
               this.labelResult.Hide();

               this.question = GameEngine.Instance().GetQuestion();

               if (this.question == null)
               { 
                    ShowFinalResult();
                    return;
               }
                    
               int j = 0;
               this.rightAnswer = new Random().Next(0, 3);
              
               this.answers = new string[4];

               for(int i=0;i<=3;i++)
               {
                    if(i==rightAnswer)
                    {
                        this.answers[i] = question.RightAnswer;
                    }
                    else
                    {
                         this.answers[i] = question.WrongAnswers[j];
                         j++;
                    }
               }

               this.buttonAnswer0.Text = this.answers[0];
               this.buttonAnswer1.Text = this.answers[1];
               this.buttonAnswer2.Text = this.answers[2];
               this.buttonAnswer3.Text = this.answers[3];
               this.labelQuestion.Text = this.question.QuestionString;
               this.labelTitleQuestion.Text = this.question.Title;
          }

          private void buttonNewQuestion_Click(object sender, EventArgs e)
          {
               newQuestion();
          }

          private void buttonAnswer0_Click(object sender, EventArgs e)
          {
               this.buttonAnswer0.Enabled = false;

               if(rightAnswer==0)
               {
                    amountOfRightAnswers++;
                    this.labelResult.Text = "Right\nAnswer";
                    this.labelResult.ForeColor = Color.Green;
               }
               else
               {
                    this.labelResult.Text = "Wrong\nAnswer";
                    this.labelResult.ForeColor = Color.Red;
               }

               this.labelResult.Show();
          }

          private void buttonAnswer1_Click(object sender, EventArgs e)
          {
               this.buttonAnswer1.Enabled = false;

               if (rightAnswer == 1)
               {
                    amountOfRightAnswers++;
                    this.labelResult.Text = "Right\nAnswer";
                    this.labelResult.ForeColor = Color.Green;
               }
               else
               {
                    this.labelResult.Text = "Wrong\nAnswer";
                    this.labelResult.ForeColor = Color.Red;
               }

               this.labelResult.Show();
          }

          private void buttonAnswer2_Click(object sender, EventArgs e)
          {
               this.buttonAnswer2.Enabled = false;

               if (rightAnswer == 2)
               {
                    amountOfRightAnswers++;
                    this.labelResult.Text = "Right\nAnswer";
                    this.labelResult.ForeColor = Color.Green;
               }
               else
               {
                    this.labelResult.Text = "Wrong\nAnswer";
                    this.labelResult.ForeColor = Color.Red;
               }

               this.labelResult.Show();
          }

          private void buttonAnswer3_Click(object sender, EventArgs e)
          {
               this.buttonAnswer3.Enabled = false;

               if (rightAnswer == 3)
               {
                    amountOfRightAnswers++;
                    this.labelResult.Text = "Right\nAnswer";
                    this.labelResult.ForeColor = Color.Green;
               }
               else
               {
                    this.labelResult.Text = "Wrong\nAnswer";
                    this.labelResult.ForeColor = Color.Red;
               }

               this.labelResult.Show();
          }

          private void buttonGetExplanation_Click(object sender, EventArgs e)
          {
               this.buttonGetExplanation.Enabled = false;
               this.labelExplanation.Text = question.Explanation;
          }
     }
}
