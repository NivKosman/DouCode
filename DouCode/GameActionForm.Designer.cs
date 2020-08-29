namespace DouCode
{
     partial class GameActionForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.NamePlayerLabel = new System.Windows.Forms.Label();
               this.BackButton = new System.Windows.Forms.Button();
               this.panelGame = new System.Windows.Forms.Panel();
               this.textBoxTitle = new System.Windows.Forms.TextBox();
               this.textBoxExplanation = new System.Windows.Forms.TextBox();
               this.buttonAnswer3 = new System.Windows.Forms.Button();
               this.buttonAnswer2 = new System.Windows.Forms.Button();
               this.buttonAnswer1 = new System.Windows.Forms.Button();
               this.buttonAnswer0 = new System.Windows.Forms.Button();
               this.textBoxQuestion = new System.Windows.Forms.TextBox();
               this.buttonNewQuestion = new System.Windows.Forms.Button();
               this.textBoxResult = new System.Windows.Forms.TextBox();
               this.buttonGetExplanation = new System.Windows.Forms.Button();
               this.panelGame.SuspendLayout();
               this.SuspendLayout();
               // 
               // NamePlayerLabel
               // 
               this.NamePlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.NamePlayerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
               this.NamePlayerLabel.Location = new System.Drawing.Point(18, 10);
               this.NamePlayerLabel.Name = "NamePlayerLabel";
               this.NamePlayerLabel.Size = new System.Drawing.Size(458, 35);
               this.NamePlayerLabel.TabIndex = 0;
               this.NamePlayerLabel.Text = "label1";
               // 
               // BackButton
               // 
               this.BackButton.ForeColor = System.Drawing.SystemColors.HotTrack;
               this.BackButton.Location = new System.Drawing.Point(21, 315);
               this.BackButton.Name = "BackButton";
               this.BackButton.Size = new System.Drawing.Size(75, 26);
               this.BackButton.TabIndex = 1;
               this.BackButton.Text = "Back";
               this.BackButton.UseVisualStyleBackColor = true;
               this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
               // 
               // panelGame
               // 
               this.panelGame.Controls.Add(this.textBoxTitle);
               this.panelGame.Controls.Add(this.textBoxExplanation);
               this.panelGame.Controls.Add(this.buttonAnswer3);
               this.panelGame.Controls.Add(this.buttonAnswer2);
               this.panelGame.Controls.Add(this.buttonAnswer1);
               this.panelGame.Controls.Add(this.buttonAnswer0);
               this.panelGame.Controls.Add(this.textBoxQuestion);
               this.panelGame.Location = new System.Drawing.Point(24, 58);
               this.panelGame.Name = "panelGame";
               this.panelGame.Size = new System.Drawing.Size(490, 251);
               this.panelGame.TabIndex = 2;
               // 
               // textBoxTitle
               // 
               this.textBoxTitle.Location = new System.Drawing.Point(3, 4);
               this.textBoxTitle.Name = "textBoxTitle";
               this.textBoxTitle.Size = new System.Drawing.Size(477, 20);
               this.textBoxTitle.TabIndex = 6;
               // 
               // textBoxExplanation
               // 
               this.textBoxExplanation.Location = new System.Drawing.Point(3, 190);
               this.textBoxExplanation.Multiline = true;
               this.textBoxExplanation.Name = "textBoxExplanation";
               this.textBoxExplanation.Size = new System.Drawing.Size(480, 48);
               this.textBoxExplanation.TabIndex = 5;
               // 
               // buttonAnswer3
               // 
               this.buttonAnswer3.Location = new System.Drawing.Point(3, 151);
               this.buttonAnswer3.Name = "buttonAnswer3";
               this.buttonAnswer3.Size = new System.Drawing.Size(480, 23);
               this.buttonAnswer3.TabIndex = 4;
               this.buttonAnswer3.Text = "button4";
               this.buttonAnswer3.UseVisualStyleBackColor = true;
               this.buttonAnswer3.Click += new System.EventHandler(this.buttonAnswer3_Click);
               // 
               // buttonAnswer2
               // 
               this.buttonAnswer2.Location = new System.Drawing.Point(3, 122);
               this.buttonAnswer2.Name = "buttonAnswer2";
               this.buttonAnswer2.Size = new System.Drawing.Size(480, 23);
               this.buttonAnswer2.TabIndex = 3;
               this.buttonAnswer2.Text = "button3";
               this.buttonAnswer2.UseVisualStyleBackColor = true;
               this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer2_Click);
               // 
               // buttonAnswer1
               // 
               this.buttonAnswer1.Location = new System.Drawing.Point(3, 93);
               this.buttonAnswer1.Name = "buttonAnswer1";
               this.buttonAnswer1.Size = new System.Drawing.Size(480, 23);
               this.buttonAnswer1.TabIndex = 2;
               this.buttonAnswer1.Text = "button2";
               this.buttonAnswer1.UseVisualStyleBackColor = true;
               this.buttonAnswer1.Click += new System.EventHandler(this.buttonAnswer1_Click);
               // 
               // buttonAnswer0
               // 
               this.buttonAnswer0.Location = new System.Drawing.Point(3, 64);
               this.buttonAnswer0.Name = "buttonAnswer0";
               this.buttonAnswer0.Size = new System.Drawing.Size(480, 23);
               this.buttonAnswer0.TabIndex = 1;
               this.buttonAnswer0.Text = "button1";
               this.buttonAnswer0.UseVisualStyleBackColor = true;
               this.buttonAnswer0.Click += new System.EventHandler(this.buttonAnswer0_Click);
               // 
               // textBoxQuestion
               // 
               this.textBoxQuestion.Location = new System.Drawing.Point(3, 38);
               this.textBoxQuestion.Name = "textBoxQuestion";
               this.textBoxQuestion.Size = new System.Drawing.Size(480, 20);
               this.textBoxQuestion.TabIndex = 0;
               // 
               // buttonNewQuestion
               // 
               this.buttonNewQuestion.ForeColor = System.Drawing.SystemColors.HotTrack;
               this.buttonNewQuestion.Location = new System.Drawing.Point(367, 315);
               this.buttonNewQuestion.Name = "buttonNewQuestion";
               this.buttonNewQuestion.Size = new System.Drawing.Size(119, 26);
               this.buttonNewQuestion.TabIndex = 3;
               this.buttonNewQuestion.Text = "New question";
               this.buttonNewQuestion.UseVisualStyleBackColor = true;
               this.buttonNewQuestion.Click += new System.EventHandler(this.buttonNewQuestion_Click);
               // 
               // textBoxResult
               // 
               this.textBoxResult.Location = new System.Drawing.Point(529, 122);
               this.textBoxResult.Multiline = true;
               this.textBoxResult.Name = "textBoxResult";
               this.textBoxResult.Size = new System.Drawing.Size(119, 84);
               this.textBoxResult.TabIndex = 4;
               // 
               // buttonGetExplanation
               // 
               this.buttonGetExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonGetExplanation.ForeColor = System.Drawing.SystemColors.HotTrack;
               this.buttonGetExplanation.Location = new System.Drawing.Point(539, 248);
               this.buttonGetExplanation.Name = "buttonGetExplanation";
               this.buttonGetExplanation.Size = new System.Drawing.Size(89, 50);
               this.buttonGetExplanation.TabIndex = 5;
               this.buttonGetExplanation.Text = "get explanation";
               this.buttonGetExplanation.UseVisualStyleBackColor = true;
               this.buttonGetExplanation.Click += new System.EventHandler(this.buttonGetExplanation_Click);
               // 
               // GameActionForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(675, 371);
               this.Controls.Add(this.buttonGetExplanation);
               this.Controls.Add(this.textBoxResult);
               this.Controls.Add(this.buttonNewQuestion);
               this.Controls.Add(this.panelGame);
               this.Controls.Add(this.BackButton);
               this.Controls.Add(this.NamePlayerLabel);
               this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Name = "GameActionForm";
               this.Text = "GameActionForm";
               this.panelGame.ResumeLayout(false);
               this.panelGame.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label NamePlayerLabel;
          private System.Windows.Forms.Button BackButton;
          private System.Windows.Forms.Panel panelGame;
          private System.Windows.Forms.TextBox textBoxQuestion;
          private System.Windows.Forms.Button buttonNewQuestion;
          private System.Windows.Forms.TextBox textBoxExplanation;
          private System.Windows.Forms.Button buttonAnswer3;
          private System.Windows.Forms.Button buttonAnswer2;
          private System.Windows.Forms.Button buttonAnswer1;
          private System.Windows.Forms.Button buttonAnswer0;
          private System.Windows.Forms.TextBox textBoxTitle;
          private System.Windows.Forms.TextBox textBoxResult;
          private System.Windows.Forms.Button buttonGetExplanation;
     }
}