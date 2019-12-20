using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;

namespace WpfNetCoreRobot
{
    public enum Pole
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
        }

    /// <summary>
    /// The Coordinates class has the properties for x,y and pole
    /// </summary>
    public class Coordinates: Screen
    {
        private int _x;
        private int _y;
        private Pole _pole;

        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
                NotifyOfPropertyChange(() => X);
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
                NotifyOfPropertyChange(() => Y);
            }
        }

        public Pole Pole
        {
            get { return _pole; }
            set
            {
                _pole = value;
                NotifyOfPropertyChange(() => Pole);
            }
        }

        public Coordinates()
        {
            X = 0;
            Y = 0;
            Pole = 0;
        }
    }
}
