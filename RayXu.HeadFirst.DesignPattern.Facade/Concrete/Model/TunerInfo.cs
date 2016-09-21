/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 7:40:37
*  Description:  
*
*  Update History:
*  2016/5/10 7:40:37：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Facade.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Facade.Concrete
{
    public class TunerInfo : BaseInfo
    {
        #region Members
        private double _frequency;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public TunerInfo(string desc) : base(desc)
        { }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine("Tuner: " + Description + " on");
        }

        public void Off()
        {
            Console.WriteLine("Tuner: " + Description + " off");
        }

        public void SetFrequency(double freq)
        {
            _frequency = freq;
            Console.WriteLine("Tuner: " + Description + " setting frequency to " + _frequency);
        }

        public void SetAm()
        {
            Console.WriteLine("Tuner: " + Description + " setting AM mode");
        }

        public void SetFm()
        {
            Console.WriteLine("Tuner: " + Description + " setting FM mode");
        }
        #endregion
    }
}
