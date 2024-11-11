namespace Cheesse.Pieces
{
	public interface IPiece
	{
		public PieceType Type { get; set; }
		public PieceColor Color { get; set; }
		public string Icon { get; set; }
	}
}