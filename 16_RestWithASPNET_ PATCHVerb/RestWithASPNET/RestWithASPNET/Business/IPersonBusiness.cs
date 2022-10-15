﻿using RestWithASPNET.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindByAll();
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);        
    }
}
