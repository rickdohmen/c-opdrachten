using System;

namespace les3
{
    class Room
    {
       public void kamer(int x, int y)
        {
            int[][] coordinations = new int[7][];
            for (int y = 0; y < coordinations.Length; y++)
            {
                coordinations[y] = new int[4];
                for (int coordI = 0; coordI < coordinations.Length; coordI++)
                {
                    coordinations[y][coordI] = 0;
                }
            }
        }
    }

    class Tile
    {

    }
}
