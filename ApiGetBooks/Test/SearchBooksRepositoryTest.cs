using ApiGetBooks.Controllers;
using ApiGetBooks.Entities;
using ApiGetBooks.Repositories;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;


namespace ApiGetBooks.Test {
    public class SearchBooksRepositoryTest {

        protected readonly ISearchBooksRepository _SearchBooksrepository;
        public  SearchBooksRepositoryTest(ISearchBooksRepository SearchBooksrepository) {
            _SearchBooksrepository = SearchBooksrepository;
        }

        string classTestingHere = "SearchBooksRepository";
        List<EntitysTest> ListaDeTestes = new List<EntitysTest>();
        private string methodTestingHere;
        private object result;
        private enum Result { Ok, Falhou }

        public List<EntitysTest> TestarTudoClasseSearchBooksRepository() {
            GetAllTest();
            return ListaDeTestes;
        }

        public void GetAllTest() {
            try {
                methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

                List<Books> jsonFile = ManageJson.LoadAllJson();
                List<Books> countGetAllTest = _SearchBooksrepository.GetAll(null);

                result = jsonFile.Count == countGetAllTest.Count ? Result.Ok : Result.Falhou;

                ListaDeTestes.Add(new EntitysTest() {
                    Classe = classTestingHere,
                    Metodo = methodTestingHere,
                    Resultado = result.ToString()
                });
                //Próximo metodo
                GetIdTest();
            }
            catch (System.Exception) {

                throw;
            }
        }

        public void GetIdTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test","");

            var Test1 = _SearchBooksrepository.GetId(1);
            result = Test1.Count == 1 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });

            //Próximo metodo
            GetNameTest();
        }

        public void GetNameTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            var Test1 = _SearchBooksrepository.GetName("t","ascending");
            result = Test1.Count == 5 ? result = Result.Ok : result = Result.Falhou;

            var Test2 = _SearchBooksrepository.GetName("x", "ascending");
            result = Test2.Count == 0 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });

            //Próximo metodo
            GetPriceTest();
        }

        public void GetPriceTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            var Test1 = _SearchBooksrepository.GetPrice(10.1);
            result = Test1.Count == 1 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });
            //Próximo metodo
            GetOriginallyPublishedTest();
        }

        public void GetOriginallyPublishedTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            var Test1 = _SearchBooksrepository.GetOriginallyPublished("n", "ascending");
            result = Test1.Count == 3 ? result = Result.Ok : result = Result.Falhou;

            var Test2 = _SearchBooksrepository.GetOriginallyPublished("x", "ascending");
            result = Test2.Count == 0 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });
            //Próximo metodo
            GetAuthorTest();
        }

        public void GetAuthorTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            var Test1 = _SearchBooksrepository.GetAuthor("n", "ascending");
            result = Test1.Count == 5 ? result = Result.Ok : result = Result.Falhou;

            var Test2 = _SearchBooksrepository.GetAuthor("x", "ascending");
            result = Test2.Count == 0 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });
            //Próximo metodo
            GetPageCountTest();
        }

        public void GetPageCountTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            var Test1 = _SearchBooksrepository.GetPageCount(183, "ascending");
            result = Test1.Count == 1 ? result = Result.Ok : result = Result.Falhou;

            var Test2 = _SearchBooksrepository.GetPageCount(636, "ascending");
            result = Test2.Count == 1 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });
            //Próximo metodo
            GetIllustratorTest();
        }

        public void GetIllustratorTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            var Test1 = _SearchBooksrepository.GetIllustrator("n", "ascending");
            result = Test1.Count == 3 ? result = Result.Ok : result = Result.Falhou;

            var Test2 = _SearchBooksrepository.GetIllustrator("x", "ascending");
            result = Test2.Count == 0 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });
            //Próximo metodo
            GetGenresTest();
        }

        public void GetGenresTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            var Test1 = _SearchBooksrepository.GetGenres("n", "ascending");
            result = Test1.Count == 5 ? result = Result.Ok : result = Result.Falhou;

            var Test2 = _SearchBooksrepository.GetGenres("y", "ascending");
            result = Test2.Count == 3 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });
            //Próximo metodo
            GetValueShippingTest();
        }

        public void GetValueShippingTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            var Test1 = _SearchBooksrepository.GetValueShipping(1);
            result = Test1 == 2 ? result = Result.Ok : result = Result.Falhou;

            var Test2 = _SearchBooksrepository.GetValueShipping(3);
            result = Test2 == 1.462 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });
            //Próximo metodo
        }

    }
}
