
namespace Fitness_Tracking_System
{
    partial class Cycling
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
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.txtDIstance = new System.Windows.Forms.TextBox();
            this.txtRevolution = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            this.lblCaloriesBurned = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(254, 84);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(156, 22);
            this.txtGoal.TabIndex = 32;
            // 
            // txtDIstance
            // 
            this.txtDIstance.Location = new System.Drawing.Point(254, 218);
            this.txtDIstance.Name = "txtDIstance";
            this.txtDIstance.Size = new System.Drawing.Size(156, 22);
            this.txtDIstance.TabIndex = 31;
            // 
            // txtRevolution
            // 
            this.txtRevolution.Location = new System.Drawing.Point(254, 143);
            this.txtRevolution.Name = "txtRevolution";
            this.txtRevolution.Size = new System.Drawing.Size(156, 22);
            this.txtRevolution.TabIndex = 30;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(254, 305);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(156, 22);
            this.txtSpeed.TabIndex = 29;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(3, 558);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(56, 17);
            this.lblBack.TabIndex = 28;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "<- Back";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // lblCaloriesBurned
            // 
            this.lblCaloriesBurned.AutoSize = true;
            this.lblCaloriesBurned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesBurned.Location = new System.Drawing.Point(95, 387);
            this.lblCaloriesBurned.Name = "lblCaloriesBurned";
            this.lblCaloriesBurned.Size = new System.Drawing.Size(150, 24);
            this.lblCaloriesBurned.TabIndex = 27;
            this.lblCaloriesBurned.Text = "Calories Burned:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Calculate Calories Buned";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(95, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Set Goal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(95, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Speed(Km/h)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(95, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Distance(Km)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cycling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(95, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Revolution(rpm)";
            // 
            // Cycling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(506, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.txtDIstance);
            this.Controls.Add(this.txtRevolution);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblCaloriesBurned);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Cycling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cycling";
            this.Load += new System.EventHandler(this.Cycling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.TextBox txtDIstance;
        private System.Windows.Forms.TextBox txtRevolution;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.LinkLabel lblBack;
        private System.Windows.Forms.Label lblCaloriesBurned;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}