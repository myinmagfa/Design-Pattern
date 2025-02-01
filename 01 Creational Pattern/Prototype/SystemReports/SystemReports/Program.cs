using SystemReports;
using SystemReports.Base;

// 4. استفاده از الگوی Prototype در برنامه اصلی
internal class Program
{
    private static void Main()
    {
        ReportManager reportManager = new ReportManager();

        // ایجاد گزارش‌های پایه
        reportManager.AddTemplate("Financial", new Report("Financial Report", "This is a financial summary."));
        reportManager.AddTemplate("Sales", new Report("Sales Report", "This is a sales performance report."));

        // گرفتن نمونه‌های جدید از گزارش‌ها
        Report clonedReport1 = (Report)reportManager.GetTemplate("Financial");
        clonedReport1.Title = "Updated Financial Report";

        Report clonedReport2 = (Report)reportManager.GetTemplate("Sales");

        // نمایش گزارش‌های ایجاد شده
        clonedReport1.Display();
        clonedReport2.Display();
    }
}
