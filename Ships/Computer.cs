using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Computer : Player
    {
        public Computer(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return "Komputer";
        }

        public override Tuple<byte, byte> Shot()
        {
            Random r = new Random();
            var result = Field.TAKEN;
            byte x = 0, y = 0;
            while (result == Field.TAKEN)
            {
                x = Convert.ToByte(r.Next(10));
                y = Convert.ToByte(r.Next(10));
                result = hits.CheckIfTaken(x, y);
            }
            Tuple<byte, byte> shot = new Tuple<byte, byte>(x, y);
            return shot;
        }
    }
}
