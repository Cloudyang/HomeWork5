using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModel.Fifth
{
    public class BaseFoodDecorator : AbstractFood
    {
        private AbstractFood food;

        public BaseFoodDecorator(AbstractFood food)
        {
            this.food = food;
            base.Name = food.Name;
            base.OutColor = food.OutColor;
            base.Specification = food.Specification;
            base.Amount = food.Amount;
        }
        public override void Cook()
        { 
            food.Cook();
        }
    }
}
