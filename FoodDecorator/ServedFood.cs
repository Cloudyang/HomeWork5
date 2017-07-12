using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.Fifth;
using Common;

namespace FoodDecorator
{
    public class ServedFood : BaseFoodDecorator
    {
        public ServedFood(AbstractFood food) : base(food)
        {
        }

        public override void Cook()
        {
            base.Cook();
            LogHelper.WriteLog($"{Name}:上菜");
        }
    }
}
