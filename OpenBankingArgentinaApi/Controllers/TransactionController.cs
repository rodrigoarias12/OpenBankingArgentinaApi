
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OpenBankingArgentinaApi.Models;
using OpenBankingArgentinaApi.Services;
using System.Collections.Generic;
using System.Net;

namespace OpenBankingArgentinaApi.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionService _transactionService;
        /// <summary>
        /// aaaaaaaaaaa
        /// </summary>
        /// <param name="transactionService"></param>
        public TransactionController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        /// <summary>
        /// Get account transactions
        /// </summary>
        [HttpGet]
       
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public ActionResult<List<Transaction>> Get() =>
            _transactionService.Get();

        public ActionResult<List<Transaction>> get()
        {
            List<Transaction> Transacciones = _transactionService.Get();
            return Transacciones;
        }


    }
}