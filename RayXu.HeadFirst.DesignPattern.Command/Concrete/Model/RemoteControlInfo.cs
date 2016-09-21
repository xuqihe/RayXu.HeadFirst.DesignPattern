/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 16:39:01
*  Description:  
*
*  Update History:
*  2016/5/8 16:39:01：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Command.Abstract;
using RayXu.HeadFirst.DesignPattern.Command.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command.Concrete
{
    public class RemoteControlInfo
    {
        #region Members
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public RemoteControlInfo()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = noCommand;
        }
        #endregion

        #region Methods
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _undoCommand = _onCommands[slot];
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _undoCommand = _offCommands[slot];
            _offCommands[slot].Execute();
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("--== Remote Control ==--");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.AppendLine("[slot " + i + "]: ON - " + _onCommands[i].GetType().Name + " OFF - " + _offCommands[i].GetType().Name);
            }
            return sb.ToString();
        }
    }
    #endregion
}
