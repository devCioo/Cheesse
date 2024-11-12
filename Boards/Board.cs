using Cheesse.Pieces;

namespace Cheesse.Boards
{
	public class Board
	{
		public IPiece[,] Grid { get; set; }

		public Board()
		{
			Grid = new IPiece[,]
			{
				{ new Rook(PieceColor.Black), new Knight(PieceColor.Black), new Bishop(PieceColor.Black), new Queen(PieceColor.Black),
				  new King(PieceColor.Black), new Bishop(PieceColor.Black), new Knight(PieceColor.Black), new Rook(PieceColor.Black) },
				{ new Pawn(PieceColor.Black), new Pawn(PieceColor.Black), new Pawn(PieceColor.Black), new Pawn(PieceColor.Black),
				  new Pawn(PieceColor.Black), new Pawn(PieceColor.Black), new Pawn(PieceColor.Black), new Pawn(PieceColor.Black)},
				{ null, null, null, null, null, null, null, null },
				{ null, null, null, null, null, null, null, null },
				{ null, null, null, null, null, null, null, null },
				{ null, null, null, null, null, null, null, null },
				{ new Pawn(PieceColor.White), new Pawn(PieceColor.White), new Pawn(PieceColor.White), new Pawn(PieceColor.White),
				  new Pawn(PieceColor.White), new Pawn(PieceColor.White), new Pawn(PieceColor.White), new Pawn(PieceColor.White)},
				{ new Rook(PieceColor.White), new Knight(PieceColor.White), new Bishop(PieceColor.White), new Queen(PieceColor.White),
				  new King(PieceColor.White), new Bishop(PieceColor.White), new Knight(PieceColor.White), new Rook(PieceColor.White) },
			};
		}
	}
}