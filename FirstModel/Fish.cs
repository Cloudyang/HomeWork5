using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;

namespace FirstModel
{
    /// <summary>
    /// 鱼
    /// </summary>
    public class Fish : AbstractDish
    {
        public Fish() : base("鱼") { }

        public override void Show()
        {
            Console.WriteLine($"这是一道{base.Name}"); ;
        }
    }
}
