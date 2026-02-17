using DesignPatternChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class ReportDirector
    {
        public void BuildStandardAnnualPDF(IReportBuilder builder)
        {
            builder.SetTitle("Relatório Anual")
                   .SetFormat("PDF")
                   .SetStartDate(new DateTime(DateTime.Now.Year, 1, 1))
                   .SetEndDate(new DateTime(DateTime.Now.Year, 12, 31))
                   .SetIncludeHeader(true)
                   .SetHeaderText("Relatório Anual de Vendas - Usando o Standard format")
                   .SetIncludeFooter(true)
                   .SetFooterText("Confidencial")
                   .SetIncludeCharts(true)
                   .SetChartType("Bar")
                   .SetIncludeSummary(true)
                   .SetColumns(new List<string> { "Produto", "Quantidade", "Valor" })
                   .SetGroupBy("Categoria")
                   .SetIncludeTotals(true)
                   .SetOrientation("Portrait")
                   .SetPageSize("A4")
                   .SetIncludePageNumbers(true);
        }


    }
}
