using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindByAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
