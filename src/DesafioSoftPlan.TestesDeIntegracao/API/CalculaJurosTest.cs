using Xunit;
using System.Net;
using System.Net.Http;
using DesafioSoftPlan.Api;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace DesafioSoftPlan.TestesDeIntegracao.API
{
    public class CalculaJurosTest
    {
        private readonly HttpClient _client;

        public CalculaJurosTest()
        {
            var server = new TestServer(new WebHostBuilder().UseEnvironment("Development").UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [Fact]
        public void TestCalculaJuros()
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:44300/calculajuros?valorinicial=100&meses=5");

            var response = _client.SendAsync(request).Result;

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
