
namespace RPS___Graphical
{
    partial class RPS
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
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblCompScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(74, 205);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(650, 650);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbComputer
            // 
            this.pbComputer.Location = new System.Drawing.Point(1251, 205);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(650, 650);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputer.TabIndex = 1;
            this.pbComputer.TabStop = false;
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRock.Location = new System.Drawing.Point(436, 1010);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(359, 143);
            this.btnRock.TabIndex = 2;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScissors.Location = new System.Drawing.Point(1220, 1010);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(359, 143);
            this.btnScissors.TabIndex = 3;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaper.Location = new System.Drawing.Point(817, 1010);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(359, 143);
            this.btnPaper.TabIndex = 4;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(436, 1182);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(1143, 89);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer.Location = new System.Drawing.Point(257, 107);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(252, 48);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1463, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.Location = new System.Drawing.Point(257, 178);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(252, 48);
            this.lblPlayerScore.TabIndex = 8;
            this.lblPlayerScore.Text = "Score";
            this.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompScore
            // 
            this.lblCompScore.Location = new System.Drawing.Point(1463, 178);
            this.lblCompScore.Name = "lblCompScore";
            this.lblCompScore.Size = new System.Drawing.Size(252, 48);
            this.lblCompScore.TabIndex = 9;
            this.lblCompScore.Text = "Score";
            this.lblCompScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(978, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "VS";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(430, 890);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1149, 78);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "label3";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComments
            // 
            this.lblComments.Location = new System.Drawing.Point(430, 821);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(1149, 78);
            this.lblComments.TabIndex = 12;
            this.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1960, 1393);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCompScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbComputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock, Paper, Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblCompScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblComments;
    }
}

