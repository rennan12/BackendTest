using ApiGetBooks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGetBooks.Repositories {
    public interface ISearchBooksRepository {
        List<Books> GetAll(string sort);
        List<Books> GetId(int id);
        List<Books> GetName(string param, string sort);
        List<Books> GetPrice(double price);
        List<Books> GetOriginallyPublished(string param, string sort);
        List<Books> GetAuthor(string param, string sort);
        List<Books> GetPageCount(int param, string sort);
        List<Books> GetIllustrator(string param, string sort);
        List<Books> GetGenres(string param, string sort);
        double? GetValueShipping(int id);
    }
}
