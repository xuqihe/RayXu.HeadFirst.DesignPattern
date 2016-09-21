/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 8:14:38
*  Description:  
*
*  Update History:
*  2016/5/11 8:14:38：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.TemplateMethod.Utility
{
    public class UtilityHelper
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region Methods
        public static bool GetUserConfirm(string prompt)
        {
            string answer = null;
            string promptMsg = prompt + " (Y for yes/ N for no): ";
            Console.Write(promptMsg);

            answer = Console.ReadLine();
            while (answer.ToLower() != "y" && answer.ToLower() != "n")
            {
                Console.Write(promptMsg);
                answer = Console.ReadLine();
            }

            return answer.ToLower() == "y";
        }
        #endregion
    }
}
