namespace DouCode
{
     partial class MainMenu
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
               this.NametextBox = new System.Windows.Forms.TextBox();
               this.Namelabel = new System.Windows.Forms.Label();
               this.TitleLabel = new System.Windows.Forms.Label();
               this.StartButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // NametextBox
               // 
               this.NametextBox.Location = new System.Drawing.Point(53, 75);
               this.NametextBox.Name = "NametextBox";
               this.NametextBox.Size = new System.Drawing.Size(113, 20);
               this.NametextBox.TabIndex = 0;              
               // 
               // Namelabel
               // 
               this.Namelabel.AutoSize = true;
               this.Namelabel.Location = new System.Drawing.Point(12, 78);
               this.Namelabel.Name = "Namelabel";
               this.Namelabel.Size = new System.Drawing.Size(35, 13);
               this.Namelabel.TabIndex = 1;
               this.Namelabel.Text = "Name";
               // 
               // TitleLabel
               // 
               this.TitleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.TitleLabel.ForeColor = System.Drawing.SystemColors.InfoText;
               this.TitleLabel.Location = new System.Drawing.Point(54, 24);
               this.TitleLabel.Name = "TitleLabel";
               this.TitleLabel.Size = new System.Drawing.Size(125, 35);
               this.TitleLabel.TabIndex = 2;
               this.TitleLabel.Text = "DouCode";
               this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // StartButton
               // 
               this.StartButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.StartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
               this.StartButton.Location = new System.Drawing.Point(104, 156);
               this.StartButton.Name = "StartButton";
               this.StartButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
               this.StartButton.Size = new System.Drawing.Size(75, 29);
               this.StartButton.TabIndex = 3;
               this.StartButton.Text = "Start";
               this.StartButton.UseVisualStyleBackColor = false;
               this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
               // 
               // MainMenu
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(284, 261);
               this.Controls.Add(this.StartButton);
               this.Controls.Add(this.TitleLabel);
               this.Controls.Add(this.Namelabel);
               this.Controls.Add(this.NametextBox);
               this.Name = "MainMenu";
               this.Text = "DouCode";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox NametextBox;
          private System.Windows.Forms.Label Namelabel;
          private System.Windows.Forms.Label TitleLabel;
          private System.Windows.Forms.Button StartButton;
     }
}

