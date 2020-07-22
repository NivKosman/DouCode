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
               // GameActionForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(519, 371);
               this.Controls.Add(this.BackButton);
               this.Controls.Add(this.NamePlayerLabel);
               this.Name = "GameActionForm";
               this.Text = "GameActionForm";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Label NamePlayerLabel;
          private System.Windows.Forms.Button BackButton;
     }
}