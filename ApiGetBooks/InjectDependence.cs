using ApiGetBooks.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ApiGetBooks {
    public class InjectDependence {
        public static void Inject(IServiceCollection services) {
            services.AddScoped<ISearchBooksRepository, SearchBooksRepository>();
        }
    }
}
