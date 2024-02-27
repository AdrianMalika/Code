
namespace Fitness_Tracking_System
{
    partial class Swimming
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtHeartRate = new System.Windows.Forms.TextBox();
            this.txtLaps = new System.Windows.Forms.TextBox();
            this.lblCaloriesBurned = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SWIMMING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(80, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Laps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(80, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distance (m)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(80, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heart Rate";
            // 
            // txtGoal
            // 
            this.txtGoal.BackColor = System.Drawing.Color.Linen;
            this.txtGoal.Location = new System.Drawing.Point(257, 79);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(156, 22);
            this.txtGoal.TabIndex = 13;
            // 
            // txtDistance
            // 
            this.txtDistance.BackColor = System.Drawing.Color.Linen;
            this.txtDistance.Location = new System.Drawing.Point(257, 213);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(156, 22);
            this.txtDistance.TabIndex = 14;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.BackColor = System.Drawing.Color.Linen;
            this.txtHeartRate.Location = new System.Drawing.Point(257, 291);
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(156, 22);
            this.txtHeartRate.TabIndex = 15;
            // 
            // txtLaps
            // 
            this.txtLaps.BackColor = System.Drawing.Color.Linen;
            this.txtLaps.Location = new System.Drawing.Point(257, 140);
            this.txtLaps.Name = "txtLaps";
            this.txtLaps.Size = new System.Drawing.Size(156, 22);
            this.txtLaps.TabIndex = 16;
            // 
            // lblCaloriesBurned
            // 
            this.lblCaloriesBurned.AutoSize = true;
            this.lblCaloriesBurned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCaloriesBurned.Location = new System.Drawing.Point(80, 378);
            this.lblCaloriesBurned.Name = "lblCaloriesBurned";
            this.lblCaloriesBurned.Size = new System.Drawing.Size(150, 24);
            this.lblCaloriesBurned.TabIndex = 17;
            this.lblCaloriesBurned.Text = "Calories Burned:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(97, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate Calories Buned";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(12, 552);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(56, 17);
            this.lblBack.TabIndex = 19;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "<- Back";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(80, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Set Goal";
            // 
            // Swimming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(506, 578);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCaloriesBurned);
            this.Controls.Add(this.txtLaps);
            this.Controls.Add(this.txtHeartRate);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Swimming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming";
            this.Load += new System.EventHandler(this.Swimming_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtLaps;
        private System.Windows.Forms.Label lblCaloriesBurned;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.Label label3;
    }
}