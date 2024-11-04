using FDBApiConnector.Common;
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
        private readonly IApiClient _apiClient;

        public CoreDrugService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<ApiDispensableResponse> SearchDispensableDrugs(string dispensableDrugDesc)
        {
            var requestUri = $"v1_3/DispensableDrugs/?callSystemName=Testing+str&callid=142541255&searchtype=StartsWith&searchText={dispensableDrugDesc}";
            return await _apiClient.GetAsync<ApiDispensableResponse>(requestUri);
        }
        public async Task<ApiERXDispensableDrugResponse> GetERXDispensableDrugs()
        {
            var requestUri = $"v1_4/ERXDispensableDrugs/?callSystemName=Testing+str&callid=142541255";
            return await _apiClient.GetAsync<ApiERXDispensableDrugResponse>(requestUri);
        }

    }
}
