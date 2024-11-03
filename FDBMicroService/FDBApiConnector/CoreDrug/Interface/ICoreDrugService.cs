using FDBViewModel.CoreDrug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBApiConnector.CoreDrug.Interface
{
    public interface ICoreDrugService
    {
        Task<DispensableGenericsResponse> SearchDispensableGenerics(string dispensableDrugDesc);
    }
}
