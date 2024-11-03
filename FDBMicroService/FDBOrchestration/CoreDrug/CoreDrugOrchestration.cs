using FDBApiConnector.CoreDrug.Interface;
using FDBOrchestration.CoreDrug.Interface;
using FDBViewModel.CoreDrug;
using FDBViewModel.CoreDrug.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBOrchestration.CoreDrug
{
    public class CoreDrugOrchestration : ICoreDrugOrchestration
    {
        public readonly ICoreDrugService _coreDrugService;

        public CoreDrugOrchestration(ICoreDrugService coreDrugService)
        {
            _coreDrugService = coreDrugService;
        }
        public async Task<List<FDBDispensableResponse>> GetDispensableDrugs(string DrugNameDesc = null)
        {
            List<FDBDispensableResponse> fDBDispensableResponses = new List<FDBDispensableResponse>();
            var response = await this._coreDrugService.SearchDispensableDrugs(DrugNameDesc);
            if (response != null && response.Items != null)
            {
                foreach (var item in response.Items)
                {
                    FDBDispensableResponse fDBDispensableResponse = new FDBDispensableResponse();
                    fDBDispensableResponse.DispensableDrugDesc = item.DispensableDrugDesc;
                    fDBDispensableResponse.DispensableGenericDesc = item.DispensableGenericDesc;
                    fDBDispensableResponse.DrugNameDesc = item.DrugNameDesc;
                    fDBDispensableResponse.FederalLegendCodeDesc = item.FederalLegendCodeDesc;
                    fDBDispensableResponse.Dosage = item.MedStrength + " " + item.MedStrengthUnit + " " + item.FederalLegendCodeDesc;
                    fDBDispensableResponses.Add(fDBDispensableResponse);
                }
            }
            return fDBDispensableResponses;
        }
    }
}
