using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;
using FirstModel;
using SecondModel;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1  每个人要学会做几个菜，不低于3个。。。先不用任何工厂方法，普通实现，分别展示几个菜，好不好吃
            Console.WriteLine("+++++++++++++++++++每个人要学会做几个菜，不低于3个。。。先不用任何工厂方法，普通实现，分别展示几个菜，好不好吃++++++++++++++");
            {
                ///模拟每个人炒菜
                var person = new Person();
                var tomatoegg = new TomatoScrambledEggs();
                var vegetable = new Vegetable();
                var fish = new Fish();
                ///番茄炒蛋
                person.Cook(tomatoegg);

                ///青菜
                person.Cook(vegetable);

                ///鱼
                person.Cook(fish);

                ///自己做得菜，好不好吃
                person.Show();                
            }
            #endregion

            #region 2  用简单工厂实现客人点菜，而不是让客人自己做菜
            Console.WriteLine("++++++++++++++++++++用简单工厂实现客人点菜，而不是让客人自己做菜+++++++++++++++++++++++++++++++++++++++++");
            {
                var tomatoegg = FoodSimpleFactory.CreateFood(FoodType.TomatoScrambledEggs);
                tomatoegg.Show();
                var fish = FoodSimpleFactory.CreateFood(FoodType.Fish);
                fish.Show();
                var vegetable = FoodSimpleFactory.CreateFood(FoodType.Vegetable);
                vegetable.Show();
            }
            #endregion

            Console.ReadKey();
        }
    }
}
