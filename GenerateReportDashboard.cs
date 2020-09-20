using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetable_Management_System.src;
using Timetable_Management_System.src.Models;
using System.Data.SqlClient;

namespace Timetable_Management_System
{
    public partial class GenerateReportDashboard : Form
    {

        List<Lecturer> selectedLecturersListForCreateSession;

        public GenerateReportDashboard()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            this.WindowState = FormWindowState.Maximized;

            //Create Session
            fillInitialComboboxes();
            cleanCreateSession();
        }

       

        private void GenerateReportDashboard_Load(object sender, EventArgs e)
        {

            selectedLecturersListForCreateSession = new List<Lecturer>();

            fillCmbLecturerList();
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void imgManageStudent_Click(object sender, EventArgs e)
        {
            ManageStudentsDashboard manageStudentsDashboardObj = new ManageStudentsDashboard();
            manageStudentsDashboardObj.Show();
            this.Hide();
        }

        private void ImgManageLecturers_Click(object sender, EventArgs e)
        {
            ManageLecturerDashboard lecturerDashboardObj = new ManageLecturerDashboard();
            lecturerDashboardObj.Show();
            this.Hide();
        }

        private void imgManageSubjects_Click(object sender, EventArgs e)
        {
            ManageSubjectsDashboard manageSubjectsDashboardObj = new ManageSubjectsDashboard();
            manageSubjectsDashboardObj.Show();
            this.Hide();
        }

        private void imgTime_Click(object sender, EventArgs e)
        {
            ManageTimeDashboard manageTimeDashboardObj = new ManageTimeDashboard();
            manageTimeDashboardObj.Show(); 
            this.Hide();
        }

        private void imgLocations_Click(object sender, EventArgs e)
        {
            ManageLocationsDashboard manageLocationsDashboardObj = new ManageLocationsDashboard();
            manageLocationsDashboardObj.Show();
            this.Hide();
        }

        private void imgManageTags_Click(object sender, EventArgs e)
        {
            ManageTagsDashboard manageTagsDashboardObj = new ManageTagsDashboard();
            manageTagsDashboardObj.Show();
            this.Hide();
        }

        private void imgStatistics_Click(object sender, EventArgs e)
        {
            ManageStatisticsDashboard manageStatisticsDashboardObj = new ManageStatisticsDashboard();
            manageStatisticsDashboardObj.Show();
            this.Hide();

        }

        private void imgGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReportDashboard generateReportDashboardObj = new GenerateReportDashboard();
            generateReportDashboardObj.Show();
            this.Hide();
        }
        
        List<Lecturer> foundLecturersListForDisplay = new List<Lecturer>();

        private void fillCmbLecturerList()
        {
            //No items in the list. All lecturers needs be added to dropdown
            if(selectedLecturersListForCreateSession.Count == 0)
            {
                cmbLecturerAddSession.Items.Clear();
               
                foundLecturersListForDisplay = getAllLecturers();

                foreach (Lecturer lecObj in foundLecturersListForDisplay) // Loop through List with foreach
                {
                    cmbLecturerAddSession.Items.Add(lecObj.lecturerID + " - " + lecObj.name);
                }
            }
            //Lecturers already selected
            else
            {
                cmbLecturerAddSession.Items.Clear();
                foundLecturersListForDisplay = refreshDataInLecturerCmb();
                foreach (Lecturer lecObj in foundLecturersListForDisplay) // Loop through List with foreach
                {
                    cmbLecturerAddSession.Items.Add(lecObj.lecturerID + " - " + lecObj.name);
                }
            }

        }

        private List<Lecturer> getAllLecturers()
        {
            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            using var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "";

            stm = "SELECT * FROM lecturers";

            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            List<Lecturer> foundLecturersListForDisplay = new List<Lecturer>();
            
            while (rdr.Read())
            {
                Lecturer lecObj = new Lecturer();
                // Console.WriteLine($@"{rdr.GetInt32(0),-3} {rdr.GetString(1),-8} {rdr.GetInt32(2),8}");
                lecObj.lecturerID = Int32.Parse($@"{rdr.GetInt32(0),-3}");
                lecObj.title = $@"{ rdr.GetString(1),-8}".Trim();
                lecObj.name = $@"{ rdr.GetString(2),-8}".Trim();
                lecObj.faculty = $@"{ rdr.GetString(3),-8}".Trim();
                lecObj.department = $@"{ rdr.GetString(4),-8}".Trim();
                lecObj.center = $@"{ rdr.GetString(5),-8}".Trim();
                lecObj.building = $@"{ rdr.GetString(6),-8}".Trim();
                lecObj.employeeLevel = Int32.Parse($@"{rdr.GetInt32(7),-3}");
                lecObj.photoPath = $@"{ rdr.GetString(8),-8}".Trim();

                foundLecturersListForDisplay.Add(lecObj);
            }
            return foundLecturersListForDisplay;
        }

