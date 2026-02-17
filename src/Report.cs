namespace Builder_Pattern
{
    public class Report 
    {
        public string Title { get; internal set; }
        public string Format { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public bool IncludeHeader { get; internal set; }
        public bool IncludeFooter { get; internal set; }
        public string HeaderText { get; internal set; }
        public string FooterText { get; internal set; }
        public bool IncludeCharts { get; internal set; }
        public string ChartType { get; internal set; }
        public bool IncludeSummary { get; internal set; }
        public List<string> Columns { get; internal set; }
        public List<string> Filters { get; internal set; }
        public string SortBy { get; internal set; }
        public string GroupBy { get; internal set; }
        public bool IncludeTotals { get; internal set; }
        public string Orientation { get; internal set; }
        public string PageSize { get; internal set; }
        public bool IncludePageNumbers { get; internal set; }
        public string CompanyLogo { get; internal set; }
        public string WaterMark { get; internal set; }


        public void Generate()
        {
            Console.WriteLine($"\n=== Gerando Relatório: {Title} ===");
            Console.WriteLine($"Formato: {Format}");
            Console.WriteLine($"Período: {StartDate:dd/MM/yyyy} a {EndDate:dd/MM/yyyy}");

            if (IncludeHeader)
                Console.WriteLine($"Cabeçalho: {HeaderText}");

            if (IncludeCharts)
                Console.WriteLine($"Gráfico: {ChartType}");

            Console.WriteLine($"Colunas: {string.Join(", ", Columns)}");

            if (Filters?.Count > 0)
                Console.WriteLine($"Filtros: {string.Join(", ", Filters)}");

            if (!string.IsNullOrEmpty(GroupBy))
                Console.WriteLine($"Agrupado por: {GroupBy}");

            if (IncludeFooter)
                Console.WriteLine($"Rodapé: {FooterText}");

            Console.WriteLine("Relatório gerado com sucesso!");
        }
    }
}
