using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IWalletService walletService;
        public WalletController(IWalletService _walletService)
        {
            this.walletService = _walletService;
        }

        [HttpGet("GetAllWallets")]
        public List<Wallet> GetAllcontactus()
        {
            return this.walletService.GetAllWallets();
        }
        [HttpPost("CREATEWallets")]
        public void CREATEWallets(Wallet contactu)
        {
            walletService.CREATEWallets(contactu);
        }
        [HttpPut("UPDATEWallets/{id}")]
        public void UPDATEWallets(int id, Wallet contactu)
        {
            walletService.UPDATEWallets(id, contactu);
        }
        [HttpGet("GetWalletById/{id}")]
        public Wallet GetWalletById(int id)
        {
            return this.walletService.GetWalletById(id);
        }
        [HttpDelete("DeleteWallets/{id}")]
        public void DeleteWallets(int id)
        {
            walletService.DeleteWallets(id);
        }
    }
}
