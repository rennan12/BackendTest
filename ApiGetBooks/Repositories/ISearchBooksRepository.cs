using ApiGetBooks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGetBooks.Repositories {
    public interface ISearchBooksRepository {
        List<Books> GetAll();
        List<Books> GetAll(Constants.Order a);
        List<Books> GetId(int id);
        List<Books> GetName(string name, string sort);
        List<Books> GetPrice(double price);
    }
}
