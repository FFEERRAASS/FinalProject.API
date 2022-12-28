using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface ICharityService
    {
        public List<Cahrity> GetAllcahrity();
        public void Createcahrity(Cahrity cahrity);
        public void Updatecahrity(Cahrity cahrity);
        public void DeleteCategory(int id);
        public Cahrity GetcahrityById(int id);
        public List<Cahrity> GetcahrityByCategory(int id);
    }
}
