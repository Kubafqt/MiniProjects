
namespace Hodiny
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lbDigitalClock = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lbDigitalClock
         // 
         this.lbDigitalClock.AutoSize = true;
         this.lbDigitalClock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.lbDigitalClock.Location = new System.Drawing.Point(684, 22);
         this.lbDigitalClock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
         this.lbDigitalClock.Name = "lbDigitalClock";
         this.lbDigitalClock.Size = new System.Drawing.Size(68, 30);
         this.lbDigitalClock.TabIndex = 0;
         this.lbDigitalClock.Text = "label1";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(830, 563);
         this.Controls.Add(this.lbDigitalClock);
         this.DoubleBuffered = true;
         this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.Text = "Hodiny";
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbDigitalClock;
   }
}

