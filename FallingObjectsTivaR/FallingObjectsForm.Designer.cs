namespace FallingObjectsTivaR
{
    partial class frmFallingObjects
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtNumberBox = new System.Windows.Forms.TextBox();
            this.lblDisplayedAnswer = new System.Windows.Forms.Label();
            this.btnGetNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(61, 31);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // txtNumberBox
            // 
            this.txtNumberBox.Location = new System.Drawing.Point(64, 78);
            this.txtNumberBox.Name = "txtNumberBox";
            this.txtNumberBox.Size = new System.Drawing.Size(100, 20);
            this.txtNumberBox.TabIndex = 1;
            this.txtNumberBox.TextChanged += new System.EventHandler(this.txtNumberBox_TextChanged);
            // 
            // lblDisplayedAnswer
            // 
            this.lblDisplayedAnswer.AutoSize = true;
            this.lblDisplayedAnswer.Location = new System.Drawing.Point(61, 175);
            this.lblDisplayedAnswer.Name = "lblDisplayedAnswer";
            this.lblDisplayedAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblDisplayedAnswer.TabIndex = 2;
            this.lblDisplayedAnswer.Text = "Answer";
            // 
            // btnGetNumber
            // 
            this.btnGetNumber.Location = new System.Drawing.Point(64, 119);
            this.btnGetNumber.Name = "btnGetNumber";
            this.btnGetNumber.Size = new System.Drawing.Size(75, 23);
            this.btnGetNumber.TabIndex = 3;
            this.btnGetNumber.Text = "Get Number";
            this.btnGetNumber.UseVisualStyleBackColor = true;
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGetNumber);
            this.Controls.Add(this.lblDisplayedAnswer);
            this.Controls.Add(this.txtNumberBox);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtNumberBox;
        private System.Windows.Forms.Label lblDisplayedAnswer;
        private System.Windows.Forms.Button btnGetNumber;
    }
}

