using System.Text;
using Microsoft.Win32;

namespace AutoReportRegistryBuilder{
     public static class FPOSRegReader{
        static Dictionary<String,String> reports = new ();
        private const string FPOS5Path = "C:\\FPOS5\\bin\\";
        private const string FPOS6Path = "C:\\FPOS\\bin\\";
        static string FPOSRegistryPath = "\\SOFTWARE\\Future P.O.S.\\";
        static RegistryKey? FPOSRegistryKey = (RegistryKey?)Registry.CurrentUser.GetValue(FPOSRegistryPath);
        //Initializes the Reports Dictionary with the report types as the key 
        //and the name of the associated execuatable as the value.
        private static void init(){
            reports["Labor vs Sales Report"] = "lvsrpt.exe";
            reports["Sales by Range Report"] = "slsrgrpt.exe";
            reports["Sales Performance Report"] = "SalesPerformanceReport.exe";
            reports["Sales Accountability Report"] = "SlsAcrpt.exe";
            reports["Sales by Serving Period Report"] = "SlsPdrpt.exe";
            reports["Sales Statistics Report"] = "slsstrpt.exe";
            reports["Sales Projection Report"] = "SPRpt.exe";
            reports["Cash Over Short Report Report"] = "CashOvrShortRpt.exe";
            reports["Comparative Item Sales Report"] = "Comparative Report";
            reports["Cumulative Sales Report Report"] = "CmSlsRpt.exe";
            reports["Daily Sales by Month Report"] = "DailySalesByMonth.exe";
            reports["Item Costing Report"] = "";
            reports["Item Sales Report"] = "";
            reports["Movement Report"] = "";
            reports["Revenue Center Report"] = "";
            reports["Top/Bottom Movers Report"] = "";
            reports["Weekly Movement Report"] = "";
            reports["Distributor Report"] = "";
            reports["Food Costing Report"] = "";
            reports["Inventory Count Sheets Report"] = "";
            reports["Inventory List Report"] = "";
            reports["Reorder Report"] = "";
            reports["Beverage Ratio Report"] = "";
            reports["Effective Wage Report"] = "";
            reports["Employee Cashout Report"] = "";
            reports["Employee Promo Sales"] = "";
            reports["Employee Sales By Department Report"] = "";
            reports["Employee Timecard Report"] = "";
            reports["Employee Wage Report"] = "";
            reports["Sales Performance Report"] = "";
            reports["Server Wage Audit Report"] = "";
            reports["Customer Charge Report"] = "";
            reports["Customer Loyalty Report"] = "";
            reports["Customer Transaction Report"] = "";
            reports["Duplicate Customers Report"] = "";
            reports["Activity Report"] = "actrpt.exe";
            reports["Coupons Report"] = "cpnrpt.exe";
            reports["Discounts Report"] = "discrpt.exe";
            reports["Electronice Journal Report"] = "ejrpt.exe";
            reports["Item Prep Time Report"] = "iptrpt.exe";
            reports["Items Sold Report"] = "isrpt.exe";
            reports["Local Transaction Report"] = "creditdevicereport.exe";
            //reports["Log Report"] = "logrpt.exe"; 
            reports["Paid Out Report"] = "pdoutrpt.exe";
            reports["Voided Items Report"] = "virpt.exe";
        }
        static IFPOSRegEntry[]? readFile(string filePath){
            
            return null;
        }
        //Returns a string containing the name of the executable that runs the specified report.
        //Returns an empty string if the reportType is not a key in the report Dictionary.
        public static string? getExeName(string reportType){
            try{
                return reports[reportType];
            }catch(KeyNotFoundException ex){
                Console.WriteLine(ex.Message);
                return "";
            }
            
        }   
        static FPOSRegReader(){
            init();
        }

        public static void exeCheck(){
            foreach(var k in reports.Keys){
                if(File.Exists($"{FPOS6Path}{reports[k]}")){
                    Console.WriteLine($"{FPOS6Path}{reports[k]} succesfully validated.");
                }else if(reports[k] == ""){
                    Console.WriteLine($"{k} has no associated executable.");
                }else{
                    Console.Error.WriteLine($"{FPOS6Path}{reports[k]} not found!");
                }
            }
        }
    }
}