using System.Text.Json.Serialization;

namespace ComponentesParaBlazor.Shared.Models.Charts.Responsive;

public class ResponsiveModel
{
    [JsonPropertyName("breakpoint")] public int Breakpoint { get; set; }
    // TODO: Add options.
}