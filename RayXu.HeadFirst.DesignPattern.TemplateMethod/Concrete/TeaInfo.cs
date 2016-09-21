/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 7:34:14
*  Description:  
*
*  Update History:
*  2016/5/11 7:34:14：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.TemplateMethod.Abstract;
using RayXu.HeadFirst.DesignPattern.TemplateMethod.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.TemplateMethod.Concrete
{
    public class TeaInfo : CaffeineBeverageInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region CaffeineBeverageInfo Methods
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiment()
        {
            Console.WriteLine("Adding lemon");
        }

        public override bool CheckCustomerWantCondiment()
        {
            return UtilityHelper.GetUserConfirm("Do you want to add condiment?");
        }
        #endregion
    }
}
