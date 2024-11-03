using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBViewModel.CoreDrug.ApiConnector
{
    public class ClinicalQuantity
    {
        public string? ClinicalQuantityDesc { get; set; }
        public int SubUnitQuantity { get; set; }
        public string? SubUnitOfMeasureDesc { get; set; }
        public string? PackageDesc { get; set; }
        public int eRxQuantity { get; set; }
        public string? eRxScriptPotencyUnitCode { get; set; }
        public string? eRxScriptUnitOfMeasureDesc { get; set; }
    }

    public class ERXDispensableDrug
    {
        public string? DispensableDrugID { get; set; }
        public string? DispensableDrugDesc { get; set; }
        public string? DispensableDrugTallManDesc { get; set; }
        public string? DispensableGenericDesc { get; set; }
        public string? DispensableGenericID { get; set; }
        public string? DoseFormDesc { get; set; }
        public string? DoseFormID { get; set; }
        public string? DrugNameDesc { get; set; }
        public string? DrugNameID { get; set; }
        public string? DefaultETCID { get; set; }
        public string? DefaultETCDesc { get; set; }
        public string? FederalDEAClassCode { get; set; }
        public string? FederalDEAClassCodeDesc { get; set; }
        public string? MedStrength { get; set; }
        public string? MedStrengthUnit { get; set; }
        public string? NameTypeCode { get; set; }
        public string? NameTypeCodeDesc { get; set; }
        public string? RouteDesc { get; set; }
        public string? RouteID { get; set; }
        public string? GenericDrugID { get; set; }
        public string? GenericDrugDesc { get; set; }
        public string? RXCUIDesc { get; set; }
        public string? RXCUI { get; set; }
        public string? RXCUITypeDesc { get; set; }
        public string? RXCUITypeCode { get; set; }
        public string? RXCUITypeOID { get; set; }
        public ClinicalQuantity? ClinicalQuantity { get; set; }
        public RepresentativeERXPackagedDrug? RepresentativeERXPackagedDrug { get; set; }
    }

    public class RepresentativeERXPackagedDrug
    {
        public string? PackagedDrugID { get; set; }
        public string? PackagedDrugDesc { get; set; }
        public DateTime AddDate { get; set; }
        public string? RepackagerCode { get; set; }
        public string? RepackagerCodeDesc { get; set; }
        public string? PrivateLabeledProductCode { get; set; }
        public string? PrivateLabeledProductCodeDesc { get; set; }
        public object? MostRecentAddDate { get; set; }
        public string? ClinicalQuantityDescription { get; set; }
        public object? ObsoleteDate { get; set; }
        public bool UnitDosePackagingIndicator { get; set; }
        public bool InnerPackageIndicator { get; set; }
        public bool SampleNDCIndicator { get; set; }
        public bool IsMedicalDevice { get; set; }
        public string? FederalLegendCode { get; set; }
        public string? FederalLegendCodeDesc { get; set; }
        public string? GenericDrugNameCode { get; set; }
        public string? GenericDrugNameCodeDesc { get; set; }
    }

    public class ApiERXDispensableDrugResponse
    {
        public string? ServiceCallID { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public int TotalResultCount { get; set; }
        public List<ERXDispensableDrug>? Items { get; set; }
    }


}
