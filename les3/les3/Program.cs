using System;

namespace les3
{
    class Room
    {
       public void kamer(int x, int y)
        {
            Tile[][] coordinations = new Tile[7][];
            for (y = 0; y < coordinations.Length; y++)
            {
                coordinations[y] = new Tile[4];
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
