using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;
using System.Configuration;
using System.Reflection;

namespace SecondModel
{
    public enum FoodType
    {
        Fish,
        TomatoScrambledEggs,
        Vegetable
    }
    public class FoodSimpleFactory
    {
        private static Dictionary<FoodType,AbstactDish> FoodDict;

        /// <summary>
        /// 初始化实例
        /// </summary>
        static FoodSimpleFactory()
        {
            FoodDict = new Dictionary<FoodType, AbstactDish>();

            for (int i = 0; i < ConfigurationManager.AppSettings.Count; i++)
            {
                var settingValues = ConfigurationManager.AppSettings.Get(i).Split(',');
                var assembly = Assembly.Load(settingValues[0]);
                Type type = assembly.GetType(settingValues[1]);
                var food = Activator.CreateInstance(type) as AbstactDish;
                switch (ConfigurationManager.AppSettings.GetKey(i))
                {
                    case "Fish":
                        FoodDict.Add(FoodType.Fish, food);
                        break;
                    case "TomatoScrambledEggs":
                        FoodDict.Add(FoodType.TomatoScrambledEggs, food);
                        break;
                    case "Vegetable":
                        FoodDict.Add(FoodType.Vegetable, food);
                        break;
                }
            }
        }
        public static AbstactDish CreateFood(FoodType type)
        {            
            return FoodDict[type];
        }
    }
}
