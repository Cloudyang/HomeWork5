using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.Fifth;
using Common;

namespace FoodDecorator
{
    public class CutFood : BaseFoodDecorator
    {
        public CutFood(AbstractFood food) : base(food)
        {
        }
        public override void Cook()
        {
            LogHelper.WriteLog("切菜");
            base.Cook();
        }
    }
}
