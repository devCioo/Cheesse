namespace Cheesse.Utils
{
	public static class BoardUtils
	{
		public static char GetColumnName(int column) => (char)(column + 'a');
		public static int GetColumnNumber(char column) => column - 'a';
		public static int GetRowName(int row) => 8 - row;
	}
}