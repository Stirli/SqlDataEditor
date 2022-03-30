namespace SqlDataEditor.Common
{
	partial class TabControlEx
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
			this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// headerPanel
			// 
			this.headerPanel.AutoScroll = true;
			this.headerPanel.AutoScrollMargin = new System.Drawing.Size(50, 50);
			this.headerPanel.AutoSize = true;
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.MinimumSize = new System.Drawing.Size(0, 30);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(347, 30);
			this.headerPanel.TabIndex = 0;
			// 
			// contentPanel
			// 
			this.contentPanel.BackColor = System.Drawing.Color.RosyBrown;
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(0, 30);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(347, 409);
			this.contentPanel.TabIndex = 1;
			// 
			// TabControlEx
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.headerPanel);
			this.Name = "TabControlEx";
			this.Size = new System.Drawing.Size(347, 439);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private FlowLayoutPanel headerPanel;
		private Panel contentPanel;
	}
}
