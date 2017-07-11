using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IModel.Fifth;
using Common;

namespace Homework5
{
    class OrderDishes
    {
        static List<AbstractFood> Foods;
        static OrderDishes()
        {
            var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DishesCFG", "Foods.Json");
            string sJoin = File.ReadAllText(filepath);
            var foodConfigs = JsonHelper.JsonToObj<List<FoodConfig>>(sJoin);

            Foods = new List<AbstractFood>();
            foreach (var foodConfig in foodConfigs)
            {
                var food = ObjectFactory.CreateObject<AbstractFood>(foodConfig.DllName, foodConfig.ClassName);
                food.Amount = foodConfig.Amount;
                food.Name = foodConfig.FoodName;
                food.Specification = foodConfig.Specification;
                food.EventList = foodConfig.EventList;
                food.OutColor = foodConfig.OutColor;

                Foods.Add(food);
            }
        }

        public void Show()
        {
            for (int i = 1; i <= Foods.Count; i++)
            {
                var itemp = i - 1;
                LogHelper.WriteLog($"{i}:{Foods[itemp].Name}");
                //LogHelper.WriteLog($"{i}:{Foods[--i].Name}"); 会导致i值被重新复位
            }
        }

        public void OrderDish(int id)
        {
            if (id >= 1 && id <= Foods.Count)
            {
                //   Foods[--id].Show(); 此方法不可取，会导致索引对象为空
                var itemp = id - 1;
                var food = Foods[itemp];
                food.Show();
            }
            else
            {
                throw new Exception($"{id}号不在菜单中，请核实！");
            }
        }
    }
}
