using ApiGetBooks.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiGetBooks.Repositories {
    public class BooksRepository : IBooksRepository {
        public List<Books> LoadAllJson() {
            string json = File.ReadAllText(@"../books.json");
            List<Books> Books = JsonSerializer.Deserialize<List<Books>>(json);
            return Books;
        }

        public List<Books> GetId(int id) {
            return LoadAllJson().Where(x => x.Id == id).ToList();
        }

        public List<Books> GetName(string name, string sort) {
            var searchName = LoadAllJson().Where(x => x.Name.ToUpper().Contains(name.ToUpper()));
            return searchName.OrderByDescending(x => x.Price).ToList();
        }

        public List<Books> GetPrice(double price) {
            return LoadAllJson().Where(x => x.Price.Equals(price)).ToList();
        }
    }
}
