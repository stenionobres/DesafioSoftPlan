using RestSharp;

namespace DesafioSoftPlan.Api.ApiServices
{
    public class TaxaDeJurosApiService
    {
        private string _baseUrl => "https://localhost:44300";

        private RestClient _restClient;

        public TaxaDeJurosApiService()
        {
            _restClient = new RestClient(_baseUrl);
        }

        public double GetTaxaDeJuros()
        {
            var taxaDeJuros = 0d;
            var request = new RestRequest("taxaJuros", Method.GET);
            var response = _restClient.Execute<double>(request);

            if (response.IsSuccessful)
            {
                taxaDeJuros = response.Data;
            }

            return taxaDeJuros;
        }
    }
}
