using ReportExample.Base;
using ReportExample.Reports;

namespace ReportExample.ReportsCreator
{
    public class PdfReportCreator : Creator
    {
        public override IReport FactoryMethod()
        {
            return new Pdf();
        }
    }
}
