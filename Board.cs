using System;
namespace ChessGame
{
	public class Board
	{
		//64 bit representations of locations of each piece type of each color
		/*
		 * 
		 * This is the blackPawnBitBoard at the start of the game
		 * 
		 * 0 0 0 0 0 0 0 0
		 * 1 1 1 1 1 1 1 1
		 * 0 0 0 0 0 0 0 0
		 * 0 0 0 0 0 0 0 0
		 * 0 0 0 0 0 0 0 0
		 * 0 0 0 0 0 0 0 0
		 * 0 0 0 0 0 0 0 0
		 * 0 0 0 0 0 0 0 0
		 * 
		 * rank = horizontal rows
		 * file = vertical columns
		 */
		public ulong[] pieceBitboards = { 2921282437283, 2921282437283 }; 

		public void printBitboard(ulong bitboard)
		{
			Console.WriteLine(bitboard);
		}


	}
}

