using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Human : Player
    {
        public Human(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return name;
        }

        public override Tuple<byte, byte> Shot()
        {
            Field result;
            byte x, y;
            int granicaX = 474, granicaY = 100, kratka = 40;
            x = Convert.ToByte(((Ships.MousePosition.X - Ships.ActiveForm.Bounds.X) - granicaX) / kratka);
            y = Convert.ToByte(((Ships.MousePosition.Y - Ships.ActiveForm.Bounds.Y) - granicaY) / kratka);
            result = hits.CheckIfTaken(x, y);
            if (result == Field.TAKEN)
                return null;
            Tuple<byte, byte> shot = new Tuple<byte, byte>(x, y);
            return shot;
        }
    }
}
