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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.grbCliffHeight = new System.Windows.Forms.GroupBox();
            this.lblCliffQuestion = new System.Windows.Forms.Label();
            this.txtCliffBox = new System.Windows.Forms.TextBox();
            this.grbGravity = new System.Windows.Forms.GroupBox();
            this.picPlanet = new System.Windows.Forms.PictureBox();
            this.radMars = new System.Windows.Forms.RadioButton();
            this.radEarth = new System.Windows.Forms.RadioButton();
            this.lblGravityQuestion = new System.Windows.Forms.Label();
            this.lblGravity = new System.Windows.Forms.Label();
            this.lblGravityIs = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.grbTime.SuspendLayout();
            this.grbCliffHeight.SuspendLayout();
            this.grbGravity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(6, 24);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(272, 15);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "How long has it been since you have dropped it?";
            // 
            // txtNumberBox
            // 
            this.txtNumberBox.Location = new System.Drawing.Point(62, 74);
            this.txtNumberBox.Name = "txtNumberBox";
            this.txtNumberBox.Size = new System.Drawing.Size(100, 20);
            this.txtNumberBox.TabIndex = 1;
            this.txtNumberBox.Text = "1";
            // 
            // lblDisplayedAnswer
            // 
            this.lblDisplayedAnswer.AutoSize = true;
            this.lblDisplayedAnswer.Font = new System.Drawing.Font("Charlemagne Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayedAnswer.Location = new System.Drawing.Point(281, 378);
            this.lblDisplayedAnswer.Name = "lblDisplayedAnswer";
            this.lblDisplayedAnswer.Size = new System.Drawing.Size(58, 13);
            this.lblDisplayedAnswer.TabIndex = 2;
            this.lblDisplayedAnswer.Text = "Answer";
            // 
            // btnGetNumber
            // 
            this.btnGetNumber.Font = new System.Drawing.Font("EuroRoman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnGetNumber.Location = new System.Drawing.Point(284, 327);
            this.btnGetNumber.Name = "btnGetNumber";
            this.btnGetNumber.Size = new System.Drawing.Size(266, 35);
            this.btnGetNumber.TabIndex = 3;
            this.btnGetNumber.Text = "Get Number";
            this.btnGetNumber.UseVisualStyleBackColor = true;
            this.btnGetNumber.Click += new System.EventHandler(this.btnGetNumber_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(946, 24);
            this.mnuMainMenu.TabIndex = 4;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.lblQuestion);
            this.grbTime.Controls.Add(this.txtNumberBox);
            this.grbTime.Location = new System.Drawing.Point(12, 98);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(293, 195);
            this.grbTime.TabIndex = 6;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Change Time";
            // 
            // grbCliffHeight
            // 
            this.grbCliffHeight.Controls.Add(this.lblCliffQuestion);
            this.grbCliffHeight.Controls.Add(this.txtCliffBox);
            this.grbCliffHeight.Location = new System.Drawing.Point(314, 98);
            this.grbCliffHeight.Name = "grbCliffHeight";
            this.grbCliffHeight.Size = new System.Drawing.Size(293, 195);
            this.grbCliffHeight.TabIndex = 7;
            this.grbCliffHeight.TabStop = false;
            this.grbCliffHeight.Text = "Change Cliff Height";
            // 
            // lblCliffQuestion
            // 
            this.lblCliffQuestion.AutoSize = true;
            this.lblCliffQuestion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliffQuestion.Location = new System.Drawing.Point(6, 23);
            this.lblCliffQuestion.Name = "lblCliffQuestion";
            this.lblCliffQuestion.Size = new System.Drawing.Size(242, 16);
            this.lblCliffQuestion.TabIndex = 0;
            this.lblCliffQuestion.Text = "How high is the cliff you dropped it from?";
            // 
            // txtCliffBox
            // 
            this.txtCliffBox.Location = new System.Drawing.Point(62, 74);
            this.txtCliffBox.Name = "txtCliffBox";
            this.txtCliffBox.Size = new System.Drawing.Size(100, 20);
            this.txtCliffBox.TabIndex = 1;
            this.txtCliffBox.Text = "100";
            // 
            // grbGravity
            // 
            this.grbGravity.Controls.Add(this.picPlanet);
            this.grbGravity.Controls.Add(this.radMars);
            this.grbGravity.Controls.Add(this.radEarth);
            this.grbGravity.Controls.Add(this.lblGravityQuestion);
            this.grbGravity.Location = new System.Drawing.Point(613, 98);
            this.grbGravity.Name = "grbGravity";
            this.grbGravity.Size = new System.Drawing.Size(307, 195);
            this.grbGravity.TabIndex = 8;
            this.grbGravity.TabStop = false;
            this.grbGravity.Text = "Change the Gravity";
            // 
            // picPlanet
            // 
            this.picPlanet.Image = global::FallingObjectsTivaR.Properties.Resources.Earth2;
            this.picPlanet.Location = new System.Drawing.Point(97, 57);
            this.picPlanet.Name = "picPlanet";
            this.picPlanet.Size = new System.Drawing.Size(144, 132);
            this.picPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet.TabIndex = 3;
            this.picPlanet.TabStop = false;
            // 
            // radMars
            // 
            this.radMars.AutoSize = true;
            this.radMars.Location = new System.Drawing.Point(30, 115);
            this.radMars.Name = "radMars";
            this.radMars.Size = new System.Drawing.Size(48, 17);
            this.radMars.TabIndex = 2;
            this.radMars.Text = "Mars";
            this.radMars.UseVisualStyleBackColor = true;
            this.radMars.CheckedChanged += new System.EventHandler(this.radMars_CheckedChanged);
            // 
            // radEarth
            // 
            this.radEarth.AutoSize = true;
            this.radEarth.Checked = true;
            this.radEarth.Location = new System.Drawing.Point(30, 74);
            this.radEarth.Name = "radEarth";
            this.radEarth.Size = new System.Drawing.Size(50, 17);
            this.radEarth.TabIndex = 1;
            this.radEarth.TabStop = true;
            this.radEarth.Text = "Earth";
            this.radEarth.UseVisualStyleBackColor = true;
            this.radEarth.CheckedChanged += new System.EventHandler(this.radEarth_CheckedChanged);
            // 
            // lblGravityQuestion
            // 
            this.lblGravityQuestion.AutoSize = true;
            this.lblGravityQuestion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravityQuestion.Location = new System.Drawing.Point(6, 23);
            this.lblGravityQuestion.Name = "lblGravityQuestion";
            this.lblGravityQuestion.Size = new System.Drawing.Size(152, 16);
            this.lblGravityQuestion.TabIndex = 0;
            this.lblGravityQuestion.Text = "What Planet are you on?";
            // 
            // lblGravity
            // 
            this.lblGravity.AutoSize = true;
            this.lblGravity.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGravity.Location = new System.Drawing.Point(680, 327);
            this.lblGravity.Name = "lblGravity";
            this.lblGravity.Size = new System.Drawing.Size(40, 25);
            this.lblGravity.TabIndex = 9;
            this.lblGravity.Text = "9.81";
            // 
            // lblGravityIs
            // 
            this.lblGravityIs.AutoSize = true;
            this.lblGravityIs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravityIs.ForeColor = System.Drawing.Color.Red;
            this.lblGravityIs.Location = new System.Drawing.Point(632, 294);
            this.lblGravityIs.Name = "lblGravityIs";
            this.lblGravityIs.Size = new System.Drawing.Size(139, 16);
            this.lblGravityIs.TabIndex = 10;
            this.lblGravityIs.Text = "The gravity on earth is:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(172, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(568, 41);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Calculating The Height of an Object";
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(946, 469);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblGravityIs);
            this.Controls.Add(this.lblGravity);
            this.Controls.Add(this.grbGravity);
            this.Controls.Add(this.grbCliffHeight);
            this.Controls.Add(this.btnGetNumber);
            this.Controls.Add(this.lblDisplayedAnswer);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects By Tiva Rait";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.grbCliffHeight.ResumeLayout(false);
            this.grbCliffHeight.PerformLayout();
            this.grbGravity.ResumeLayout(false);
            this.grbGravity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtNumberBox;
        private System.Windows.Forms.Label lblDisplayedAnswer;
        private System.Windows.Forms.Button btnGetNumber;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.GroupBox grbCliffHeight;
        private System.Windows.Forms.Label lblCliffQuestion;
        private System.Windows.Forms.TextBox txtCliffBox;
        private System.Windows.Forms.GroupBox grbGravity;
        private System.Windows.Forms.RadioButton radMars;
        private System.Windows.Forms.RadioButton radEarth;
        private System.Windows.Forms.Label lblGravityQuestion;
        private System.Windows.Forms.PictureBox picPlanet;
        private System.Windows.Forms.Label lblGravity;
        private System.Windows.Forms.Label lblGravityIs;
        private System.Windows.Forms.Label lblTitle;
    }
}

