
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OpenBankingArgentinaApi.Models;
using OpenBankingArgentinaApi.Services;
using System.Collections.Generic;

namespace OpenBankingArgentinaApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionService _transactionService;

        public TransactionController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public ActionResult<List<Transaction>> Get() =>
            _transactionService.Get();
        



    }
}