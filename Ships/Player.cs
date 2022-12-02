using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ships
{
    abstract class Player
    {
        public List<Ship> ships;
        public Board fleet;
        public Board hits;
        public string name;

        public Player(string name)
        {
            this.name = name;
            fleet = new Board(10);
            hits = new Board(10);
            ships = new List<Ship>(7);
        }

        public abstract Tuple<byte, byte> Shot();

        public void Clear()
        {
            fleet.ClearBoard();
            hits.ClearBoard();
            ships.Clear();
        }

        public void PutRandomlyShips()
        {
            Clear();
            Random r = new Random();
            byte size;
            byte x;
            byte y;
            Direction direction;

            for (int i = 0; i < ships.Capacity; i++)
            {
                if (i == 0) size = 6;
                else if (i == 1 || i == 2) size = 4;
                else if (i == 3 || i == 4) size = 3;
                else size = 2;

                bool result = false;
                while (!result)
                {
                    x = Convert.ToByte(r.Next(11 - size));
                    y = Convert.ToByte(r.Next(11 - size));
                    int k = r.Next(2);
                    if (k == 0)
                        direction = Direction.HORIZONTAL;
                    else
                        direction = Direction.VERTICAL;

                    // dodajemy statek i sprawdzamy, czy udało się go położyć
                    Ship ship = new Ship(direction, x, y, size);
                    result = fleet.PutShip(ship);
                    if (result == true)
                        ships.Add(ship);
                }
            }
        }

        public bool CheckIfShipsSank()
        {
            if (ships.Count() == 0) return true;
            return false;
        }

        public void DidShipSank()
        {
            for (int i = 0; i < ships.Count(); i++)
            {
                bool drown = true;
                for (int j = 0; j < ships[i].Size; j++)
                {
                    if (ships[i][j] == false)
                        drown = false;
                }
                if (drown == true)
                {
                    MessageBox.Show("The " + ships[i].Size + "-masted ship sank!!!");
                    ships.Remove(ships[i]);
                    return;
                }
            }
        }

        public Ship ExecuteShot(Tuple<byte, byte> shot)
        {
            return fleet.ExecuteShot(shot.Item1, shot.Item2);
        }

        public void MarkShot(Ship executedShot, Tuple<byte, byte> shot)
        {
            if (executedShot != null)
                hits.MarkHit(shot.Item1, shot.Item2);
            else
                hits.MarkMishit(shot.Item1, shot.Item2);
        }
    }
}
