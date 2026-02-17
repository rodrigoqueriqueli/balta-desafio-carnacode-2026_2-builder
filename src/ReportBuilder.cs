using DesignPatternChallenge;

namespace Builder_Pattern
{
    internal class ReportBuilder : IReportBuilder
    {
        private readonly Report _report = new();

        public Report Build()
        {
            return _report;
        }

        public IReportBuilder Generate()
        {
            Console.WriteLine($"\n=== Gerando Relatório: {_report.Title} ===");
            Console.WriteLine($"Formato: {_report.Format}");
            Console.WriteLine($"Período: {_report.StartDate:dd/MM/yyyy} a {_report.EndDate:dd/MM/yyyy}");

            if (_report.IncludeHeader)
                Console.WriteLine($"Cabeçalho: {_report.HeaderText}");

            if (_report.IncludeCharts)
                Console.WriteLine($"Gráfico: {_report.ChartType}");

            Console.WriteLine($"Colunas: {string.Join(", ", _report.Columns)}");

            if (_report?.Filters?.Count > 0)
                Console.WriteLine($"Filtros: {string.Join(", ", _report.Filters)}");

            if (!string.IsNullOrEmpty(_report.GroupBy))
                Console.WriteLine($"Agrupado por: {_report.GroupBy}");

            if (_report.IncludeFooter)
                Console.WriteLine($"Rodapé: {_report.FooterText}");

            Console.WriteLine("Relatório gerado com sucesso!");

            return this;
        }

        public IReportBuilder SetChartType(string chartType)
        {
            _report.ChartType = chartType;
            return this;
        }

        public IReportBuilder SetColumns(List<string> columns)
        {
            _report.Columns = columns;
            return this;
        }

        public IReportBuilder SetCompanyLogo(string companyLogo)
        {
            _report.CompanyLogo = companyLogo;
            return this;
        }

        public IReportBuilder SetEndDate(DateTime endDate)
        {
            _report.EndDate = endDate;
            return this;
        }

        public IReportBuilder SetFilters(List<string> filters)
        {
            _report.Filters = filters;
            return this;
        }

        public IReportBuilder SetFooterText(string footerText)
        {
            _report.FooterText = footerText;
            return this;
        }

        public IReportBuilder SetFormat(string format)
        {
            _report.Format = format;
            return this;
        }

        public IReportBuilder SetGroupBy(string groupBy)
        {
            _report.GroupBy = groupBy;
            return this;
        }

        public IReportBuilder SetHeaderText(string headerText)
        {
            _report.HeaderText = headerText;
            return this;
        }

        public IReportBuilder SetIncludeCharts(bool includeCharts)
        {
            _report.IncludeCharts = includeCharts;
            return this;
        }

        public IReportBuilder SetIncludeFooter(bool includeFooter)
        {
            _report.IncludeFooter = includeFooter;
            return this;
        }

        public IReportBuilder SetIncludeHeader(bool includeHeader)
        {
            _report.IncludeHeader = includeHeader;
            return this;
        }

        public IReportBuilder SetIncludePageNumbers(bool includePageNumber)
        {
            _report.IncludePageNumbers = includePageNumber;
            return this;
        }

        public IReportBuilder SetIncludeSummary(bool includeSummary)
        {
            _report.IncludeSummary = includeSummary;
            return this;
        }

        public IReportBuilder SetIncludeTotals(bool includeTotals)
        {
            _report.IncludeTotals = includeTotals;
            return this;
        }

        public IReportBuilder SetOrientation(string orientation)
        {
            _report.Orientation = orientation;
            return this;
        }

        public IReportBuilder SetPageSize(string pageSize)
        {
            _report.PageSize = pageSize;
            return this;
        }

        public IReportBuilder SetSortBy(string sortBy)
        {
            _report.SortBy = sortBy;
            return this;
        }

        public IReportBuilder SetStartDate(DateTime startDate)
        {
            _report.StartDate = startDate;
            return this;
        }

        public IReportBuilder SetTitle(string title)
        {
            _report.Title = title;
            return this;
        }

        public IReportBuilder SetWaterMark(string waterMark)
        {
            _report.WaterMark = waterMark;
            return this;
        }
    }
}
