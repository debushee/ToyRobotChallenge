using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfNetCoreRobot
{
    /// <summary>
    /// CommandClass is used to capture the string commands entered by the user
    /// </summary>
    public class CommandClass: Screen
    {
        private string _commandToRun;
        public string CommandToRun
        {
            get { return _commandToRun; }
            set
            {
                _commandToRun = value;
                NotifyOfPropertyChange(() => CommandToRun);
            }
        }
        public CommandClass(string Command)
        {
            CommandToRun = Command;
        }
    }
}
