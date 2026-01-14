namespace RegistrationSys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            buttonValidateEmpCode = new Button();
            labelName = new Label();
            groupBoxRegistration = new GroupBox();
            labelShowSurname = new Label();
            labelShowName = new Label();
            label2Surname = new Label();
            label3 = new Label();
            labelShowDepartment = new Label();
            label2 = new Label();
            labelShowExpires = new Label();
            labelExpires = new Label();
            labelShowRegNumber = new Label();
            labelVality = new Label();
            labelRegNumber = new Label();
            labelRegDateStamp = new Label();
            labelRegDate = new Label();
            buttonShowPass = new Button();
            dateTimeVality = new DateTimePicker();
            labelValidUntil = new Label();
            labelDepartment = new Label();
            comboBoxDepartment = new ComboBox();
            labelConfirmPass = new Label();
            labelNewPass = new Label();
            labelUsername = new Label();
            textBoxConfirmPass = new TextBox();
            textBoxNewPass = new TextBox();
            textBoxUsername = new TextBox();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            textBoxName = new TextBox();
            labelFindUser = new Label();
            textBoxEmpCode = new TextBox();
            buttonAddUser = new Button();
            labelClock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            buttonFindUser = new Button();
            buttonDeleteUser = new Button();
            textBoxFindUser = new TextBox();
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxRegistration.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_gatekeeper;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonValidateEmpCode
            // 
            buttonValidateEmpCode.Location = new Point(440, 12);
            buttonValidateEmpCode.Name = "buttonValidateEmpCode";
            buttonValidateEmpCode.Size = new Size(64, 23);
            buttonValidateEmpCode.TabIndex = 2;
            buttonValidateEmpCode.Text = "&Validate";
            buttonValidateEmpCode.UseVisualStyleBackColor = true;
            buttonValidateEmpCode.Click += buttonValidateEmpCode_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.Location = new Point(89, 22);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 19);
            labelName.TabIndex = 4;
            labelName.Text = "Name: ";
            // 
            // groupBoxRegistration
            // 
            groupBoxRegistration.Controls.Add(labelShowSurname);
            groupBoxRegistration.Controls.Add(labelShowName);
            groupBoxRegistration.Controls.Add(label2Surname);
            groupBoxRegistration.Controls.Add(label3);
            groupBoxRegistration.Controls.Add(labelShowDepartment);
            groupBoxRegistration.Controls.Add(label2);
            groupBoxRegistration.Controls.Add(labelShowExpires);
            groupBoxRegistration.Controls.Add(labelExpires);
            groupBoxRegistration.Controls.Add(labelShowRegNumber);
            groupBoxRegistration.Controls.Add(labelVality);
            groupBoxRegistration.Controls.Add(labelRegNumber);
            groupBoxRegistration.Controls.Add(labelRegDateStamp);
            groupBoxRegistration.Controls.Add(labelRegDate);
            groupBoxRegistration.Controls.Add(buttonShowPass);
            groupBoxRegistration.Controls.Add(dateTimeVality);
            groupBoxRegistration.Controls.Add(labelValidUntil);
            groupBoxRegistration.Controls.Add(labelDepartment);
            groupBoxRegistration.Controls.Add(comboBoxDepartment);
            groupBoxRegistration.Controls.Add(labelConfirmPass);
            groupBoxRegistration.Controls.Add(labelNewPass);
            groupBoxRegistration.Controls.Add(labelUsername);
            groupBoxRegistration.Controls.Add(textBoxConfirmPass);
            groupBoxRegistration.Controls.Add(textBoxNewPass);
            groupBoxRegistration.Controls.Add(textBoxUsername);
            groupBoxRegistration.Controls.Add(textBoxSurname);
            groupBoxRegistration.Controls.Add(labelSurname);
            groupBoxRegistration.Controls.Add(textBoxName);
            groupBoxRegistration.Controls.Add(labelName);
            groupBoxRegistration.Enabled = false;
            groupBoxRegistration.Location = new Point(149, 45);
            groupBoxRegistration.Name = "groupBoxRegistration";
            groupBoxRegistration.Size = new Size(632, 276);
            groupBoxRegistration.TabIndex = 5;
            groupBoxRegistration.TabStop = false;
            groupBoxRegistration.Text = "Registration";
            // 
            // labelShowSurname
            // 
            labelShowSurname.AutoSize = true;
            labelShowSurname.Font = new Font("Segoe UI", 10F);
            labelShowSurname.Location = new Point(515, 51);
            labelShowSurname.Name = "labelShowSurname";
            labelShowSurname.Size = new Size(15, 19);
            labelShowSurname.TabIndex = 28;
            labelShowSurname.Text = "-";
            // 
            // labelShowName
            // 
            labelShowName.AutoSize = true;
            labelShowName.Font = new Font("Segoe UI", 10F);
            labelShowName.Location = new Point(515, 23);
            labelShowName.Name = "labelShowName";
            labelShowName.Size = new Size(15, 19);
            labelShowName.TabIndex = 28;
            labelShowName.Text = "-";
            // 
            // label2Surname
            // 
            label2Surname.AutoSize = true;
            label2Surname.Font = new Font("Segoe UI", 10F);
            label2Surname.Location = new Point(365, 51);
            label2Surname.Name = "label2Surname";
            label2Surname.Size = new Size(66, 19);
            label2Surname.TabIndex = 27;
            label2Surname.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(365, 23);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 27;
            label3.Text = "Name: ";
            // 
            // labelShowDepartment
            // 
            labelShowDepartment.AutoSize = true;
            labelShowDepartment.Font = new Font("Segoe UI", 10F);
            labelShowDepartment.Location = new Point(515, 205);
            labelShowDepartment.Name = "labelShowDepartment";
            labelShowDepartment.Size = new Size(15, 19);
            labelShowDepartment.TabIndex = 26;
            labelShowDepartment.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(365, 205);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 24;
            label2.Text = "Department: ";
            // 
            // labelShowExpires
            // 
            labelShowExpires.AutoSize = true;
            labelShowExpires.Font = new Font("Segoe UI", 10F);
            labelShowExpires.Location = new Point(515, 158);
            labelShowExpires.Name = "labelShowExpires";
            labelShowExpires.Size = new Size(55, 19);
            labelShowExpires.TabIndex = 23;
            labelShowExpires.Text = "--/--/--";
            // 
            // labelExpires
            // 
            labelExpires.AutoSize = true;
            labelExpires.Font = new Font("Segoe UI", 10F);
            labelExpires.Location = new Point(365, 158);
            labelExpires.Name = "labelExpires";
            labelExpires.Size = new Size(58, 19);
            labelExpires.TabIndex = 22;
            labelExpires.Text = "Expires: ";
            // 
            // labelShowRegNumber
            // 
            labelShowRegNumber.AutoSize = true;
            labelShowRegNumber.Font = new Font("Segoe UI", 10F);
            labelShowRegNumber.Location = new Point(515, 100);
            labelShowRegNumber.Name = "labelShowRegNumber";
            labelShowRegNumber.Size = new Size(15, 19);
            labelShowRegNumber.TabIndex = 21;
            labelShowRegNumber.Text = "-";
            // 
            // labelVality
            // 
            labelVality.AutoSize = true;
            labelVality.Font = new Font("Segoe UI", 10F);
            labelVality.Location = new Point(365, 233);
            labelVality.Name = "labelVality";
            labelVality.Size = new Size(62, 19);
            labelVality.TabIndex = 20;
            labelVality.Text = "<Vality>";
            // 
            // labelRegNumber
            // 
            labelRegNumber.AutoSize = true;
            labelRegNumber.Font = new Font("Segoe UI", 10F);
            labelRegNumber.Location = new Point(365, 100);
            labelRegNumber.Name = "labelRegNumber";
            labelRegNumber.Size = new Size(143, 19);
            labelRegNumber.TabIndex = 18;
            labelRegNumber.Text = "Registration Number: ";
            // 
            // labelRegDateStamp
            // 
            labelRegDateStamp.AutoSize = true;
            labelRegDateStamp.Font = new Font("Segoe UI", 10F);
            labelRegDateStamp.Location = new Point(515, 129);
            labelRegDateStamp.Name = "labelRegDateStamp";
            labelRegDateStamp.Size = new Size(55, 19);
            labelRegDateStamp.TabIndex = 17;
            labelRegDateStamp.Text = "--/--/--";
            // 
            // labelRegDate
            // 
            labelRegDate.AutoSize = true;
            labelRegDate.Font = new Font("Segoe UI", 10F);
            labelRegDate.Location = new Point(365, 129);
            labelRegDate.Name = "labelRegDate";
            labelRegDate.Size = new Size(116, 19);
            labelRegDate.TabIndex = 16;
            labelRegDate.Text = "Registration date:";
            // 
            // buttonShowPass
            // 
            buttonShowPass.Font = new Font("Arial", 10F);
            buttonShowPass.Location = new Point(291, 128);
            buttonShowPass.Name = "buttonShowPass";
            buttonShowPass.Size = new Size(29, 23);
            buttonShowPass.TabIndex = 15;
            buttonShowPass.Text = "👁️";
            buttonShowPass.UseVisualStyleBackColor = true;
            buttonShowPass.Click += buttonShowPass_Click;
            buttonShowPass.MouseEnter += button1_MouseEnter;
            // 
            // dateTimeVality
            // 
            dateTimeVality.Location = new Point(147, 233);
            dateTimeVality.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimeVality.MinDate = new DateTime(2026, 1, 1, 23, 59, 0, 0);
            dateTimeVality.Name = "dateTimeVality";
            dateTimeVality.Size = new Size(138, 23);
            dateTimeVality.TabIndex = 8;
            dateTimeVality.Value = new DateTime(2026, 1, 1, 23, 59, 0, 0);
            dateTimeVality.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelValidUntil
            // 
            labelValidUntil.AutoSize = true;
            labelValidUntil.Font = new Font("Segoe UI", 10F);
            labelValidUntil.Location = new Point(65, 233);
            labelValidUntil.Name = "labelValidUntil";
            labelValidUntil.Size = new Size(76, 19);
            labelValidUntil.TabIndex = 13;
            labelValidUntil.Text = "Valid until: ";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Font = new Font("Segoe UI", 10F);
            labelDepartment.Location = new Point(51, 205);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(90, 19);
            labelDepartment.TabIndex = 12;
            labelDepartment.Text = "Department: ";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Items.AddRange(new object[] { "Expedition", "Customs warehouse", "Management", "Temporary access" });
            comboBoxDepartment.Location = new Point(147, 204);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(138, 23);
            comboBoxDepartment.TabIndex = 7;
            // 
            // labelConfirmPass
            // 
            labelConfirmPass.AutoSize = true;
            labelConfirmPass.Font = new Font("Segoe UI", 10F);
            labelConfirmPass.Location = new Point(14, 157);
            labelConfirmPass.Name = "labelConfirmPass";
            labelConfirmPass.Size = new Size(127, 19);
            labelConfirmPass.TabIndex = 11;
            labelConfirmPass.Text = "Confirm Password: ";
            // 
            // labelNewPass
            // 
            labelNewPass.AutoSize = true;
            labelNewPass.Font = new Font("Segoe UI", 10F);
            labelNewPass.Location = new Point(67, 129);
            labelNewPass.Name = "labelNewPass";
            labelNewPass.Size = new Size(74, 19);
            labelNewPass.TabIndex = 10;
            labelNewPass.Text = "Password: ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10F);
            labelUsername.Location = new Point(63, 103);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(78, 19);
            labelUsername.TabIndex = 9;
            labelUsername.Text = "Username: ";
            // 
            // textBoxConfirmPass
            // 
            textBoxConfirmPass.Location = new Point(147, 157);
            textBoxConfirmPass.Name = "textBoxConfirmPass";
            textBoxConfirmPass.PasswordChar = '*';
            textBoxConfirmPass.Size = new Size(138, 23);
            textBoxConfirmPass.TabIndex = 6;
            textBoxConfirmPass.Tag = "ConfirmPass";
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(147, 128);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.PasswordChar = '*';
            textBoxNewPass.Size = new Size(138, 23);
            textBoxNewPass.TabIndex = 5;
            textBoxNewPass.Tag = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(147, 99);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(138, 23);
            textBoxUsername.TabIndex = 4;
            textBoxUsername.Tag = "Username";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(147, 51);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(138, 23);
            textBoxSurname.TabIndex = 3;
            textBoxSurname.Tag = "Surname";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 10F);
            labelSurname.Location = new Point(71, 51);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(70, 19);
            labelSurname.TabIndex = 6;
            labelSurname.Text = "Surname: ";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(147, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(138, 23);
            textBoxName.TabIndex = 2;
            textBoxName.Tag = "Name";
            // 
            // labelFindUser
            // 
            labelFindUser.AutoSize = true;
            labelFindUser.Font = new Font("Segoe UI", 10F);
            labelFindUser.Location = new Point(514, 14);
            labelFindUser.Name = "labelFindUser";
            labelFindUser.Size = new Size(74, 19);
            labelFindUser.TabIndex = 8;
            labelFindUser.Text = "Find User: ";
            // 
            // textBoxEmpCode
            // 
            textBoxEmpCode.CharacterCasing = CharacterCasing.Upper;
            textBoxEmpCode.Location = new Point(296, 12);
            textBoxEmpCode.Name = "textBoxEmpCode";
            textBoxEmpCode.Size = new Size(138, 23);
            textBoxEmpCode.TabIndex = 1;
            textBoxEmpCode.KeyUp += textBoxEmpCode_KeyUp;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Enabled = false;
            buttonAddUser.Location = new Point(12, 130);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(121, 23);
            buttonAddUser.TabIndex = 10;
            buttonAddUser.Text = "&Save in the local DB";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // labelClock
            // 
            labelClock.AutoSize = true;
            labelClock.Location = new Point(12, 306);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(37, 15);
            labelClock.TabIndex = 13;
            labelClock.Text = "Clock";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // buttonFindUser
            // 
            buttonFindUser.Location = new Point(721, 12);
            buttonFindUser.Name = "buttonFindUser";
            buttonFindUser.Size = new Size(63, 23);
            buttonFindUser.TabIndex = 0;
            buttonFindUser.Text = "&Find...";
            buttonFindUser.UseVisualStyleBackColor = true;
            buttonFindUser.Click += buttonFindUser_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(12, 159);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(121, 23);
            buttonDeleteUser.TabIndex = 16;
            buttonDeleteUser.Text = "&Delete...";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // textBoxFindUser
            // 
            textBoxFindUser.Location = new Point(594, 12);
            textBoxFindUser.Name = "textBoxFindUser";
            textBoxFindUser.Size = new Size(118, 23);
            textBoxFindUser.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(161, 14);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 8;
            label1.Text = "Employment Code: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 335);
            Controls.Add(textBoxFindUser);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonFindUser);
            Controls.Add(labelClock);
            Controls.Add(buttonAddUser);
            Controls.Add(textBoxEmpCode);
            Controls.Add(groupBoxRegistration);
            Controls.Add(buttonValidateEmpCode);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(labelFindUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(814, 513);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WG Registration System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxRegistration.ResumeLayout(false);
            groupBoxRegistration.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonValidateEmpCode;
        private Label labelName;
        private GroupBox groupBoxRegistration;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private TextBox textBoxName;
        private Label labelUsername;
        private Label labelFindUser;
        private TextBox textBoxUsername;
        private Label labelConfirmPass;
        private Label labelNewPass;
        private TextBox textBoxConfirmPass;
        private TextBox textBoxNewPass;
        private TextBox textBoxEmpCode;
        private Label labelDepartment;
        private ComboBox comboBoxDepartment;
        private DateTimePicker dateTimeVality;
        private Label labelValidUntil;
        private Button buttonAddUser;
        private Label labelClock;
        private System.Windows.Forms.Timer timer1;
        private Button buttonShowPass;
        private ToolTip toolTip1;
        private Label labelRegDate;
        private Label labelRegDateStamp;
        private Button buttonFindUser;
        private Label labelRegNumber;
        private Label labelVality;
        private Label labelShowRegNumber;
        private Label labelShowExpires;
        private Label labelExpires;
        private Label label2;
        private Label labelShowDepartment;
        private Button buttonDeleteUser;
        private TextBox textBoxFindUser;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private Label labelShowSurname;
        private Label labelShowName;
        private Label label2Surname;
        private Label label3;
    }
}
