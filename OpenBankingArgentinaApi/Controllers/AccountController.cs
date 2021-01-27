
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OpenBankingArgentinaApi.Models;
using OpenBankingArgentinaApi.Services;
using System.Collections.Generic;
using System.Net;

namespace OpenBankingArgentinaApi.Controllers
{

    /// <summary>
    /// Accceso a los datos de una cuenta
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountService _accountService;

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }
        /// <summary>
        /// Get account details
        /// </summary>
        /// /// <remarks>
        /// Descripción
        ///
        ///     GET /Account
        ///     Obtener información de la cuenta 
        ///
        /// </remarks>
        /// <returns>Account</returns>

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(Account), (int)HttpStatusCode.OK)]
        public ActionResult<Account> Get() =>
            _accountService.Get();

      

       
    }
}