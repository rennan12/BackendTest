using ApiGetBooks.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ApiGetBooks.Repositories {
    public class SearchBooksRepository : ISearchBooksRepository {

        readonly List<Books> JsonAll = ManageJson.LoadAllJson();

        public List<Books> ascendingPrice(IEnumerable<Books> list) {
            return list.OrderBy(x => x.Price).ToList();
        }
        public List<Books> descendingPrice(IEnumerable<Books> list) {
            return list.OrderByDescending(x => x.Price).ToList();
        }

        public List<Books> GetAll(string sort) {
            if (sort == "ascending") return ascendingPrice(JsonAll);
            if (sort == "descending") return descendingPrice(JsonAll);
            if (sort == null) return JsonAll;
            else { return null; }
        }

        public List<Books> GetId(int id) {
            return JsonAll.Where(x => x.Id == id).ToList();
        }

        public List<Books> GetName(string param, string sort) {

            var searchName = JsonAll.Where(x => x.Name.ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return ascendingPrice(searchName);
            if (sort == "descending") return descendingPrice(searchName);
            if (sort == null) return searchName.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetPrice(double price) {
            return JsonAll.Where(x => x.Price.Equals(price)).OrderBy(x => x.Id).ToList();
        }

        public List<Books> GetOriginallyPublished(string param, string sort) {

            var searchOriginallyPublished = JsonAll.Where(x => x.Specifications.OriginallyPublished.ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return ascendingPrice(searchOriginallyPublished);
            if (sort == "descending") return descendingPrice(searchOriginallyPublished);
            if (sort == null) return searchOriginallyPublished.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetAuthor(string param, string sort) {

            var searchAuthor = JsonAll.Where(x => x.Specifications.Author.ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return ascendingPrice(searchAuthor);
            if (sort == "descending") return descendingPrice(searchAuthor);
            if (sort == null) return searchAuthor.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetPageCount(int param, string sort) {

            var searchPageCount = JsonAll.Where(x => x.Specifications.PageCount == param);

            if (sort == "ascending") return ascendingPrice(searchPageCount);
            if (sort == "descending") return descendingPrice(searchPageCount);
            if (sort == null) return searchPageCount.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetIllustrator(string param, string sort) {

            var searchllustrator = JsonAll.Where(x => x.Specifications.Illustrator.ToString().ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return ascendingPrice(searchllustrator);
            if (sort == "descending") return descendingPrice(searchllustrator);
            if (sort == null) return searchllustrator.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetGenres(string param, string sort) {

            var searchGenres = JsonAll.Where(x => x.Specifications.Genres.ToString().ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return ascendingPrice(searchGenres);
            if (sort == "descending") return descendingPrice(searchGenres);
            if (sort == null) return searchGenres.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public double? GetValueShipping(int id) {
            var searchId = JsonAll.Where(x => x.Id == id).FirstOrDefault();

            if(searchId != null) {
                return searchId.Price * 0.2;
            } else { return null; }
        }
    }
}
