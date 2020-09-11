using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Timetable_Management_System
{
    public partial class ManageTagsDashboard : Form
    {
        public ManageTagsDashboard()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            this.WindowState = FormWindowState.Maximized;
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void ManageTagsDashboard_Load(object sender, EventArgs e)
        {
            createTagsTableIfEmpty();

            LoadTags();
        }

        // Create "tags" table if not exists
        private void createTagsTableIfEmpty()
        {
            string cs = @"URI=file:.\timetableManagementSystemDB.db";

            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE TABLE  IF NOT EXISTS tags (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                tag TEXT
                )";
            cmd.ExecuteNonQuery();
        }
        //set connection
        private void setConnection()
        {
            sql_con = new SQLiteConnection(@"URI=file:.\timetableManagementSystemDB.db");
        }
        private void LoadTags()
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT * FROM tags";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }
        //set executequery
        private void ExecuteQuery(string txtQuery)
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //add tag
        private void button1_Click(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO tags (tag) VALUES('" + textBox1.Text + "')";
            ExecuteQuery(txtQuery);
            LoadTags();
        }

        //edit tag
        private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE tags SET year='" + lblManageTags.Text + "' WHERE id ='" + Convert.ToInt32(lblManageTags.Text) + "'";
            ExecuteQuery(txtQuery);
            LoadTags();
        }
        //del tag
        private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM tags WHERE id='" + Convert.ToInt32(lblManageTags.Text) + "'";
            ExecuteQuery(txtQuery);
            LoadTags();
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

        private void ManageTags_Click(object sender, EventArgs e)
        {

        }

        private void lblManageTags_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblManageTags.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "INSERT INTO tags (tag) VALUES('" + textBox1.Text + "')";
            ExecuteQuery(txtQuery);
            LoadTags();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE tags SET tag='" + textBox1.Text + "' WHERE id ='" + Convert.ToInt32(lblManageTags.Text) + "'";
            ExecuteQuery(txtQuery);
            LoadTags();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "DELETE FROM tags WHERE id='" + Convert.ToInt32(lblManageTags.Text) + "'";
            ExecuteQuery(txtQuery);
            LoadTags();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
