using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetable_Management_System.src;

namespace Timetable_Management_System
{
    public partial class ManageStatisticsDashboard : Form
    {
        private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter dbAdapter;

     
        public ManageStatisticsDashboard()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            this.WindowState = FormWindowState.Maximized;


        }

        private void ManageStatisticsDashboard_Load(object sender, EventArgs e)
        {
            fill_Chart_LecturerCountByProfessionalLevel();
            fill_Chart_LecturerCountByFaculty();
        }

        private void fill_Chart_LecturerCountByProfessionalLevel()
        {
            setConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            string commandText = "SELECT employeeLevel , count(*) AS lecturerCount   FROM lecturers GROUP BY employeeLevel, name;";
            dbAdapter = new SQLiteDataAdapter(commandText, sql_conn);
            DataSet lectCountsByLevel = new DataSet();
            lectCountsByLevel.Reset();
            dbAdapter.Fill(lectCountsByLevel);

            DataTable dataTable = new DataTable();
            dataTable = lectCountsByLevel.Tables[0];
            //dataTable.R
            for (int count = 0; count < dataTable.Rows.Count; count++)
            {
                // Get individual datatables here...
                DataRow dataRow = dataTable.Rows[count];
                System.Diagnostics.Debug.WriteLine(dataRow.ItemArray);
                chart_LecturerCountByProfessionalLevel.Series["Lecturer Count"].Points.AddXY(dataRow.ItemArray[0].ToString(), dataRow.ItemArray[1].ToString());
            }

            //roomsGrid.DataSource = roomsTable;
            sql_conn.Close();

 
            //chart title  
            chart_LecturerCountByProfessionalLevel.Titles.Add("Lecturer Count by Professional Level");
        }

        private void fill_Chart_LecturerCountByFaculty()
        {
            setConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            string commandText = "SELECT faculty , count(*) AS lecturerCount   FROM lecturers GROUP BY faculty";
            dbAdapter = new SQLiteDataAdapter(commandText, sql_conn);
            DataSet lectCountsByLevel = new DataSet();
            lectCountsByLevel.Reset();
            dbAdapter.Fill(lectCountsByLevel);

            DataTable dataTable = new DataTable();
            dataTable = lectCountsByLevel.Tables[0];
            //dataTable.R
            for (int count = 0; count < dataTable.Rows.Count; count++)
            {
                // Get individual datatables here...
                DataRow dataRow = dataTable.Rows[count];
                System.Diagnostics.Debug.WriteLine(dataRow.ItemArray);
                chart_lecturersByFaculty.Series["Lecturer Count"].Points.AddXY(dataRow.ItemArray[0].ToString(), dataRow.ItemArray[1].ToString());
            }

            //roomsGrid.DataSource = roomsTable;
            sql_conn.Close();


            //chart title  
            chart_lecturersByFaculty.Titles.Add("Lecturer Count by Faculty");
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LecturersStatistics_Click(object sender, EventArgs e)
        {

        }





        // Create SQLite DB Conn
        private void setConnection()
        {
            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            sql_conn = new SQLiteConnection(cs);
            //sql_conn.Open();
        }

        private void chart_lecturersByFaculty_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
