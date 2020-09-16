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
     public partial class PyhtonModuleForm : Form
     {
          public PyhtonModuleForm()
          {
               InitializeComponent();
          }

          private void buttonBack_Click(object sender, EventArgs e)
          {
               this.Hide();
               GameActionForm gameForm = new GameActionForm();
               gameForm.ShowDialog();
               this.Close();
          }

          private void buttonRun_Click(object sender, EventArgs e)
          {
               List<string> Commands = new List<string>();
               string[] myArray = textBoxPythonModule.Text.Split(new Char[] { '\n' });

               foreach (string str in myArray)
                    Commands.Add(str);

               textBoxPythonModule.Text = PythonModule.PythonMachine(Commands);
          }
     }
}
