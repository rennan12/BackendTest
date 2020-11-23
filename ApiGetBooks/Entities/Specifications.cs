using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiGetBooks.Entities {
    public class Specifications {

        [JsonPropertyName("Originally published")]
        public string OriginallyPublished { get; set; }

        [JsonPropertyName("Author")]
        public string Author { get; set; }

        [JsonPropertyName("Page count")]
        public int PageCount { get; set; }


        [JsonPropertyName("Illustrator")]
        public object Illustrator { get; set; }
        /*Os campos Illustrator e Genres, devem ser do tipo object pois o json fornecido, 
        tem diferentes tipos de dados no mesmo parâmetro. Hora é objeto, hora é array */
        [JsonPropertyName("Genres")]
        public object Genres { get; set; }
    }
}
