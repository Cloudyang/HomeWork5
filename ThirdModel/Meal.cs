using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;
using IModel.AbstractFactory;
using System.Configuration;
using System.Reflection;

namespace ThirdModel
{
    public class Meal : AbstractMeal
    {
        private static List<Type> Types = new List<Type>();
        static Meal()
        {
            for (int i = 0; i < ConfigurationManager.AppSettings.Count; i++)
            {
                var settingValues = ConfigurationManager.AppSettings.Get(i).Split(',');
                var assembly = Assembly.Load(settingValues[0]);
                Type type = assembly.GetType(settingValues[1]);
                Types.Add(type);
            }
        }
        public Meal()
        {
            Types.ForEach(type =>
            {
                var food = Activator.CreateInstance(type) as AbstactDish;
                Foods.Add(food);
            });
        }

        public override AbstractRice CreateRice()
        {
            return new AbstractRice();
        }

        public override AbstractSoup CreateSoup()
        {
            return new AbstractSoup();
        }

        public override void Show()
        {
            Foods.ForEach(food =>
            {
                food.Show();
            });

            CreateRice().Show();

            CreateSoup().Show();
        }
    }
}
