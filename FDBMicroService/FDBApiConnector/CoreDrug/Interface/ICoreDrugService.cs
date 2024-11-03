using FDBViewModel.CoreDrug;
using FDBViewModel.CoreDrug.ApiConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBApiConnector.CoreDrug.Interface
{
    public interface ICoreDrugService
    {
        Task<ApiDispensableResponse> SearchDispensableDrugs(string dispensableDrugDesc);

    }
}
