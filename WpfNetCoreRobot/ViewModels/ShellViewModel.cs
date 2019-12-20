using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using Caliburn.Micro;

namespace WpfNetCoreRobot.ViewModels
{
    public class ShellViewModel: Screen
    {

        private BindableCollection<Coordinates> _coords;
        public BindableCollection<Coordinates> Coords
        {
            get { return _coords; }
            set
            {
                _coords = value;
                NotifyOfPropertyChange(() => Coords);
            }
        }

        private BindableCollection<CommandClass> _commandsToProcess;
        public BindableCollection<CommandClass> CommandsToProcess
        {
            get { return _commandsToProcess; }
            set
            {
                _commandsToProcess = value;
                NotifyOfPropertyChange(() => CommandsToProcess);
            }
        }

        public ListView CoordsListView { get; private set; }
        public ListView CommandsListView { get; private set; }
        public string TextCommand { get; set; }
        public ShellViewModel()
        {
            Coords = new BindableCollection<Coordinates>();
            Coords.Add(new Coordinates());
            CommandsToProcess = new BindableCollection<CommandClass>();
        }
        public void Move()
        {
            var Comm = new Commands();
            foreach(var coo in Coords)
            {
                Comm.Move(coo);
            }
            NotifyOfPropertyChange(() => Coords);
            NotifyOfPropertyChange(() => CoordsListView);
        }

        public void Left()
        {
            var Comm = new Commands();
            foreach (var coo in Coords)
            {
                Comm.Left(coo);
            }
            NotifyOfPropertyChange(() => Coords);
            NotifyOfPropertyChange(() => CoordsListView);
        }

        public void Right()
        {
            var Comm = new Commands();
            foreach (var coo in Coords)
            {
                Comm.Right(coo);
            }
            NotifyOfPropertyChange(() => Coords);
            NotifyOfPropertyChange(() => CoordsListView);
        }

        public void Place(int x, int y, Pole pole)
        {
            var Comm = new Commands();
            foreach (var coo in Coords)
            {
                if (Enumerable.Range(0, 4).Contains(x) && Enumerable.Range(0, 4).Contains(y))
                {
                    Comm.Place(coo, x, y, pole);
                }
            }
            NotifyOfPropertyChange(() => Coords);
            NotifyOfPropertyChange(() => CoordsListView);
        }

        public void EnterCommand()
        {
            CommandsToProcess.Add(new CommandClass(TextCommand));
            NotifyOfPropertyChange(() => CommandsToProcess);
            NotifyOfPropertyChange(() => CommandsListView);
        }

        public void RunAllCommands()
        {
            int PlaceFlag = 0;
            foreach (var commandToProcess in CommandsToProcess)
            {
                if (PlaceFlag == 0)
                {
                    if (commandToProcess.CommandToRun.ToUpper().Contains("PLACE"))
                    {
                        string[] placeArray;
                        placeArray = commandToProcess.CommandToRun.Split(',');
                        Enum.TryParse(placeArray[2].ToUpper(), out Pole poleOut);
                        Place(Convert.ToInt32(placeArray[1]), Convert.ToInt32(placeArray[1]), poleOut);
                        PlaceFlag = 1;
                    }
                }
                else
                {
                    if (commandToProcess.CommandToRun.ToUpper().Contains("PLACE"))
                    {
                        string[] placeArray;
                        placeArray = commandToProcess.CommandToRun.Split(',');
                        Enum.TryParse(placeArray[2].ToUpper(), out Pole poleOut);
                        Place(Convert.ToInt32(placeArray[1]), Convert.ToInt32(placeArray[1]), poleOut);
                    }
                    else if (commandToProcess.CommandToRun.ToUpper() == "LEFT")
                    {
                        Left();
                    }
                    else if (commandToProcess.CommandToRun.ToUpper() == "RIGHT")
                    {
                        Right();
                    }
                    else if (commandToProcess.CommandToRun.ToUpper() == "MOVE")
                    {
                        Move();
                    }
                }
                
            }
        }
    }
}
