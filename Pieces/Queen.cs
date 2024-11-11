using MudBlazor;

namespace Cheesse.Pieces
{
	public class Queen : IPiece
	{
		public PieceType Type { get; set; } = PieceType.Queen;
		public PieceColor Color { get; set; }
		public string Icon { get; set; } = Icons.Custom.Uncategorized.ChessQueen;

		public Queen(PieceColor color)
		{
			Color = color;
		}
	}
}