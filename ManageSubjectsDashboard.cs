using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using Timetable_Management_System.src;
using Timetable_Management_System.src.Models;

namespace Timetable_Management_System
{
    public partial class ManageSubjectsDashboard : Form
    {
        String[] tagsList;

        Dictionary<string, bool> closeButtonClickStatus_Add = new Dictionary<string, bool>();

        public ManageSubjectsDashboard()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            this.WindowState = FormWindowState.Maximized;
        }

        private void ManageSubjectsDashboard_Load(object sender, EventArgs e)
        {

            //Add
            List<string> loadedTagsList = loadTags();


            tagsList = loadedTagsList.ToArray();

            for(int i=0; i< tagsList.Length; i++)
            {
                //closeButtonClickStatus_Add.Add(tagsList[i], true);
                closeButtonClickStatus_Add[tagsList[i]] = true;
            }
           

            drawTagsInSubject_Add(loadedTagsList);
            chkParallelSubject_Add.Checked = true;
            chkParallelSubject_Add.Checked = false;
            loadYearAndSemester_Add();
        }

        private void loadYearAndSemester_Add()
        {
            cmbOfferedYear_Add.Items.Clear();
            cmbSemester_Add.Items.Clear();

            List<int> yearsList = new List<int>();
            List<int> semestersList = new List<int>();

            //Todo
            yearsList.Add(1);
            yearsList.Add(2);
            yearsList.Add(3);
            yearsList.Add(4);

            //Todo
            semestersList.Add(1);
            semestersList.Add(2);

            for (int i=0;i<yearsList.Count; i++)
            {
                cmbOfferedYear_Add.Items.Add(yearsList[i]);
            }

            for (int i = 0; i < semestersList.Count; i++)
            {
                cmbSemester_Add.Items.Add(semestersList[i]);
            }
        }

        private void drawTagsInSubject_Add(List<string> loadedTagsList)
        {
           
           
            int initialLocation = 250;
            for(int i=0;i< tagsList.Length; i++)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(110, initialLocation);
                label.Size = new System.Drawing.Size(80, 20);
                label.Name = "lbl"+ tagsList[i]+"_Add";
                label.Text = tagsList[i]+"";
                AddSubject.Controls.Add(label);
                initialLocation = initialLocation + 30;
            }
            
            initialLocation = 250;

            for (int i = 0; i < tagsList.Length; i++)
            {
                TextBox textbox = new TextBox();
                textbox.Location = new System.Drawing.Point(200, initialLocation);
                textbox.Size = new System.Drawing.Size(80, 20);
                textbox.Name = "txt" + tagsList[i] + "Hrs_Add";
                textbox.Text = "";
                AddSubject.Controls.Add(textbox);
                initialLocation = initialLocation + 30;
            }

            initialLocation = 250;

