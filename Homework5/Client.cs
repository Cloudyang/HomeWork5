using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Common;
using IModel.Fifth;

namespace Homework5
{
    class Client
    {
        private static Dictionary<string, int> Score = new Dictionary<string, int>();
        private static readonly object _lock = new object();
        static List<AbstractFood> Foods;
        static Client()
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

        /// <summary>
        /// 评选出得分最高的客户点评的菜
        /// </summary>
        public static void MaxScore()
        {
            var iMax = Score.Max(s => s.Value);
            var csf = Score.Where(s => s.Value == iMax)
                .Select(o => o.Key);
            LogHelper.WriteLog($"{string.Join(",", csf)} 最高得分：{iMax}");
        }

        private string name;
        public Client(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            ///随机点5个菜
            for (int i = 0; i < 5; i++)
            {
                int iSelected = RandomHelper.GetRandomNumber(0, 6);
                var food = Foods[iSelected];
                lock (_lock)
                {
                    LogHelper.WriteLog($"{name}操作开始");
                    food.Cook();
                    food.Taste();
                    Score.Add($"{name}第{i+1}次点评:{food.Name}", food.Remark());
                    LogHelper.WriteLog($"{name}操作结束");
                }
            }
        }

    }
}
