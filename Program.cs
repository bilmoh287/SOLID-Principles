using System;

/* DIP:
 High-level modules should not depend on low-level modules.
 Both should depend on abstractions (e.g., interfaces or abstract classes).

 */

// compatible SRP, OCP, DIP + DI design pattern.

public interface IReportGenerator
{
    void Generate();
}

public class PdfReportGenerator : IReportGenerator
{
    public void Generate()
    {
        Console.WriteLine("PDF report generated :-).");
    }
}

public class ExelReportGenerator : IReportGenerator
{
    public void Generate()
    {
        Console.WriteLine("Exel report generated :-).");
    }
}

public class WordReportGenerator : IReportGenerator
{
    public void Generate()
    {
        Console.WriteLine("Word report generated :-).");
    }
}

public class ReportGenerator
{
    private IReportGenerator _ReportGenerator;


    public ReportGenerator(IReportGenerator reportGenerator)
    {
        // Direct dependency on interface (IReportGenerator) instead of concrete class (PdfReportGenerator)
        _ReportGenerator = reportGenerator;

    }

    public void GenerateReport()
    {
        _ReportGenerator.Generate();
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Client code
            ReportGenerator reportGenerator = new ReportGenerator( new PdfReportGenerator());
            reportGenerator.GenerateReport();

            reportGenerator = new ReportGenerator(new ExelReportGenerator());
            reportGenerator.GenerateReport();

            reportGenerator = new ReportGenerator(new WordReportGenerator());
            reportGenerator.GenerateReport();

            Console.ReadKey();

        }
    }
}
