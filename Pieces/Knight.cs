using MudBlazor;

namespace Cheesse.Pieces
{
	public class Knight : IPiece
	{
		public PieceType Type { get; set; } = PieceType.Knight;
		public PieceColor Color { get; set; }
		public string Icon { get; set; } = Icons.Custom.Uncategorized.ChessKnight;

		public Knight(PieceColor color)
		{
			Color = color;
		}
	}
}