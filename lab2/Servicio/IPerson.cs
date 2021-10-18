using lab2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Servicio
{
    public interface IPerson
    {
        void Save(Person e);

 

        ICollection<Person> ListarPersonas();
    }
}
