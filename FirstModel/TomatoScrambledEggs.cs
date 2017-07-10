using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;

namespace FirstModel
{
    /// <summary>
    /// 番茄炒蛋
    /// </summary>
    public class TomatoScrambledEggs : AbstactDish
    {
        public TomatoScrambledEggs() : base("番茄炒蛋") { }

        public override void Show()
        {
            Console.WriteLine($"这是一道{base.Name}"); ;
        }
    }
}
