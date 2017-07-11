using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;
using FirstModel;
using SecondModel;
using Common;

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

            #region 3  用工厂方法实现客人点菜，而不是让客人自己做菜
            Console.WriteLine("++++++++++++++++++++用工厂方法实现客人点菜，而不是让客人自己做++++++++++++++++++++++++++++++++++++++++++");
            {
                var tomatoScrambledEggsFactory = new SecondModel.Factory.TomatoScrambledEggsFactory();
                var tomatoegg = tomatoScrambledEggsFactory.CreateFoodFactory();
                tomatoegg.Show();

                var fishFactory = new SecondModel.Factory.FishFactory();
                var fish = fishFactory.CreateFoodFactory();
                fish.Show();

                var vegatableFactory = new SecondModel.Factory.VegetableFactory();
                var vegatable = vegatableFactory.CreateFoodFactory();
                vegatable.Show();

            }
            #endregion

            #region 4  用抽象工厂，每个工厂都能做三个菜、一个汤、一个主食
            Console.WriteLine("++++++++++++++++++++用抽象工厂，每个工厂都能做三个菜、一个汤、一个主食++++++++++++++++++++++++++++++++++");
            {
                var meal = new ThirdModel.Meal();
                meal.Show();
            }
            #endregion

            #region 5  做个点菜系统，用户输入可选菜id进行点菜：
            try {
                #region 多线程演示：甲乙丙三个客人(三个线程)分别随机点5个菜，然后每个菜依次做菜、品尝、点评
                Console.WriteLine("++++++++++++++++++++多线程演示：甲乙丙三个客人(三个线程)分别随机点5个菜，然后每个菜依次做菜、品尝、点评++");
                {
                    List<Client> clients = new List<Client>();
                    Client client = new Client("甲");
                    clients.Add(client);
                    client = new Client("乙");
                    clients.Add(client);
                    client = new Client("丙");
                    clients.Add(client);

                    Parallel.ForEach(clients, c => { c.Show(); });

                    Client.MaxScore();
                }
                #endregion

                #region 用户输入id点菜
                Console.WriteLine("++++++++++++++++++++做个点菜系统，用户输入可选菜id进行点菜++++++++++++++++++++++++++++++++++++++++++++++");
                {
                    OrderDishes od = new OrderDishes();
                    od.Show();
                    Console.WriteLine("按上述数字选择菜单，按e退出");

                    string sInKey = Console.ReadKey().KeyChar.ToString().ToLower();
                    do
                    {
                        Console.WriteLine();
                        try
                        {
                            od.OrderDish(int.Parse(sInKey));
                        }
                        catch (Exception ex)
                        {
                            LogHelper.WriteLog($"  报错信息：{ex.Message}");
                        }
                        sInKey = Console.ReadKey().KeyChar.ToString().ToLower();
                    } while (!sInKey.Equals("e"));
                }
                #endregion
                #endregion
            }catch(Exception ex)
            {
                LogHelper.WriteLog(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
