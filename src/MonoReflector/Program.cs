using System;
using Gtk;

namespace MonoReflector
{
	internal static class Program
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow mainWindow = new MainWindow ();
			mainWindow.Show ();
			Application.Run ();
		}
	}
}
