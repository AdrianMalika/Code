
namespace Fitness_Tracking_System
{
    partial class HomePage
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
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSetGoal = new System.Windows.Forms.Button();
            this.cmdHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.LinkColor = System.Drawing.Color.Red;
            this.lblLogOut.Location = new System.Drawing.Point(12, 385);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(55, 17);
            this.lblLogOut.TabIndex = 0;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "LogOut";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fitness Tracker";
            // 
            // cmdSetGoal
            // 
            this.cmdSetGoal.BackColor = System.Drawing.Color.Linen;
            this.cmdSetGoal.Location = new System.Drawing.Point(144, 110);
            this.cmdSetGoal.Name = "cmdSetGoal";
            this.cmdSetGoal.Size = new System.Drawing.Size(229, 64);
            this.cmdSetGoal.TabIndex = 3;
            this.cmdSetGoal.Text = "Set Activity Goal";
            this.cmdSetGoal.UseVisualStyleBackColor = false;
            this.cmdSetGoal.Click += new System.EventHandler(this.cmdSetGoal_Click);
            // 
            // cmdHistory
            // 
            this.cmdHistory.BackColor = System.Drawing.Color.Linen;
            this.cmdHistory.Location = new System.Drawing.Point(144, 242);
            this.cmdHistory.Name = "cmdHistory";
            this.cmdHistory.Size = new System.Drawing.Size(229, 64);
            this.cmdHistory.TabIndex = 5;
            this.cmdHistory.Text = "View Activity History";
            this.cmdHistory.UseVisualStyleBackColor = false;
            this.cmdHistory.Click += new System.EventHandler(this.cmdHistory_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(527, 409);
            this.Controls.Add(this.cmdHistory);
            this.Controls.Add(this.cmdSetGoal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogOut);
            this.KeyPreview = true;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSetGoal;
        private System.Windows.Forms.Button cmdHistory;
    }
}