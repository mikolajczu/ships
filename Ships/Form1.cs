using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ships
{
    public partial class Ships : Form
    {
        Thread th;
        bool roundEnd = true;
        List<Player> players = new List<Player>(2);
        bool[] m_ship = new bool[7];

        public Ships()
        {
            InitializeComponent();
            back.Hide();
            label1.Hide();
            fleet.Hide();
            hits.Hide();
            putRandomlyButton.Hide();
            clearButton.Hide();
            startButton.Hide();
            ship6.Hide();
            ship42.Hide();
            ship41.Hide();
            ship31.Hide();
            ship32.Hide();
            ship22.Hide();
            ship21.Hide();
            label1.Parent = background;
            fleet.Parent = background;
            back.Parent = background;
            putRandomlyButton.Parent = background;
            clearButton.Parent = background;
            startButton.Parent = background;
            players.Add(new Human("Player1"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            tytuł.Show();
            pvp.Show();
            pvc.Show();
            quit.Show();
            back.Hide();
            label1.Hide();
            fleet.Hide();
            putRandomlyButton.Hide();
            clearButton.Hide();
            startButton.Hide();
            ship6.Hide();
            ship42.Hide();
            ship41.Hide();
            ship31.Hide();
            ship32.Hide();
            ship22.Hide();
            ship21.Hide();
            players[0].Clear();
            if (back.Text == "Menu")
                fleet.Location = new Point(fleet.Location.X + 221, fleet.Location.Y + 26);
            hits.Hide();
            back.Text = "back";
        }

        private void pvp_Click(object sender, EventArgs e)
        {
            //tytuł.Hide();
            //pvp.Hide();
            //pvc.Hide();
            //quit.Hide();
            //back.Show();
            //label1.Show();
            //fleet.Show();
            //putRandomlyButton.Show();
            //clearButton.Show();
            //startButton.Show();
            //ship6.Show();
            //ship42.Show();
            //ship41.Show();
            //ship31.Show();
            //ship32.Show();
            //ship22.Show();
            //ship21.Show();
            //Human player2 = new Human("Player2");
            //if (players.Count == 2)
            //    players.RemoveAt(1);
            //players.Add(player2);
        }

        private void pvc_Click(object sender, EventArgs e)
        {
            tytuł.Hide();
            pvp.Hide();
            pvc.Hide();
            quit.Hide();
            back.Show();
            label1.Show();
            fleet.Show();
            putRandomlyButton.Show();
            clearButton.Show();
            startButton.Show();
            ship6.Show();
            ship42.Show();
            ship41.Show();
            ship31.Show();
            ship32.Show();
            ship22.Show();
            ship21.Show();
            Computer computer = new Computer("Computer");
            if (players.Count == 2)
                players.RemoveAt(1);
            players.Add(computer);
            players[1].PutRandomlyShips();
        }

        private void fleet_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Pen pGreen = new Pen(Color.Green);
            Pen pGreen2 = new Pen(Color.Green, 3);
            Pen pRed2 = new Pen(Color.Red, 3);
            Brush b = new SolidBrush(Color.Green);
            int kratka = 40;
            for (int i = 0; i <= 500; i += kratka)
            {
                z.DrawLine(pGreen, i, 0, i, 500);
                z.DrawLine(pGreen, 0, i, 500, i);
            }
            for (int i = 0; i < players[0].fleet.map.GetLength(0); i++)
                for (int j = 0; j < players[0].fleet.map.GetLength(1); j++)
                {
                    if (players[0].fleet.map[i, j].f == Field.LOCATED)
                    {
                        z.FillRectangle(b, j * kratka, i * kratka, kratka, kratka);
                        z.DrawRectangle(new Pen(Color.DarkGreen), j * kratka, i * kratka, kratka, kratka);
                    }
                    else if (players[0].fleet.map[i, j].f == Field.HIT)
                    {
                        z.DrawEllipse(pRed2, j * kratka + 5, i * kratka + 5, 30, 30);
                        z.DrawEllipse(pRed2, j * kratka + 15, i * kratka + 15, 10, 10);
                        z.DrawLine(pRed2, j * kratka + 20, i * kratka, j * kratka + 20, i * kratka + 15);
                        z.DrawLine(pRed2, j * kratka + 20, i * kratka + 25, j * kratka + 20, i * kratka + kratka);
                        z.DrawLine(pRed2, j * kratka, i * kratka + 20, j * kratka + 15, i * kratka + 20);
                        z.DrawLine(pRed2, j * kratka + 25, i * kratka + 20, j * kratka + 40, i * kratka + 20);
                        z.DrawRectangle(new Pen(Color.DarkGreen), j * kratka, i * kratka, kratka, kratka);
                    }
                    else if (players[0].fleet.map[i, j].f == Field.MISHIT)
                    {
                        z.DrawEllipse(pGreen2, j * kratka + 5, i * kratka + 5, 30, 30);
                        z.DrawEllipse(pGreen2, j * kratka + 15, i * kratka + 15, 10, 10);
                        z.DrawLine(pGreen2, j * kratka + 20, i * kratka, j * kratka + 20, i * kratka + 15);
                        z.DrawLine(pGreen2, j * kratka + 20, i * kratka + 25, j * kratka + 20, i * kratka + 40);
                        z.DrawLine(pGreen2, j * kratka, i * kratka + 20, j * kratka + 15, i * kratka + 20);
                        z.DrawLine(pGreen2, j * kratka + 25, i * kratka + 20, j * kratka + 40, i * kratka + 20);
                        z.DrawRectangle(new Pen(Color.DarkGreen), j * kratka, i * kratka, kratka, kratka);
                    }
                }
        }

        private void hits_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Pen pGreen = new Pen(Color.Green);
            Pen pGreen2 = new Pen(Color.Green, 3);
            Pen pRed2 = new Pen(Color.Red, 3);
            Brush b = new SolidBrush(Color.Green);
            int kratka = 40;
            for (int i = 0; i <= 500; i += kratka)
            {
                z.DrawLine(pGreen, i, 0, i, 500);
                z.DrawLine(pGreen, 0, i, 500, i);
            }
            for (int i = 0; i < players[0].hits.map.GetLength(0); i++)
                for (int j = 0; j < players[0].hits.map.GetLength(1); j++)
                {
                    if (players[0].hits.map[i, j].f == Field.LOCATED)
                    {
                        z.FillRectangle(b, j * kratka, i * kratka, kratka, kratka);
                        z.DrawRectangle(new Pen(Color.DarkGreen), j * kratka, i * kratka, kratka, kratka);
                    }
                    else if (players[0].hits.map[i, j].f == Field.HIT)
                    {
                        z.DrawEllipse(pRed2, j * kratka + 5, i * kratka + 5, 30, 30);
                        z.DrawEllipse(pRed2, j * kratka + 15, i * kratka + 15, 10, 10);
                        z.DrawLine(pRed2, j * kratka + 20, i * kratka, j * kratka + 20, i * kratka + 15);
                        z.DrawLine(pRed2, j * kratka + 20, i * kratka + 25, j * kratka + 20, i * kratka + 40);
                        z.DrawLine(pRed2, j * kratka, i * kratka + 20, j * kratka + 15, i * kratka + 20);
                        z.DrawLine(pRed2, j * kratka + 25, i * kratka + 20, j * kratka + 40, i * kratka + 20);
                        z.DrawRectangle(new Pen(Color.DarkGreen), j * kratka, i * kratka, kratka, kratka);
                    }
                    else if (players[0].hits.map[i, j].f == Field.MISHIT)
                    {
                        z.DrawEllipse(pGreen2, j * kratka + 5, i * kratka + 5, 30, 30);
                        z.DrawEllipse(pGreen2, j * kratka + 15, i * kratka + 15, 10, 10);
                        z.DrawLine(pGreen2, j * kratka + 20, i * kratka, j * kratka + 20, i * kratka + 15);
                        z.DrawLine(pGreen2, j * kratka + 20, i * kratka + 25, j * kratka + 20, i * kratka + 40);
                        z.DrawLine(pGreen2, j * kratka, i * kratka + 20, j * kratka + 15, i * kratka + 20);
                        z.DrawLine(pGreen2, j * kratka + 25, i * kratka + 20, j * kratka + 40, i * kratka + 20);
                        z.DrawRectangle(new Pen(Color.DarkGreen), j * kratka, i * kratka, kratka, kratka);
                    }
                }
        }

        private void putRandomlyButton_Click(object sender, EventArgs e)
        {
            players[0].PutRandomlyShips();
            ship6.Hide();
            ship42.Hide();
            ship41.Hide();
            ship31.Hide();
            ship32.Hide();
            ship22.Hide();
            ship21.Hide();
            fleet.Invalidate();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            players[0].Clear();
            ship6.Show();
            ship42.Show();
            ship41.Show();
            ship31.Show();
            ship32.Show();
            ship22.Show();
            ship21.Show();
            fleet.Invalidate();
            ship6.Left = 664;
            ship6.Top = 93;
            ship41.Left = 718;
            ship41.Top = 93;
            ship42.Left = 772;
            ship42.Top = 93;
            ship31.Left = 827;
            ship31.Top = 93;
            ship32.Left = 718;
            ship32.Top = 277;
            ship21.Left = 772;
            ship21.Top = 277;
            ship22.Left = 827;
            ship22.Top = 277;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (players[0].ships.Count != players[0].ships.Capacity)
            {
                MessageBox.Show("PUT YOUR FLEET UP!!!");
                return;
            }
            putRandomlyButton.Hide();
            clearButton.Hide();
            startButton.Hide();
            label1.Hide();
            hits.Show();
            fleet.Location = new Point(fleet.Location.X - 221, fleet.Location.Y - 26);
            back.Text = "Menu";
        }

        #region ShipMoving
        private void move_ShipOnBackground(int width, int height, MouseEventArgs e)
        {
            if (m_ship[6] == true)
            {
                ship6.Left = (background.Width - width) / 2 + e.X - 20;
                ship6.Top = (background.Height - height) / 2 + e.Y - 20;
            }
            if (m_ship[5] == true)
            {
                ship41.Left = (background.Width - width) / 2 + e.X - 20;
                ship41.Top = (background.Height - height) / 2 + e.Y - 20;
            }
            if (m_ship[4] == true)
            {
                ship42.Left = (background.Width - width) / 2 + e.X - 20;
                ship42.Top = (background.Height - height) / 2 + e.Y - 20;
            }
            if (m_ship[3] == true)
            {
                ship31.Left = (background.Width - width) / 2 + e.X - 20;
                ship31.Top = (background.Height - height) / 2 + e.Y - 20;
            }
            if (m_ship[2] == true)
            {
                ship32.Left = (background.Width - width) / 2 + e.X - 20;
                ship32.Top = (background.Height - height) / 2 + e.Y - 20;
            }
            if (m_ship[1] == true)
            {
                ship21.Left = (background.Width - width) / 2 + e.X - 20;
                ship21.Top = (background.Height - height) / 2 + e.Y - 20;
            }
            if (m_ship[0] == true)
            {
                ship22.Left = (background.Width - width) / 2 + e.X - 20;
                ship22.Top = (background.Height - height) / 2 + e.Y - 20;
            }
        }

        private void move_Ship(MouseEventArgs e)
        {
            if (m_ship[6] == true)
            {
                ship6.Left += e.X - 20;
                ship6.Top += e.Y - 20;
            }
            if (m_ship[5] == true)
            {
                ship41.Left += e.X - 20;
                ship41.Top += e.Y - 20;
            }
            if (m_ship[4] == true)
            {
                ship42.Left += e.X - 20;
                ship42.Top += e.Y - 20;
            }
            if (m_ship[3] == true)
            {
                ship31.Left += e.X - 20;
                ship31.Top += e.Y - 20;
            }
            if (m_ship[2] == true)
            {
                ship32.Left += e.X - 20;
                ship32.Top += e.Y - 20;
            }
            if (m_ship[1] == true)
            {
                ship21.Left += e.X - 20;
                ship21.Top += e.Y - 20;
            }
            if (m_ship[0] == true)
            {
                ship22.Left += e.X - 20;
                ship22.Top += e.Y - 20;
            }
        }

        private void ship6_MouseMove(object sender, MouseEventArgs e)
        {
            move_Ship(e);
        }

        private void ship41_MouseMove(object sender, MouseEventArgs e)
        {
            move_Ship(e);
        }

        private void ship42_MouseMove(object sender, MouseEventArgs e)
        {
            move_Ship(e);
        }

        private void ship31_MouseMove(object sender, MouseEventArgs e)
        {
            move_Ship(e);
        }

        private void ship32_MouseMove(object sender, MouseEventArgs e)
        {
            move_Ship(e);
        }

        private void ship21_MouseMove(object sender, MouseEventArgs e)
        {
            move_Ship(e);
        }

        private void ship22_MouseMove(object sender, MouseEventArgs e)
        {
            move_Ship(e);
        }

        private void background_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_ship[6] == true)
            {
                ship6.Left = e.X - 20;
                ship6.Top = e.Y - 20;
            }
            if (m_ship[4] == true)
            {
                ship42.Left = e.X - 20;
                ship42.Top = e.Y - 20;
            }
            if (m_ship[5] == true)
            {
                ship41.Left = e.X - 20;
                ship41.Top = e.Y - 20;
            }
            if (m_ship[2] == true)
            {
                ship32.Left = e.X - 20;
                ship32.Top = e.Y - 20;
            }
            if (m_ship[3] == true)
            {
                ship31.Left = e.X - 20;
                ship31.Top = e.Y - 20;
            }
            if (m_ship[0] == true)
            {
                ship22.Left = e.X - 20;
                ship22.Top = e.Y - 20;
            }
            if (m_ship[1] == true)
            {
                ship21.Left = e.X - 20;
                ship21.Top = e.Y - 20;
            }
        }
