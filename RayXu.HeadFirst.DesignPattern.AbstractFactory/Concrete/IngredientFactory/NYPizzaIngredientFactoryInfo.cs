/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 14:02:30
*  Description:  
*
*  Update History:
*  2016/5/8 14:02:30：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.AbstractFactory.Concrete
{
    public class NYPizzaIngredientFactoryInfo: IPizzaIngredientFactory
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region IPizzaIngredientFactory Methods
        public IDough CreateDough()
        {
            return new ThinCrustDoughInfo();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauceInfo();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheeseInfo();
        }

        public IVeggie[] CreateVeggie()
        {
            IVeggie[] veggies = { new GarlicInfo(), new OnionInfo(), new MushroomInfo(), new RedPepperInfo() };
            return veggies;
        }

        public IPepperoni CreatePepporoni()
        {
            return new SlicedPepperoniInfo();
        }

        public IClam CreateClam()
        {
            return new FreshClamInfo();
        }
        #endregion
    }
}
