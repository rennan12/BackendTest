using ApiGetBooks.Controllers;
using ApiGetBooks.Repositories;
using ApiGetBooks.Test;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace ApiGetBooks {
    public class InjectDependence {
        public static void Inject(IServiceCollection services) {
            services.AddScoped<ISearchBooksRepository, SearchBooksRepository>();
            services.AddScoped<SearchBooksRepositoryTest, SearchBooksRepositoryTest>();
            services.AddScoped<ManageJsonTest, ManageJsonTest>();
            services.AddControllers();

            services.AddApiVersioning(x => {
                x.DefaultApiVersion = new ApiVersion(1, 0);
                x.AssumeDefaultVersionWhenUnspecified = true;
                x.ReportApiVersions = true;
                x.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
            });
        }
    }
}
