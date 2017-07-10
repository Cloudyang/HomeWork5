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
        private List<AbstactDish> Foods { get; set; }

        public Person()
        {
            Foods = new List<AbstactDish>();
        }

        /// <summary>
        /// 用于模拟炒菜
        /// </summary>
        public void Cook(AbstactDish food)
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
