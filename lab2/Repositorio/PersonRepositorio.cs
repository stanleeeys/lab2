using lab2.Data;
using lab2.Dominio;
using lab2.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Repositorio
{
    public class PersonRepositorio: IPerson
    {
        AplicationDbContext app;

        public PersonRepositorio(AplicationDbContext app)
        {
            this.app = app;
        }

        public void Save (Person e)
        {
            
            app.Update(e);
            app.SaveChanges();
        }

        public ICollection<Person> ListarPersonas()
        {
            return app.people.ToList();
        }

    }



    
}
