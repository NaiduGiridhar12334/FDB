using FDBViewModel.CoreDrug;
using FDBViewModel.CoreDrug.Business;

namespace FDBOrchestration.CoreDrug.Interface
{
    public interface ICoreDrugOrchestration
    {
        Task<List<FDBDispensableResponse>> GetDispensableDrugs(string DrugNameDesc = null);
    }
}
