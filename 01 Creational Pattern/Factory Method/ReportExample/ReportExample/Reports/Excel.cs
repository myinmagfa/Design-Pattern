using ReportExample.Base;

namespace ReportExample.Reports
{
    public class Excel : IReport
    {
        public void Export()
        {
            Console.WriteLine("Report Exported as Excel");
        }
    }
}
