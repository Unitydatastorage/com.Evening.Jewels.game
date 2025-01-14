﻿namespace MatchThreeEngine
{
    public sealed class Match
    {
        public readonly int TypeId;

        public readonly int Score;

        public readonly TileInfo[] Tiles;

        public Match(TileInfo origin, TileInfo[] horizontal, TileInfo[] vertical)
        {
            TypeId = origin.TypeId;

            if (horizontal.Length >= 2 && vertical.Length >= 2)
            {
                Tiles = new TileInfo[horizontal.Length + vertical.Length + 1];

                Tiles[0] = origin;

                horizontal.CopyTo(Tiles, 1);

                vertical.CopyTo(Tiles, horizontal.Length + 1);
            }
            else if (horizontal.Length >= 2)
            {
                Tiles = new TileInfo[horizontal.Length + 1];

                Tiles[0] = origin;

                horizontal.CopyTo(Tiles, 1);
            }
            else if (vertical.Length >= 2)
            {
                Tiles = new TileInfo[vertical.Length + 1];

                Tiles[0] = origin;

                vertical.CopyTo(Tiles, 1);
            }
            else Tiles = null;

            Score = Tiles?.Length ?? -1;
        }
    }
}