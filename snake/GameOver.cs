using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class GameOver
    {
		private int Bunda;

		public GameOver(int Bunda)
		{
			this.Bunda = Bunda;
		}

		public void Ending()
		{
			Console.Clear();
			Console.SetWindowSize(90, 30);
			int xOff = 6;
			int yOff = 12;
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.SetCursorPosition(xOff, yOff++);
			WriteText("=====================================", xOff + 20, yOff++);
			WriteText("G A M E     O V E R", xOff + 30, yOff++);
			WriteText("=====================================", xOff + 20, yOff++);
		}

		static void WriteText(string text, int xOff, int yOff)
		{
			Console.SetCursorPosition(xOff, yOff);
			Console.WriteLine(text);
		}
	}
}
