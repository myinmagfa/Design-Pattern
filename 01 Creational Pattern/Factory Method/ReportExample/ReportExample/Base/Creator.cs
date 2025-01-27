namespace ReportExample.Base
{
    public abstract class Creator
    {
        public abstract IReport FactoryMethod();
        public void CreateReport()
        {
            var report= FactoryMethod();
            report.Export();
        }

        
    }
}
