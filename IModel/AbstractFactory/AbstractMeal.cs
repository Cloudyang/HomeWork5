using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;

namespace IModel.AbstractFactory
{
   public abstract class AbstractMeal
    {
        protected List<AbstactDish> Foods = new List<AbstactDish>();
        public abstract void Show();

        public abstract AbstractRice CreateRice();

        public abstract AbstractSoup CreateSoup();
    }
}
