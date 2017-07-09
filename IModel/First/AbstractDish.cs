using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModel.First
{
    public abstract class AbstractFood
    {
        public AbstractFood(string name)
        {
            Name = name;
        }
        /// <summary>
        /// 菜名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 显示
        /// </summary>
        public abstract void Show();
    }
}
