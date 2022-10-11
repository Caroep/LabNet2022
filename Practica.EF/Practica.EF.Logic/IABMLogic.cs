using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica.EF.Logic
{
    public interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newVar);
        void Delete(int id);
        void Update(T var);
    }
}
