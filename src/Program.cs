
using Builder_Pattern;
using System;
using System.Collections.Generic;

namespace DesignPatternChallenge
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Relatórios 1===");


            //Fluent ReportBuilder
            var report = new ReportBuilder()
                             .SetTitle("Vendas Mensais")
                             .SetFormat("PDF")
                             .SetStartDate(new DateTime(2024, 1, 1))
                             .SetEndDate(new DateTime(2024, 1, 31))
                             .SetIncludeHeader(true)
                             .SetIncludeFooter(true)
                             .SetHeaderText("Relatório de Vendas")
                             .SetFooterText("Confidencial")
                             .SetIncludeCharts(true)
                             .SetChartType("Bar")
                             .SetIncludeSummary(true)
                             .SetColumns(new List<string> { "Produto", "Quantidade", "Valor" })
                             .SetFilters(new List<string> { "Status=Ativo" })
                             .SetSortBy("Valor")
                             .SetGroupBy("Categoria")
                             .SetIncludeTotals(true)
                             .SetOrientation("Portrait")
                             .SetPageSize("A4")
                             .SetIncludePageNumbers(true)
                             .SetCompanyLogo("logo.png")
                             .SetWaterMark("Confidencial")
                             .Build();

            report.Generate();

            //Fluent ReportBuilder
            var report2 = new ReportBuilder()
                              .SetTitle("Relatório Trimestral")
                              .SetFormat("Excel")
                              .SetStartDate(new DateTime(2024, 1, 1))
                              .SetEndDate(new DateTime(2024, 3, 31))
                              .SetColumns(new List<string> { "Vendedor", "Região", "Total" })
                              .SetIncludeCharts(true)
                              .SetChartType ("line")
                              .SetIncludeHeader(true)
                              .SetGroupBy("Região")
                              .SetIncludeTotals(true)
                              .Build();

            report2.Generate();


            var report3 = new ReportBuilder()
                              .SetTitle("Vendas Anuais")
                              .SetFormat("PDF")
                              .SetStartDate(new DateTime(2024, 1, 1))
                              .SetEndDate(new DateTime(2024, 12, 31))
                              .SetIncludeHeader(true)
                              .SetHeaderText("Relatório de Vendas")
                              .SetIncludeFooter(true)
                              .SetFooterText("Confidencial")
                              .SetColumns(new List<string> { "Produto", "Quantidade", "Valor" })
                              .SetIncludeCharts(true)
                              .SetChartType("Pie")
                              .SetIncludeTotals(true)
                              .SetOrientation("Landscape")
                              .SetPageSize("A4")
                              .Build();

            report3.Generate();

            var director = new ReportDirector();
            var report4 = new ReportBuilder();
            director.BuildStandardAnnualPDF(report4);

            report4.Generate();

            Console.ReadLine();
        }
    }
}