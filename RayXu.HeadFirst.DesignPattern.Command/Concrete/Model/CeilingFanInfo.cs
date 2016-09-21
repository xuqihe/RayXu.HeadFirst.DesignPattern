/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 16:10:07
*  Description:  
*
*  Update History:
*  2016/5/8 16:10:07：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command.Concrete
{
    public enum CeilingFanLevel
    {
        OFF = 0,
        LOW = 1,
        MEDIUM = 2,
        HIGH = 3
    }

    public class CeilingFanInfo
    {
        #region Members
        private CeilingFanLevel _speed;
        #endregion

        #region  Properties
        public CeilingFanLevel Speed
        {
            get { return _speed; }
            set { SetSpeed(value); }
        }

        public string Location { get; set; }
        #endregion

        #region Constructors
        public CeilingFanInfo(string location)
        {
            Location = location;
            _speed = CeilingFanLevel.OFF;
        }
        #endregion

        #region Methods
        private void SetSpeed(CeilingFanLevel level)
        {
            _speed = level;
            Console.WriteLine(Location + ": Ceiling fan is on " + Speed.ToString());
        }
        #endregion
    }
}
