using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;
using FirstModel;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 每个人要学会做几个菜，不低于3个。。。先不用任何工厂方法，普通实现，分别展示几个菜，好不好吃
            {
                ///模拟每个人炒菜
                var person = new Person();
                var tomatoegg = new TomatoEgg();
                var vegetable = new Vegetable();
                var fish = new Fish();
                ///番茄炒蛋
                person.Fried(tomatoegg);

                ///青菜
                person.Fried(vegetable);

                ///鱼
                person.Fried(fish);

                ///自己做得菜，好不好吃
                person.Show();                
            }
            #endregion

            Console.ReadKey();
        }
    }
}
