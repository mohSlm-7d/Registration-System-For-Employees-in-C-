namespace Registration_System
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RegTabControl = new System.Windows.Forms.TabControl();
            this.StudentTabPage = new System.Windows.Forms.TabPage();
            this.StdRegLinkLabel = new System.Windows.Forms.LinkLabel();
            this.lblStudent = new System.Windows.Forms.Label();
            this.StdRegExitButton = new System.Windows.Forms.Button();
            this.StdRegPanel = new System.Windows.Forms.Panel();
            this.StdClrLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddStdButton = new System.Windows.Forms.Button();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.StdIDTextBox = new System.Windows.Forms.TextBox();
            this.StdIDLabel = new System.Windows.Forms.Label();
            this.StdNameTextBox = new System.Windows.Forms.TextBox();
            this.StdNameLabel = new System.Windows.Forms.Label();
            this.PSUTPictureBox = new System.Windows.Forms.PictureBox();
            this.CourseTabPage = new System.Windows.Forms.TabPage();
            this.CourseTabLinkLabelPrev = new System.Windows.Forms.LinkLabel();
            this.CourseTabLinkLabelNext = new System.Windows.Forms.LinkLabel();
            this.CourseRegExitButton = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.CourseRegPanel = new System.Windows.Forms.Panel();
            this.CourseClrLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CreditNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CourseIDTextBox = new System.Windows.Forms.TextBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.CourseCrdLabel = new System.Windows.Forms.Label();
            this.CourseIDLabel = new System.Windows.Forms.Label();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EnrollTabPage = new System.Windows.Forms.TabPage();
            this.EnrollTabLinkLabelPrev = new System.Windows.Forms.LinkLabel();
            this.EnrollTabLinkLabelNext = new System.Windows.Forms.LinkLabel();
            this.lblEnrollment = new System.Windows.Forms.Label();
            this.EnrollExitButton = new System.Windows.Forms.Button();
            this.EnrollPanel = new System.Windows.Forms.Panel();
            this.EnrollClrLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EnrollCourseIDComboBox = new System.Windows.Forms.ComboBox();
            this.EnrollStdIDComboBox = new System.Windows.Forms.ComboBox();
            this.EnrollButton = new System.Windows.Forms.Button();
            this.EnrollCourseIDLabel = new System.Windows.Forms.Label();
            this.EnrollStdIDLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GradesTabPage = new System.Windows.Forms.TabPage();
            this.GradesTabLinkLabelPrev = new System.Windows.Forms.LinkLabel();
            this.lblGrades = new System.Windows.Forms.Label();
            this.GradesExitButton = new System.Windows.Forms.Button();
            this.GradesDataGridView = new System.Windows.Forms.DataGridView();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RegTabControl.SuspendLayout();
            this.StudentTabPage.SuspendLayout();
            this.StdRegPanel.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSUTPictureBox)).BeginInit();
            this.CourseTabPage.SuspendLayout();
            this.CourseRegPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.EnrollTabPage.SuspendLayout();
            this.EnrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.GradesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // RegTabControl
            // 
            this.RegTabControl.Controls.Add(this.StudentTabPage);
            this.RegTabControl.Controls.Add(this.CourseTabPage);
            this.RegTabControl.Controls.Add(this.EnrollTabPage);
            this.RegTabControl.Controls.Add(this.GradesTabPage);
            this.RegTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegTabControl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegTabControl.HotTrack = true;
            this.RegTabControl.Location = new System.Drawing.Point(0, 0);
            this.RegTabControl.Multiline = true;
            this.RegTabControl.Name = "RegTabControl";
            this.RegTabControl.SelectedIndex = 0;
            this.RegTabControl.Size = new System.Drawing.Size(493, 407);
            this.RegTabControl.TabIndex = 0;
            this.RegTabControl.SelectedIndexChanged += new System.EventHandler(this.RegTabControl_SelectedIndexChanged);
            // 
            // StudentTabPage
            // 
            this.StudentTabPage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StudentTabPage.Controls.Add(this.StdRegLinkLabel);
            this.StudentTabPage.Controls.Add(this.lblStudent);
            this.StudentTabPage.Controls.Add(this.StdRegExitButton);
            this.StudentTabPage.Controls.Add(this.StdRegPanel);
            this.StudentTabPage.Controls.Add(this.PSUTPictureBox);
            this.StudentTabPage.Location = new System.Drawing.Point(4, 22);
            this.StudentTabPage.Name = "StudentTabPage";
            this.StudentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentTabPage.Size = new System.Drawing.Size(485, 381);
            this.StudentTabPage.TabIndex = 0;
            this.StudentTabPage.Text = "Student Registration";
            // 
            // StdRegLinkLabel
            // 
            this.StdRegLinkLabel.AutoSize = true;
            this.StdRegLinkLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdRegLinkLabel.Location = new System.Drawing.Point(365, 277);
            this.StdRegLinkLabel.Name = "StdRegLinkLabel";
            this.StdRegLinkLabel.Size = new System.Drawing.Size(58, 13);
            this.StdRegLinkLabel.TabIndex = 13;
            this.StdRegLinkLabel.TabStop = true;
            this.StdRegLinkLabel.Text = "Next Tab";
            this.ToolTip.SetToolTip(this.StdRegLinkLabel, "Next Tab: Course Registration");
            this.StdRegLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StdRegLinkLabel_LinkClicked);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(167, 20);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(180, 29);
            this.lblStudent.TabIndex = 12;
            this.lblStudent.Text = "Add Student";
            // 
            // StdRegExitButton
            // 
            this.StdRegExitButton.BackColor = System.Drawing.Color.SlateGray;
            this.StdRegExitButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.StdRegExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.StdRegExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StdRegExitButton.Location = new System.Drawing.Point(337, 207);
            this.StdRegExitButton.Name = "StdRegExitButton";
            this.StdRegExitButton.Size = new System.Drawing.Size(122, 46);
            this.StdRegExitButton.TabIndex = 11;
            this.StdRegExitButton.Text = "Exit";
            this.ToolTip.SetToolTip(this.StdRegExitButton, "Exit App");
            this.StdRegExitButton.UseVisualStyleBackColor = false;
            this.StdRegExitButton.Click += new System.EventHandler(this.StdRegExitButton_Click);
            // 
            // StdRegPanel
            // 
            this.StdRegPanel.BackColor = System.Drawing.Color.Transparent;
            this.StdRegPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StdRegPanel.Controls.Add(this.StdClrLinkLabel);
            this.StdRegPanel.Controls.Add(this.GenderGroupBox);
            this.StdRegPanel.Controls.Add(this.BirthDateTimePicker);
            this.StdRegPanel.Controls.Add(this.AddStdButton);
            this.StdRegPanel.Controls.Add(this.BirthDateLabel);
            this.StdRegPanel.Controls.Add(this.StdIDTextBox);
            this.StdRegPanel.Controls.Add(this.StdIDLabel);
            this.StdRegPanel.Controls.Add(this.StdNameTextBox);
            this.StdRegPanel.Controls.Add(this.StdNameLabel);
            this.StdRegPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdRegPanel.ForeColor = System.Drawing.Color.Black;
            this.StdRegPanel.Location = new System.Drawing.Point(19, 61);
            this.StdRegPanel.Name = "StdRegPanel";
            this.StdRegPanel.Size = new System.Drawing.Size(295, 302);
            this.StdRegPanel.TabIndex = 0;
            // 
            // StdClrLinkLabel
            // 
            this.StdClrLinkLabel.AutoSize = true;
            this.StdClrLinkLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdClrLinkLabel.Location = new System.Drawing.Point(9, 277);
            this.StdClrLinkLabel.Name = "StdClrLinkLabel";
            this.StdClrLinkLabel.Size = new System.Drawing.Size(106, 13);
            this.StdClrLinkLabel.TabIndex = 13;
            this.StdClrLinkLabel.TabStop = true;
            this.StdClrLinkLabel.Text = "Clear my choices";
            this.StdClrLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StdClrLinkLabel_LinkClicked);
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.Location = new System.Drawing.Point(12, 151);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(234, 55);
            this.GenderGroupBox.TabIndex = 12;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender:";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(128, 23);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(66, 17);
            this.FemaleRadioButton.TabIndex = 12;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.ToolTip.SetToolTip(this.FemaleRadioButton, "Student Gender");
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(35, 23);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(51, 17);
            this.MaleRadioButton.TabIndex = 11;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.ToolTip.SetToolTip(this.MaleRadioButton, "Student Gender");
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.CustomFormat = "yyyy";
            this.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDateTimePicker.Location = new System.Drawing.Point(85, 101);
            this.BirthDateTimePicker.MaxDate = new System.DateTime(2021, 6, 4, 13, 42, 16, 0);
            this.BirthDateTimePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(161, 21);
            this.BirthDateTimePicker.TabIndex = 11;
            this.ToolTip.SetToolTip(this.BirthDateTimePicker, "Student Birth Year");
            this.BirthDateTimePicker.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            // 
            // AddStdButton
            // 
            this.AddStdButton.BackColor = System.Drawing.Color.SlateGray;
            this.AddStdButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.AddStdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.AddStdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStdButton.Location = new System.Drawing.Point(12, 231);
            this.AddStdButton.Name = "AddStdButton";
            this.AddStdButton.Size = new System.Drawing.Size(234, 33);
            this.AddStdButton.TabIndex = 9;
            this.AddStdButton.Text = "Add Student";
            this.ToolTip.SetToolTip(this.AddStdButton, "Add New Student");
            this.AddStdButton.UseVisualStyleBackColor = false;
            this.AddStdButton.Click += new System.EventHandler(this.AddStdButton_Click);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(9, 104);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(69, 13);
            this.BirthDateLabel.TabIndex = 4;
            this.BirthDateLabel.Text = "Birth Year:";
            // 
            // StdIDTextBox
            // 
            this.StdIDTextBox.Location = new System.Drawing.Point(85, 58);
            this.StdIDTextBox.Name = "StdIDTextBox";
            this.StdIDTextBox.Size = new System.Drawing.Size(161, 21);
            this.StdIDTextBox.TabIndex = 3;
            this.ToolTip.SetToolTip(this.StdIDTextBox, "Student ID");
            // 
            // StdIDLabel
            // 
            this.StdIDLabel.AutoSize = true;
            this.StdIDLabel.Location = new System.Drawing.Point(9, 60);
            this.StdIDLabel.Name = "StdIDLabel";
            this.StdIDLabel.Size = new System.Drawing.Size(26, 13);
            this.StdIDLabel.TabIndex = 2;
            this.StdIDLabel.Text = "ID:";
            // 
            // StdNameTextBox
            // 
            this.StdNameTextBox.Location = new System.Drawing.Point(85, 15);
            this.StdNameTextBox.Name = "StdNameTextBox";
            this.StdNameTextBox.Size = new System.Drawing.Size(161, 21);
            this.StdNameTextBox.TabIndex = 1;
            this.ToolTip.SetToolTip(this.StdNameTextBox, "Student Name");
            // 
            // StdNameLabel
            // 
            this.StdNameLabel.AutoSize = true;
            this.StdNameLabel.Location = new System.Drawing.Point(9, 18);
            this.StdNameLabel.Name = "StdNameLabel";
            this.StdNameLabel.Size = new System.Drawing.Size(45, 13);
            this.StdNameLabel.TabIndex = 0;
            this.StdNameLabel.Text = "Name:";
            // 
            // PSUTPictureBox
            // 
            this.PSUTPictureBox.Image = global::Registration_System.Properties.Resources.psut;
            this.PSUTPictureBox.Location = new System.Drawing.Point(337, 61);
            this.PSUTPictureBox.Name = "PSUTPictureBox";
            this.PSUTPictureBox.Size = new System.Drawing.Size(122, 123);
            this.PSUTPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PSUTPictureBox.TabIndex = 10;
            this.PSUTPictureBox.TabStop = false;
            this.ToolTip.SetToolTip(this.PSUTPictureBox, "PSUT Picture");
            // 
            // CourseTabPage
            // 
            this.CourseTabPage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CourseTabPage.Controls.Add(this.CourseTabLinkLabelPrev);
            this.CourseTabPage.Controls.Add(this.CourseTabLinkLabelNext);
            this.CourseTabPage.Controls.Add(this.CourseRegExitButton);
            this.CourseTabPage.Controls.Add(this.lblCourse);
            this.CourseTabPage.Controls.Add(this.CourseRegPanel);
            this.CourseTabPage.Controls.Add(this.pictureBox2);
            this.CourseTabPage.Location = new System.Drawing.Point(4, 22);
            this.CourseTabPage.Name = "CourseTabPage";
            this.CourseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CourseTabPage.Size = new System.Drawing.Size(485, 381);
            this.CourseTabPage.TabIndex = 1;
            this.CourseTabPage.Text = "Course Registration";
            // 
            // CourseTabLinkLabelPrev
            // 
            this.CourseTabLinkLabelPrev.AutoSize = true;
            this.CourseTabLinkLabelPrev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CourseTabLinkLabelPrev.Location = new System.Drawing.Point(347, 285);
            this.CourseTabLinkLabelPrev.Name = "CourseTabLinkLabelPrev";
            this.CourseTabLinkLabelPrev.Size = new System.Drawing.Size(58, 13);
            this.CourseTabLinkLabelPrev.TabIndex = 16;
            this.CourseTabLinkLabelPrev.TabStop = true;
            this.CourseTabLinkLabelPrev.Text = "Prev Tab";
            this.ToolTip.SetToolTip(this.CourseTabLinkLabelPrev, "Previous Tab: Student Registration");
            this.CourseTabLinkLabelPrev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CourseTabLinkLabelPrev_LinkClicked);
            // 
            // CourseTabLinkLabelNext
            // 
            this.CourseTabLinkLabelNext.AutoSize = true;
            this.CourseTabLinkLabelNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CourseTabLinkLabelNext.Location = new System.Drawing.Point(417, 285);
            this.CourseTabLinkLabelNext.Name = "CourseTabLinkLabelNext";
            this.CourseTabLinkLabelNext.Size = new System.Drawing.Size(58, 13);
            this.CourseTabLinkLabelNext.TabIndex = 15;
            this.CourseTabLinkLabelNext.TabStop = true;
            this.CourseTabLinkLabelNext.Text = "Next Tab";
            this.ToolTip.SetToolTip(this.CourseTabLinkLabelNext, "Next Tab: Enrollment");
            this.CourseTabLinkLabelNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CourseTabLinkLabelNext_LinkClicked);
            // 
            // CourseRegExitButton
            // 
            this.CourseRegExitButton.BackColor = System.Drawing.Color.SlateGray;
            this.CourseRegExitButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.CourseRegExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.CourseRegExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseRegExitButton.Location = new System.Drawing.Point(356, 233);
            this.CourseRegExitButton.Name = "CourseRegExitButton";
            this.CourseRegExitButton.Size = new System.Drawing.Size(122, 36);
            this.CourseRegExitButton.TabIndex = 14;
            this.CourseRegExitButton.Text = "Exit";
            this.ToolTip.SetToolTip(this.CourseRegExitButton, "Exit App");
            this.CourseRegExitButton.UseVisualStyleBackColor = false;
            this.CourseRegExitButton.Click += new System.EventHandler(this.CourseRegExitButton_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(168, 21);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(166, 29);
            this.lblCourse.TabIndex = 13;
            this.lblCourse.Text = "Add Course";
            // 
            // CourseRegPanel
            // 
            this.CourseRegPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseRegPanel.Controls.Add(this.CourseClrLinkLabel);
            this.CourseRegPanel.Controls.Add(this.CreditNumericUpDown);
            this.CourseRegPanel.Controls.Add(this.CourseIDTextBox);
            this.CourseRegPanel.Controls.Add(this.AddCourseButton);
            this.CourseRegPanel.Controls.Add(this.CourseCrdLabel);
            this.CourseRegPanel.Controls.Add(this.CourseIDLabel);
            this.CourseRegPanel.Controls.Add(this.CourseNameTextBox);
            this.CourseRegPanel.Controls.Add(this.CourseNameLabel);
            this.CourseRegPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseRegPanel.Location = new System.Drawing.Point(26, 73);
            this.CourseRegPanel.Name = "CourseRegPanel";
            this.CourseRegPanel.Size = new System.Drawing.Size(315, 243);
            this.CourseRegPanel.TabIndex = 9;
            // 
            // CourseClrLinkLabel
            // 
            this.CourseClrLinkLabel.AutoSize = true;
            this.CourseClrLinkLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CourseClrLinkLabel.Location = new System.Drawing.Point(18, 211);
            this.CourseClrLinkLabel.Name = "CourseClrLinkLabel";
            this.CourseClrLinkLabel.Size = new System.Drawing.Size(106, 13);
            this.CourseClrLinkLabel.TabIndex = 14;
            this.CourseClrLinkLabel.TabStop = true;
            this.CourseClrLinkLabel.Text = "Clear my choices";
            this.CourseClrLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CourseClrLinkLabel_LinkClicked);
            // 
            // CreditNumericUpDown
            // 
            this.CreditNumericUpDown.Location = new System.Drawing.Point(108, 108);
            this.CreditNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CreditNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CreditNumericUpDown.Name = "CreditNumericUpDown";
            this.CreditNumericUpDown.Size = new System.Drawing.Size(156, 21);
            this.CreditNumericUpDown.TabIndex = 6;
            this.ToolTip.SetToolTip(this.CreditNumericUpDown, "Course Credit Hours");
            this.CreditNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // CourseIDTextBox
            // 
            this.CourseIDTextBox.Location = new System.Drawing.Point(108, 66);
            this.CourseIDTextBox.Name = "CourseIDTextBox";
            this.CourseIDTextBox.Size = new System.Drawing.Size(156, 21);
            this.CourseIDTextBox.TabIndex = 5;
            this.ToolTip.SetToolTip(this.CourseIDTextBox, "Course ID");
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.BackColor = System.Drawing.Color.SlateGray;
            this.AddCourseButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.AddCourseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.AddCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCourseButton.ForeColor = System.Drawing.Color.Black;
            this.AddCourseButton.Location = new System.Drawing.Point(21, 159);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(243, 36);
            this.AddCourseButton.TabIndex = 7;
            this.AddCourseButton.Text = "Add Course";
            this.ToolTip.SetToolTip(this.AddCourseButton, "Add New Course ");
            this.AddCourseButton.UseVisualStyleBackColor = false;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // CourseCrdLabel
            // 
            this.CourseCrdLabel.AutoSize = true;
            this.CourseCrdLabel.Location = new System.Drawing.Point(18, 112);
            this.CourseCrdLabel.Name = "CourseCrdLabel";
            this.CourseCrdLabel.Size = new System.Drawing.Size(84, 13);
            this.CourseCrdLabel.TabIndex = 3;
            this.CourseCrdLabel.Text = "Credit Hours:";
            // 
            // CourseIDLabel
            // 
            this.CourseIDLabel.AutoSize = true;
            this.CourseIDLabel.Location = new System.Drawing.Point(18, 71);
            this.CourseIDLabel.Name = "CourseIDLabel";
            this.CourseIDLabel.Size = new System.Drawing.Size(26, 13);
            this.CourseIDLabel.TabIndex = 2;
            this.CourseIDLabel.Text = "ID:";
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(108, 24);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(156, 21);
            this.CourseNameTextBox.TabIndex = 1;
            this.ToolTip.SetToolTip(this.CourseNameTextBox, "Course Name");
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(18, 30);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(45, 13);
            this.CourseNameLabel.TabIndex = 0;
            this.CourseNameLabel.Text = "Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Registration_System.Properties.Resources.psut;
            this.pictureBox2.Location = new System.Drawing.Point(356, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureBox2, "PSUT Picture");
            // 
            // EnrollTabPage
            // 
            this.EnrollTabPage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EnrollTabPage.Controls.Add(this.EnrollTabLinkLabelPrev);
            this.EnrollTabPage.Controls.Add(this.EnrollTabLinkLabelNext);
            this.EnrollTabPage.Controls.Add(this.lblEnrollment);
            this.EnrollTabPage.Controls.Add(this.EnrollExitButton);
            this.EnrollTabPage.Controls.Add(this.EnrollPanel);
            this.EnrollTabPage.Controls.Add(this.pictureBox4);
            this.EnrollTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnrollTabPage.Name = "EnrollTabPage";
            this.EnrollTabPage.Size = new System.Drawing.Size(485, 381);
            this.EnrollTabPage.TabIndex = 2;
            this.EnrollTabPage.Text = "Enrollment";
            // 
            // EnrollTabLinkLabelPrev
            // 
            this.EnrollTabLinkLabelPrev.AutoSize = true;
            this.EnrollTabLinkLabelPrev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnrollTabLinkLabelPrev.Location = new System.Drawing.Point(329, 251);
            this.EnrollTabLinkLabelPrev.Name = "EnrollTabLinkLabelPrev";
            this.EnrollTabLinkLabelPrev.Size = new System.Drawing.Size(58, 13);
            this.EnrollTabLinkLabelPrev.TabIndex = 18;
            this.EnrollTabLinkLabelPrev.TabStop = true;
            this.EnrollTabLinkLabelPrev.Text = "Prev Tab";
            this.ToolTip.SetToolTip(this.EnrollTabLinkLabelPrev, "Prvious Tab: Course Registration");
            this.EnrollTabLinkLabelPrev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnrollTabLinkLabelPrev_LinkClicked);
            // 
            // EnrollTabLinkLabelNext
            // 
            this.EnrollTabLinkLabelNext.AutoSize = true;
            this.EnrollTabLinkLabelNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnrollTabLinkLabelNext.ForeColor = System.Drawing.Color.Black;
            this.EnrollTabLinkLabelNext.Location = new System.Drawing.Point(399, 251);
            this.EnrollTabLinkLabelNext.Name = "EnrollTabLinkLabelNext";
            this.EnrollTabLinkLabelNext.Size = new System.Drawing.Size(58, 13);
            this.EnrollTabLinkLabelNext.TabIndex = 17;
            this.EnrollTabLinkLabelNext.TabStop = true;
            this.EnrollTabLinkLabelNext.Text = "Next Tab";
            this.ToolTip.SetToolTip(this.EnrollTabLinkLabelNext, "Next Tab: Grades");
            this.EnrollTabLinkLabelNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnrollTabLinkLabelNext_LinkClicked);
            // 
            // lblEnrollment
            // 
            this.lblEnrollment.AutoSize = true;
            this.lblEnrollment.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollment.Location = new System.Drawing.Point(144, 16);
            this.lblEnrollment.Name = "lblEnrollment";
            this.lblEnrollment.Size = new System.Drawing.Size(204, 29);
            this.lblEnrollment.TabIndex = 14;
            this.lblEnrollment.Text = "Enroll Student";
            // 
            // EnrollExitButton
            // 
            this.EnrollExitButton.BackColor = System.Drawing.Color.SlateGray;
            this.EnrollExitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.EnrollExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.EnrollExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollExitButton.Location = new System.Drawing.Point(330, 198);
            this.EnrollExitButton.Name = "EnrollExitButton";
            this.EnrollExitButton.Size = new System.Drawing.Size(121, 35);
            this.EnrollExitButton.TabIndex = 10;
            this.EnrollExitButton.Text = "Exit";
            this.ToolTip.SetToolTip(this.EnrollExitButton, "Exit App");
            this.EnrollExitButton.UseVisualStyleBackColor = false;
            this.EnrollExitButton.Click += new System.EventHandler(this.EnrollExitButton_Click);
            // 
            // EnrollPanel
            // 
            this.EnrollPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnrollPanel.Controls.Add(this.EnrollClrLinkLabel);
            this.EnrollPanel.Controls.Add(this.EnrollCourseIDComboBox);
            this.EnrollPanel.Controls.Add(this.EnrollStdIDComboBox);
            this.EnrollPanel.Controls.Add(this.EnrollButton);
            this.EnrollPanel.Controls.Add(this.EnrollCourseIDLabel);
            this.EnrollPanel.Controls.Add(this.EnrollStdIDLabel);
            this.EnrollPanel.Location = new System.Drawing.Point(16, 58);
            this.EnrollPanel.Name = "EnrollPanel";
            this.EnrollPanel.Size = new System.Drawing.Size(285, 209);
            this.EnrollPanel.TabIndex = 9;
            // 
            // EnrollClrLinkLabel
            // 
            this.EnrollClrLinkLabel.AutoSize = true;
            this.EnrollClrLinkLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnrollClrLinkLabel.Location = new System.Drawing.Point(17, 180);
            this.EnrollClrLinkLabel.Name = "EnrollClrLinkLabel";
            this.EnrollClrLinkLabel.Size = new System.Drawing.Size(106, 13);
            this.EnrollClrLinkLabel.TabIndex = 15;
            this.EnrollClrLinkLabel.TabStop = true;
            this.EnrollClrLinkLabel.Text = "Clear my choices";
            this.EnrollClrLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnrollClrLinkLabel_LinkClicked);
            // 
            // EnrollCourseIDComboBox
            // 
            this.EnrollCourseIDComboBox.FormattingEnabled = true;
            this.EnrollCourseIDComboBox.Items.AddRange(new object[] {
            "Course ID"});
            this.EnrollCourseIDComboBox.Location = new System.Drawing.Point(95, 83);
            this.EnrollCourseIDComboBox.Name = "EnrollCourseIDComboBox";
            this.EnrollCourseIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.EnrollCourseIDComboBox.TabIndex = 8;
            this.EnrollCourseIDComboBox.Text = "Course ID";
            this.ToolTip.SetToolTip(this.EnrollCourseIDComboBox, "Course ID");
            this.EnrollCourseIDComboBox.SelectedIndexChanged += new System.EventHandler(this.EnrollCourseIDComboBox_SelectedIndexChanged);
            // 
            // EnrollStdIDComboBox
            // 
            this.EnrollStdIDComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EnrollStdIDComboBox.FormattingEnabled = true;
            this.EnrollStdIDComboBox.Items.AddRange(new object[] {
            "Student ID"});
            this.EnrollStdIDComboBox.Location = new System.Drawing.Point(95, 36);
            this.EnrollStdIDComboBox.Name = "EnrollStdIDComboBox";
            this.EnrollStdIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.EnrollStdIDComboBox.TabIndex = 7;
            this.EnrollStdIDComboBox.Text = "Student ID";
            this.ToolTip.SetToolTip(this.EnrollStdIDComboBox, "Student ID");
            this.EnrollStdIDComboBox.SelectedIndexChanged += new System.EventHandler(this.EnrollStdIDComboBox_SelectedIndexChanged);
            // 
            // EnrollButton
            // 
            this.EnrollButton.BackColor = System.Drawing.Color.SlateGray;
            this.EnrollButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.EnrollButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.EnrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollButton.Location = new System.Drawing.Point(54, 130);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(162, 35);
            this.EnrollButton.TabIndex = 5;
            this.EnrollButton.Text = "Register";
            this.ToolTip.SetToolTip(this.EnrollButton, "Enroll Student In Course");
            this.EnrollButton.UseVisualStyleBackColor = false;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // EnrollCourseIDLabel
            // 
            this.EnrollCourseIDLabel.AutoSize = true;
            this.EnrollCourseIDLabel.Location = new System.Drawing.Point(17, 87);
            this.EnrollCourseIDLabel.Name = "EnrollCourseIDLabel";
            this.EnrollCourseIDLabel.Size = new System.Drawing.Size(71, 13);
            this.EnrollCourseIDLabel.TabIndex = 4;
            this.EnrollCourseIDLabel.Text = "Course ID:";
            // 
            // EnrollStdIDLabel
            // 
            this.EnrollStdIDLabel.AutoSize = true;
            this.EnrollStdIDLabel.Location = new System.Drawing.Point(17, 39);
            this.EnrollStdIDLabel.Name = "EnrollStdIDLabel";
            this.EnrollStdIDLabel.Size = new System.Drawing.Size(74, 13);
            this.EnrollStdIDLabel.TabIndex = 3;
            this.EnrollStdIDLabel.Text = "Student ID:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Registration_System.Properties.Resources.psut;
            this.pictureBox4.Location = new System.Drawing.Point(330, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureBox4, "PSUT Picture");
            // 
            // GradesTabPage
            // 
            this.GradesTabPage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GradesTabPage.Controls.Add(this.GradesTabLinkLabelPrev);
            this.GradesTabPage.Controls.Add(this.lblGrades);
            this.GradesTabPage.Controls.Add(this.GradesExitButton);
            this.GradesTabPage.Controls.Add(this.GradesDataGridView);
            this.GradesTabPage.Controls.Add(this.ExportButton);
            this.GradesTabPage.Controls.Add(this.ImportButton);
            this.GradesTabPage.Controls.Add(this.pictureBox3);
            this.GradesTabPage.Location = new System.Drawing.Point(4, 22);
            this.GradesTabPage.Name = "GradesTabPage";
            this.GradesTabPage.Size = new System.Drawing.Size(485, 381);
            this.GradesTabPage.TabIndex = 3;
            this.GradesTabPage.Text = "Grades";
            // 
            // GradesTabLinkLabelPrev
            // 
            this.GradesTabLinkLabelPrev.AutoSize = true;
            this.GradesTabLinkLabelPrev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GradesTabLinkLabelPrev.Location = new System.Drawing.Point(368, 275);
            this.GradesTabLinkLabelPrev.Name = "GradesTabLinkLabelPrev";
            this.GradesTabLinkLabelPrev.Size = new System.Drawing.Size(58, 13);
            this.GradesTabLinkLabelPrev.TabIndex = 19;
            this.GradesTabLinkLabelPrev.TabStop = true;
            this.GradesTabLinkLabelPrev.Text = "Prev Tab";
            this.ToolTip.SetToolTip(this.GradesTabLinkLabelPrev, "Previous Tab: Enrollment");
            this.GradesTabLinkLabelPrev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GradesTabLinkLabelPrev_LinkClicked);
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrades.Location = new System.Drawing.Point(178, 22);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(107, 29);
            this.lblGrades.TabIndex = 15;
            this.lblGrades.Text = "Grades";
            // 
            // GradesExitButton
            // 
            this.GradesExitButton.BackColor = System.Drawing.Color.SlateGray;
            this.GradesExitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.GradesExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.GradesExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradesExitButton.Location = new System.Drawing.Point(341, 216);
            this.GradesExitButton.Name = "GradesExitButton";
            this.GradesExitButton.Size = new System.Drawing.Size(119, 38);
            this.GradesExitButton.TabIndex = 4;
            this.GradesExitButton.Text = "Exit";
            this.ToolTip.SetToolTip(this.GradesExitButton, "Exit App");
            this.GradesExitButton.UseVisualStyleBackColor = false;
            this.GradesExitButton.Click += new System.EventHandler(this.GradesExitButton_Click);
            // 
            // GradesDataGridView
            // 
            this.GradesDataGridView.AllowUserToAddRows = false;
            this.GradesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradesDataGridView.GridColor = System.Drawing.Color.White;
            this.GradesDataGridView.Location = new System.Drawing.Point(20, 157);
            this.GradesDataGridView.Name = "GradesDataGridView";
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle67.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle67.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GradesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle67;
            this.GradesDataGridView.RowHeadersVisible = false;
            this.GradesDataGridView.RowHeadersWidth = 500;
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GradesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle68;
            this.GradesDataGridView.Size = new System.Drawing.Size(304, 214);
            this.GradesDataGridView.StandardTab = true;
            this.GradesDataGridView.TabIndex = 3;
            // 
            // ExportButton
            // 
            this.ExportButton.AutoSize = true;
            this.ExportButton.BackColor = System.Drawing.Color.SlateGray;
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.ExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Location = new System.Drawing.Point(20, 69);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(304, 38);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Export Grades";
            this.ToolTip.SetToolTip(this.ExportButton, "Exoprt Grades To A Text File");
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.AutoSize = true;
            this.ImportButton.BackColor = System.Drawing.Color.SlateGray;
            this.ImportButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.ImportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Location = new System.Drawing.Point(20, 113);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(304, 38);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Import Enrollment";
            this.ToolTip.SetToolTip(this.ImportButton, "Import Grades And Display Them In A Table");
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Registration_System.Properties.Resources.psut;
            this.pictureBox3.Location = new System.Drawing.Point(341, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.ToolTip.SetToolTip(this.pictureBox3, "PSUT Picture");
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 1000;
            this.ToolTip.ReshowDelay = 100;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(493, 407);
            this.Controls.Add(this.RegTabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "RegistrationForm";
            this.Text = "PSUT University Registration System";
            this.RegTabControl.ResumeLayout(false);
            this.StudentTabPage.ResumeLayout(false);
            this.StudentTabPage.PerformLayout();
            this.StdRegPanel.ResumeLayout(false);
            this.StdRegPanel.PerformLayout();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSUTPictureBox)).EndInit();
            this.CourseTabPage.ResumeLayout(false);
            this.CourseTabPage.PerformLayout();
            this.CourseRegPanel.ResumeLayout(false);
            this.CourseRegPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.EnrollTabPage.ResumeLayout(false);
            this.EnrollTabPage.PerformLayout();
            this.EnrollPanel.ResumeLayout(false);
            this.EnrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.GradesTabPage.ResumeLayout(false);
            this.GradesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage StudentTabPage;
        private System.Windows.Forms.TabPage CourseTabPage;
        private System.Windows.Forms.TabPage EnrollTabPage;
        private System.Windows.Forms.TabPage GradesTabPage;
        private System.Windows.Forms.Label StdIDLabel;
        private System.Windows.Forms.TextBox StdNameTextBox;
        private System.Windows.Forms.Label StdNameLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.TextBox StdIDTextBox;
        private System.Windows.Forms.Button AddStdButton;
        private System.Windows.Forms.PictureBox PSUTPictureBox;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.TextBox CourseNameTextBox;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label CourseIDLabel;
        private System.Windows.Forms.TextBox CourseIDTextBox;
        private System.Windows.Forms.Label CourseCrdLabel;
        private System.Windows.Forms.NumericUpDown CreditNumericUpDown;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button EnrollButton;
        private System.Windows.Forms.Label EnrollCourseIDLabel;
        private System.Windows.Forms.Label EnrollStdIDLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.DataGridView GradesDataGridView;
        private System.Windows.Forms.Panel StdRegPanel;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Panel CourseRegPanel;
        private System.Windows.Forms.ComboBox EnrollCourseIDComboBox;
        private System.Windows.Forms.ComboBox EnrollStdIDComboBox;
        private System.Windows.Forms.Panel EnrollPanel;
        private System.Windows.Forms.Button EnrollExitButton;
        private System.Windows.Forms.Button GradesExitButton;
        private System.Windows.Forms.TabControl RegTabControl;
        private System.Windows.Forms.Button StdRegExitButton;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button CourseRegExitButton;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblEnrollment;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.LinkLabel StdRegLinkLabel;
        private System.Windows.Forms.LinkLabel CourseTabLinkLabelPrev;
        private System.Windows.Forms.LinkLabel CourseTabLinkLabelNext;
        private System.Windows.Forms.LinkLabel EnrollTabLinkLabelPrev;
        private System.Windows.Forms.LinkLabel EnrollTabLinkLabelNext;
        private System.Windows.Forms.LinkLabel GradesTabLinkLabelPrev;
        private System.Windows.Forms.LinkLabel StdClrLinkLabel;
        private System.Windows.Forms.LinkLabel CourseClrLinkLabel;
        private System.Windows.Forms.LinkLabel EnrollClrLinkLabel;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

