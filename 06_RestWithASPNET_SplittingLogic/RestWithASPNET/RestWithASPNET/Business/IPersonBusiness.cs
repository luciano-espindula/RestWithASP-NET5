﻿using RestWithASPNET.Model;
using System.Collections.Generic;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindByAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
