using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using IModel.Fifth;

namespace FifthModel
{
    public class TomatoScrambledEggs : AbstractFood
    {
        public override void Cook()
        {
            LogHelper.WriteLog($"{Name}开始做菜");
            if (EventList != null)
            {
                foreach (var item in EventList)
                {
                    LogHelper.WriteLog($"{Name}:{item}", OutColor);
                }
            }
            LogHelper.WriteLog($"{Name}结束做菜");
        }
    }
}
