using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Diagnostics;
using AutoReportRegistryBuilder;

const string FUTURE_REG_ENTRY = "SOFTWARE\\Future P.O.S.";
RegistryKey? regKey = Registry.CurrentUser.OpenSubKey(FUTURE_REG_ENTRY);

const string reportRegex = "AUTO_*";
Regex rx = new Regex(reportRegex);

List<string> entries = new ();

if(regKey != null){
    foreach(var s in regKey.GetSubKeyNames()){
        if(rx.IsMatch(s)){
            entries.Add(s);
            Console.WriteLine(s);
        }     
    }
}else{
    Console.WriteLine("No Entries Found.");
}
//FPOSRegReader.exeCheck();
//foreach(string s in entries){
//    string reportType = s.Split('_')[1];
//    ProcessStartInfo info = new ProcessStartInfo($"cmd.exe /c {}\\{FPOSRegReader.getExeName(reportType)} {s}");
//}

 //   foreach(var s in subKeys){
 //       Console.WriteLine(s);
 //   }






