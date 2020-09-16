namespace DouCode
{
     partial class PyhtonModuleForm
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
               this.labelWelcom = new System.Windows.Forms.Label();
               this.textBoxPythonModule = new System.Windows.Forms.TextBox();
               this.buttonBack = new System.Windows.Forms.Button();
               this.buttonRun = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // labelWelcom
               // 
               this.labelWelcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelWelcom.ForeColor = System.Drawing.SystemColors.HotTrack;
               this.labelWelcom.Location = new System.Drawing.Point(12, 9);
               this.labelWelcom.Name = "labelWelcom";
               this.labelWelcom.Size = new System.Drawing.Size(633, 54);
               this.labelWelcom.TabIndex = 0;
               this.labelWelcom.Text = "Welcome to our Python Module.\r\nYou can try by yourself programming in Python.\r\nWr" +
    "ite your commands and in the end press Run and you will see the output.\r\n\r\n";
               // 
               // textBoxPythonModule
               // 
               this.textBoxPythonModule.Location = new System.Drawing.Point(15, 84);
               this.textBoxPythonModule.Multiline = true;
               this.textBoxPythonModule.Name = "textBoxPythonModule";
               this.textBoxPythonModule.Size = new System.Drawing.Size(613, 288);
               this.textBoxPythonModule.TabIndex = 1;
               // 
               // buttonBack
               // 
               this.buttonBack.ForeColor = System.Drawing.SystemColors.HotTrack;
               this.buttonBack.Location = new System.Drawing.Point(26, 392);
               this.buttonBack.Name = "buttonBack";
               this.buttonBack.Size = new System.Drawing.Size(75, 23);
               this.buttonBack.TabIndex = 2;
               this.buttonBack.Text = "Back";
               this.buttonBack.UseVisualStyleBackColor = true;
               this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
               // 
               // buttonRun
               // 
               this.buttonRun.ForeColor = System.Drawing.SystemColors.HotTrack;
               this.buttonRun.Location = new System.Drawing.Point(553, 392);
               this.buttonRun.Name = "buttonRun";
               this.buttonRun.Size = new System.Drawing.Size(75, 23);
               this.buttonRun.TabIndex = 3;
               this.buttonRun.Text = "Run";
               this.buttonRun.UseVisualStyleBackColor = true;
               this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
               // 
               // PyhtonModuleForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(772, 445);
               this.Controls.Add(this.buttonRun);
               this.Controls.Add(this.buttonBack);
               this.Controls.Add(this.textBoxPythonModule);
               this.Controls.Add(this.labelWelcom);
               this.Name = "PyhtonModuleForm";
               this.Text = "PyhtonModuleForm";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label labelWelcom;
          private System.Windows.Forms.TextBox textBoxPythonModule;
          private System.Windows.Forms.Button buttonBack;
          private System.Windows.Forms.Button buttonRun;
     }
}