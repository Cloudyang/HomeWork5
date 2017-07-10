using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModel.First;

namespace IModel.Second
{
    public interface ICreator
    {
        AbstactDish CreateFoodFactory();
    }
}
