using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.Fifth;
using Common;

namespace FifthModel
{
    public class Fish : AbstractFood
    {
        public override void Cook()
        {
            LogHelper.WriteLog($"{base.Name}开始做菜");
            foreach (var item in base.EventList)
            {
                LogHelper.WriteLog($"{base.Name}:{item}", OutColor);
            }
            LogHelper.WriteLog($"{base.Name}结束做菜");
        }
    }
}
