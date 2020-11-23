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
    [ApiVersion("1.0")] // controle de versão da API
    public class BooksController : Controller {
        protected readonly ISearchBooksRepository _SearchBooksrepository;
        public BooksController(ISearchBooksRepository SearchBooksrepository) {
            _SearchBooksrepository = SearchBooksrepository;
            
        }
        [HttpGet]
        [Route("{sort?}")]
        public ActionResult<List<Books>> GetAll(Constants.Order sort) {
            try {
                return Ok(_SearchBooksrepository.GetAll(sort));
            }
            catch (ArgumentException e) {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("id/{id:int:min(1)}")]
        public ActionResult<List<Books>> GetId(int id) {

            try {
                return Ok(_SearchBooksrepository.GetId(id));
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("name/{name}/{sort?}")]
        public List<Books> GetName(string name, string sort) {
            return _SearchBooksrepository.GetName(name, sort);
        }

        [HttpGet]
        [Route("price/{price}")]
        public List<Books> GetPrice(double price) {
            return _SearchBooksrepository.GetPrice(price);
        }

    }
}
