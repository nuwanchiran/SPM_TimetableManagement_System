namespace Timetable_Management_System
{
    partial class ManageStatisticsDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStatisticsDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LecturersStatistics = new System.Windows.Forms.TabPage();
            this.lblLecturerStatistics = new System.Windows.Forms.Label();
            this.StudentsStatistics = new System.Windows.Forms.TabPage();
            this.lblStudentStatistics = new System.Windows.Forms.Label();
            this.SubjectsStatistics = new System.Windows.Forms.TabPage();
            this.lblSubjectStatistics = new System.Windows.Forms.Label();
            this.imgLoggedUser = new System.Windows.Forms.PictureBox();
            this.imgGenerateReport = new System.Windows.Forms.PictureBox();
            this.imgStatistics = new System.Windows.Forms.PictureBox();
            this.imgManageTags = new System.Windows.Forms.PictureBox();
            this.imgLocations = new System.Windows.Forms.PictureBox();
            this.imgManageSubjects = new System.Windows.Forms.PictureBox();
            this.ImgManageLecturers = new System.Windows.Forms.PictureBox();
            this.imgManageStudent = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgTime = new System.Windows.Forms.PictureBox();
            this.chart_LecturerCountByProfessionalLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_lecturersByFaculty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.LecturersStatistics.SuspendLayout();
            this.StudentsStatistics.SuspendLayout();
            this.SubjectsStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoggedUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGenerateReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgManageTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgManageSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgManageLecturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgManageStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_LecturerCountByProfessionalLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lecturersByFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.LecturersStatistics);
            this.tabControl1.Controls.Add(this.StudentsStatistics);
            this.tabControl1.Controls.Add(this.SubjectsStatistics);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(26, 220);
            this.tabControl1.Location = new System.Drawing.Point(6, 136);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1915, 534);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // LecturersStatistics
            // 
            this.LecturersStatistics.Controls.Add(this.label1);
            this.LecturersStatistics.Controls.Add(this.chart_lecturersByFaculty);
            this.LecturersStatistics.Controls.Add(this.chart_LecturerCountByProfessionalLevel);
            this.LecturersStatistics.Controls.Add(this.lblLecturerStatistics);
            this.LecturersStatistics.Location = new System.Drawing.Point(224, 4);
            this.LecturersStatistics.Name = "LecturersStatistics";
            this.LecturersStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.LecturersStatistics.Size = new System.Drawing.Size(1687, 526);
            this.LecturersStatistics.TabIndex = 0;
            this.LecturersStatistics.Text = "Lecturers";
            this.LecturersStatistics.UseVisualStyleBackColor = true;
            this.LecturersStatistics.Click += new System.EventHandler(this.LecturersStatistics_Click);
            // 
            // lblLecturerStatistics
            // 
            this.lblLecturerStatistics.AutoSize = true;
            this.lblLecturerStatistics.Location = new System.Drawing.Point(6, 3);
            this.lblLecturerStatistics.Name = "lblLecturerStatistics";
            this.lblLecturerStatistics.Size = new System.Drawing.Size(124, 20);
            this.lblLecturerStatistics.TabIndex = 0;
            this.lblLecturerStatistics.Text = "Lecturer Statistics";
            // 
            // StudentsStatistics
            // 
            this.StudentsStatistics.Controls.Add(this.lblStudentStatistics);
            this.StudentsStatistics.Location = new System.Drawing.Point(224, 4);
            this.StudentsStatistics.Name = "StudentsStatistics";
            this.StudentsStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsStatistics.Size = new System.Drawing.Size(1687, 526);
            this.StudentsStatistics.TabIndex = 1;
            this.StudentsStatistics.Text = "Students";
            this.StudentsStatistics.UseVisualStyleBackColor = true;
            // 
            // lblStudentStatistics
            // 
            this.lblStudentStatistics.AutoSize = true;
            this.lblStudentStatistics.Location = new System.Drawing.Point(347, 72);
            this.lblStudentStatistics.Name = "lblStudentStatistics";
            this.lblStudentStatistics.Size = new System.Drawing.Size(122, 20);
            this.lblStudentStatistics.TabIndex = 0;
            this.lblStudentStatistics.Text = "Student Statistics";
            // 
            // SubjectsStatistics
            // 
            this.SubjectsStatistics.Controls.Add(this.lblSubjectStatistics);
            this.SubjectsStatistics.Location = new System.Drawing.Point(224, 4);
            this.SubjectsStatistics.Name = "SubjectsStatistics";
            this.SubjectsStatistics.Size = new System.Drawing.Size(1687, 526);
            this.SubjectsStatistics.TabIndex = 2;
            this.SubjectsStatistics.Text = "Subjects";
            this.SubjectsStatistics.UseVisualStyleBackColor = true;
            // 
            // lblSubjectStatistics
            // 
            this.lblSubjectStatistics.AutoSize = true;
            this.lblSubjectStatistics.Location = new System.Drawing.Point(263, 58);
            this.lblSubjectStatistics.Name = "lblSubjectStatistics";
            this.lblSubjectStatistics.Size = new System.Drawing.Size(120, 20);
            this.lblSubjectStatistics.TabIndex = 0;
            this.lblSubjectStatistics.Text = "Subject Statistics";
            // 
            // imgLoggedUser
            // 
            this.imgLoggedUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLoggedUser.BackgroundImage")));
            this.imgLoggedUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLoggedUser.Location = new System.Drawing.Point(1791, 0);
            this.imgLoggedUser.Name = "imgLoggedUser";
            this.imgLoggedUser.Size = new System.Drawing.Size(121, 134);
            this.imgLoggedUser.TabIndex = 53;
            this.imgLoggedUser.TabStop = false;
            // 
            // imgGenerateReport
            // 
            this.imgGenerateReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgGenerateReport.BackgroundImage")));
            this.imgGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgGenerateReport.Location = new System.Drawing.Point(1241, 0);
            this.imgGenerateReport.Name = "imgGenerateReport";
            this.imgGenerateReport.Size = new System.Drawing.Size(130, 130);
            this.imgGenerateReport.TabIndex = 52;
            this.imgGenerateReport.TabStop = false;
            this.imgGenerateReport.Click += new System.EventHandler(this.imgGenerateReport_Click);
            // 
            // imgStatistics
            // 
            this.imgStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgStatistics.BackgroundImage")));
            this.imgStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgStatistics.Location = new System.Drawing.Point(1105, 0);
            this.imgStatistics.Name = "imgStatistics";
            this.imgStatistics.Size = new System.Drawing.Size(130, 130);
            this.imgStatistics.TabIndex = 51;
            this.imgStatistics.TabStop = false;
            this.imgStatistics.Click += new System.EventHandler(this.imgStatistics_Click);
            // 
            // imgManageTags
            // 
            this.imgManageTags.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgManageTags.BackgroundImage")));
            this.imgManageTags.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgManageTags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgManageTags.Location = new System.Drawing.Point(969, 1);
            this.imgManageTags.Name = "imgManageTags";
            this.imgManageTags.Size = new System.Drawing.Size(130, 130);
            this.imgManageTags.TabIndex = 50;
            this.imgManageTags.TabStop = false;
            this.imgManageTags.Click += new System.EventHandler(this.imgManageTags_Click);
            // 
            // imgLocations
            // 
            this.imgLocations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLocations.BackgroundImage")));
            this.imgLocations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLocations.Location = new System.Drawing.Point(833, 1);
            this.imgLocations.Name = "imgLocations";
            this.imgLocations.Size = new System.Drawing.Size(130, 130);
            this.imgLocations.TabIndex = 49;
            this.imgLocations.TabStop = false;
            this.imgLocations.Click += new System.EventHandler(this.imgLocations_Click);
            // 
            // imgManageSubjects
            // 
            this.imgManageSubjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgManageSubjects.BackgroundImage")));
            this.imgManageSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgManageSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgManageSubjects.Location = new System.Drawing.Point(562, 1);
            this.imgManageSubjects.Name = "imgManageSubjects";
            this.imgManageSubjects.Size = new System.Drawing.Size(130, 130);
            this.imgManageSubjects.TabIndex = 48;
            this.imgManageSubjects.TabStop = false;
            this.imgManageSubjects.Click += new System.EventHandler(this.imgManageSubjects_Click);
            // 
            // ImgManageLecturers
            // 
            this.ImgManageLecturers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgManageLecturers.BackgroundImage")));
            this.ImgManageLecturers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgManageLecturers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgManageLecturers.Location = new System.Drawing.Point(426, 1);
            this.ImgManageLecturers.Name = "ImgManageLecturers";
            this.ImgManageLecturers.Size = new System.Drawing.Size(130, 130);
            this.ImgManageLecturers.TabIndex = 47;
            this.ImgManageLecturers.TabStop = false;
            this.ImgManageLecturers.Click += new System.EventHandler(this.ImgManageLecturers_Click);
            // 
            // imgManageStudent
            // 
            this.imgManageStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgManageStudent.BackgroundImage")));
            this.imgManageStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgManageStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgManageStudent.Location = new System.Drawing.Point(290, 1);
            this.imgManageStudent.Name = "imgManageStudent";
            this.imgManageStudent.Size = new System.Drawing.Size(130, 130);
            this.imgManageStudent.TabIndex = 46;
            this.imgManageStudent.TabStop = false;
            this.imgManageStudent.Click += new System.EventHandler(this.imgManageStudent_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(40, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 130);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1915, 134);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // imgTime
            // 
            this.imgTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgTime.BackgroundImage")));
            this.imgTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTime.Location = new System.Drawing.Point(697, 1);
            this.imgTime.Name = "imgTime";
            this.imgTime.Size = new System.Drawing.Size(130, 130);
            this.imgTime.TabIndex = 45;
            this.imgTime.TabStop = false;
            this.imgTime.Click += new System.EventHandler(this.imgTime_Click);
            // 
            // chart_LecturerCountByProfessionalLevel
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_LecturerCountByProfessionalLevel.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_LecturerCountByProfessionalLevel.Legends.Add(legend2);
            this.chart_LecturerCountByProfessionalLevel.Location = new System.Drawing.Point(60, 65);
            this.chart_LecturerCountByProfessionalLevel.Name = "chart_LecturerCountByProfessionalLevel";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Lecturer Count";
            this.chart_LecturerCountByProfessionalLevel.Series.Add(series2);
            this.chart_LecturerCountByProfessionalLevel.Size = new System.Drawing.Size(573, 300);
            this.chart_LecturerCountByProfessionalLevel.TabIndex = 1;
            this.chart_LecturerCountByProfessionalLevel.Text = "Lecturers by Professional Level";
            this.chart_LecturerCountByProfessionalLevel.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart_lecturersByFaculty
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_lecturersByFaculty.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_lecturersByFaculty.Legends.Add(legend1);
            this.chart_lecturersByFaculty.Location = new System.Drawing.Point(639, 65);
            this.chart_lecturersByFaculty.Name = "chart_lecturersByFaculty";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Lecturer Count";
            this.chart_lecturersByFaculty.Series.Add(series1);
            this.chart_lecturersByFaculty.Size = new System.Drawing.Size(573, 300);
            this.chart_lecturersByFaculty.TabIndex = 2;
            this.chart_lecturersByFaculty.Text = "Lecturers by Faculty";
            this.chart_lecturersByFaculty.Click += new System.EventHandler(this.chart_lecturersByFaculty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = " Maximum Time Allocated Lecturers of subjects  (Data is not available yet)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageStatisticsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 673);
            this.Controls.Add(this.imgTime);
            this.Controls.Add(this.imgLoggedUser);
            this.Controls.Add(this.imgGenerateReport);
            this.Controls.Add(this.imgStatistics);
            this.Controls.Add(this.imgManageTags);
            this.Controls.Add(this.imgLocations);
            this.Controls.Add(this.imgManageSubjects);
            this.Controls.Add(this.ImgManageLecturers);
            this.Controls.Add(this.imgManageStudent);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageStatisticsDashboard";
            this.Text = "ManageStatisticsDashboard";
            this.Load += new System.EventHandler(this.ManageStatisticsDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.LecturersStatistics.ResumeLayout(false);
            this.LecturersStatistics.PerformLayout();
            this.StudentsStatistics.ResumeLayout(false);
            this.StudentsStatistics.PerformLayout();
            this.SubjectsStatistics.ResumeLayout(false);
            this.SubjectsStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoggedUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGenerateReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgManageTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgManageSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgManageLecturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgManageStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_LecturerCountByProfessionalLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lecturersByFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LecturersStatistics;
        private System.Windows.Forms.Label lblLecturerStatistics;
        private System.Windows.Forms.TabPage StudentsStatistics;
        private System.Windows.Forms.Label lblStudentStatistics;
        private System.Windows.Forms.TabPage SubjectsStatistics;
        private System.Windows.Forms.Label lblSubjectStatistics;
        private System.Windows.Forms.PictureBox imgLoggedUser;
        private System.Windows.Forms.PictureBox imgGenerateReport;
        private System.Windows.Forms.PictureBox imgStatistics;
        private System.Windows.Forms.PictureBox imgManageTags;
        private System.Windows.Forms.PictureBox imgLocations;
        private System.Windows.Forms.PictureBox imgManageSubjects;
        private System.Windows.Forms.PictureBox ImgManageLecturers;
        private System.Windows.Forms.PictureBox imgManageStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_LecturerCountByProfessionalLevel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_lecturersByFaculty;
        private System.Windows.Forms.Label label1;
    }
}