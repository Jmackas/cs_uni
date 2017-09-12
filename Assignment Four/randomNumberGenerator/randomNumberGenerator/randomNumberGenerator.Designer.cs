﻿namespace randomNumberGenerator
{
    partial class randomNumberGenerator
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
            this.inputMaximumLabel = new System.Windows.Forms.TextBox();
            this.maximumAmountLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.clearForm = new System.Windows.Forms.Button();
            this.saveFileControl = new System.Windows.Forms.SaveFileDialog();
            this.listboxOutput = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputMaximumLabel
            // 
            this.inputMaximumLabel.Location = new System.Drawing.Point(109, 6);
            this.inputMaximumLabel.Name = "inputMaximumLabel";
            this.inputMaximumLabel.Size = new System.Drawing.Size(100, 20);
            this.inputMaximumLabel.TabIndex = 0;
            // 
            // maximumAmountLabel
            // 
            this.maximumAmountLabel.AutoSize = true;
            this.maximumAmountLabel.Location = new System.Drawing.Point(12, 9);
            this.maximumAmountLabel.Name = "maximumAmountLabel";
            this.maximumAmountLabel.Size = new System.Drawing.Size(91, 13);
            this.maximumAmountLabel.TabIndex = 1;
            this.maximumAmountLabel.Text = "Maximum Number";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(91, 220);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(116, 37);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(213, 220);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(75, 37);
            this.exitProgramButton.TabIndex = 5;
            this.exitProgramButton.Text = "Exit";
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // clearForm
            // 
            this.clearForm.Location = new System.Drawing.Point(215, 4);
            this.clearForm.Name = "clearForm";
            this.clearForm.Size = new System.Drawing.Size(75, 23);
            this.clearForm.TabIndex = 2;
            this.clearForm.Text = "Clear";
            this.clearForm.UseVisualStyleBackColor = true;
            this.clearForm.Click += new System.EventHandler(this.clearForm_Click);
            // 
            // listboxOutput
            // 
            this.listboxOutput.FormattingEnabled = true;
            this.listboxOutput.Location = new System.Drawing.Point(8, 32);
            this.listboxOutput.Name = "listboxOutput";
            this.listboxOutput.Size = new System.Drawing.Size(281, 173);
            this.listboxOutput.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(10, 220);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 37);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // randomNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 262);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listboxOutput);
            this.Controls.Add(this.clearForm);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.maximumAmountLabel);
            this.Controls.Add(this.inputMaximumLabel);
            this.Name = "randomNumberGenerator";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputMaximumLabel;
        private System.Windows.Forms.Label maximumAmountLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitProgramButton;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.SaveFileDialog saveFileControl;
        private System.Windows.Forms.ListBox listboxOutput;
        private System.Windows.Forms.Button saveButton;
    }
}

