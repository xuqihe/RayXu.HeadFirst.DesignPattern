/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 15:59:06
*  Description:  
*
*  Update History:
*  2016/5/8 15:59:06：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command.Abstract
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
