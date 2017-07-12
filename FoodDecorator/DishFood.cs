using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.Fifth;
using Common;

namespace FoodDecorator
{
    public class DishFood : BaseFoodDecorator
    {
        public DishFood(AbstractFood food) : base(food)
        {
        }

        public override void Cook()
        {
            base.Cook();
            LogHelper.WriteLog($"{Name}:摆盘");
        }
    }
}
