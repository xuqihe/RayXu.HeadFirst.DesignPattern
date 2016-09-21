using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Abstract
{
    public abstract class CondimentDecoratorInfo : BeverageInfo
    {
        public override abstract string GetDescription();
    }
}
