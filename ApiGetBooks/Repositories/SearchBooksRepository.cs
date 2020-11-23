using ApiGetBooks.Entities;
using System.Collections.Generic;
using System.Linq;


namespace ApiGetBooks.Repositories {
    public class SearchBooksRepository : ISearchBooksRepository {

        readonly List<Books> JsonAll = ManageJson.LoadAllJson();

        public List<Books> GetAll() {
            return JsonAll;
        }
        public List<Books> GetAll(string? a) {
            if(a == Constants.Order.ascending) { }
            return JsonAll;
        }
        public List<Books> GetId(int id) {
            return JsonAll.Where(x => x.Id == id).ToList();
        }
        public List<Books> GetId(int id, string sort) {
            return JsonAll.Where(x => x.Id == id).OrderBy(x => x.Price).ToList();
        }

        public List<Books> GetName(string name, string sort) {
            var searchName = JsonAll.Where(x => x.Name.ToUpper().Contains(name.ToUpper()));
            return searchName.OrderByDescending(x => x.Price).ToList();
        }

        public List<Books> GetPrice(double price) {
            return JsonAll.Where(x => x.Price.Equals(price)).ToList();
        }
    }
}
