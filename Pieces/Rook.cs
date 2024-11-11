using MudBlazor;

namespace Cheesse.Pieces
{
	public class Rook : IPiece
	{
		public PieceType Type { get; set; } = PieceType.Rook;
		public PieceColor Color { get; set; }
		public string Icon { get; set; } = Icons.Custom.Uncategorized.ChessRook;

		public Rook(PieceColor color)
		{
			Color = color;
		}
	}
}