using System.Text.Json.Serialization;

namespace ComponentesParaBlazor.Pages.Components.Charts.Responsive;

public class ResponsiveModel
{
    [JsonPropertyName("breakpoint")] public int Breakpoint { get; set; }
    // TODO: Add options.
}