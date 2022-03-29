using SqlDataEditor.Presentation;
using SqlDataEditor.Properties;

namespace SqlDataEditor
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();

			MainPresenter presenter = new();
			presenter.Start();
			Settings.Default.Save();

		}
	}
}