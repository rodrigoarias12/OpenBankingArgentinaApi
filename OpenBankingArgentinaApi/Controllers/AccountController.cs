
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OpenBankingArgentinaApi.Models;
using OpenBankingArgentinaApi.Services;
using System.Collections.Generic;

namespace OpenBankingArgentinaApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountService _accountService;

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<List<Account>> Get() =>
            _accountService.Get();

      

       
    }
}