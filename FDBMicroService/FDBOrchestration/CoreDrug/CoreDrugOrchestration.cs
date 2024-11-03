using FDBApiConnector.CoreDrug.Interface;
using FDBOrchestration.CoreDrug.Interface;
using FDBViewModel.CoreDrug;
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
        public async Task<DispensableGenericsResponse> GetDispensableGenerics(string DrugNameDesc = null)
        {
            return await _coreDrugService.SearchDispensableGenerics(DrugNameDesc);
        }
    }
}
