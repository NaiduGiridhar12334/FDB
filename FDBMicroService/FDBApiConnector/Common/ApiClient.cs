using FDBViewModel.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FDBApiConnector.Common
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient _client;
        private readonly ApiSettings _settings;

        public ApiClient(HttpClient client, IOptions<ApiSettings> settings)
        {
            _client = client;
            _settings = settings.Value;

            _client.BaseAddress = new Uri(_settings.FDBBaseUrl);
            _client.DefaultRequestHeaders.Add("Authorization", _settings.FDBAuthorizationKey);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<TResponse> GetAsync<TResponse>(string requestUri)
        {
            HttpResponseMessage response = await _client.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TResponse>(jsonResponse);
            }
            else
            {
                throw new Exception($"API call failed with status: {response.ReasonPhrase}");
            }
        }
    }
}
