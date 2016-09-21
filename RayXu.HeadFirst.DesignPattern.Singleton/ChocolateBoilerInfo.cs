/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 15:32:58
*  Description:  
*
*  Update History:
*  2016/5/8 15:32:58：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Singleton
{
    public class ChocolateBoilerInfo
    {
        #region Members
        private bool _isEmpty;
        private bool _isBoiled;
        private volatile static ChocolateBoilerInfo _uniqueInstance;
        private static object objLock = string.Empty;
        #endregion

        #region  Properties
        public bool IsEmpty { get { return _isEmpty; } }
        public bool IsBoiled { get { return _isBoiled; } }
        #endregion

        #region Constructors
        private ChocolateBoilerInfo()
        {
            _isEmpty = true;
            _isBoiled = false;
        }
        #endregion

        #region Methods
        public static ChocolateBoilerInfo GetInstance()
        {
            if (_uniqueInstance == null)
            {
                lock (objLock)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new ChocolateBoilerInfo();
                        Console.WriteLine("Create a ChocolateBoiler");
                    }
                }
            }
            return _uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty)
            {
                _isEmpty = false;
                _isBoiled = false;
                Console.WriteLine("Fill");
            }
        }

        public void Boil()
        {
            if (!IsEmpty && !IsBoiled)
            {
                _isBoiled = true;
                Console.WriteLine("Boil");
            }
        }

        public void Drain()
        {
            if (!IsEmpty)
            {
                _isEmpty = true;
                Console.WriteLine("Drain");
            }
        }
        #endregion
    }
}
