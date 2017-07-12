using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.Fifth;
using Common;

namespace FoodDecorator
{
    public class WashFood : BaseFoodDecorator
    {
        public WashFood(AbstractFood food) : base(food) { }

        public override void Cook()
        {
            LogHelper.WriteLog($"{Name}:洗菜");
            base.Cook();
        }
    }
}
