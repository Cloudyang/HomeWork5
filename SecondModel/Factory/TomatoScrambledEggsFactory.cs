using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using IModel.First;
using IModel.Second;

namespace SecondModel.Factory
{
    public class TomatoScrambledEggsFactory : ICreator
    {
        private static Type type = null;
        static TomatoScrambledEggsFactory()
        {
            var settingValues = ConfigurationManager.AppSettings.Get("TomatoScrambledEggs").Split(',');
            var assembly = Assembly.Load(settingValues[0]);
            type = assembly.GetType(settingValues[1]);
        }

        public AbstractFood CreateFoodFactory()
        {
            return Activator.CreateInstance(type) as AbstractFood;
        }
    }
}
