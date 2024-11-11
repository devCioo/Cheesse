using MudBlazor;

namespace Cheesse.Pieces
{
	public class King : IPiece
	{
		public PieceType Type { get; set; } = PieceType.King;
		public PieceColor Color { get; set; }
		public string Icon { get; set; } = Icons.Custom.Uncategorized.ChessKing;

		public King(PieceColor color)
		{
			Color = color;
		}
	}
}