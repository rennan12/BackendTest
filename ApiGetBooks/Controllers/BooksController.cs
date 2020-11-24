using ApiGetBooks.Entities;
using ApiGetBooks.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using static ApiGetBooks.Repositories.SearchBooksRepository;

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
        public ActionResult<List<Books>> GetAll(string sort) {
            try {
                var GetAll = _SearchBooksrepository.GetAll(sort);
                if (GetAll != null) {
                    return Ok(GetAll);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("id/{id:int:min(1)}")]
        public ActionResult<List<Books>> GetId(int id) {
            try {
                var GetId = _SearchBooksrepository.GetId(id);
                if (GetId.Count > 0) {
                    return Ok(GetId);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        [Route("name/{name}/{sort?}")]
        public ActionResult<List<Books>> GetName(string name, string sort) {
            try {
                var GetName = _SearchBooksrepository.GetName(name, sort);
                if (GetName != null && GetName.Count > 0) {
                    return Ok(GetName);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("price/{price}")]
        public ActionResult<List<Books>> GetPrice(double price) {
            try {
                var GetPrice = _SearchBooksrepository.GetPrice(price);
                if (GetPrice != null && GetPrice.Count > 0) {
                    return Ok(GetPrice);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("originally_published/{param}/{sort?}")]
        public ActionResult<List<Books>> GetOriginallyPublished(string param, string sort) {
            try {
                var GetOriginallyPublished = _SearchBooksrepository.GetOriginallyPublished(param, sort);
                if (GetOriginallyPublished != null && GetOriginallyPublished.Count > 0) {
                    return Ok(GetOriginallyPublished);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("author/{param}/{sort?}")]
        public ActionResult<List<Books>> GetAuthor(string param, string sort) {
            try {
                var GetAuthor = _SearchBooksrepository.GetAuthor(param, sort);
                if (GetAuthor != null && GetAuthor.Count > 0) {
                    return Ok(GetAuthor);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("page_count/{param}/{sort?}")]
        public ActionResult<List<Books>> GetPageCount(int param, string sort) {
            try {
                var GetPageCount = _SearchBooksrepository.GetPageCount(param, sort);
                if (GetPageCount != null && GetPageCount.Count > 0) {
                    return Ok(GetPageCount);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("illustrator/{param}/{sort?}")]
        public ActionResult<List<Books>> GetIllustrator(string param, string sort) {
            try {
                var GetIllustrator = _SearchBooksrepository.GetIllustrator(param, sort);
                if (GetIllustrator != null && GetIllustrator.Count > 0) {
                    return Ok(GetIllustrator);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("genres/{param}/{sort?}")]
        public ActionResult<List<Books>> GetGenres(string param, string sort) {
            try {
                var GetGenres = _SearchBooksrepository.GetGenres(param, sort);
                if (GetGenres != null && GetGenres.Count > 0) {
                    return Ok(GetGenres);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("Shipping/{id}")]
        public ActionResult<List<Books>> GetValueShipping(int id) {
            try {
                var GetValueShipping = _SearchBooksrepository.GetValueShipping(id);
                if (GetValueShipping != null) {
                    return Ok(GetValueShipping);
                }
                else {
                    return BadRequest();
                }
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
