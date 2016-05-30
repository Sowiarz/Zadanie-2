using System;
using System.IO;
using System.Windows.Forms;

namespace Zadanie_2
{
	class MainClass
	{
		[STAThread]
		public static void Main (string[] args)
		{
			var dialog = new OpenFileDialog
			{
				Multiselect = false,
				Title = "Open Hex Document",
			};
			using (dialog)
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					FileStream fs = new FileStream(dialog.FileName, FileMode.Open);

					int hexIn;
					String hexText = string.Empty;

					for (int i = 0; (hexIn = fs.ReadByte()) != -1; i++){
						hexText = string.Format("{0:X2}", hexIn);
					}
					Console.WriteLine (hexText);
				}
			}

		}

	}
}
