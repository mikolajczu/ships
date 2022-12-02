using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    public enum Field
    {
        EMPTY,
        HIT,
        LOCATED,
        MISHIT,
        TAKEN
    }

    struct MapField
    {
        public Field f;
        public Ship s;
    }

    class Board
    {
        public MapField[,] map;

        public Board(int x)
        {
            map = new MapField[x, x];
            ClearBoard();
        }

        public void ClearBoard()
        {
            for (int i = 0; i < map.GetLength(0); i++)
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j].f = Field.EMPTY;
                    map[i, j].s = null;
                }
        }

        public bool PutShip(Ship ship)
        {
            int liczbaKratek = 9;
            if (ship.Direction == Direction.VERTICAL)
            {
                if (ship.Y + ship.Size > map.GetLength(0) || ship.X > liczbaKratek || ship.Y > liczbaKratek)
                    return false;

                for (int i = ship.Y - 1; i < ship.Y + ship.Size + 1; i++)
                {
                    if (i < 0 || i > map.GetLength(0) - 1) continue;
                    for (int j = ship.X - 1; j <= ship.X + 1; j++)
                    {
                        if (j < 0 || j > map.GetLength(0) - 1) continue;
                        if ((i == ship.Y - 1 || i == ship.Y + ship.Size + 1) && (j == ship.X - 1 || j == ship.X + 1)) continue;
                        if (map[i, j].f == Field.LOCATED)
                            return false;
                    }
                }
                for (int i = 0; i < ship.Size; i++)
                {
                    map[ship.Y + i, ship.X].f = Field.LOCATED;
                    map[ship.Y + i, ship.X].s = ship;
                }
            }
            else
            {
                if (ship.X + ship.Size > map.GetLength(0) || ship.X > liczbaKratek || ship.Y > liczbaKratek)
                    return false;

                for (int i = ship.Y - 1; i <= ship.Y + 1; i++)
                {
                    if (i < 0 || i > map.GetLength(0) - 1) continue;
                    for (int j = ship.X - 1; j < ship.X + ship.Size + 1; j++)
                    {
                        if (j < 0 || j > map.GetLength(0) - 1) continue;
                        if ((i == ship.Y - 1 || i == ship.Y + 1) && (j == ship.X - 1 || j == ship.X + ship.Size + 1)) continue;
                        if (map[i, j].f == Field.LOCATED)
                            return false;
                    }
                }
                for (int i = 0; i < ship.Size; i++)
                {
                    map[ship.Y, ship.X + i].f = Field.LOCATED;
                    map[ship.Y, ship.X + i].s = ship;
                }
            }
            return true;
        }

        public Field CheckIfTaken(int x, int y)
        {
            if (map[y, x].f == Field.MISHIT || map[y, x].f == Field.HIT)
                return Field.TAKEN;
            return Field.EMPTY;
        }

        public void MarkHit(int x, int y)
        {
            map[y, x].f = Field.HIT;
        }

        public void MarkMishit(int x, int y)
        {
            map[y, x].f = Field.MISHIT;
        }

        public Ship ExecuteShot(int x, int y)
        {
            if (map[y, x].s != null)
            {
                map[y, x].f = Field.HIT;
                if (map[y, x].s.Direction == Direction.VERTICAL && map[y, x].s.X == x)
                    map[y, x].s[y - map[y, x].s.Y] = true;
                else if (map[y, x].s.Direction == Direction.HORIZONTAL && map[y, x].s.Y == y)
                    map[y, x].s[x - map[y, x].s.X] = true;
            }
            else
                map[y, x].f = Field.MISHIT;

            return map[y, x].s;
        }
    }
}
