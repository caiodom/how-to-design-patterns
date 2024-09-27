// Creating different reports
using Visitor;

IReport revenueReport = new RevenueReport(10000);
IReport expenseReport = new ExpenseReport(5000);
IReport investmentReport = new InvestmentReport(2000);

// Creating a visitor for tax calculation
IReportVisitor taxCalculator = new TaxCalculatorVisitor();

// Using the tax calculator visitor on each report
revenueReport.Accept(taxCalculator);
expenseReport.Accept(taxCalculator);
investmentReport.Accept(taxCalculator);

Console.WriteLine();

// Creating a visitor for PDF export
IReportVisitor pdfExporter = new PdfExportVisitor();

// Using the PDF export visitor on each report
revenueReport.Accept(pdfExporter);
expenseReport.Accept(pdfExporter);
investmentReport.Accept(pdfExporter);