﻿using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface IWalletService
    {
        List<Wallet> GetAllWallets();
        void CREATEWallets(Wallet wallet);
        void UPDATEWallets(int id, Wallet wallet);
        Wallet GetWalletById(int id);
        void DeleteWallets(int id);
    }
}