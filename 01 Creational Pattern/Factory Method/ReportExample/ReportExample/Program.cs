using ReportExample.Base;
using ReportExample.ReportsCreator;

internal class Program
{
    private static void Main(string[] args)
    {
        new ExportReport().Main();
    }
}

internal class ExportReport
{
    public void Main()
    {
        CreatorHandler(new ExcelReportCreator());
        CreatorHandler(new HtmlReportCreator());
        CreatorHandler(new PdfReportCreator());
    }

    public void CreatorHandler(Creator creator)
    {
        creator.CreateReport();
        Console.WriteLine();
    }
}

// در یک برنامه گزارش‌گیری، ممکن است بخواهید گزارش‌هایی در قالب‌های مختلف (PDF، Excel یا HTML) ایجاد کنید.