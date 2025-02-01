namespace SystemReports.Base
{
    // 2. کلاس پایه Report که پیاده‌سازی Prototype را انجام می‌دهد
    public class Report : IReportPrototype
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
            CreatedDate = DateTime.Now;
        }

        // متد Clone برای ایجاد یک کپی از شیء فعلی
        public IReportPrototype Clone()
        {
            return new Report(Title, Content)
            {
                CreatedDate = CreatedDate
            };
        }

        public void Display()
        {
            Console.WriteLine($"Report: {Title}\nCreated: {CreatedDate}\nContent: {Content}\n");
        }
    }
}
