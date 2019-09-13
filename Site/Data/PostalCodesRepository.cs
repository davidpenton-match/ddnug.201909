using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Site.Data
{
    public interface IPostalCodesRepository
    {
        Task<string> Get(int postalCode);
    }

    public class PostalCodesRepository : IPostalCodesRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PostalCodesRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> Get(int postalCode)
        {
            var client = _httpClientFactory.CreateClient();

            var xx = await client.GetAsync("https://api.zippopotam.us/us/" + postalCode.ToString());

            return await xx.Content.ReadAsStringAsync();
        }
    }
}
