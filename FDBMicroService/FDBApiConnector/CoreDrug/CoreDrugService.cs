using FDBApiConnector.CoreDrug.Interface;
using FDBViewModel.CoreDrug;
using FDBViewModel.CoreDrug.ApiConnector;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace FDBApiConnector.CoreDrug
{
    public class CoreDrugService : ICoreDrugService
    {
        private readonly HttpClient _client;
        public CoreDrugService(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://api.fdbcloudconnector.com/CC/api/");
            _client.DefaultRequestHeaders.Add("Authorization", "SHAREDKEY 214512:8+dWskmjgeC5nQ072vZ7D7e/Y78sIOrxd7z1TXxkA1I=");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ApiDispensableResponse> SearchDispensableDrugs(string dispensableDrugDesc)
        {
            var requestUri = $"v1_3/DispensableDrugs/?callSystemName=Testing+str&callid=142541255&searchtype=StartsWith&searchText={dispensableDrugDesc}";
            HttpResponseMessage response = await _client.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                // Use ReadFromJsonAsync to deserialize the JSON response
                var jsonResponse = await response.Content.ReadAsStringAsync();

                var rootResult = JsonSerializer.Deserialize<ApiDispensableResponse>(jsonResponse);

                if (rootResult != null)
                {
                    rootResult.Items = rootResult.Items.ToList(); // Ensure Items is not null and can be processed
                }
                return rootResult;
            }
            else
            {
                throw new Exception($"API call failed with status: {response.ReasonPhrase}");
            }
        }


        public async Task<ApiERXDispensableDrugResponse> GetERXDispensableDrugs()
        {
            var requestUri = $"v1_4/ERXDispensableDrugs/?callSystemName=Testing+str&callid=142541255";
            HttpResponseMessage response = await _client.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                // Use ReadFromJsonAsync to deserialize the JSON response
                var jsonResponse = await response.Content.ReadAsStringAsync();

                var rootResult = JsonSerializer.Deserialize<ApiERXDispensableDrugResponse>(jsonResponse);

                if (rootResult != null)
                {
                    rootResult.Items = rootResult.Items.ToList();
                }
                return rootResult;
            }
            else
            {
                throw new Exception($"API call failed with status: {response.ReasonPhrase}");
            }
        }
    }
}
