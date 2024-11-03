using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBViewModel.CoreDrug.Business
{
    public class FDBDispensableResponse
    {
        public string? DrugNameDesc { get; set; }
        public string? FederalLegendCodeDesc { get; set; }
        public string? DispensableDrugDesc { get; set; }
        public string? DispensableGenericDesc { get; set; }
        public string? Dosage { get; set; }
    }
}
