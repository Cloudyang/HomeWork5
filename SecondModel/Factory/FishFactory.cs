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
    public class FishFactory : ICreator
    {
        private static Type type = null;
        static FishFactory()
        {
            var settingValues = ConfigurationManager.AppSettings.Get("Fish").Split(',');
            var assembly = Assembly.Load(settingValues[0]);
            type = assembly.GetType(settingValues[1]);
        }

        public AbstactDish CreateFoodFactory()
        {
            return Activator.CreateInstance(type) as AbstactDish;
        }
    }
}
