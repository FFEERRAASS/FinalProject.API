using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class WalletService: IWalletService
    {
        private readonly IWalletRepository walletRepository;
        public WalletService(IWalletRepository _walletRepository)
        {
            this.walletRepository = _walletRepository;
        }
        public void CREATEWallets(Wallet wallet)
        {
            walletRepository.CREATEWallets(wallet);
        }

        public void DeleteWallets(int id)
        {
           walletRepository.DeleteWallets(id);
        }

        public List<Wallet> GetAllWallets()
        {
            return walletRepository.GetAllWallets();
        
        }

        public Wallet GetWalletById(int id)
        {
           return walletRepository.GetWalletById(id);
        }

        public void UPDATEWallets(Wallet wallet)
        {
           walletRepository.UPDATEWallets( wallet);  
        }
        public Wallet getwalletforuser(int id)
        {
            return walletRepository.getwalletforuser(id);

        }

    }
}
