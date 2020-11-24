using ApiGetBooks.Entities;
using ApiGetBooks.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;


namespace ApiGetBooks.Test {
    [Route("[Controller]")]
    [ApiController]
    [ApiVersion("1.0")] // controle de versão da API
        public class TestController : Controller {

        protected readonly SearchBooksRepositoryTest _SearchBooksRepositoryTest;
        protected readonly ManageJsonTest _ManageJsonTest;
        public TestController(SearchBooksRepositoryTest SearchBooksRepositoryTest, ManageJsonTest ManageJsonTest) {
            _SearchBooksRepositoryTest = SearchBooksRepositoryTest;
            _ManageJsonTest = ManageJsonTest;
        }

        [HttpGet]
        public ActionResult<List<EntitysTest>> Get() {
            try {
                var ClasseSearchBooksRepository = _SearchBooksRepositoryTest.TestarTudoClasseSearchBooksRepository();
                var ManageJsonTest = _ManageJsonTest.TestarTudoClasseManageJsonTest();
                return Ok(ManageJsonTest.Concat(ClasseSearchBooksRepository));
            }
            catch (ArgumentException e) {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            } 
        }

    }
}
