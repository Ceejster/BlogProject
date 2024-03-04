using System.ComponentModel;

namespace BlogProject.Enums
{
    public enum ModerationType
    {
        [Description("Political propoganda")]
        Political,
        [Description("Offensive or innaproriate language")]
        Language,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Sexual Content")]
        Sexual,
        [Description("Threatening language")]
        Threatening
    }
}
