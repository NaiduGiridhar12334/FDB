using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBViewModel.CoreDrug.ApiConnector
{
    public class DispensableDrug
    {
        public string? DrugNameDesc { get; set; }
        public string? FederalLegendCodeDesc { get; set; }
        public string? DispensableDrugDesc { get; set; }
        public string? DispensableGenericDesc { get; set; }
        public string? MedStrength { get; set; }
        public string? MedStrengthUnit { get; set; }
        public string? DoseFormDesc { get; set; }
    }

    public class ApiDispensableResponse
    {
        public string? ServiceCallID { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int TotalResultCount { get; set; }
        public List<DispensableDrug>? Items { get; set; }
    }
}
