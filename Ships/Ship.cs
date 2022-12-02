using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    public enum Direction
    {
        HORIZONTAL,
        VERTICAL
    }

    class Ship
    {
        Direction direction;
        public Direction Direction { get { return direction; } }

        byte x;
        public byte X { get { return x; } }

        byte y;
        public byte Y { get { return y; } }

        bool[] masts;
        public bool this[int x]
        {
            get { return masts[x]; }
            set { masts[x] = value; }
        }
        public int Size { get { return masts.Length; } }

        public Ship(Direction direction, byte x, byte y, int size)
        {
            this.direction = direction;
            this.x = x;
            this.y = y;
            masts = new bool[size];
            for (int i = 0; i < size; i++)
                masts[i] = false;
        }
    }
}
