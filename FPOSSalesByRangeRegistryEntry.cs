namespace AutoReportRegistryBuilder
{
    public class FPOSSalesByRangeRegistryEntry : IFPOSRegEntry{
        string StartDate = "";
        int StartDateType = 0;
        string StartTime = "";
        int StartTimeType = 0;
        string EndDate = "";
        int EndDateType = 0;
        string EndTime = "";
        int EndTimeType = 0;

        string EmailFrom = "";
        string EmailTo = "";
        int EmailAfterRun = 0;
        int ExportFile = 0;
        int DontIncludeOrderTypeSummary = 0;
        int DontIncludeOrderTypeSummaryType = 0;
        int OrderTypeScope = 0;
        int OrderTypeScope_Type = 0;
        int DontIncludeGratuitiesinSaleAmt = 0;
        int DontIncludGratuitiesinSaleAmtType = 0;
        int IncludeUntippedMediaTotal = 0;
        int IncludeUntippedMediaTotalType = 0;
        int DontIncludeItemsWithAZeroPrice = 0;
        int DontIncludeItemsWithAZeroPriceType = 0;
        int DontIncludeToGoSalesinServingPeriodSummary = 0;
        int DontIncludeToGoSalesinServingPeriodSummaryType = 0;
        int DontIncludeGratuitiinAccountable = 0;
        int DontIncludeGratuitiesinAccountableType = 0;
        int IncludeOpenSales = 0;
        int IncludeOpenSalesType = 0;
        int TerminalTotalstoAddChecksTo = 0;
        int TerminalTotalstoAdChecksTo_Type = 0;
        int SelectionCriteria = 0;
        int SelectionCriteriaType = 0;
        int DontShowCancelledSales = 0;
        int DontShowCancelledSalesType = 0;
        int DontShowTrainingModeSales = 0;
        int DontShowTrainingModeSalesType = 0;
        int DontShowRefundedSales = 0;
        int DontShowRefundedSalesType = 0;
        int DontShowReOpenedSales = 0;
        int DontShowReOpenedSales_Type = 0;
        int IncludeCashTipsinMediaTotal = 0;
        int IncludeCashTipsinMediaTotalType = 0;
        int SubtractCashTipsFromAdjCash = 0;
        int SubtractCashTipsFromAdjCashType = 0;
        int IncludePerformanceRatings = 0;
        int IncludePerformanceRatingsType = 0;
        int DontShowVoidedItems = 0;
        int DontShowVoidedItemsType = 0;
        int ShowDetailedGiftCertificate = 0;
        int ShowDetailedGiftCertificateType = 0;
        int ShowPercentNetSalesinDiscountSummary = 0;
        int ShowPercentNetSalesinDiscountSummaryType = 0;
        int ShowPercentNetSalesinAuditSummary = 0;
        int ShowPercentNetSalesinAuditSummaryType = 0;
        int ShowDissatisfactionDiscountSummary = 0;
        int ShowDissatisfactionDiscountSummaryType = 0;
        int ShowDetailedTax = 0;
        int ShowDetailedTaxType = 0;
        int PrintOptions = 0;

        public void readEntry(){

        }
    }
}