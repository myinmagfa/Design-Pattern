using ReportExample.Base;
using ReportExample.Reports;

namespace ReportExample.ReportsCreator
{
    public class ExcelReportCreator : Creator
    {
        public override IReport FactoryMethod()
        {
            return new Excel();
        }
    }
}
