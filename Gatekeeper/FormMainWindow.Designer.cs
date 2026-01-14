namespace Gatekeeper
{
    partial class FormMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newOrderToolStripMenuItem = new ToolStripMenuItem();
            openOrderToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            fAQToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            labelTitle = new Label();
            labelSONumberText = new Label();
            labelSORegNum = new Label();
            labelRespTechText = new Label();
            groupBoxMain = new GroupBox();
            buttonResetOrder = new Button();
            buttonStart = new Button();
            dateTimePickerDeadline = new DateTimePicker();
            labelStatus = new Label();
            labelOpenedText = new Label();
            labelExpCompletionDate = new Label();
            labelStatusText = new Label();
            labelOpenedDateText = new Label();
            comboBoxPriority = new ComboBox();
            richTextBoxDescription = new RichTextBox();
            comboBoxDepartment = new ComboBox();
            textBoxRespTech = new TextBox();
            labelPriority = new Label();
            labelDescription = new Label();
            labelDepartmentText = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            buttonFinishOrder = new Button();
            buttonRefreshList = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelReady = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1367, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newOrderToolStripMenuItem, openOrderToolStripMenuItem, toolStripSeparator2, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newOrderToolStripMenuItem
            // 
            newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            newOrderToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newOrderToolStripMenuItem.Size = new Size(180, 22);
            newOrderToolStripMenuItem.Text = "&New order";
            newOrderToolStripMenuItem.Click += newOrderToolStripMenuItem_Click;
            // 
            // openOrderToolStripMenuItem
            // 
            openOrderToolStripMenuItem.Name = "openOrderToolStripMenuItem";
            openOrderToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openOrderToolStripMenuItem.Size = new Size(180, 22);
            openOrderToolStripMenuItem.Text = "&Open order";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "&Quit";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fAQToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // fAQToolStripMenuItem
            // 
            fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            fAQToolStripMenuItem.Size = new Size(180, 22);
            fAQToolStripMenuItem.Text = "FAQ";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            labelTitle.Location = new Point(403, 46);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(503, 54);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "SERVICE ORDER REGISTER";
            // 
            // labelSONumberText
            // 
            labelSONumberText.AutoSize = true;
            labelSONumberText.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSONumberText.Location = new Point(15, 28);
            labelSONumberText.Name = "labelSONumberText";
            labelSONumberText.Size = new Size(114, 19);
            labelSONumberText.TabIndex = 2;
            labelSONumberText.Text = "SO NUMBER:";
            // 
            // labelSORegNum
            // 
            labelSORegNum.AutoSize = true;
            labelSORegNum.BackColor = Color.Gold;
            labelSORegNum.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSORegNum.Location = new Point(15, 57);
            labelSORegNum.Name = "labelSORegNum";
            labelSORegNum.Size = new Size(14, 19);
            labelSORegNum.TabIndex = 3;
            labelSORegNum.Text = "-";
            // 
            // labelRespTechText
            // 
            labelRespTechText.AutoSize = true;
            labelRespTechText.Font = new Font("Arial", 12F);
            labelRespTechText.Location = new Point(162, 28);
            labelRespTechText.Name = "labelRespTechText";
            labelRespTechText.Size = new Size(173, 18);
            labelRespTechText.TabIndex = 2;
            labelRespTechText.Text = "Responsible technician:";
            // 
            // groupBoxMain
            // 
            groupBoxMain.BackColor = SystemColors.HighlightText;
            groupBoxMain.Controls.Add(buttonResetOrder);
            groupBoxMain.Controls.Add(buttonStart);
            groupBoxMain.Controls.Add(dateTimePickerDeadline);
            groupBoxMain.Controls.Add(labelStatus);
            groupBoxMain.Controls.Add(labelOpenedText);
            groupBoxMain.Controls.Add(labelExpCompletionDate);
            groupBoxMain.Controls.Add(labelStatusText);
            groupBoxMain.Controls.Add(labelOpenedDateText);
            groupBoxMain.Controls.Add(comboBoxPriority);
            groupBoxMain.Controls.Add(richTextBoxDescription);
            groupBoxMain.Controls.Add(comboBoxDepartment);
            groupBoxMain.Controls.Add(textBoxRespTech);
            groupBoxMain.Controls.Add(labelPriority);
            groupBoxMain.Controls.Add(labelDescription);
            groupBoxMain.Controls.Add(labelSONumberText);
            groupBoxMain.Controls.Add(labelDepartmentText);
            groupBoxMain.Controls.Add(labelRespTechText);
            groupBoxMain.Controls.Add(labelSORegNum);
            groupBoxMain.Enabled = false;
            groupBoxMain.Location = new Point(12, 136);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(757, 528);
            groupBoxMain.TabIndex = 4;
            groupBoxMain.TabStop = false;
            // 
            // buttonResetOrder
            // 
            buttonResetOrder.Font = new Font("Arial", 12F);
            buttonResetOrder.Location = new Point(665, 475);
            buttonResetOrder.Name = "buttonResetOrder";
            buttonResetOrder.Size = new Size(75, 31);
            buttonResetOrder.TabIndex = 6;
            buttonResetOrder.Text = "Reset";
            buttonResetOrder.UseVisualStyleBackColor = true;
            buttonResetOrder.Click += buttonResetOrder_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Arial", 12F);
            buttonStart.Location = new Point(584, 475);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 31);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Format = DateTimePickerFormat.Short;
            dateTimePickerDeadline.Location = new Point(209, 433);
            dateTimePickerDeadline.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimePickerDeadline.MinDate = new DateTime(2026, 1, 12, 0, 0, 0, 0);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(190, 23);
            dateTimePickerDeadline.TabIndex = 5;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(690, 433);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(36, 19);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "N/A";
            // 
            // labelOpenedText
            // 
            labelOpenedText.AutoSize = true;
            labelOpenedText.Font = new Font("Arial", 12F);
            labelOpenedText.Location = new Point(463, 434);
            labelOpenedText.Name = "labelOpenedText";
            labelOpenedText.Size = new Size(13, 18);
            labelOpenedText.TabIndex = 9;
            labelOpenedText.Text = "-";
            // 
            // labelExpCompletionDate
            // 
            labelExpCompletionDate.AutoSize = true;
            labelExpCompletionDate.Font = new Font("Arial", 12F);
            labelExpCompletionDate.Location = new Point(209, 403);
            labelExpCompletionDate.Name = "labelExpCompletionDate";
            labelExpCompletionDate.Size = new Size(193, 18);
            labelExpCompletionDate.TabIndex = 8;
            labelExpCompletionDate.Text = "Expected completion date:";
            // 
            // labelStatusText
            // 
            labelStatusText.AutoSize = true;
            labelStatusText.Font = new Font("Arial", 12F);
            labelStatusText.Location = new Point(684, 403);
            labelStatusText.Name = "labelStatusText";
            labelStatusText.Size = new Size(56, 18);
            labelStatusText.TabIndex = 8;
            labelStatusText.Text = "Status:";
            // 
            // labelOpenedDateText
            // 
            labelOpenedDateText.AutoSize = true;
            labelOpenedDateText.Font = new Font("Arial", 12F);
            labelOpenedDateText.Location = new Point(463, 403);
            labelOpenedDateText.Name = "labelOpenedDateText";
            labelOpenedDateText.Size = new Size(106, 18);
            labelOpenedDateText.TabIndex = 8;
            labelOpenedDateText.Text = "Opened Date:";
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPriority.Font = new Font("Segoe UI", 9F);
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Items.AddRange(new object[] { "5 - Very High", "4 - High", "3 - Medium", "2 - Low", "1 - Very Low" });
            comboBoxPriority.Location = new Point(15, 433);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(130, 23);
            comboBoxPriority.TabIndex = 4;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.BackColor = SystemColors.Window;
            richTextBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxDescription.Font = new Font("Arial", 12F);
            richTextBoxDescription.Location = new Point(15, 133);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(725, 256);
            richTextBoxDescription.TabIndex = 3;
            richTextBoxDescription.Text = "Insert a description";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Items.AddRange(new object[] { "IT (Information Tech)", "Office 1 - Financial", "Office 2 - HR", "Office 3 - Security", "Expedition Area", "External Area", "Administration", "Warehouse 1 - Main Docks", "Warehouse 2 - Perishables", "Warehouse 3 - Chemicals", "Warehouse 4 - Health Surveillance", "Warehouse 5 - Sensitive Materials" });
            comboBoxDepartment.Location = new Point(463, 55);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(277, 23);
            comboBoxDepartment.TabIndex = 2;
            // 
            // textBoxRespTech
            // 
            textBoxRespTech.Location = new Point(162, 55);
            textBoxRespTech.Name = "textBoxRespTech";
            textBoxRespTech.Size = new Size(277, 23);
            textBoxRespTech.TabIndex = 1;
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Arial", 12F);
            labelPriority.Location = new Point(15, 403);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(61, 18);
            labelPriority.TabIndex = 2;
            labelPriority.Text = "Priority:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(15, 100);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(92, 18);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Description:";
            // 
            // labelDepartmentText
            // 
            labelDepartmentText.AutoSize = true;
            labelDepartmentText.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDepartmentText.Location = new Point(463, 28);
            labelDepartmentText.Name = "labelDepartmentText";
            labelDepartmentText.Size = new Size(94, 18);
            labelDepartmentText.TabIndex = 2;
            labelDepartmentText.Text = "Department:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_gatekeeper;
            pictureBox1.Location = new Point(12, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(786, 136);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(569, 452);
            dataGridView1.TabIndex = 6;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // buttonFinishOrder
            // 
            buttonFinishOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonFinishOrder.Enabled = false;
            buttonFinishOrder.Font = new Font("Arial", 12F);
            buttonFinishOrder.Location = new Point(1179, 611);
            buttonFinishOrder.Name = "buttonFinishOrder";
            buttonFinishOrder.Size = new Size(176, 31);
            buttonFinishOrder.TabIndex = 6;
            buttonFinishOrder.Text = "Finish selected order";
            buttonFinishOrder.UseVisualStyleBackColor = true;
            buttonFinishOrder.Click += buttonFinishOrder_Click;
            // 
            // buttonRefreshList
            // 
            buttonRefreshList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonRefreshList.Font = new Font("Arial", 12F);
            buttonRefreshList.Location = new Point(786, 611);
            buttonRefreshList.Name = "buttonRefreshList";
            buttonRefreshList.Size = new Size(176, 31);
            buttonRefreshList.TabIndex = 6;
            buttonRefreshList.Text = "Refresh";
            buttonRefreshList.UseVisualStyleBackColor = true;
            buttonRefreshList.Click += buttonRefreshList_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelReady });
            statusStrip1.Location = new Point(0, 670);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1367, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelReady
            // 
            toolStripStatusLabelReady.Name = "toolStripStatusLabelReady";
            toolStripStatusLabelReady.Size = new Size(39, 17);
            toolStripStatusLabelReady.Text = "Ready";
            // 
            // FormMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 692);
            Controls.Add(statusStrip1);
            Controls.Add(buttonRefreshList);
            Controls.Add(buttonFinishOrder);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxMain);
            Controls.Add(labelTitle);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1383, 731);
            MinimumSize = new Size(1383, 731);
            Name = "FormMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Order Manager";
            FormClosing += FormMainWindow_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem newOrderToolStripMenuItem;
        private ToolStripMenuItem openOrderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem fAQToolStripMenuItem;
        private Label labelTitle;
        private Label labelSONumberText;
        private Label labelSORegNum;
        private Label labelRespTechText;
        private GroupBox groupBoxMain;
        private TextBox textBoxRespTech;
        private Label labelDepartmentText;
        private ComboBox comboBoxDepartment;
        private RichTextBox richTextBoxDescription;
        private Label labelDescription;
        private ComboBox comboBoxPriority;
        private Label labelPriority;
        private Label labelOpenedText;
        private Label labelExpCompletionDate;
        private Label labelOpenedDateText;
        private DateTimePicker dateTimePickerDeadline;
        private Label labelStatus;
        private Label labelStatusText;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button buttonStart;
        private Button buttonResetOrder;
        private Button buttonFinishOrder;
        private Button buttonRefreshList;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelReady;
    }
}