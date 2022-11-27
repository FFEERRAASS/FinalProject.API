﻿using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface ICharityRepository
    {
        List<Cahrity> GetAllcahrity();
         void Createcahrity(Cahrity cahrity);
         void Updatecahrity(Cahrity cahrity);
        public void DeleteCategory(int id);
        public Cahrity GetcahrityById(int id);
    }
}
