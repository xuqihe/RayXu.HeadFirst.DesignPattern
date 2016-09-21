/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 12:11:40
*  Description:  
*
*  Update History:
*  2016/5/8 12:11:40：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.AbstractFactory.Abstract
{
    public interface IPizzaIngredientFactory
    {
        ICheese CreateCheese();
        IClam CreateClam();
        IDough CreateDough();
        IPepperoni CreatePepporoni();
        ISauce CreateSauce();
        IVeggie[] CreateVeggie();
    }
}
