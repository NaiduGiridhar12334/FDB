using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBViewModel.CoreDrug
{
    public class Item
    {
        public string? DrugNameDesc { get; set; }
        public string? FederalLegendCodeDesc { get; set; }
        public string? DispensableDrugDesc { get; set; }
        public string? DispensableGenericDesc { get; set; }
    }

    public class DispensableGenericsResponse
    {
        public string? ServiceCallID { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int TotalResultCount { get; set; }
        public List<Item>? Items { get; set; }
    }
}
