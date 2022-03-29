namespace SqlDataEditor
{
    partial class LoginForm
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
			this.dialogPanel1 = new SqlDataEditor.Common.DialogPanel();
			this.serverEditor = new SqlDataEditor.Common.Editor();
			this.dbNameBox = new SqlDataEditor.Common.Editor();
			this.userBox = new SqlDataEditor.Common.Editor();
			this.passwdBox = new SqlDataEditor.Common.Editor();
			this.SuspendLayout();
			// 
			// dialogPanel1
			// 
			this.dialogPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.dialogPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dialogPanel1.Location = new System.Drawing.Point(0, 156);
			this.dialogPanel1.Name = "dialogPanel1";
			this.dialogPanel1.Size = new System.Drawing.Size(415, 51);
			this.dialogPanel1.TabIndex = 0;
			// 
			// serverEditor
			// 
			this.serverEditor.BackColor = System.Drawing.Color.Transparent;
			this.serverEditor.Header = "Server";
			this.serverEditor.Location = new System.Drawing.Point(12, 12);
			this.serverEditor.Name = "serverEditor";
			this.serverEditor.Size = new System.Drawing.Size(194, 61);
			this.serverEditor.TabIndex = 1;
			this.serverEditor.Type = SqlDataEditor.Common.Editor.EditorType.Text;
			// 
			// dbNameBox
			// 
			this.dbNameBox.BackColor = System.Drawing.Color.Transparent;
			this.dbNameBox.Header = "Database";
			this.dbNameBox.Location = new System.Drawing.Point(212, 12);
			this.dbNameBox.Name = "dbNameBox";
			this.dbNameBox.Size = new System.Drawing.Size(194, 61);
			this.dbNameBox.TabIndex = 2;
			this.dbNameBox.Type = SqlDataEditor.Common.Editor.EditorType.Text;
			// 
			// userBox
			// 
			this.userBox.BackColor = System.Drawing.Color.Transparent;
			this.userBox.Header = "User";
			this.userBox.Location = new System.Drawing.Point(12, 79);
			this.userBox.Name = "userBox";
			this.userBox.Size = new System.Drawing.Size(194, 61);
			this.userBox.TabIndex = 3;
			this.userBox.Type = SqlDataEditor.Common.Editor.EditorType.Text;
			// 
			// passwdBox
			// 
			this.passwdBox.BackColor = System.Drawing.Color.Transparent;
			this.passwdBox.Header = "Password";
			this.passwdBox.Location = new System.Drawing.Point(212, 79);
			this.passwdBox.Name = "passwdBox";
			this.passwdBox.Size = new System.Drawing.Size(194, 61);
			this.passwdBox.TabIndex = 4;
			this.passwdBox.Type = SqlDataEditor.Common.Editor.EditorType.Password;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(415, 207);
			this.Controls.Add(this.passwdBox);
			this.Controls.Add(this.userBox);
			this.Controls.Add(this.dbNameBox);
			this.Controls.Add(this.serverEditor);
			this.Controls.Add(this.dialogPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);

        }

        #endregion

        private Common.DialogPanel dialogPanel1;
        private Common.Editor serverEditor;
        private Common.Editor dbNameBox;
        private Common.Editor userBox;
        private Common.Editor passwdBox;
    }
}