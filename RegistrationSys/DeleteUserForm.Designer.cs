namespace RegistrationSys
{
    partial class DeleteUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserForm));
            label1 = new Label();
            textBoxRegCode = new TextBox();
            buttonConfirmDelete = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Registration Code: ";
            // 
            // textBoxRegCode
            // 
            textBoxRegCode.CharacterCasing = CharacterCasing.Upper;
            textBoxRegCode.Location = new Point(125, 17);
            textBoxRegCode.Name = "textBoxRegCode";
            textBoxRegCode.Size = new Size(179, 23);
            textBoxRegCode.TabIndex = 1;
            // 
            // buttonConfirmDelete
            // 
            buttonConfirmDelete.Font = new Font("Segoe UI", 12F);
            buttonConfirmDelete.Location = new Point(57, 57);
            buttonConfirmDelete.Name = "buttonConfirmDelete";
            buttonConfirmDelete.Size = new Size(92, 34);
            buttonConfirmDelete.TabIndex = 2;
            buttonConfirmDelete.Text = "Delete";
            buttonConfirmDelete.UseVisualStyleBackColor = true;
            buttonConfirmDelete.Click += buttonConfirmDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F);
            buttonCancel.Location = new Point(170, 57);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(92, 34);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Close";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += button1_Click;
            // 
            // DeleteUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 103);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirmDelete);
            Controls.Add(textBoxRegCode);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxRegCode;
        private Button buttonConfirmDelete;
        private Button buttonCancel;
    }
}