            for (int i = 0; i < tagsList.Length; i++)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(300, initialLocation);
                lbl.Size = new System.Drawing.Size(50, 20);
                lbl.Name = "lbl" + tagsList[i] + "Hours_Add";
                lbl.Text = "hours";
                AddSubject.Controls.Add(lbl);
                initialLocation = initialLocation + 30;
            }

            initialLocation = 250;

            for (int i = 0; i < tagsList.Length; i++)
            {
                Button closeBtn = new Button();
                closeBtn.Location = new System.Drawing.Point(370, initialLocation);
                closeBtn.Size = new System.Drawing.Size(20, 20);
                closeBtn.Name = "btn" + tagsList[i] + "Close_Add";
                //closeBtn.Click += new EventHandler(CloseButtonClick_Add(tagsList[i]));
                string temp = tagsList[i] + "";
                closeBtn.Click += (se, ev) => button_Click(se, ev, temp);
                closeBtn.Text = "X";
                AddSubject.Controls.Add(closeBtn);
                initialLocation = initialLocation + 30;
            }

        }

        // String[] closedTags_Add;
        HashSet<string> closedTags_Add = new HashSet<string>();
        

        private void button_Click(object se, EventArgs ev, string needCloseType)
        {
            //check  if clicked item is already available
            //then remove

            foreach (var item in closeButtonClickStatus_Add)
            {

                if (item.Key.Equals(needCloseType))
                {
                    closeButtonClickStatus_Add[needCloseType] = !(item.Value);
                    break;
                }
            }


            foreach (var item in closeButtonClickStatus_Add)
            {

                //item.Key
                 if(item.Value == false)
                {
                    string btnName = "btn" + item.Key + "Close_Add";
                    string txtName = "txt" + item.Key + "Hrs_Add";

                    Button btn = null;
                    TextBox txt = null;

                    if (AddSubject.Controls.ContainsKey(btnName))
                    {
                        btn = AddSubject.Controls[btnName] as Button;
                        txt = AddSubject.Controls[txtName] as TextBox;
                        //     btn.Enabled = false;
                        txt.Enabled = false;
                    }
                }else if (item.Value == true){
                    string btnName = "btn" + item.Key + "Close_Add";
                    string txtName = "txt" + item.Key + "Hrs_Add";

                    Button btn = null;
                    TextBox txt = null;

                    if (AddSubject.Controls.ContainsKey(btnName))
                    {
                        btn = AddSubject.Controls[btnName] as Button;
                        txt = AddSubject.Controls[txtName] as TextBox;
                        //     btn.Enabled = false;
                        txt.Enabled = true;
                    }
                }

            }

        }


        private List<string> loadTags()
        {
            //Load tags from tags table
            //To Do

            List<string> tempTagsList = new List<string>();
            tempTagsList.Add("Lecture");
            tempTagsList.Add("Tutorial");
            tempTagsList.Add("Lab");
            tempTagsList.Add("Evaluation");

            return tempTagsList;
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

     

        private void btnAddSubject_Add_Click(object sender, EventArgs e)
        {

            Subject subjectObj = new Subject();
            
            List<Subject_Tags> subjectTagsListObj = new List<Subject_Tags>();


            int selectedYear_Add=1;
            bool yearSuccess_Add = Int32.TryParse(this.cmbOfferedYear_Add.GetItemText(this.cmbOfferedYear_Add.SelectedItem), out selectedYear_Add);

            int selectedSemester_Add = 1;
            bool semesterSuccess_Add = Int32.TryParse(this.cmbSemester_Add.GetItemText(this.cmbSemester_Add.SelectedItem), out selectedSemester_Add);

            subjectObj.offeredYear = selectedYear_Add;
            subjectObj.offeredSemester = selectedSemester_Add;
            subjectObj.subjectCode = txtSubjectCode_Add.Text;
            subjectObj.subjectName = txtSubjectName_Add.Text;

            if (chkParallelSubject_Add.Checked == true)
            {
                subjectObj.isParallel = true;
                subjectObj.category = txtCategory_Add.Text;
            }
            else if (chkParallelSubject_Add.Checked == false)
            {
                subjectObj.isParallel = false;
                subjectObj.category = "N/A";
            }



            

            foreach (var item in closeButtonClickStatus_Add)
            {
                if(item.Value==true)
                {
                    Subject_Tags subject_TagsObj = new Subject_Tags();
                    string txtName = "txt" + item.Key + "Hrs_Add";
                    TextBox txt = null;
                    txt = AddSubject.Controls[txtName] as TextBox;
                    //txt.Text
                    //item.Key
                    
                    subject_TagsObj.subjectCode = txtSubjectCode_Add.Text;
                    subject_TagsObj.tag = item.Key;
                    subject_TagsObj.hrs = double.Parse(txt.Text, System.Globalization.CultureInfo.InvariantCulture) ;

                    subjectTagsListObj.Add(subject_TagsObj);
                    

                }
            }

            AddsubjectToDB(subjectObj, subjectTagsListObj);
        }

        private void AddsubjectToDB(Subject subjectObj, List<Subject_Tags> subjectTagsListObj)
        {
            string cs = @"URI=file:.\" + Utils.dbName + ".db";

            using var con = new SQLiteConnection(cs);
            con.Open();


    

            //Adding subject
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE TABLE  IF NOT EXISTS subjects (
                                    subjectCode STRING PRIMARY KEY,
	                                subjectName TEXT,
	                                offeredYear INTEGER,
	                                offeredSemester INTEGER,
	                                isParallel BOOLEAN,
	                                category TEXT
                )";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO subjects VALUES" +
                "(@subjectCode, @subjectName, @offeredYear, @offeredSemester, @isParallel, @category)";

            cmd.Parameters.AddWithValue("@subjectCode", subjectObj.subjectCode);
            cmd.Parameters.AddWithValue("@subjectName", subjectObj.subjectName);
            cmd.Parameters.AddWithValue("@offeredYear", subjectObj.offeredYear);
            cmd.Parameters.AddWithValue("@offeredSemester", subjectObj.offeredSemester);
            cmd.Parameters.AddWithValue("@isParallel", subjectObj.isParallel);
            cmd.Parameters.AddWithValue("@category", subjectObj.category);
          
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            //Adding subject_tag mapping
            foreach (Subject_Tags subject_TagsObj in subjectTagsListObj) // Loop through List with foreach
            {
                using var cmd1 = new SQLiteCommand(con);

                cmd1.CommandText = @"CREATE TABLE  IF NOT EXISTS subjects_tags (
           
                                        subjectCode STRING ,
	                                    tag STRING,
	                                    hrs DOUBLE,

	                                    PRIMARY KEY (subjectCode ,tag )
                )";
                cmd1.ExecuteNonQuery();

                cmd1.CommandText = "INSERT INTO subjects_tags VALUES" +
                    "(@subjectCodeM, @tag, @hrs)";

                cmd1.Parameters.AddWithValue("@subjectCodeM", subject_TagsObj.subjectCode);
                cmd1.Parameters.AddWithValue("@tag", subject_TagsObj.tag);
                cmd1.Parameters.AddWithValue("@hrs", subject_TagsObj.hrs);

                cmd1.Prepare();

                cmd1.ExecuteNonQuery();
            }
            con.Close();

            MessageBox.Show("Subject Added", "Success");
        }

        private void chkParallelSubject_Add_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParallelSubject_Add.Checked == true){
                categorySetVisible();
            }else if(chkParallelSubject_Add.Checked == false){
                categorySetInvisible();
            }


        }

        private void categorySetInvisible()
        {
            lblCategory_Add.Visible = false;
            txtCategory_Add.Visible = false;
        }

        private void categorySetVisible()
        {
            lblCategory_Add.Visible = true;
            txtCategory_Add.Visible = true;


        }


    }
}
