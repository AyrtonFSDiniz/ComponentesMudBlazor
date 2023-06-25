using System.Text.Json.Serialization;
using ComponentesParaBlazor.Pages.Components.Charts.Annotations;
using ComponentesParaBlazor.Pages.Components.Charts.Chart;
using ComponentesParaBlazor.Pages.Components.Charts.DataLabels;
using ComponentesParaBlazor.Pages.Components.Charts.Fill;
using ComponentesParaBlazor.Pages.Components.Charts.ForecastDataPoints;
using ComponentesParaBlazor.Pages.Components.Charts.Grid;
using ComponentesParaBlazor.Pages.Components.Charts.Legend;
using ComponentesParaBlazor.Pages.Components.Charts.NoData;
using ComponentesParaBlazor.Pages.Components.Charts.PlotOptions;
using ComponentesParaBlazor.Pages.Components.Charts.Responsive;
using ComponentesParaBlazor.Pages.Components.Charts.Series;
using ComponentesParaBlazor.Pages.Components.Charts.States;
using ComponentesParaBlazor.Pages.Components.Charts.Stroke;
using ComponentesParaBlazor.Pages.Components.Charts.Subtitle;
using ComponentesParaBlazor.Pages.Components.Charts.Theme;
using ComponentesParaBlazor.Pages.Components.Charts.Title;
using ComponentesParaBlazor.Pages.Components.Charts.Tooltip;
using ComponentesParaBlazor.Pages.Components.Charts.XAxis;
using ComponentesParaBlazor.Pages.Components.Charts.YAxis;

namespace ComponentesParaBlazor.Pages.Components.Charts;

public class ChartOptionsModel<TSeries, TXAxis>
{
    [JsonPropertyName("annotations")] public AnnotationsModel Annotations { get; set; } = new();
    [JsonPropertyName("chart")] public ChartModel Chart { get; set; } = new();
    //
    [JsonPropertyName("colors")]
    public List<string> Colors { get; set; } = new() {"var(--mud-palette-primary)", "var(--mud-palette-secondary)"};
    
    [JsonPropertyName("dataLabels")] public DataLabelsModel DataLabels { get; set; } = new();
    [JsonPropertyName("fill")] public FillModel Fill { get; set; } = new();
    
    [JsonPropertyName("forecastDataPoints")]
    public ForecastDataPointsModel ForecastDataPoints { get; set; } = new();

    // [JsonPropertyName("grid")] public GridModel Grid { get; set; } = new(); // TODO: Yaxis issue...
    [JsonPropertyName("labels")] public List<string> Labels { get; set; } = new();
    [JsonPropertyName("legend")] public LegendModel Legend { get; set; } = new();
    [JsonPropertyName("markers")] public LegendModel.MarkersModel Markers { get; set; } = new();
    [JsonPropertyName("noData")] public NoDataModel NoData { get; set; } = new();
    [JsonPropertyName("plotOptions")] public PlotOptionsModel PlotOptions { get; set; } = new();
    [JsonPropertyName("responsive")] public List<ResponsiveModel> Responsive { get; set; } = new();
    [JsonPropertyName("series")] public List<TSeries> Series { get; set; } = new();
    [JsonPropertyName("states")] public StatesModel States { get; set; } = new();
    [JsonPropertyName("stroke")] public StrokeModel Stroke { get; set; } = new();
    [JsonPropertyName("subtitle")] public SubtitleModel Subtitle { get; set; } = new();
    [JsonPropertyName("theme")] public ThemeModel Theme { get; set; } = new();
    [JsonPropertyName("title")] public TitleModel Title { get; set; } = new();
    [JsonPropertyName("tooltip")] public TooltipModel Tooltip { get; set; } = new();
    [JsonPropertyName("xaxis")] public XAxisModel<TXAxis> XAxis { get; set; } = new();
    [JsonPropertyName("yaxis")] public YAxisModel YAxis { get; set; } = new();
}