// DESAFIO: Gerador de Relatórios Complexos
// PROBLEMA: Sistema precisa gerar diferentes tipos de relatórios (PDF, Excel, HTML)
// com múltiplas configurações opcionais (cabeçalho, rodapé, gráficos, tabelas, filtros)
// O código atual usa construtores enormes ou muitos setters, tornando difícil criar relatórios


using Builder_Pattern;

namespace DesignPatternChallenge
{
    public interface IReportBuilder
    {
        IReportBuilder SetChartType(string chartType);
        IReportBuilder SetColumns(List<string> columns);
        IReportBuilder SetCompanyLogo(string companyLogo);
        IReportBuilder SetEndDate(DateTime endDate);
        IReportBuilder SetFilters(List<string> filters);
        IReportBuilder SetFooterText(string footerText);
        IReportBuilder SetFormat(string format);
        IReportBuilder SetGroupBy(string groupBy);
        IReportBuilder SetHeaderText(string headerText);
        IReportBuilder SetIncludeCharts(bool includeCharts);
        IReportBuilder SetIncludeFooter(bool includeFooter);
        IReportBuilder SetIncludeHeader(bool includeHeader);
        IReportBuilder SetIncludePageNumbers(bool includePageNumber);
        IReportBuilder SetIncludeSummary(bool includeSummary);
        IReportBuilder SetIncludeTotals(bool includeTotals);
        IReportBuilder SetOrientation(string orientation);
        IReportBuilder SetPageSize(string pageSize);
        IReportBuilder SetSortBy(string sortBy);
        IReportBuilder SetStartDate(DateTime startDate);
        IReportBuilder SetTitle(string title);
        IReportBuilder SetWaterMark(string waterMark);

        Report Build();
    }
}