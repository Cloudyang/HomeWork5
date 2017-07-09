using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;

namespace FirstModel
{
    public class Person
    {
        /// <summary>
        /// 模拟想吃的所有菜
        /// </summary>
        private List<AbstractFood> Foods { get; set; }

        public Person()
        {
            Foods = new List<AbstractFood>();
        }

        /// <summary>
        /// 用于模拟炒菜
        /// </summary>
        public void Cook(AbstractFood food)
        {
            Foods.Add(food);
        }

        /// <summary>
        /// 展示几个菜，好不好吃
        /// </summary>
        public void Show()
        {
            foreach (var food in Foods)
            {
                food.Show();
                Console.WriteLine("这是自己做得菜，好不好吃");
            }
        }
    }
}
