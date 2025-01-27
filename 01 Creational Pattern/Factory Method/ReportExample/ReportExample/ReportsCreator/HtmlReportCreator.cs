using ReportExample.Base;
using ReportExample.Reports;

namespace ReportExample.ReportsCreator
{
    public class HtmlReportCreator : Creator
    {
        public override IReport FactoryMethod()
        {
            return new Html();
        }
    }
}
