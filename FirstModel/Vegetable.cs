using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;

namespace FirstModel
{
    /// <summary>
    /// 青菜
    /// </summary>
    public class Vegetable : AbstactDish
    {
        public Vegetable() : base("青菜") { }

        public override void Show()
        {
            Console.WriteLine($"这是一道{base.Name}"); ;
        }
    }
}
