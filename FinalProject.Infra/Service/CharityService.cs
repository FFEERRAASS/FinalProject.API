﻿using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class CharityService : ICharityService
    {
        private readonly ICharityRepository _charityRepository;

        public CharityService(ICharityRepository charityRepository) 
        {
            _charityRepository = charityRepository;
        }

        public List<Cahrity> GetAllcahrity()
        {
            return _charityRepository.GetAllcahrity();
        }

        public void Createcahrity(Cahrity cahrity)
        {
            _charityRepository.Createcahrity(cahrity);
        }

        public void Updatecahrity(Cahrity cahrity)
        {
            _charityRepository.Updatecahrity(cahrity);
        }

        public void DeleteCategory(int id) 
        {
            _charityRepository.DeleteCategory(id);
        }
        public Cahrity GetcahrityById(int id)
        {
            return _charityRepository.GetcahrityById(id);
        }
        public List<Cahrity> GetcahrityByCategory(int id)

        {
            return _charityRepository.GetcahrityByCategory(id);
        }


    }
}
