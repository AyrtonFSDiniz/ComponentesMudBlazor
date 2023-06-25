using System.Text.Json.Serialization;
using ComponentesParaBlazor.Shared.Models.Charts.Annotations;
using ComponentesParaBlazor.Shared.Models.Charts.Chart;
using ComponentesParaBlazor.Shared.Models.Charts.DataLabels;
using ComponentesParaBlazor.Shared.Models.Charts.Fill;
using ComponentesParaBlazor.Shared.Models.Charts.ForecastDataPoints;
using ComponentesParaBlazor.Shared.Models.Charts.Grid;
using ComponentesParaBlazor.Shared.Models.Charts.Legend;
using ComponentesParaBlazor.Shared.Models.Charts.NoData;
using ComponentesParaBlazor.Shared.Models.Charts.PlotOptions;
using ComponentesParaBlazor.Shared.Models.Charts.Responsive;
using ComponentesParaBlazor.Shared.Models.Charts.Series;
using ComponentesParaBlazor.Shared.Models.Charts.States;
using ComponentesParaBlazor.Shared.Models.Charts.Stroke;
using ComponentesParaBlazor.Shared.Models.Charts.Subtitle;
using ComponentesParaBlazor.Shared.Models.Charts.Theme;
using ComponentesParaBlazor.Shared.Models.Charts.Title;
using ComponentesParaBlazor.Shared.Models.Charts.Tooltip;
using ComponentesParaBlazor.Shared.Models.Charts.XAxis;
using ComponentesParaBlazor.Shared.Models.Charts.YAxis;

namespace ComponentesParaBlazor.Shared.Models.Charts;

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