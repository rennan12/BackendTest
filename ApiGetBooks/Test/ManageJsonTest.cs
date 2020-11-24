using ApiGetBooks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ApiGetBooks.Test {
    public class ManageJsonTest {

        public List<EntitysTest> TestarTudoClasseManageJsonTest() {
            LoadAllJsonTest();
            return ListaDeTestes;
        }

        string classTestingHere = "ManageJson";
        List<EntitysTest> ListaDeTestes = new List<EntitysTest>();
        private string methodTestingHere;
        private object result;
        private enum Result { Ok, Falhou }


        public void LoadAllJsonTest() {
            methodTestingHere = MethodBase.GetCurrentMethod().Name.Replace("Test", "");

            List<Books> jsonFile = ManageJson.LoadAllJson();

            result = jsonFile.Count == 5 ? result = Result.Ok : result = Result.Falhou;

            ListaDeTestes.Add(new EntitysTest() {
                Classe = classTestingHere,
                Metodo = methodTestingHere,
                Resultado = result.ToString()
            });
            //Próximo metodo


        }
    }
}
