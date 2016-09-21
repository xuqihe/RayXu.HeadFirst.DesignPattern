/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 7:22:40
*  Description:  
*
*  Update History:
*  2016/5/11 7:22:40：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.TemplateMethod.Abstract
{
    public abstract class CaffeineBeverageInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region Methods
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CheckCustomerWantCondiment())
            {
                AddCondiment();
            }
        }

        public abstract void Brew();

        public abstract void AddCondiment();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual bool CheckCustomerWantCondiment()
        {
            return true;
        }
        #endregion
    }
}
