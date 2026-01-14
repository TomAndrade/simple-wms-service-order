namespace RegistrationSys
{
    partial class FindUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindUserForm));
            textBoxFindUser = new TextBox();
            buttonFind = new Button();
            buttonCancel = new Button();
            comboBoxFindBy = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxFindUser
            // 
            textBoxFindUser.CharacterCasing = CharacterCasing.Upper;
            textBoxFindUser.Enabled = false;
            textBoxFindUser.Location = new Point(170, 18);
            textBoxFindUser.Name = "textBoxFindUser";
            textBoxFindUser.Size = new Size(132, 23);
            textBoxFindUser.TabIndex = 2;
            // 
            // buttonFind
            // 
            buttonFind.Enabled = false;
            buttonFind.Font = new Font("Segoe UI", 12F);
            buttonFind.Location = new Point(56, 96);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(92, 34);
            buttonFind.TabIndex = 3;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F);
            buttonCancel.Location = new Point(170, 96);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(92, 34);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxFindBy
            // 
            comboBoxFindBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFindBy.FormattingEnabled = true;
            comboBoxFindBy.Items.AddRange(new object[] { "Username", "RegCode" });
            comboBoxFindBy.Location = new Point(27, 18);
            comboBoxFindBy.Name = "comboBoxFindBy";
            comboBoxFindBy.Size = new Size(121, 23);
            comboBoxFindBy.TabIndex = 1;
            comboBoxFindBy.SelectedIndexChanged += comboBoxFindBy_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 63);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // FindUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 142);
            Controls.Add(label1);
            Controls.Add(comboBoxFindBy);
            Controls.Add(buttonCancel);
            Controls.Add(buttonFind);
            Controls.Add(textBoxFindUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FindUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxFindUser;
        private Button buttonFind;
        private Button buttonCancel;
        private ComboBox comboBoxFindBy;
        private Label label1;
    }
}