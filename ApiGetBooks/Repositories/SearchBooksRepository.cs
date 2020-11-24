using ApiGetBooks.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ApiGetBooks.Repositories {
    public class SearchBooksRepository : ISearchBooksRepository {

        readonly List<Books> JsonAll = ManageJson.LoadAllJson();

        public List<Books> AscendingPrice(IEnumerable<Books> list) {
            return list.OrderBy(x => x.Price).ToList();
        }
        public List<Books> DescendingPrice(IEnumerable<Books> list) {
            return list.OrderByDescending(x => x.Price).ToList();
        }

        public List<Books> GetAll(string sort) {
            if (sort == "ascending") return AscendingPrice(JsonAll);
            if (sort == "descending") return DescendingPrice(JsonAll);
            if (sort == null) return JsonAll;
            else { return null; }
        }

        public List<Books> GetId(int id) {
            return JsonAll.Where(x => x.Id == id).ToList();
        }

        public List<Books> GetName(string param, string sort) {

            var searchName = JsonAll.Where(x => x.Name.ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return AscendingPrice(searchName);
            if (sort == "descending") return DescendingPrice(searchName);
            if (sort == null) return searchName.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetPrice(double price) {
            return JsonAll.Where(x => x.Price.Equals(price)).OrderBy(x => x.Id).ToList();
        }

        public List<Books> GetOriginallyPublished(string param, string sort) {

            var searchOriginallyPublished = JsonAll.Where(x => x.Specifications.OriginallyPublished.ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return AscendingPrice(searchOriginallyPublished);
            if (sort == "descending") return DescendingPrice(searchOriginallyPublished);
            if (sort == null) return searchOriginallyPublished.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetAuthor(string param, string sort) {

            var searchAuthor = JsonAll.Where(x => x.Specifications.Author.ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return AscendingPrice(searchAuthor);
            if (sort == "descending") return DescendingPrice(searchAuthor);
            if (sort == null) return searchAuthor.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetPageCount(int param, string sort) {

            var searchPageCount = JsonAll.Where(x => x.Specifications.PageCount == param);

            if (sort == "ascending") return AscendingPrice(searchPageCount);
            if (sort == "descending") return DescendingPrice(searchPageCount);
            if (sort == null) return searchPageCount.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetIllustrator(string param, string sort) {

            var searchllustrator = JsonAll.Where(x => x.Specifications.Illustrator.ToString().ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return AscendingPrice(searchllustrator);
            if (sort == "descending") return DescendingPrice(searchllustrator);
            if (sort == null) return searchllustrator.OrderBy(x => x.Id).ToList();
            else { return null; }
        }

        public List<Books> GetGenres(string param, string sort) {

            var searchGenres = JsonAll.Where(x => x.Specifications.Genres.ToString().ToUpper().Contains(param.ToUpper()));

            if (sort == "ascending") return AscendingPrice(searchGenres);
            if (sort == "descending") return DescendingPrice(searchGenres);
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
