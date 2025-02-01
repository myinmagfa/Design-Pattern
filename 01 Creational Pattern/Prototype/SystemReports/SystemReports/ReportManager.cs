using SystemReports.Base;

namespace SystemReports
{
    // 3. کلاس مدیریت نمونه‌های گزارش
    public class ReportManager
    {
        private Dictionary<string, IReportPrototype> _reportTemplates = new Dictionary<string, IReportPrototype>();

        public void AddTemplate(string key, IReportPrototype report)
        {
            _reportTemplates[key] = report;
        }

        public IReportPrototype GetTemplate(string key)
        {
            if (_reportTemplates.ContainsKey(key))
            {
                return _reportTemplates[key].Clone();
            }
            return null;
        }
    }
}
