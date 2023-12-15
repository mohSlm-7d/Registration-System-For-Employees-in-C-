/*Mohammad Salman - 20190901
  Rakan Abzakh - 
  Alaa Mdenat  -    
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; //SQL Connector
using System.IO;

namespace Registration_System
{
    public partial class RegistrationForm : Form
    {
        private string ID;
        private string CID;
        private string Name;
        private int BirthYear;
        private string Gender;
        private int CreditHrs;
        private bool Enroll = true;
        private bool EnrollComboBox = false;
        // creating DB variables
        SQLiteConnection con = new SQLiteConnection("Data Source=Registration.db;Version=3;");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt;
        SQLiteDataReader dr;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void StdRegExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Confirm == DialogResult.OK)
                Application.Exit();
           
        }

        private void CourseRegExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Confirm == DialogResult.OK)
                Application.Exit();
        }

        private void EnrollExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Confirm == DialogResult.OK)
                Application.Exit();
        }

        private void GradesExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Confirm == DialogResult.OK)
                Application.Exit();
        }
        private void AddStdButton_Click(object sender, EventArgs e)
        {     
            if (StdIDTextBox.Text != "" && StdNameTextBox.Text != "" && (MaleRadioButton.Checked || FemaleRadioButton.Checked))
            {
                if (DateTime.Now.Year - BirthDateTimePicker.Value.Year >= 18)
                {
                    try
                    {
                        Name = StdNameTextBox.Text;
                        ID = StdIDTextBox.Text;
                        BirthYear = BirthDateTimePicker.Value.Year;
                        if (MaleRadioButton.Checked)
                            Gender = "M";
                        else
                            Gender = "F";
                        Student NewStd = new Student(ID, Name, Gender, BirthYear);

                        // 1- Open the connection to DB
                        con.Open();
                        // 2- Build Command Text
                        cmd.Connection = con; // set the connection to instance of SqlCommand 
                        cmd.CommandText = "Insert Into Students (ID, name, gender, birthyear)" +
                            "values (@stid, @stname, @stgender, @birthYear)";
                        cmd.Parameters.AddWithValue("stid", NewStd.GetID());
                        cmd.Parameters.AddWithValue("stname", NewStd.GetName());
                        cmd.Parameters.AddWithValue("stgender", NewStd.GetGender());
                        cmd.Parameters.AddWithValue("birthYear", NewStd.GetBirthYear());

                        // 3- execute the command
                        cmd.ExecuteNonQuery();
                        // 4- close DB connection
                        con.Close();

                        MessageBox.Show("Student has been added successfully", "Student Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Exception Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The student age has to be at least 18!", "Incorrect age Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill all information fields with the correct data!", "Incorrect Data Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (CourseIDTextBox.Text != "" && CourseNameTextBox.Text!="")
            {
                try
                {
                    Name = CourseNameTextBox.Text;
                    ID = CourseIDTextBox.Text;
                    CreditHrs = int.Parse(CreditNumericUpDown.Value.ToString());
                    Course NewCourse = new Course(ID, Name, CreditHrs);

                    // 1- Open the connection to DB
                    con.Open();

                    // 2- Build Command Text
                    cmd.Connection = con; // set the connection to instance of SqlCommand 
                    cmd.CommandText = "Insert Into Courses (ID, name, CreditHrs)" +
                        "values (@cid, @cname, @CreditHrs)";

                    /*MessageBox.Show("ID: " + NewCourse.GetID());*/

                    cmd.Parameters.AddWithValue("cid", NewCourse.GetID());
                    cmd.Parameters.AddWithValue("cname", NewCourse.GetName());
                    cmd.Parameters.AddWithValue("CreditHrs", NewCourse.GetCreditHrs());


                    // 3- execute the command
                    cmd.ExecuteNonQuery();

                    // 4- close DB connection
                    con.Close();

                    MessageBox.Show("Course has been added successfully", "Course Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill all information fields with the correct data!", "Incorrect Data Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            if (Enroll)
            {
                try
                {
                    
                    ID = EnrollStdIDComboBox.SelectedValue.ToString();
                    CID = EnrollCourseIDComboBox.SelectedValue.ToString();
                    Enrollment NewEnrollment = new Enrollment(ID, CID);

                    // 1- Open the connection to DB
                    con.Open();

                    // 2- Build Command Text
                    cmd.Connection = con; // set the connection to instance of SqlCommand 
                    cmd.CommandText = "Insert Into enrollment (SID, CiD)" +
                        "values (@cid, @cname)";

                    cmd.Parameters.AddWithValue("cid", NewEnrollment.GetSID());
                    cmd.Parameters.AddWithValue("cname", NewEnrollment.GetCID());

                    // 3- execute the command
                    cmd.ExecuteNonQuery();

                    // 4- close DB connection
                    con.Close();

                    MessageBox.Show("Student has been registered in the selected course", "Student Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill all information fields with the correct data!", "Incorrect Data Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RegTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {  
                
            try
            {

                if (RegTabControl.SelectedIndex == 2)
                {
                    con.Open();
                    string StudentTable = "SELECT id FROM students ORDER BY id";
                    string CourseTable = "SELECT id FROM courses ORDER BY id";

                    cmd = new SQLiteCommand(StudentTable, con);
                    da = new SQLiteDataAdapter(StudentTable, con);

                    dt = new DataTable();
                    da.Fill(dt);


                    EnrollStdIDComboBox.DisplayMember = "id";
                    EnrollStdIDComboBox.ValueMember = "id";
                    EnrollStdIDComboBox.DataSource = dt;

                    cmd = new SQLiteCommand(CourseTable, con);
                    da = new SQLiteDataAdapter(CourseTable, con);

                    dt = new DataTable();
                    da.Fill(dt);

                    EnrollCourseIDComboBox.DisplayMember = "id";
                    EnrollCourseIDComboBox.ValueMember = "id";
                    EnrollCourseIDComboBox.DataSource = dt;

                    con.Close();
                    Enroll = true;
                }
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {           
            
            try
            {
                var writer = new StreamWriter("reg.CSV");

                
                con.Open();
                string enrollments = "SELECT sid, cid FROM enrollment ORDER BY sid";
               
                cmd = new SQLiteCommand(enrollments, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ID = dr["sid"].ToString();
                        CID = dr["cid"].ToString();
                        writer.WriteLine(ID + "," + CID + ",");
                    }                    
                }
                else
                {
                    MessageBox.Show("No Enrolled students");
                    return;
                }
                
                dr.Close();
                con.Close();
                writer.Close();
                
                System.Diagnostics.Process Reg = System.Diagnostics.Process.Start("reg.CSV");

                Reg.WaitForExit();
                MessageBox.Show("Grades have been inserted successfully!", "Grades Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);



            } catch (Exception exception)            
            {             
                MessageBox.Show(exception.Message, "Exception Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                        
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = new StreamReader("reg.csv");
                con.Open();
                while (!reader.EndOfStream){
                    string Line = reader.ReadLine();
                    string[] values = Line.Split(',');

                    cmd.Connection = con;// set the connection to instance of SqlCommand 
                    //Build Command Text
                    cmd.CommandText = "UPDATE Enrollment Set grade=@grade Where sid=@SID AND cid=@CID";

                    cmd.Parameters.AddWithValue("grade", values[2]);
                    cmd.Parameters.AddWithValue("SID", values[0]);
                    cmd.Parameters.AddWithValue("CID", values[1]);

                    //Execute the command

                    cmd.ExecuteNonQuery();
                    
                }
                con.Close();
                reader.Close();

                con.Open();
                string DGridCmd = "Select * From Enrollment Order By Sid";
                cmd = new SQLiteCommand(DGridCmd, con);
                da = new SQLiteDataAdapter(DGridCmd, con);
                da.Fill(ds, "StudentsGrades");
                GradesDataGridView.DataSource = ds.Tables["StudentsGrades"].DefaultView;
                con.Close();
                
            } catch (Exception exception) {
                MessageBox.Show(exception.Message, "Exception Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void StdRegLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegTabControl.SelectedIndex  += 1;
        }

        private void CourseTabLinkLabelPrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegTabControl.SelectedIndex -= 1;
        }

        private void CourseTabLinkLabelNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegTabControl.SelectedIndex += 1;
        }

        private void EnrollTabLinkLabelPrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegTabControl.SelectedIndex -= 1;
        }

        private void EnrollTabLinkLabelNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegTabControl.SelectedIndex += 1;
        }

        private void GradesTabLinkLabelPrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegTabControl.SelectedIndex -= 1;
        }

        private void StdClrLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StdIDTextBox.Text = "";
            StdNameTextBox.Text = "";
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
        }

        private void CourseClrLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseIDTextBox.ResetText();
            CourseNameTextBox.ResetText();
            CreditNumericUpDown.Value = 3;
        }

        private void EnrollClrLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnrollStdIDComboBox.Text = "Student ID";
            EnrollCourseIDComboBox.Text = "Course ID";
            Enroll = false;
            EnrollStdIDComboBox.ForeColor = Color.Gray;
            EnrollCourseIDComboBox.ForeColor = Color.Gray;
        }

        private void EnrollStdIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnrollStdIDComboBox.ForeColor = Color.Black;
            if (EnrollComboBox)
            {
                Enroll = true;
                EnrollComboBox = false;
            }
            else
            {
                EnrollComboBox = true;
            }
        }

        private void EnrollCourseIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnrollCourseIDComboBox.Items.Contains()
            EnrollCourseIDComboBox.ForeColor = Color.Black;
            if (EnrollComboBox)
            {
                Enroll = true;
                EnrollComboBox = false;
            }
            else
            {
                EnrollComboBox = true;
            }
        }
    }
}
