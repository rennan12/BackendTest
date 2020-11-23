using ApiGetBooks.Entities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ApiGetBooks {
    public static class ManageJson {
        public static List<Books> LoadAllJson() {
            string json = File.ReadAllText(@"../books.json");
            List<Books> Books = JsonSerializer.Deserialize<List<Books>>(json);
            return Books;
        }
    }
}
