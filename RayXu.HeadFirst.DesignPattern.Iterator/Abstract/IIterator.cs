/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 22:28:14
*  Description:  
*
*  Update History:
*  2016/5/11 22:28:14：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Iterator.Abstract
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
