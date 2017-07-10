using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModel.Fifth
{
    public abstract class AbstractFood
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 做菜
        /// </summary>
        public abstract void Cook();

        /// <summary>
        /// 品尝
        /// </summary>
        public void Taste()
        {
            Console.WriteLine($"开始品尝{Name}");
        }

        /// <summary>
        /// 点评 满分10，0-10随机评分
        /// </summary>
        public virtual void Remark()
        {
            Random rand = new Random();
            Console.WriteLine($"这道菜{Name}得分：{rand.Next(11)}");
        } 
    }
}
