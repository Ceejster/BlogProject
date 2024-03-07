using System.ComponentModel.DataAnnotations;

namespace BlogProject.Enums
{
    public enum ReadyStatus
    {
        Incomplete,
        [Display(Name = "Production Ready")]
        ProductionReady,
        [Display(Name = "Preview Ready")]
        PreviewReady
    }
}
