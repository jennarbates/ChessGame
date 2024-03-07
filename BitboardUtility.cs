using System;
namespace ChessGame
{
	public static class BitboardUtility
	{

		public static void printBitboard(ulong bitboard)
		{
			String bitboardString = Convert.ToString((long)bitboard, 2);
            string missingZeros = new string('0', 64 - bitboardString.Length);
            bitboardString = missingZeros + bitboardString;
            for (int i = 0; i <= bitboardString.Length; i++)
            {
                if (i % 8 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write(bitboardString[i] + " ");

            }
        }
	}
}

