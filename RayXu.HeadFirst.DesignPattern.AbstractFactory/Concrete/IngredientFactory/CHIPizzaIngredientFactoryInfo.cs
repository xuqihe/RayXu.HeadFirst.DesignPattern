/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 12:26:24
*  Description:  
*
*  Update History:
*  2016/5/8 12:26:24：Create.
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
    public class CHIPizzaIngredientFactoryInfo: IPizzaIngredientFactory
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
            return new ThickCrustDoughInfo();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauceInfo();
        }

        public ICheese CreateCheese()
        {
            return new MozzerellaInfo();
        }

        public IVeggie[] CreateVeggie()
        {
            IVeggie[] veggies = { new BlackOliveInfo(), new SpinachInfo(), new EggPlantInfo() };
            return veggies;
        }

        public IPepperoni CreatePepporoni()
        {
            return new SlicedPepperoniInfo();
        }

        public IClam CreateClam()
        {
            return new FrozenClamInfo();
        }
        #endregion
    }
}
