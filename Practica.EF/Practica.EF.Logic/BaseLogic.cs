using Practica.EF.Data;

namespace Practica.EF.Logic
{

    public class BaseLogic
    {
        protected readonly NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
