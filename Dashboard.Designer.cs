namespace WindowsFormsApplication1
{
    partial class Dashboard
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
            this.btnManageProject = new System.Windows.Forms.Button();
            this.btnManageAdvisor = new System.Windows.Forms.Button();
            this.btnManageEvaluation = new System.Windows.Forms.Button();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageProject
            // 
            this.btnManageProject.Location = new System.Drawing.Point(26, 41);
            this.btnManageProject.Name = "btnManageProject";
            this.btnManageProject.Size = new System.Drawing.Size(111, 23);
            this.btnManageProject.TabIndex = 0;
            this.btnManageProject.Text = "Manage Project";
            this.btnManageProject.UseVisualStyleBackColor = true;
            this.btnManageProject.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManageAdvisor
            // 
            this.btnManageAdvisor.Location = new System.Drawing.Point(182, 40);
            this.btnManageAdvisor.Name = "btnManageAdvisor";
            this.btnManageAdvisor.Size = new System.Drawing.Size(128, 23);
            this.btnManageAdvisor.TabIndex = 1;
            this.btnManageAdvisor.Text = "Manage Advisor";
            this.btnManageAdvisor.UseVisualStyleBackColor = true;
            this.btnManageAdvisor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManageEvaluation
            // 
            this.btnManageEvaluation.Location = new System.Drawing.Point(26, 104);
            this.btnManageEvaluation.Name = "btnManageEvaluation";
            this.btnManageEvaluation.Size = new System.Drawing.Size(111, 23);
            this.btnManageEvaluation.TabIndex = 2;
            this.btnManageEvaluation.Text = "Manage Evaluation";
            this.btnManageEvaluation.UseVisualStyleBackColor = true;
            this.btnManageEvaluation.Click += new System.EventHandler(this.btnManageEvaluation_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.Location = new System.Drawing.Point(182, 104);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(128, 23);
            this.btnManageStudent.TabIndex = 3;
            this.btnManageStudent.Text = "Manage Student";
            this.btnManageStudent.UseVisualStyleBackColor = true;
            this.btnManageStudent.Click += new System.EventHandler(this.button4_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.btnManageStudent);
            this.Controls.Add(this.btnManageEvaluation);
            this.Controls.Add(this.btnManageAdvisor);
            this.Controls.Add(this.btnManageProject);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageProject;
        private System.Windows.Forms.Button btnManageAdvisor;
        private System.Windows.Forms.Button btnManageEvaluation;
        private System.Windows.Forms.Button btnManageStudent;
    }
}