//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Report.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientTable
    {
        public Nullable<long> ActiveClientAccessCodeGeneratedAt { get; set; }
        public string ActiveClientAccessCode { get; set; }
        public Nullable<System.DateTime> DateRegistered { get; set; }
        public string DatabaseServer { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUserName { get; set; }
        public string DatabasePassword { get; set; }
        public string FullName { get; set; }
        public Nullable<bool> IsProvisioned { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public Nullable<bool> IsRegisteredForTax { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<bool> DefaultPostalAddressFromResidential { get; set; }
        public Nullable<System.DateTime> DatePreRegistered { get; set; }
        public string SiteCode { get; set; }
        public string ActivationId { get; set; }
        public Nullable<System.DateTime> DateExportedToCRM { get; set; }
        public string SalesPerson { get; set; }
        public Nullable<bool> AccessBlocked { get; set; }
        public string AccessBlockedReason { get; set; }
        public string AppVersion { get; set; }
        public string ServicesBaseUrl { get; set; }
        public string LiquidPartnerClientId { get; set; }
        public Nullable<bool> DefaultAccountContact { get; set; }
        public string ReferenceCode { get; set; }
        public Nullable<System.DateTime> DateExportedForWhiteLabel { get; set; }
        public string WhiteLabelClientId { get; set; }
        public Nullable<int> IdClient_Original { get; set; }
        public System.Guid IdClient { get; set; }
        public System.Guid FK_WhiteLabelInfoId { get; set; }
        public Nullable<System.Guid> FK_LiquidPartnerId { get; set; }
        public Nullable<System.Guid> BillingModelId { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string SchemaName { get; set; }
        public string Src { get; set; }
        public string SrcId { get; set; }
        public Nullable<System.Guid> FK_PrevWhiteLabelInfoId { get; set; }
        public string ReportsServiceBaseUrl { get; set; }
        public Nullable<bool> HasDebitOrder { get; set; }
        public Nullable<int> DbVersion { get; set; }
        public string SalesPersonInitials { get; set; }
        public Nullable<System.DateTime> LeadExportedToCRM { get; set; }
        public string PreRegEmployeeCount { get; set; }
        public string PreRegArea { get; set; }
        public string UIOption { get; set; }
        public string ReferralCode { get; set; }
    }
}