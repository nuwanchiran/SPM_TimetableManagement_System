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


     
    }
}
