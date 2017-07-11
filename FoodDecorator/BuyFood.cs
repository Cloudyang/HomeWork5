using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.Fifth;
using Common;

namespace FoodDecorator
{
    public class BuyFood : BaseFoodDecorator
    {
        public BuyFood(AbstractFood food) : base(food) { }

        public override void Cook()
        {
            LogHelper.WriteLog("买菜");
            base.Cook();
        }
    }
}
