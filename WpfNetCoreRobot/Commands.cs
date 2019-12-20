using System;
using System.Collections.Generic;
using System.Text;

namespace WpfNetCoreRobot
{
    /// <summary>
    /// Commands class runs all the commands which are despatched from the ShellView and ShellViewModel
    /// </summary>
    public class Commands
    {
        public Coordinates Left(Coordinates coord)
        {
            if (coord.Pole == Pole.NORTH)
            {
                coord.Pole = Pole.WEST;
            }
            else if (coord.Pole == Pole.EAST)
            {
                coord.Pole = Pole.NORTH;
            }
            else if (coord.Pole == Pole.SOUTH)
            {
                coord.Pole = Pole.EAST;
            }
            else if (coord.Pole == Pole.WEST)
            {
                coord.Pole = Pole.SOUTH;
            }
            else
            {
                return coord;
            }
            return coord;
        }

        public Coordinates Right(Coordinates coord)
        {
            if (coord.Pole == Pole.NORTH)
            {
                coord.Pole = Pole.EAST;
            }
            else if (coord.Pole == Pole.EAST)
            {
                coord.Pole = Pole.SOUTH;
            }
            else if (coord.Pole == Pole.SOUTH)
            {
                coord.Pole = Pole.WEST;
            }
            else if (coord.Pole == Pole.WEST)
            {
                coord.Pole = Pole.NORTH;
            }
            else
            {
                return coord;
            }
            return coord;
        }

        public Coordinates Move(Coordinates coord)
        {
            if (coord.Pole == Pole.NORTH)
            {
                if (coord.Y < 4)
                {
                    coord.Y++;
                } 
            }
            else if (coord.Pole == Pole.SOUTH)
            {
                if (coord.Y > 0)
                {
                    coord.Y--;
                }
            }
            else if (coord.Pole == Pole.EAST)
            {
                if (coord.X < 4)
                {
                    coord.X++;
                }
            }
            else if (coord.Pole == Pole.WEST)
            {
                if (coord.X > 0)
                {
                    coord.X--;
                }
                    
            }
            else
            {
                return coord;
            }
            return coord;
        }

        public Coordinates Place(Coordinates coord, int x, int y, Pole pole)
        {
            coord.X = x;
            coord.Y = y;
            coord.Pole = pole;
            return coord;
        }
    }
}
