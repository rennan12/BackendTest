using ApiGetBooks.Entities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ApiGetBooks {
    public static class ManageJson {
        public static List<Books> LoadAllJson() {

            try {
                string json = File.ReadAllText(@"books.json");
                List<Books> BooksJson = JsonSerializer.Deserialize<List<Books>>(json);
                return BooksJson;
            }
            catch (System.IO.FileNotFoundException ex) {

                throw ex;
            }

        }
    }
}
