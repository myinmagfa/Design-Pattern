using ReportExample.Base;

namespace ReportExample.Reports
{
    public class Pdf:IReport
    {
        public void Export()
        {
            Console.WriteLine("Report Exported as PDF");
        }

    }
}
