
namespace Fitness_Tracking_System
{
    partial class Yoga
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
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblCaloriesBurned = new System.Windows.Forms.Label();
            this.txtPose = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIntensityLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(4, 556);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(56, 17);
            this.lblBack.TabIndex = 25;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "<- Back";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(204, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Yoga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Set Goal";
            // 
            // txtGoal
            // 
            this.txtGoal.BackColor = System.Drawing.Color.Linen;
            this.txtGoal.Location = new System.Drawing.Point(266, 92);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(156, 22);
            this.txtGoal.TabIndex = 22;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Linen;
            this.txtTime.Location = new System.Drawing.Point(266, 304);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(156, 22);
            this.txtTime.TabIndex = 21;
            // 
            // lblCaloriesBurned
            // 
            this.lblCaloriesBurned.AutoSize = true;
            this.lblCaloriesBurned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesBurned.Location = new System.Drawing.Point(89, 401);
            this.lblCaloriesBurned.Name = "lblCaloriesBurned";
            this.lblCaloriesBurned.Size = new System.Drawing.Size(150, 24);
            this.lblCaloriesBurned.TabIndex = 19;
            this.lblCaloriesBurned.Text = "Calories Burned:";
            this.lblCaloriesBurned.Click += new System.EventHandler(this.lblCaloriesBurned_Click);
            // 
            // txtPose
            // 
            this.txtPose.BackColor = System.Drawing.Color.Linen;
            this.txtPose.Location = new System.Drawing.Point(266, 151);
            this.txtPose.Name = "txtPose";
            this.txtPose.Size = new System.Drawing.Size(156, 22);
            this.txtPose.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(111, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calculate Calories Buned";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "IntensityLevel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "TIme(min)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Poses";
            // 
            // cmbIntensityLevel
            // 
            this.cmbIntensityLevel.BackColor = System.Drawing.Color.Linen;
            this.cmbIntensityLevel.FormattingEnabled = true;
            this.cmbIntensityLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbIntensityLevel.Location = new System.Drawing.Point(266, 224);
            this.cmbIntensityLevel.Name = "cmbIntensityLevel";
            this.cmbIntensityLevel.Size = new System.Drawing.Size(156, 24);
            this.cmbIntensityLevel.TabIndex = 26;
            // 
            // Yoga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(506, 578);
            this.Controls.Add(this.cmbIntensityLevel);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblCaloriesBurned);
            this.Controls.Add(this.txtPose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Yoga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yoga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblCaloriesBurned;
        private System.Windows.Forms.TextBox txtPose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIntensityLevel;
    }
}