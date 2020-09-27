namespace Frontend.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using DTO;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    public class IndexModel : PageModel
    {
        private readonly IHttpClientFactory clientFactory;
        private readonly IConfiguration configuration;
        private readonly ILogger<IndexModel> logger;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            this.logger = logger;
            this.clientFactory = clientFactory;
            this.configuration = configuration;
        }

        public IEnumerable<WeatherDto> Forecast { get; private set; }

        public SystemInfoDto SystemInfoDto { get; private set; }

        public async Task OnGet()
        {
            var httpClient = this.clientFactory.CreateClient("apigateway");
         
            this.SystemInfoDto = await httpClient.GetFromJsonAsync<SystemInfoDto>("system");
            this.Forecast = await httpClient.GetFromJsonAsync<IEnumerable<WeatherDto>>("weather");
        }
    }
}