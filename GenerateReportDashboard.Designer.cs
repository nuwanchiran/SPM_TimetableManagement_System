namespace Timetable_Management_System
{
    partial class GenerateReportDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReportDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CreateSession = new System.Windows.Forms.TabPage();
            this.imgDataGridView_CreateSession = new System.Windows.Forms.DataGridView();
            this.cmbDuration_CreateSession = new System.Windows.Forms.TextBox();
            this.cmbNoOfStudents_CreateSession = new System.Windows.Forms.TextBox();
            this.cmbSubject_CreateSession = new System.Windows.Forms.ComboBox();
            this.cmbSubGroup_CreateSession = new System.Windows.Forms.ComboBox();
            this.cmbGroup_CreateSession = new System.Windows.Forms.ComboBox();
            this.cmbProgram_CreateSession = new System.Windows.Forms.ComboBox();
            this.cmbSemester_CreateSession = new System.Windows.Forms.ComboBox();
            this.cmbYear_CreateSession = new System.Windows.Forms.ComboBox();
            this.cmbTag_CreateSession = new System.Windows.Forms.ComboBox();
            this.lblDuration_CreateSession = new System.Windows.Forms.Label();
            this.lblNoOfStudents_CreateSession = new System.Windows.Forms.Label();
            this.lblSubject_CreateSession = new System.Windows.Forms.Label();
            this.lblSubGroup_CreateSession = new System.Windows.Forms.Label();
            this.lblGroup_CreateSession = new System.Windows.Forms.Label();
            this.lblProgram_CreateSession = new System.Windows.Forms.Label();
            this.lblSemester_CreateSession = new System.Windows.Forms.Label();
            this.lblYear_CreateSession = new System.Windows.Forms.Label();
            this.lblTag_CreateSession = new System.Windows.Forms.Label();
            this.selectedLecturersGridView = new System.Windows.Forms.DataGridView();
            this.cmbLecturerAddSession = new System.Windows.Forms.ComboBox();
            this.lblLecturerAddSession = new System.Windows.Forms.Label();
            this.lblPathAddSession = new System.Windows.Forms.Label();
            this.lblGenerateReport1 = new System.Windows.Forms.Label();
            this.lblAddSession = new System.Windows.Forms.Label();
            this.SessionManagement = new System.Windows.Forms.TabPage();
            this.lblSessionManagement = new System.Windows.Forms.Label();
            this.TimeManagement = new System.Windows.Forms.TabPage();
            this.lblTimeManagement = new System.Windows.Forms.Label();
            this.RoomManagement = new System.Windows.Forms.TabPage();
            this.lblRoomManagement = new System.Windows.Forms.Label();
            this.GenerateTimetable = new System.Windows.Forms.TabPage();
            this.lblGenerateTimetable = new System.Windows.Forms.Label();
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
            this.lblLecturerList_CreateSession = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.CreateSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDataGridView_CreateSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedLecturersGridView)).BeginInit();
            this.SessionManagement.SuspendLayout();
            this.TimeManagement.SuspendLayout();
            this.RoomManagement.SuspendLayout();
            this.GenerateTimetable.SuspendLayout();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.CreateSession);
            this.tabControl1.Controls.Add(this.SessionManagement);
            this.tabControl1.Controls.Add(this.TimeManagement);
            this.tabControl1.Controls.Add(this.RoomManagement);
            this.tabControl1.Controls.Add(this.GenerateTimetable);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(26, 220);
            this.tabControl1.Location = new System.Drawing.Point(4, 136);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1915, 910);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // CreateSession
            // 
            this.CreateSession.Controls.Add(this.groupBox1);
            this.CreateSession.Controls.Add(this.imgDataGridView_CreateSession);
            this.CreateSession.Controls.Add(this.cmbDuration_CreateSession);
            this.CreateSession.Controls.Add(this.cmbNoOfStudents_CreateSession);
            this.CreateSession.Controls.Add(this.cmbSubject_CreateSession);
            this.CreateSession.Controls.Add(this.cmbSubGroup_CreateSession);
            this.CreateSession.Controls.Add(this.cmbGroup_CreateSession);
            this.CreateSession.Controls.Add(this.cmbProgram_CreateSession);
            this.CreateSession.Controls.Add(this.cmbSemester_CreateSession);
            this.CreateSession.Controls.Add(this.cmbYear_CreateSession);
            this.CreateSession.Controls.Add(this.cmbTag_CreateSession);
            this.CreateSession.Controls.Add(this.lblDuration_CreateSession);
            this.CreateSession.Controls.Add(this.lblNoOfStudents_CreateSession);
            this.CreateSession.Controls.Add(this.lblSubject_CreateSession);
            this.CreateSession.Controls.Add(this.lblSubGroup_CreateSession);
            this.CreateSession.Controls.Add(this.lblGroup_CreateSession);
            this.CreateSession.Controls.Add(this.lblProgram_CreateSession);
            this.CreateSession.Controls.Add(this.lblSemester_CreateSession);
            this.CreateSession.Controls.Add(this.lblYear_CreateSession);
            this.CreateSession.Controls.Add(this.lblTag_CreateSession);
            this.CreateSession.Controls.Add(this.selectedLecturersGridView);
            this.CreateSession.Controls.Add(this.cmbLecturerAddSession);
            this.CreateSession.Controls.Add(this.lblLecturerAddSession);
            this.CreateSession.Controls.Add(this.lblPathAddSession);
            this.CreateSession.Controls.Add(this.lblGenerateReport1);
            this.CreateSession.Controls.Add(this.lblAddSession);
            this.CreateSession.Location = new System.Drawing.Point(224, 4);
            this.CreateSession.Name = "CreateSession";
            this.CreateSession.Padding = new System.Windows.Forms.Padding(3);
            this.CreateSession.Size = new System.Drawing.Size(1687, 902);
            this.CreateSession.TabIndex = 0;
            this.CreateSession.Text = "Create Session";
            this.CreateSession.UseVisualStyleBackColor = true;
            // 
            // imgDataGridView_CreateSession
            // 
            this.imgDataGridView_CreateSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imgDataGridView_CreateSession.Location = new System.Drawing.Point(709, 148);
            this.imgDataGridView_CreateSession.Name = "imgDataGridView_CreateSession";
            this.imgDataGridView_CreateSession.RowHeadersWidth = 51;
            this.imgDataGridView_CreateSession.RowTemplate.Height = 24;
            this.imgDataGridView_CreateSession.Size = new System.Drawing.Size(513, 390);
            this.imgDataGridView_CreateSession.TabIndex = 79;
            // 
            // cmbDuration_CreateSession
            // 
            this.cmbDuration_CreateSession.Location = new System.Drawing.Point(227, 761);
            this.cmbDuration_CreateSession.Name = "cmbDuration_CreateSession";
            this.cmbDuration_CreateSession.Size = new System.Drawing.Size(337, 27);
            this.cmbDuration_CreateSession.TabIndex = 78;
            // 
            // cmbNoOfStudents_CreateSession
            // 
            this.cmbNoOfStudents_CreateSession.Location = new System.Drawing.Point(227, 720);
            this.cmbNoOfStudents_CreateSession.Name = "cmbNoOfStudents_CreateSession";
            this.cmbNoOfStudents_CreateSession.Size = new System.Drawing.Size(337, 27);
            this.cmbNoOfStudents_CreateSession.TabIndex = 77;
            // 
            // cmbSubject_CreateSession
            // 
            this.cmbSubject_CreateSession.FormattingEnabled = true;
            this.cmbSubject_CreateSession.Location = new System.Drawing.Point(224, 672);
            this.cmbSubject_CreateSession.Name = "cmbSubject_CreateSession";
            this.cmbSubject_CreateSession.Size = new System.Drawing.Size(340, 28);
            this.cmbSubject_CreateSession.TabIndex = 76;
            // 
            // cmbSubGroup_CreateSession
            // 
            this.cmbSubGroup_CreateSession.FormattingEnabled = true;
            this.cmbSubGroup_CreateSession.Location = new System.Drawing.Point(443, 623);
            this.cmbSubGroup_CreateSession.Name = "cmbSubGroup_CreateSession";
            this.cmbSubGroup_CreateSession.Size = new System.Drawing.Size(121, 28);
            this.cmbSubGroup_CreateSession.TabIndex = 75;
            // 
            // cmbGroup_CreateSession
            // 
            this.cmbGroup_CreateSession.FormattingEnabled = true;
            this.cmbGroup_CreateSession.Location = new System.Drawing.Point(226, 623);
            this.cmbGroup_CreateSession.Name = "cmbGroup_CreateSession";
            this.cmbGroup_CreateSession.Size = new System.Drawing.Size(121, 28);
            this.cmbGroup_CreateSession.TabIndex = 74;
            // 
            // cmbProgram_CreateSession
            // 
            this.cmbProgram_CreateSession.FormattingEnabled = true;
            this.cmbProgram_CreateSession.Location = new System.Drawing.Point(226, 568);
            this.cmbProgram_CreateSession.Name = "cmbProgram_CreateSession";
            this.cmbProgram_CreateSession.Size = new System.Drawing.Size(338, 28);
            this.cmbProgram_CreateSession.TabIndex = 73;
            // 
            // cmbSemester_CreateSession
            // 
            this.cmbSemester_CreateSession.FormattingEnabled = true;
            this.cmbSemester_CreateSession.Location = new System.Drawing.Point(443, 515);
            this.cmbSemester_CreateSession.Name = "cmbSemester_CreateSession";
            this.cmbSemester_CreateSession.Size = new System.Drawing.Size(121, 28);
            this.cmbSemester_CreateSession.TabIndex = 72;
            // 
            // cmbYear_CreateSession
            // 
            this.cmbYear_CreateSession.FormattingEnabled = true;
            this.cmbYear_CreateSession.Location = new System.Drawing.Point(226, 515);
            this.cmbYear_CreateSession.Name = "cmbYear_CreateSession";
            this.cmbYear_CreateSession.Size = new System.Drawing.Size(121, 28);
            this.cmbYear_CreateSession.TabIndex = 71;
            // 
            // cmbTag_CreateSession
            // 
            this.cmbTag_CreateSession.FormattingEnabled = true;
            this.cmbTag_CreateSession.Location = new System.Drawing.Point(226, 469);
            this.cmbTag_CreateSession.Name = "cmbTag_CreateSession";
            this.cmbTag_CreateSession.Size = new System.Drawing.Size(338, 28);
            this.cmbTag_CreateSession.TabIndex = 70;
            // 
            // lblDuration_CreateSession
            // 
            this.lblDuration_CreateSession.AutoSize = true;
            this.lblDuration_CreateSession.Location = new System.Drawing.Point(143, 764);
            this.lblDuration_CreateSession.Name = "lblDuration_CreateSession";
            this.lblDuration_CreateSession.Size = new System.Drawing.Size(67, 20);
            this.lblDuration_CreateSession.TabIndex = 69;
            this.lblDuration_CreateSession.Text = "Duration";
            // 
            // lblNoOfStudents_CreateSession
            // 
            this.lblNoOfStudents_CreateSession.AutoSize = true;
            this.lblNoOfStudents_CreateSession.Location = new System.Drawing.Point(108, 720);
            this.lblNoOfStudents_CreateSession.Name = "lblNoOfStudents_CreateSession";
            this.lblNoOfStudents_CreateSession.Size = new System.Drawing.Size(110, 20);
            this.lblNoOfStudents_CreateSession.TabIndex = 68;
            this.lblNoOfStudents_CreateSession.Text = "No Of Students";
            // 
            // lblSubject_CreateSession
            // 
            this.lblSubject_CreateSession.AutoSize = true;
            this.lblSubject_CreateSession.Location = new System.Drawing.Point(160, 675);
            this.lblSubject_CreateSession.Name = "lblSubject_CreateSession";
            this.lblSubject_CreateSession.Size = new System.Drawing.Size(58, 20);
            this.lblSubject_CreateSession.TabIndex = 67;
            this.lblSubject_CreateSession.Text = "Subject";
            // 
            // lblSubGroup_CreateSession
            // 
            this.lblSubGroup_CreateSession.AutoSize = true;
            this.lblSubGroup_CreateSession.Location = new System.Drawing.Point(362, 626);
            this.lblSubGroup_CreateSession.Name = "lblSubGroup_CreateSession";
            this.lblSubGroup_CreateSession.Size = new System.Drawing.Size(75, 20);
            this.lblSubGroup_CreateSession.TabIndex = 66;
            this.lblSubGroup_CreateSession.Text = "SubGroup";
            // 
            // lblGroup_CreateSession
            // 
            this.lblGroup_CreateSession.AutoSize = true;
            this.lblGroup_CreateSession.Location = new System.Drawing.Point(160, 626);
            this.lblGroup_CreateSession.Name = "lblGroup_CreateSession";
            this.lblGroup_CreateSession.Size = new System.Drawing.Size(50, 20);
            this.lblGroup_CreateSession.TabIndex = 65;
            this.lblGroup_CreateSession.Text = "Group";
            // 
            // lblProgram_CreateSession
            // 
            this.lblProgram_CreateSession.AutoSize = true;
            this.lblProgram_CreateSession.Location = new System.Drawing.Point(160, 571);
            this.lblProgram_CreateSession.Name = "lblProgram_CreateSession";
            this.lblProgram_CreateSession.Size = new System.Drawing.Size(66, 20);
            this.lblProgram_CreateSession.TabIndex = 64;
            this.lblProgram_CreateSession.Text = "Program";
            // 
            // lblSemester_CreateSession
            // 
            this.lblSemester_CreateSession.AutoSize = true;
            this.lblSemester_CreateSession.Location = new System.Drawing.Point(367, 518);
            this.lblSemester_CreateSession.Name = "lblSemester_CreateSession";
            this.lblSemester_CreateSession.Size = new System.Drawing.Size(70, 20);
            this.lblSemester_CreateSession.TabIndex = 63;
            this.lblSemester_CreateSession.Text = "Semester";
            // 
            // lblYear_CreateSession
            // 
            this.lblYear_CreateSession.AutoSize = true;
            this.lblYear_CreateSession.Location = new System.Drawing.Point(160, 518);
            this.lblYear_CreateSession.Name = "lblYear_CreateSession";
            this.lblYear_CreateSession.Size = new System.Drawing.Size(37, 20);
            this.lblYear_CreateSession.TabIndex = 62;
            this.lblYear_CreateSession.Text = "Year";
            // 
            // lblTag_CreateSession
            // 
            this.lblTag_CreateSession.AutoSize = true;
            this.lblTag_CreateSession.Location = new System.Drawing.Point(160, 472);
            this.lblTag_CreateSession.Name = "lblTag_CreateSession";
            this.lblTag_CreateSession.Size = new System.Drawing.Size(32, 20);
            this.lblTag_CreateSession.TabIndex = 61;
            this.lblTag_CreateSession.Text = "Tag";
            // 
            // selectedLecturersGridView
            // 
            this.selectedLecturersGridView.AllowUserToAddRows = false;
            this.selectedLecturersGridView.AllowUserToDeleteRows = false;
            this.selectedLecturersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedLecturersGridView.Location = new System.Drawing.Point(180, 167);
            this.selectedLecturersGridView.Name = "selectedLecturersGridView";
            this.selectedLecturersGridView.RowHeadersWidth = 51;
            this.selectedLecturersGridView.RowTemplate.Height = 24;
            this.selectedLecturersGridView.Size = new System.Drawing.Size(472, 253);
            this.selectedLecturersGridView.TabIndex = 60;
            this.selectedLecturersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedLecturersGridView_CellClick);
            // 
            // cmbLecturerAddSession
            // 
            this.cmbLecturerAddSession.FormattingEnabled = true;
            this.cmbLecturerAddSession.Location = new System.Drawing.Point(235, 104);
            this.cmbLecturerAddSession.Name = "cmbLecturerAddSession";
            this.cmbLecturerAddSession.Size = new System.Drawing.Size(209, 28);
            this.cmbLecturerAddSession.TabIndex = 59;
            this.cmbLecturerAddSession.SelectedIndexChanged += new System.EventHandler(this.cmbLecturerAddSession_SelectedIndexChanged);
            // 
            // lblLecturerAddSession
            // 
            this.lblLecturerAddSession.AutoSize = true;
            this.lblLecturerAddSession.Location = new System.Drawing.Point(126, 110);
            this.lblLecturerAddSession.Name = "lblLecturerAddSession";
            this.lblLecturerAddSession.Size = new System.Drawing.Size(68, 20);
            this.lblLecturerAddSession.TabIndex = 58;
            this.lblLecturerAddSession.Text = "Lecturers";
            // 
            // lblPathAddSession
            // 
            this.lblPathAddSession.AutoSize = true;
            this.lblPathAddSession.Location = new System.Drawing.Point(20, 20);
            this.lblPathAddSession.Name = "lblPathAddSession";
            this.lblPathAddSession.Size = new System.Drawing.Size(371, 20);
            this.lblPathAddSession.TabIndex = 57;
            this.lblPathAddSession.Text = "Admin Dashboard > Generate Report > Create Session";
            // 
            // lblGenerateReport1
            // 
            this.lblGenerateReport1.AutoSize = true;
            this.lblGenerateReport1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateReport1.Location = new System.Drawing.Point(605, 21);
            this.lblGenerateReport1.Name = "lblGenerateReport1";
            this.lblGenerateReport1.Size = new System.Drawing.Size(250, 41);
            this.lblGenerateReport1.TabIndex = 56;
            this.lblGenerateReport1.Text = "Generate Report";
            // 
            // lblAddSession
            // 
            this.lblAddSession.AutoSize = true;
            this.lblAddSession.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSession.Location = new System.Drawing.Point(654, 79);
            this.lblAddSession.Name = "lblAddSession";
            this.lblAddSession.Size = new System.Drawing.Size(154, 32);
            this.lblAddSession.TabIndex = 55;
            this.lblAddSession.Text = "Add Session";
            // 
            // SessionManagement
            // 
            this.SessionManagement.Controls.Add(this.lblSessionManagement);
            this.SessionManagement.Location = new System.Drawing.Point(224, 4);
            this.SessionManagement.Name = "SessionManagement";
            this.SessionManagement.Padding = new System.Windows.Forms.Padding(3);
            this.SessionManagement.Size = new System.Drawing.Size(1687, 902);
            this.SessionManagement.TabIndex = 1;
            this.SessionManagement.Text = "SessionManagement";
            this.SessionManagement.UseVisualStyleBackColor = true;
            // 
            // lblSessionManagement
            // 
            this.lblSessionManagement.AutoSize = true;
            this.lblSessionManagement.Location = new System.Drawing.Point(314, 64);
            this.lblSessionManagement.Name = "lblSessionManagement";
            this.lblSessionManagement.Size = new System.Drawing.Size(150, 20);
            this.lblSessionManagement.TabIndex = 0;
            this.lblSessionManagement.Text = "Session Management";
            // 
            // TimeManagement
            // 
            this.TimeManagement.Controls.Add(this.lblTimeManagement);
            this.TimeManagement.Location = new System.Drawing.Point(224, 4);
            this.TimeManagement.Name = "TimeManagement";
            this.TimeManagement.Size = new System.Drawing.Size(1687, 902);
            this.TimeManagement.TabIndex = 2;
            this.TimeManagement.Text = "Time Management";
            this.TimeManagement.UseVisualStyleBackColor = true;
            // 
            // lblTimeManagement
            // 
            this.lblTimeManagement.AutoSize = true;
            this.lblTimeManagement.Location = new System.Drawing.Point(230, 50);
            this.lblTimeManagement.Name = "lblTimeManagement";
            this.lblTimeManagement.Size = new System.Drawing.Size(134, 20);
            this.lblTimeManagement.TabIndex = 0;
            this.lblTimeManagement.Text = "Time Management";
            // 
            // RoomManagement
            // 
            this.RoomManagement.Controls.Add(this.lblRoomManagement);
            this.RoomManagement.Location = new System.Drawing.Point(224, 4);
            this.RoomManagement.Name = "RoomManagement";
            this.RoomManagement.Size = new System.Drawing.Size(1687, 902);
            this.RoomManagement.TabIndex = 3;
            this.RoomManagement.Text = "Room Management";
            this.RoomManagement.UseVisualStyleBackColor = true;
            // 
            // lblRoomManagement
            // 
            this.lblRoomManagement.AutoSize = true;
            this.lblRoomManagement.Location = new System.Drawing.Point(298, 46);
            this.lblRoomManagement.Name = "lblRoomManagement";
            this.lblRoomManagement.Size = new System.Drawing.Size(141, 20);
            this.lblRoomManagement.TabIndex = 0;
            this.lblRoomManagement.Text = "Room Management";
            // 
            // GenerateTimetable
            // 
            this.GenerateTimetable.Controls.Add(this.lblGenerateTimetable);
            this.GenerateTimetable.Location = new System.Drawing.Point(224, 4);
            this.GenerateTimetable.Name = "GenerateTimetable";
            this.GenerateTimetable.Size = new System.Drawing.Size(1687, 902);
            this.GenerateTimetable.TabIndex = 4;
            this.GenerateTimetable.Text = "Generate Timetable";
            this.GenerateTimetable.UseVisualStyleBackColor = true;
            // 
            // lblGenerateTimetable
            // 
            this.lblGenerateTimetable.AutoSize = true;
            this.lblGenerateTimetable.Location = new System.Drawing.Point(320, 36);
            this.lblGenerateTimetable.Name = "lblGenerateTimetable";
            this.lblGenerateTimetable.Size = new System.Drawing.Size(140, 20);
            this.lblGenerateTimetable.TabIndex = 0;
            this.lblGenerateTimetable.Text = "Generate Timetable";
            // 
            // imgLoggedUser
            // 
            this.imgLoggedUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLoggedUser.BackgroundImage")));
            this.imgLoggedUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLoggedUser.Location = new System.Drawing.Point(1790, 0);
            this.imgLoggedUser.Name = "imgLoggedUser";
            this.imgLoggedUser.Size = new System.Drawing.Size(121, 134);
            this.imgLoggedUser.TabIndex = 43;
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
            this.imgGenerateReport.TabIndex = 42;
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
            this.imgStatistics.TabIndex = 41;
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
            this.imgManageTags.TabIndex = 40;
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
            this.imgLocations.TabIndex = 39;
            this.imgLocations.TabStop = false;
            this.imgLocations.Click += new System.EventHandler(this.imgLocations_Click);
            // 
            // imgManageSubjects
            // 
            this.imgManageSubjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgManageSubjects.BackgroundImage")));
            this.imgManageSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgManageSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgManageSubjects.Location = new System.Drawing.Point(561, 1);
            this.imgManageSubjects.Name = "imgManageSubjects";
            this.imgManageSubjects.Size = new System.Drawing.Size(130, 130);
            this.imgManageSubjects.TabIndex = 38;
            this.imgManageSubjects.TabStop = false;
            this.imgManageSubjects.Click += new System.EventHandler(this.imgManageSubjects_Click);
            // 
            // ImgManageLecturers
            // 
            this.ImgManageLecturers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgManageLecturers.BackgroundImage")));
            this.ImgManageLecturers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgManageLecturers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgManageLecturers.Location = new System.Drawing.Point(425, 1);
            this.ImgManageLecturers.Name = "ImgManageLecturers";
            this.ImgManageLecturers.Size = new System.Drawing.Size(130, 130);
            this.ImgManageLecturers.TabIndex = 37;
            this.ImgManageLecturers.TabStop = false;
            this.ImgManageLecturers.Click += new System.EventHandler(this.ImgManageLecturers_Click);
            // 
            // imgManageStudent
            // 
            this.imgManageStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgManageStudent.BackgroundImage")));
            this.imgManageStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgManageStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgManageStudent.Location = new System.Drawing.Point(289, 1);
            this.imgManageStudent.Name = "imgManageStudent";
            this.imgManageStudent.Size = new System.Drawing.Size(130, 130);
            this.imgManageStudent.TabIndex = 36;
            this.imgManageStudent.TabStop = false;
            this.imgManageStudent.Click += new System.EventHandler(this.imgManageStudent_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(39, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 130);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1915, 134);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // imgTime
            // 
            this.imgTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgTime.BackgroundImage")));
            this.imgTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTime.Location = new System.Drawing.Point(696, 1);
            this.imgTime.Name = "imgTime";
            this.imgTime.Size = new System.Drawing.Size(130, 130);
            this.imgTime.TabIndex = 44;
            this.imgTime.TabStop = false;
            this.imgTime.Click += new System.EventHandler(this.imgTime_Click);
            // 
            // lblLecturerList_CreateSession
            // 
            this.lblLecturerList_CreateSession.AutoSize = true;
            this.lblLecturerList_CreateSession.Location = new System.Drawing.Point(46, 23);
            this.lblLecturerList_CreateSession.Name = "lblLecturerList_CreateSession";
            this.lblLecturerList_CreateSession.Size = new System.Drawing.Size(88, 20);
            this.lblLecturerList_CreateSession.TabIndex = 80;
            this.lblLecturerList_CreateSession.Text = "Lecturer List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLecturerList_CreateSession);
            this.groupBox1.Location = new System.Drawing.Point(728, 574);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 126);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // GenerateReportDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
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
            this.Name = "GenerateReportDashboard";
            this.Text = "GenerateReportDashboard";
            this.Load += new System.EventHandler(this.GenerateReportDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.CreateSession.ResumeLayout(false);
            this.CreateSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDataGridView_CreateSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedLecturersGridView)).EndInit();
            this.SessionManagement.ResumeLayout(false);
            this.SessionManagement.PerformLayout();
            this.TimeManagement.ResumeLayout(false);
            this.TimeManagement.PerformLayout();
            this.RoomManagement.ResumeLayout(false);
            this.RoomManagement.PerformLayout();
            this.GenerateTimetable.ResumeLayout(false);
            this.GenerateTimetable.PerformLayout();
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CreateSession;
        private System.Windows.Forms.TabPage SessionManagement;
        private System.Windows.Forms.Label lblSessionManagement;
        private System.Windows.Forms.TabPage TimeManagement;
        private System.Windows.Forms.Label lblTimeManagement;
        private System.Windows.Forms.TabPage RoomManagement;
        private System.Windows.Forms.Label lblRoomManagement;
        private System.Windows.Forms.TabPage GenerateTimetable;
        private System.Windows.Forms.Label lblGenerateTimetable;
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
        private System.Windows.Forms.Label lblPathAddSession;
        private System.Windows.Forms.Label lblGenerateReport1;
        private System.Windows.Forms.Label lblAddSession;
        private System.Windows.Forms.ComboBox cmbLecturerAddSession;
        private System.Windows.Forms.Label lblLecturerAddSession;
        private System.Windows.Forms.DataGridView selectedLecturersGridView;
        private System.Windows.Forms.Label lblDuration_CreateSession;
        private System.Windows.Forms.Label lblNoOfStudents_CreateSession;
        private System.Windows.Forms.Label lblSubject_CreateSession;
        private System.Windows.Forms.Label lblSubGroup_CreateSession;
        private System.Windows.Forms.Label lblGroup_CreateSession;
        private System.Windows.Forms.Label lblProgram_CreateSession;
        private System.Windows.Forms.Label lblSemester_CreateSession;
        private System.Windows.Forms.Label lblYear_CreateSession;
        private System.Windows.Forms.Label lblTag_CreateSession;
        private System.Windows.Forms.TextBox cmbDuration_CreateSession;
        private System.Windows.Forms.TextBox cmbNoOfStudents_CreateSession;
        private System.Windows.Forms.ComboBox cmbSubject_CreateSession;
        private System.Windows.Forms.ComboBox cmbSubGroup_CreateSession;
        private System.Windows.Forms.ComboBox cmbGroup_CreateSession;
        private System.Windows.Forms.ComboBox cmbProgram_CreateSession;
        private System.Windows.Forms.ComboBox cmbSemester_CreateSession;
        private System.Windows.Forms.ComboBox cmbYear_CreateSession;
        private System.Windows.Forms.ComboBox cmbTag_CreateSession;
        private System.Windows.Forms.DataGridView imgDataGridView_CreateSession;
        private System.Windows.Forms.Label lblLecturerList_CreateSession;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}