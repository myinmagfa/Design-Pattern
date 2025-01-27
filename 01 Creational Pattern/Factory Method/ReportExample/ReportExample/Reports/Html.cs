using ReportExample.Base;

namespace ReportExample.Reports
{
    public class Html:IReport
    {
        public void Export() {
            Console.WriteLine("Report Exported as Html");
        }
    }
}
