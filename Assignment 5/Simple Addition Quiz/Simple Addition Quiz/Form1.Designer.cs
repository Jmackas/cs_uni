﻿namespace Simple_Addition_Quiz
{
    partial class simpleAdditionQuizForm
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
            this.randomNumOneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomNumOneLabel
            // 
            this.randomNumOneLabel.AutoSize = true;
            this.randomNumOneLabel.Location = new System.Drawing.Point(12, 9);
            this.randomNumOneLabel.Name = "randomNumOneLabel";
            this.randomNumOneLabel.Size = new System.Drawing.Size(35, 13);
            this.randomNumOneLabel.TabIndex = 0;
            this.randomNumOneLabel.Text = "label1";
            // 
            // simpleAdditionQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.randomNumOneLabel);
            this.Name = "simpleAdditionQuizForm";
            this.Text = "Simple Addition Quiz Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomNumOneLabel;
    }
}