#endregion

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            move_ShipOnBackground(label1.Width, label1.Height, e);
        }

        private void fleet_MouseMove(object sender, MouseEventArgs e)
        {
            move_ShipOnBackground(fleet.Width, fleet.Height, e);
        }

        private bool rotateOrMoveShip(int which, int width, int height, object target, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var width1 = target.GetType().GetProperty("Width");
                var height1 = target.GetType().GetProperty("Height");
                width1.SetValue(target, height);
                height1.SetValue(target, width);
            }
            if (e.Button == MouseButtons.Left)
            {
                if (m_ship[which] == false)
                    m_ship[which] = true;
                else
                {
                    m_ship[which] = false;
                    Direction d;
                    if (width > height)
                        d = Direction.HORIZONTAL;
                    else
                        d = Direction.VERTICAL;
                    int size;
                    if (which == 6) size = 6;
                    else if (which == 5 || which == 4) size = 4;
                    else if (which == 3 || which == 2) size = 3;
                    else size = 2;
                    try
                    {
                        Ship ship = new Ship(d, Convert.ToByte(((Ships.MousePosition.X - Ships.ActiveForm.Bounds.X) - 244) / 40), Convert.ToByte(((Ships.MousePosition.Y - Ships.ActiveForm.Bounds.Y) - 93) / 40 - 1), size);
                        var result = players[0].fleet.PutShip(ship);
                        if (result == true)
                        {
                            players[0].ships.Add(ship);
                            return true;
                        }
                        else
                            return false;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        #region MouseClick
        private void ship6_MouseClick(object sender, MouseEventArgs e)
        {
            ship6.BringToFront();
            bool result = rotateOrMoveShip(6, ship6.Width, ship6.Height, ship6, e);
            if(result == true)
            {
                fleet.Invalidate();
                ship6.Hide();
            }
            else
            {
                ship6.Left = 664;
                ship6.Top = 93;
            }
        }

        private void ship41_MouseClick(object sender, MouseEventArgs e)
        {
            ship41.BringToFront();
            bool result = rotateOrMoveShip(5, ship41.Width, ship41.Height, ship41, e);
            if (result == true)
            {
                fleet.Invalidate();
                ship41.Hide();
            }
            else
            {
                ship41.Left = 718;
                ship41.Top = 93;
            }
        }

        private void ship42_MouseClick(object sender, MouseEventArgs e)
        {
            ship42.BringToFront();
            bool result = rotateOrMoveShip(4, ship42.Width, ship42.Height, ship42, e);
            if (result == true)
            {
                fleet.Invalidate();
                ship42.Hide();
            }
            else
            {
                ship42.Left = 772;
                ship42.Top = 93;
            }
        }

        private void ship31_MouseClick(object sender, MouseEventArgs e)
        {
            ship31.BringToFront();
            bool result = rotateOrMoveShip(3, ship31.Width, ship31.Height, ship31, e);
            if (result == true)
            {
                fleet.Invalidate();
                ship31.Hide();
            }
            else
            {
                ship31.Left = 827;
                ship31.Top = 93;
            }
        }

        private void ship32_MouseClick(object sender, MouseEventArgs e)
        {
            ship32.BringToFront();
            bool result = rotateOrMoveShip(2, ship32.Width, ship32.Height, ship32, e);
            if (result == true)
            {
                fleet.Invalidate();
                ship32.Hide();
            }
            else
            {
                ship32.Left = 718;
                ship32.Top = 277;
            }
        }

        private void ship21_MouseClick(object sender, MouseEventArgs e)
        {
            ship21.BringToFront();
            bool result = rotateOrMoveShip(1, ship21.Width, ship21.Height, ship21, e);
            if (result == true)
            {
                fleet.Invalidate();
                ship21.Hide();
            }
            else
            {
                ship21.Left = 772;
                ship21.Top = 277;
            }
        }

        private void ship22_MouseClick(object sender, MouseEventArgs e)
        {
            ship22.BringToFront();
            bool result = rotateOrMoveShip(0, ship22.Width, ship22.Height, ship22, e);
            if (result == true)
            {
                fleet.Invalidate();
                ship22.Hide();
            }
            else
            {
                ship22.Left = 827;
                ship22.Top = 277;
            }
        }
        #endregion

        byte i = 0;
        private void game()
        {
            roundEnd = false;
            Tuple<byte, byte> shot = players[0].Shot();
            if (shot == null)
                return;
            Ship executedShot = players[1].ExecuteShot(shot);
            players[0].MarkShot(executedShot, shot);
            if (executedShot != null)
                players[1].DidShipSank();

            if (i > 23 && players[1].CheckIfShipsSank() == true)
            {
                MessageBox.Show(players[0].name + " WON!!!");
                Close();
            }
            hits.Invalidate();

            Thread.Sleep(1000);

            Tuple<byte, byte> computerShot = players[1].Shot();
            var executedComputerShot = players[0].ExecuteShot(computerShot);
            players[1].MarkShot(executedComputerShot, computerShot);
            if (executedComputerShot != null)
                players[0].DidShipSank();

            if (i > 23 && players[0].CheckIfShipsSank() == true)
            {
                MessageBox.Show(players[1].name + " WON!!!");
                Close();
            }

            i++;
            fleet.Invalidate();

            roundEnd = true;
        }

        private void hits_MouseClick(object sender, MouseEventArgs e)
        {
            if (roundEnd == true)
            {
                th = new Thread(game);
                th.Start();
            }
        }
    }
}
