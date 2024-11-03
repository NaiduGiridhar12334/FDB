using FDBViewModel.CoreDrug;

namespace FDBOrchestration.CoreDrug.Interface
{
    public interface ICoreDrugOrchestration
    {
        Task<DispensableGenericsResponse> GetDispensableGenerics(string DrugNameDesc = null);
    }
}
