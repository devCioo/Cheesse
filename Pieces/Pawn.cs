using MudBlazor;

namespace Cheesse.Pieces
{
	public class Pawn : IPiece
	{
		public PieceType Type { get; set; } = PieceType.Pawn;
		public PieceColor Color { get; set; }
		public string Icon { get; set; } = Icons.Custom.Uncategorized.ChessPawn;

		public Pawn(PieceColor color)
		{
			Color = color;
		}
	}
}