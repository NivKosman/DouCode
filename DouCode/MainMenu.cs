﻿using System;
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
          public MainMenu()
          {
               InitializeComponent();
          }

          private void StartButton_Click(object sender, EventArgs e)
          {
               InitGameActionForm();
          }

          private void InitGameActionForm()
          {
               this.Hide();
               GameEngine.Instance(this.NametextBox.Text);
               GameActionForm GameForm = new GameActionForm();
               GameForm.ShowDialog();
               this.Close();
          }
     }
}
