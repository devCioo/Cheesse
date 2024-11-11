using MudBlazor;

namespace Cheesse.Pieces
{
	public class Bishop : IPiece
	{
		public PieceType Type { get; set; } = PieceType.Bishop;
		public PieceColor Color { get; set; }
		public string Icon { get; set; } = Icons.Custom.Uncategorized.ChessBishop;

		public Bishop(PieceColor color)
		{
			Color = color;
		}
	}
}