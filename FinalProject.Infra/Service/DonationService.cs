using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class DonationService :IDonationService
    {
        private readonly IDonationRepository donationRepository;
        public DonationService(IDonationRepository donationRepository)
        {
            this.donationRepository = donationRepository;
        }

        public List<DonationDto> getAllDonation()
        {
            return donationRepository.getAllDonation();

        }
        public void CreateDonation(Donation donation)
        {
             donationRepository.CreateDonation(donation);
        }
        public void UpdateDonation(Donation donation)
        {
            donationRepository.UpdateDonation(donation);
        }
        List<DonationDto> GetDonationByuserId(int id)
        {
            return donationRepository.GetDonationByuserId(id);
        }
    }
}
