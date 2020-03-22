using System.Collections.Generic;
using crowdfunding.Models;
using crowdfunding.Services;
using Microsoft.AspNetCore.Mvc;

namespace crowdfunding.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionController : ControllerBase
    {
        private TransactionService Service;

        public TransactionController(TransactionService service)
        {
            Service = service;
        }

        // GET api/transactions
        [HttpGet]
        public ActionResult<List<Transaction>> GetTransactions()
        {
            return Ok(Service.All());
        }

        // POST api/transactions
        [HttpPost]
        public ActionResult Create(Transaction transaction)
        {
            bool isAimExist = Service.IsAimExist(transaction.AimId);
            if (!isAimExist) return NotFound("aim not found");

            bool isBackerExist = Service.IsBackerExist(transaction.BackerId);
            if (!isBackerExist) return NotFound("backer not found");

            return Ok(Service.Create(transaction));
        }
    }
}