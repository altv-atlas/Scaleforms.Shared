namespace AltV.Atlas.Scaleforms.Shared.Models;

public record IndustrialButton
{
    public int IntParam { get; set; } = -1;
    public string? InstructionalButtonsString { get; set; }
    public string? DisplayText { get; set; }
}