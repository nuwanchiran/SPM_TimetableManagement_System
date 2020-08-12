using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable_Management_System
{
    public partial class ManageSubjectsDashboard : Form
    {
        String[] tagsList; 
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
            //MessageBox.Show(needCloseType + " close");

            for (int i = 0; i < tagsList.Length; i++)
            {
                if(tagsList[i].Equals(needCloseType)){
                    closedTags_Add.Add(needCloseType);
                }
            }


            String[] closedTagsArray_Add = new String[closedTags_Add.Count];
            closedTags_Add.CopyTo(closedTagsArray_Add);


             for(int i=0; i< closedTagsArray_Add.Length; i++)
             {
                string btnName = "btn" + closedTagsArray_Add[i] + "Close_Add";
                string txtName = "txt" + closedTagsArray_Add[i] + "Hrs_Add";

                Button btn = null;
                TextBox txt = null;

                if (AddSubject.Controls.ContainsKey(btnName))
                {
                    btn = AddSubject.Controls[btnName] as Button;
                    txt = AddSubject.Controls[txtName] as TextBox;
               //     btn.Enabled = false;
                    txt.Enabled = false;
                }



            }
            
        }

        /*
        private void addToUniqueArray_closedTags_Add(string needCloseType)
        {
            bool alreadyAvailable = false;
            for(int i = 0; i< closedTags_Add.Length;i++)
            {
                if (closedTags_Add[i].Equals(needCloseType))
                {
                    alreadyAvailable = true;
                }
            }
            if (alreadyAvailable = false)
            {
                closedTags_Add
            }
        }
        */



        /*
        private void CloseButtonClick_Add(object sender, EventArgs e)
        {
        MessageBox.Show("");
        }
        */

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
