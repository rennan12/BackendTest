using ApiGetBooks.Entities;
using ApiGetBooks.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiGetBooks.Controllers {
    [Route("[Controller]")]
    [ApiController]
    public class BooksController : Controller {
        protected readonly IBooksRepository _repository;

        public BooksController(IBooksRepository repository) {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<List<Books>> GetAll() {
            try {
                return Ok(_repository.LoadAllJson());
            }
            catch (ArgumentException e) {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