        private void cmbLecturerAddSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectComboBoxText = this.cmbLecturerAddSession.GetItemText(this.cmbLecturerAddSession.SelectedItem)+"";
            //string[] authorsList = selectComboBoxText.Split(" - ");

            // Split the string on line breaks.
            string[] lines = selectComboBoxText.Split(new string[] { " - " }, StringSplitOptions.None);

            //lines[0] = { lecturer ID}
            //lines[1] = { lecturer name}
      
            List<string> temp = new List<string>();
            temp.Add(lines[0]);

            List<Lecturer> listOfLecObj = new List<Lecturer>();
            listOfLecObj = getLecturerObjectListByProvindingLecturerIDList(temp);
            foreach (Lecturer element in listOfLecObj)
            {
                selectedLecturersListForCreateSession.Add(element);
            }

            //refresh data in lecturer Combobox
            foundLecturersListForDisplay = refreshDataInLecturerCmb();

            fillCmbLecturerList();


            UpdateSelectedLecturerGrid();

            RefreshImagesWindows_CreateSession();

            generateAndDisplayLecturersList_CreateSession();
        }

        private void RefreshImagesWindows_CreateSession()
        {
            this.imgDataGridView_CreateSession.Rows.Clear();

            if (this.imgDataGridView_CreateSession.Columns.Count < 3)
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.DefaultCellStyle.NullValue = null;
                imgDataGridView_CreateSession.Columns.Add(imgCol);
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            imgDataGridView_CreateSession.AutoSizeRowsMode =    DataGridViewAutoSizeRowsMode.AllCells;

            List<Object> temp = new List<object>();
            for (int i=0; i< selectedLecturersListForCreateSession.Count; i++)
            {
                string photoPath = selectedLecturersListForCreateSession[i].photoPath;
                Image img = Image.FromFile(@"" + photoPath);
                temp.Add(img);
                if ((i+1)%3==0)
                {
                    Object[] row = temp.Cast<object>().ToArray();
                    imgDataGridView_CreateSession.Rows.Add(row);
                    temp = new List<object>();
                }
            }
            if (temp.Count > 0)
            {
                imgDataGridView_CreateSession.Rows.Add(temp.Cast<object>().ToArray());
            }

            /*

            List<ImageLec> imagesList = new List<ImageLec>(); 
            foreach (Lecturer element in selectedLecturersListForCreateSession)
            {
                ImageLec obj = new ImageLec();
                obj.isDisplayed = false;
                obj.lecturerID = element.lecturerID;
                obj.lecturerName = element.name;
                obj.photoPath = element.photoPath;
                imagesList.Add(obj);
            }


            List<Object> temp = new List<object>();

            int row_var = 0;
            int col_var = 0;
            foreach (DataGridViewRow row in imgDataGridView_CreateSession.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    FROM lecturers WHERE
                    foreach (ImageLec element in imagesList)
                    {
                        if(element.isDisplayed == false)
                        {
                            //  selectedLecturersListForCreateSession[0].name
                            string photoPath = element.photoPath;
                          //  Image img1 = Image.FromFile(@"" + photoPath);
                          //  temp.Add(img1);


                            Bitmap bmp = (Bitmap)Bitmap.FromFile(@"" + photoPath);

                            DataGridViewImageCell iCell = new DataGridViewImageCell();
                            iCell.Value = bmp;
                            imgDataGridView_CreateSession[row_var, col_var] = iCell;
                            
                            element.isDisplayed = true;
                            break;
                        }
                       
                    }
                col_var++;

                }
             row_var++;
            }

            */


        }

        private void UpdateSelectedLecturerGrid()
        {
            selectedLecturersGridView.Columns.Clear();

            selectedLecturersGridView.ColumnCount = 2;
            selectedLecturersGridView.Columns[0].Name = "Lecturer ID";
            selectedLecturersGridView.Columns[0].Width= 100;
            selectedLecturersGridView.Columns[1].Name = "Lecturer Name";
            selectedLecturersGridView.Columns[1].Width = 150;

            foreach (Lecturer element in selectedLecturersListForCreateSession)
            {
                string[] row1 = new string[] { element.lecturerID+"", element.name };
                selectedLecturersGridView.Rows.Add(row1);
            }

            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.HeaderText = "    X";
            dgvBtn.Name = "X";
            dgvBtn.Text = "X";

            dgvBtn.Width = 50;

            selectedLecturersGridView.Columns.Add(dgvBtn);


        }

        private void selectedLecturersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowindex = selectedLecturersGridView.CurrentCell.RowIndex;
            int columnindex = selectedLecturersGridView.CurrentCell.ColumnIndex;

           
            string lecName = selectedLecturersGridView.Rows[rowindex].Cells[columnindex-1].Value.ToString();
            string lecId = selectedLecturersGridView.Rows[rowindex].Cells[columnindex-2].Value.ToString();

            find_And_Remove_Relevant_Lecturer_In_selectedLecturersListForCreateSession_List(lecId);
            UpdateSelectedLecturerGrid();
            Console.WriteLine(selectedLecturersListForCreateSession);
            fillCmbLecturerList();
            generateAndDisplayLecturersList_CreateSession();
            RefreshImagesWindows_CreateSession();
        }

        private void find_And_Remove_Relevant_Lecturer_In_selectedLecturersListForCreateSession_List( string lecId)
        {
            List<Lecturer> temp = new List<Lecturer>();
            
            foreach (Lecturer element in selectedLecturersListForCreateSession)
            {
                if(!lecId.Equals(element.lecturerID.ToString())){
                    temp.Add(element);
                }
            }
            selectedLecturersListForCreateSession = temp;
        }

        private List<Lecturer> refreshDataInLecturerCmb()
        {
            //List<int> lecIdList = new List<int>();
            string fullLecIdString = "";

            int counter = 0;
            foreach (Lecturer element in selectedLecturersListForCreateSession)
            {
                if (counter != 0)
                {
                    fullLecIdString += ",";
                }
                fullLecIdString += element.lecturerID;
                counter++;
            }

            string cs = @"URI=file:.\" + Utils.dbName + ".db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "";
            stm = "SELECT * FROM lecturers WHERE lecturerID NOT IN(" + fullLecIdString + ")";
            using var cmd = new SQLiteCommand(stm, con); 
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            List<Lecturer> lecList = new List<Lecturer>();
            while (rdr.Read())
            {
                Lecturer lecObj = new Lecturer();
                // Console.WriteLine($@"{rdr.GetInt32(0),-3} {rdr.GetString(1),-8} {rdr.GetInt32(2),8}");
                lecObj.lecturerID = Int32.Parse($@"{rdr.GetInt32(0),-3}");
                lecObj.title = $@"{ rdr.GetString(1),-8}".Trim();
                lecObj.name = $@"{ rdr.GetString(2),-8}".Trim();
                lecObj.faculty = $@"{ rdr.GetString(3),-8}".Trim();
                lecObj.department = $@"{ rdr.GetString(4),-8}".Trim();
                lecObj.center = $@"{ rdr.GetString(5),-8}".Trim();
                lecObj.building = $@"{ rdr.GetString(6),-8}".Trim();
                lecObj.employeeLevel = Int32.Parse($@"{rdr.GetInt32(7),-3}");
                lecObj.photoPath = $@"{ rdr.GetString(8),-8}".Trim();

                lecList.Add(lecObj);
            }

            con.Close();
            return lecList;

        }

        private List<Lecturer> getLecturerObjectListByProvindingLecturerIDList(List<string> listOfLecturerIDs)
        {
            List<Lecturer> fillCmbLecturerList = new List<Lecturer>();

            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            using var con = new SQLiteConnection(cs);
            con.Open();


            foreach (string lecId in listOfLecturerIDs)
            {
                string stm = "";
                stm = "SELECT * FROM lecturers WHERE lecturerID='" + lecId + "'";
                using var cmd = new SQLiteCommand(stm, con);
                using SQLiteDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Lecturer lecObj = new Lecturer();
                    // Console.WriteLine($@"{rdr.GetInt32(0),-3} {rdr.GetString(1),-8} {rdr.GetInt32(2),8}");
                    lecObj.lecturerID = Int32.Parse($@"{rdr.GetInt32(0),-3}");
                    lecObj.title = $@"{ rdr.GetString(1),-8}".Trim();
                    lecObj.name = $@"{ rdr.GetString(2),-8}".Trim();
                    lecObj.faculty = $@"{ rdr.GetString(3),-8}".Trim();
                    lecObj.department = $@"{ rdr.GetString(4),-8}".Trim();
                    lecObj.center = $@"{ rdr.GetString(5),-8}".Trim();
                    lecObj.building = $@"{ rdr.GetString(6),-8}".Trim();
                    lecObj.employeeLevel = Int32.Parse($@"{rdr.GetInt32(7),-3}");
                    lecObj.photoPath = $@"{ rdr.GetString(8),-8}".Trim();

                    fillCmbLecturerList.Add(lecObj);
                }
            }
            con.Close();

            return fillCmbLecturerList;
        }

        private void fillTags_CreateSession()
        {
            cmbTag_CreateSession.Items.Clear();

            cmbTag_CreateSession.Items.Add("Lecture");
            cmbTag_CreateSession.Items.Add("Tutorial");
            cmbTag_CreateSession.Items.Add("Lab");
            cmbTag_CreateSession.Items.Add("Evaluation");
        }
        private void fillYear_CreateSession()
        {
            cmbYear_CreateSession.Items.Add(1);
            cmbYear_CreateSession.Items.Add(2);
            cmbYear_CreateSession.Items.Add(3);
            cmbYear_CreateSession.Items.Add(4);
        }
        private void fillSemester_CreateSession()
        {
            cmbSemester_CreateSession.Items.Add(1);
            cmbSemester_CreateSession.Items.Add(2);
        }

        private void fillProgram_CreateSession()
        {
            cmbProgram_CreateSession.Items.Add("SE");
            cmbProgram_CreateSession.Items.Add("IT");
            cmbProgram_CreateSession.Items.Add("CS");
            cmbProgram_CreateSession.Items.Add("IM");
            cmbProgram_CreateSession.Items.Add("DS");
        }

        private void fillInitialComboboxes()
        {
            fillTags_CreateSession();
            fillYear_CreateSession();
            fillSemester_CreateSession();
            fillProgram_CreateSession();
            fillGroup_CreateSession();
        }

        private void fillGroup_CreateSession()
        {
           
        }

        private void generateAndDisplayLecturersList_CreateSession()
        {
            string fullLecList = "";
            foreach (Lecturer element in selectedLecturersListForCreateSession)
            {
                if (fullLecList.Equals(""))
                {
                    fullLecList = fullLecList + element.name;
                }
                else
                {
                    fullLecList = fullLecList + " , " +element.name;
                }
            }
            lblLecturerList_CreateSession.Text = fullLecList;
        }

        private void cleanCreateSession()
        {
            lblLecturerList_CreateSession.Text = "";
            lblLecturerList_CreateSession.Text = "";
            lblTag_CreateSession_Summary.Text = "";
            lblSessionID_CreateSession_Summary.Text = "";
            lblSubject_CreateSession_summary.Text = "";
            lblStudentCreateSessionSummary_CreateSession.Text = "";
            lblCountAndHrs_CreateSession.Text = "";


        }

        
        private void btnReset_CreateSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateReportDashboard obj = new GenerateReportDashboard();
            obj.Show();
        }

       
        private void btnCreateSession_Click(object sender, EventArgs e)
        {

            string sessionId = txtSessionID_CreateSession.Text;

            string selectedTag = this.cmbTag_CreateSession.GetItemText(this.cmbTag_CreateSession.SelectedItem);
            string selectedYear = this.cmbYear_CreateSession.GetItemText(this.cmbYear_CreateSession.SelectedItem);
            string selectedSemester = this.cmbSemester_CreateSession.GetItemText(this.cmbSemester_CreateSession.SelectedItem);
            string selectedProgram = this.cmbProgram_CreateSession.GetItemText(this.cmbProgram_CreateSession.SelectedItem);
            string selectedGroup = this.cmbGroup_CreateSession.GetItemText(this.cmbGroup_CreateSession.SelectedItem);
            string selectedSubGroup = this.cmbSubGroup_CreateSession.GetItemText(this.cmbSubGroup_CreateSession.SelectedItem);
            string selectedSubjectId = this.cmbSubject_CreateSession.GetItemText(this.cmbSubject_CreateSession.SelectedItem);


            string noOfStudents = txtNoOfStudents_CreateSession.Text;
            string sessionDuration = txtDuration_CreateSession.Text;


            double numberDur;
            int numberStd;

            if (sessionId.Equals(""))
            {
                MessageBox.Show("Please enter session ID");
            }
            else if (selectedTag.Equals(""))
            {
                MessageBox.Show("Please select a tag");
            }
            else if (selectedYear.Equals(""))
            {
                MessageBox.Show("Please select the year");
            }
            else if (selectedSemester.Equals(""))
            {
                MessageBox.Show("Please select the semester");
            }
            else if (selectedProgram.Equals(""))
            {
                MessageBox.Show("Please select the program");
            }
            else if (selectedGroup.Equals(""))
            {
                MessageBox.Show("Please select the group");
            }
            else if (selectedSubGroup.Equals(""))
            {
                MessageBox.Show("Please select the sub group");
            }
            else if (selectedSubjectId.Equals(""))
            {
                MessageBox.Show("Please select the subject ");
            }
            else if (noOfStudents.Equals(""))
            {
                MessageBox.Show("Please enter number of students");
            }else if (!Int32.TryParse(noOfStudents, out numberStd))
            {
                MessageBox.Show("Number of students must be a valid number");
            }
            else if (sessionDuration.Equals(""))
            {
                MessageBox.Show("Please enter session duration");
            }
            else if (!Double.TryParse(sessionDuration, out numberDur))
            {
                MessageBox.Show("Session duration must be a number");
            }
            else
            {
                //Add to db
                addSessionToDB();
            }
        }

        private void addSessionToDB()
        {
            string sessionId = txtSessionID_CreateSession.Text;

            string tag = this.cmbTag_CreateSession.GetItemText(this.cmbTag_CreateSession.SelectedItem);
            string year = this.cmbYear_CreateSession.GetItemText(this.cmbYear_CreateSession.SelectedItem);
            string semester = this.cmbSemester_CreateSession.GetItemText(this.cmbSemester_CreateSession.SelectedItem);
            string program = this.cmbProgram_CreateSession.GetItemText(this.cmbProgram_CreateSession.SelectedItem);
            string group = this.cmbGroup_CreateSession.GetItemText(this.cmbGroup_CreateSession.SelectedItem);
            string subGroup = this.cmbSubGroup_CreateSession.GetItemText(this.cmbSubGroup_CreateSession.SelectedItem);
            string subjectId = this.cmbSubject_CreateSession.GetItemText(this.cmbSubject_CreateSession.SelectedItem);


            string[] lines = subjectId.Split(new string[] { " - " }, StringSplitOptions.None);

            subjectId = lines[0];

            string noOfStudents = txtNoOfStudents_CreateSession.Text;
            string sessionDuration = txtDuration_CreateSession.Text;

            //selectedLecturersListForCreateSession

            int yearNum;
            int semesterNum;
            int groupNum;
            int subGroupNum;
            int noOfStudentsNum;
            double sessionDurationNum;

            bool success1 = Int32.TryParse(year, out yearNum);
            bool success2 = Int32.TryParse(semester, out semesterNum);
            bool success3 = Int32.TryParse(group, out groupNum);
            bool success4 = Int32.TryParse(subGroup, out subGroupNum);
            bool success5 = Int32.TryParse(noOfStudents, out noOfStudentsNum);
            bool success6 = Double.TryParse(sessionDuration, out sessionDurationNum);


            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            using var con = new SQLiteConnection(cs);
            con.Open();

            //Create session table if not exist
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE TABLE  IF NOT EXISTS session (
                                    sessionId               STRING PRIMARY KEY,
	                                tag                     TEXT,
	                                year                    INTEGER,
	                                semester                INTEGER,
                                    program                 TEXT,
                                    groupId                   INTEGER,
                                    subGroupId                INTEGER,
                                    subjectId               TEXT,
                                    noOfStudents            INTEGER,
                                    sessionDuration         DOUBLE 
                )";
            cmd.ExecuteNonQuery();

            using var cmd1 = new SQLiteCommand(con);

            cmd1.CommandText = "INSERT INTO session VALUES" +
                "(@sessionId, @tag, @year, @semester, @program, @groupId, @subGroupId, @subjectId, @noOfStudents, @sessionDuration)";

            cmd1.Parameters.AddWithValue("@sessionId", sessionId);
            cmd1.Parameters.AddWithValue("@tag", tag);
            cmd1.Parameters.AddWithValue("@year", yearNum);
            cmd1.Parameters.AddWithValue("@semester", semesterNum);
            cmd1.Parameters.AddWithValue("@program", program);
            cmd1.Parameters.AddWithValue("@groupId", groupNum);
            cmd1.Parameters.AddWithValue("@subGroupId", subGroupNum);
            cmd1.Parameters.AddWithValue("@subjectId", subjectId);
            cmd1.Parameters.AddWithValue("@noOfStudents", noOfStudentsNum);
            cmd1.Parameters.AddWithValue("@sessionDuration", sessionDurationNum);

            cmd1.Prepare();
            bool addSessionOK = true;
            try
            { 
                cmd1.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("Session Already created");
                    addSessionOK = false;
                }
            }


            //Adding Lecturers

            if(addSessionOK == true)
            {
                //Create session table if not exist
                using var cmdLec = new SQLiteCommand(con);

                cmdLec.CommandText = @"CREATE TABLE  IF NOT EXISTS session_lecturers (
                                    sessionId   TEXT,
	                                lecturerID  INTEGER
                                    
                )";
                cmdLec.ExecuteNonQuery();

                foreach (Lecturer element in selectedLecturersListForCreateSession)
                {

                    using var cmdLecAdd = new SQLiteCommand(con);

                    cmdLecAdd.CommandText = "INSERT INTO session_lecturers VALUES" +
                        "(@sessionId, @lecturerID)";

                    cmdLecAdd.Parameters.AddWithValue("@sessionId", sessionId);
                    cmdLecAdd.Parameters.AddWithValue("@lecturerID", element.lecturerID);

                    cmdLecAdd.Prepare();
                    cmdLecAdd.ExecuteNonQuery();
                }
                MessageBox.Show("Session Created Successfully");
                this.Hide();
                GenerateReportDashboard obj = new GenerateReportDashboard();
                obj.Show();
            }
           

           
            con.Close();

            

        }

        private void cmbProgram_CreateSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = this.cmbYear_CreateSession.GetItemText(this.cmbYear_CreateSession.SelectedItem);
            string selectedSemester = this.cmbSemester_CreateSession.GetItemText(this.cmbSemester_CreateSession.SelectedItem);

            string selectedProgram = this.cmbProgram_CreateSession.GetItemText(this.cmbProgram_CreateSession.SelectedItem); ;
            
            fillSubjectAccordingToProgram_Year_Semester(selectedProgram, selectedYear, selectedSemester);
            //fillGroupNumbers(selectedProgram, selectedYear, selectedSemester);
        }

        private void fillGroupNumbers(string selectedProgram, string selectedYear, string selectedSemester)
        {

            string year = "Year "+ selectedYear;
            string semester =  "Semester "+ selectedSemester;

            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            using var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "select " +
                    "s.group_no AS Group_No " +
                    " from year_semester s" +
                    " where s.year = '" + year + "' AND s.semester = '" + semester + "' AND s.programe = '" + selectedProgram + "'";

            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string groupNo = $@"{ rdr.GetString(0),-8}";

                cmbGroup_CreateSession.Items.Add(groupNo);
            }

            con.Close();
        }

        private void fillSubjectAccordingToProgram_Year_Semester(string selectedProgram, string selectedYear, string selectedSemester)
        {

            int selectedYearNum;
            int selectedSemesterNum;

            bool success1 = Int32.TryParse(selectedYear, out selectedYearNum);
            bool success2 = Int32.TryParse(selectedSemester, out selectedSemesterNum);

            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            using var con = new SQLiteConnection(cs);
            con.Open();
            string stm  = "select " +
                    "s.subjectCode AS Subject_Code ," +
                    "s.subjectName AS Subject_Name " +
                    " from subjects s" +
                    " where s.program = '"+selectedProgram+ "' AND s.offeredYear = " + selectedYearNum + " AND s.offeredSemester = "+ selectedSemesterNum + "";
            
            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string subjectCode = $@"{ rdr.GetString(0),-8}";
                string subjectName = $@"{ rdr.GetString(1),-8}";

                string generatedCode = subjectCode.Trim() + " - " + subjectName.Trim(); ;
                cmbSubject_CreateSession.Items.Add(generatedCode);
            }

            //#####
            /*
                        string yr = "Year " + selectedYear;
                        string sem = "Semester " + selectedSemester;

                         stm = "select " +
                                "s.group_no AS Group_No " +
                                " from year_semester s" +
                                " where s.year = '" + yr + "' AND s.semester = '" + sem + "' AND s.programe = '" + selectedProgram + "'";

                        using var cmd1 = new SQLiteCommand(stm, con);
                        using SQLiteDataReader rdr1 = cmd1.ExecuteReader();

                        while (rdr1.Read())
                        {

                            int group = Int32.Parse($@"{rdr.GetInt32(0),-3}");


                            cmbGroup_CreateSession.Items.Add(group.ToString());
                        }
            */
            cmbGroup_CreateSession.Items.Add("1");
            cmbGroup_CreateSession.Items.Add("2");
            cmbGroup_CreateSession.Items.Add("3");

            cmbSubGroup_CreateSession.Items.Add("1");
            cmbSubGroup_CreateSession.Items.Add("2");

            con.Close();
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {

            string sessionId = txtSessionID_CreateSession.Text;

            string selectedTag = this.cmbTag_CreateSession.GetItemText(this.cmbTag_CreateSession.SelectedItem);
            string selectedYear = this.cmbYear_CreateSession.GetItemText(this.cmbYear_CreateSession.SelectedItem);
            string selectedSemester = this.cmbSemester_CreateSession.GetItemText(this.cmbSemester_CreateSession.SelectedItem);
            string selectedProgram = this.cmbProgram_CreateSession.GetItemText(this.cmbProgram_CreateSession.SelectedItem);
            string selectedGroup = this.cmbGroup_CreateSession.GetItemText(this.cmbGroup_CreateSession.SelectedItem);
            string selectedSubGroup = this.cmbSubGroup_CreateSession.GetItemText(this.cmbSubGroup_CreateSession.SelectedItem);
            string selectedSubjectId = this.cmbSubject_CreateSession.GetItemText(this.cmbSubject_CreateSession.SelectedItem);


            string noOfStudents = txtNoOfStudents_CreateSession.Text;
            string sessionDuration = txtDuration_CreateSession.Text;


            double numberDur;
            int numberStd;

            if (sessionId.Equals(""))
            {
                MessageBox.Show("Please enter session ID");
            }
            else if (selectedTag.Equals(""))
            {
                MessageBox.Show("Please select a tag");
            }
            else if (selectedYear.Equals(""))
            {
                MessageBox.Show("Please select the year");
            }
            else if (selectedSemester.Equals(""))
            {
                MessageBox.Show("Please select the semester");
            }
            else if (selectedProgram.Equals(""))
            {
                MessageBox.Show("Please select the program");
            }
            else if (selectedGroup.Equals(""))
            {
                MessageBox.Show("Please select the group");
            }
            else if (selectedSubGroup.Equals(""))
            {
                MessageBox.Show("Please select the sub group");
            }
            else if (selectedSubjectId.Equals(""))
            {
                MessageBox.Show("Please select the subject ");
            }
            else if (noOfStudents.Equals(""))
            {
                MessageBox.Show("Please enter number of students");
            }
            else if (!Int32.TryParse(noOfStudents, out numberStd))
            {
                MessageBox.Show("Number of students must be a valid number");
            }
            else if (sessionDuration.Equals(""))
            {
                MessageBox.Show("Please enter session duration");
            }
            else if (!Double.TryParse(sessionDuration, out numberDur))
            {
                MessageBox.Show("Session duration must be a number");
            }else if(selectedLecturersListForCreateSession.Count == 0)
            {
                MessageBox.Show("Please add lecturers");
            }
            else
            {
                //set session id
                lblSessionID_CreateSession_Summary.Text = txtSessionID_CreateSession.Text;

                //set subject
                string[] lines = this.cmbSubject_CreateSession.GetItemText(this.cmbSubject_CreateSession.SelectedItem).ToString().Split(new string[] { " - " }, StringSplitOptions.None);
                string finalStr = lines[1] + " ( " + lines[0] + " ) ";
                lblSubject_CreateSession_summary.Text = finalStr;

                //Set tag
                lblTag_CreateSession_Summary.Text = this.cmbTag_CreateSession.GetItemText(this.cmbTag_CreateSession.SelectedItem);

                //Generate Count and Hours
                string countAndHours = txtNoOfStudents_CreateSession.Text + " ( " + txtDuration_CreateSession.Text + " ) ";
                lblCountAndHrs_CreateSession.Text = countAndHours;

                //Generate Summary of group

                string year = this.cmbYear_CreateSession.GetItemText(this.cmbYear_CreateSession.SelectedItem);
                string semester = this.cmbSemester_CreateSession.GetItemText(this.cmbSemester_CreateSession.SelectedItem);
                string prog = this.cmbProgram_CreateSession.GetItemText(this.cmbProgram_CreateSession.SelectedItem);
                string gr = this.cmbGroup_CreateSession.GetItemText(this.cmbGroup_CreateSession.SelectedItem);

                string fullString = "Y" + year + ".S" + semester + "." + prog + "." + gr;
                lblStudentCreateSessionSummary_CreateSession.Text = fullString;
            }

        }

        private void btnRefresh_SessionManagement_Click(object sender, EventArgs e)
        {

            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(cs);

            System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(
                "select session.sessionId AS SessionId ,session.tag AS Tag ,session.year AS Year ,session.semester AS Semester ,session.program AS Program ,session.groupId AS Group_Id ,session.subGroupId AS SubGroup_Id ,session.subjectId AS Subject_Id ,session.noOfStudents AS No_of_Students ,session.sessionDuration AS Hours from session"
                );

            cmd.Connection = conn;

            conn.Open();

            System.Data.SQLite.SQLiteDataAdapter da = new System.Data.SQLite.SQLiteDataAdapter(cmd);
            System.Data.DataSet ds = new System.Data.DataSet();

            DataTable dt = new DataTable();
            da.Fill(dt);

            manageSessionGridView.DataSource = dt;
 


            using var cmdCreateSubject = new SQLiteCommand(conn);

            cmdCreateSubject.CommandText = @"CREATE TABLE  IF NOT EXISTS session (
                                    sessionId               STRING PRIMARY KEY,
	                                tag                     TEXT,
	                                year                    INTEGER,
	                                semester                INTEGER,
                                    program                 TEXT,
                                    groupId                   INTEGER,
                                    subGroupId                INTEGER,
                                    subjectId               TEXT,
                                    noOfStudents            INTEGER,
                                    sessionDuration         DOUBLE 
                )";
            cmdCreateSubject.ExecuteNonQuery();



            //Create session table if not exist
            using var cmdLec = new SQLiteCommand(conn);

            cmdLec.CommandText = @"CREATE TABLE  IF NOT EXISTS session_lecturers (
                                    sessionId   TEXT,
	                                lecturerID  INTEGER
                                    
                )";
            cmdLec.ExecuteNonQuery();
            conn.Close();

           
        }

        private void manageSessionGridView_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = manageSessionGridView.CurrentCell.RowIndex;
            int columnindex = manageSessionGridView.CurrentCell.ColumnIndex;

            string a  = manageSessionGridView.Rows[rowindex].Cells[columnindex].Value.ToString();
        }

        private void manageSessionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = manageSessionGridView.CurrentCell.RowIndex;
          
            string sessionId = manageSessionGridView.Rows[rowindex].Cells[0].Value.ToString();
            sessionId = sessionId.Trim();
            loadLecturersAndFillImageGrid_SessionManagement(sessionId);
        }

        private void loadLecturersAndFillImageGrid_SessionManagement(string sessionId)
        {
            List<string> lecList = new List<string>();
            lecList = loadLecturerIdsBysessionID(sessionId);

            List<Lecturer> lecListFull = new List<Lecturer>();

            lecListFull = getLecturerObjectListByProvindingLecturerIDList(lecList);

            drawLecturersInGridView_ManageSession(lecListFull);
        }

        private void drawLecturersInGridView_ManageSession(List<Lecturer> lecListFull)
        {
            this.imgLecGridView.Rows.Clear();

            foreach(Lecturer element in lecListFull)
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.DefaultCellStyle.NullValue = null;
                imgLecGridView.Columns.Add(imgCol);
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            List<Object> temp = new List<object>();
            foreach (Lecturer element in lecListFull)
            {
                string photoPath = element.photoPath;
                Image img = Image.FromFile(@"" + photoPath);
                temp.Add(img);
                Object[] row = temp.Cast<object>().ToArray();
                imgDataGridView_CreateSession.Rows.Add(row);
            }


            /*
            if (this.imgDataGridView_CreateSession.Columns.Count < 3)
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.DefaultCellStyle.NullValue = null;
                imgDataGridView_CreateSession.Columns.Add(imgCol);
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            imgDataGridView_CreateSession.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            List<Object> temp = new List<object>();
            for (int i = 0; i < selectedLecturersListForCreateSession.Count; i++)
            {
                string photoPath = selectedLecturersListForCreateSession[i].photoPath;
                Image img = Image.FromFile(@"" + photoPath);
                temp.Add(img);
                if ((i + 1) % 3 == 0)
                {
                    Object[] row = temp.Cast<object>().ToArray();
                    imgDataGridView_CreateSession.Rows.Add(row);
                    temp = new List<object>();
                }
            }
            if (temp.Count > 0)
            {
                imgDataGridView_CreateSession.Rows.Add(temp.Cast<object>().ToArray());
            }

            */




        }

        private List<string> loadLecturerIdsBysessionID(string sessionId)
        {
            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            using var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "";

            stm = "SELECT lecturerID FROM session_lecturers WHERE sessionId='"+ sessionId + "'";

            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            List<string> foundLecturers = new List<string>();

            while (rdr.Read())
            {

                // Console.WriteLine($@"{rdr.GetInt32(0),-3} {rdr.GetString(1),-8} {rdr.GetInt32(2),8}");
                string lecID = ($@"{ rdr.GetInt32(0), -8 }");


                foundLecturers.Add(lecID);
            }
            con.Close();
            return foundLecturers;
        }

       

    }
}
