namespace SqlDataEditor.Common
{
	partial class TabPageHeader
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.closeBtn = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "New Tab";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.BackColor = System.Drawing.Color.IndianRed;
			this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.closeBtn.ForeColor = System.Drawing.Color.Black;
			this.closeBtn.Location = new System.Drawing.Point(103, 0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(27, 30);
			this.closeBtn.TabIndex = 1;
			this.closeBtn.Text = "Х";
			this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.closeBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(103, 30);
			this.panel1.TabIndex = 2;
			// 
			// TabPageHeader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.closeBtn);
			this.MinimumSize = new System.Drawing.Size(130, 30);
			this.Name = "TabPageHeader";
			this.Size = new System.Drawing.Size(130, 30);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Label label1;
		private Label closeBtn;
		private Panel panel1;
	}
}
