using LanguageExt;
using Microsoft.AspNetCore.Components;

namespace UnionComponents.Shared
{
    public partial class StringOption
    {
        [Parameter]
        public Option<string> ContentValue { get; set; }

        [Parameter]
        public RenderFragment Some { get; set; }

        [Parameter]
        public RenderFragment None { get; set; }
    }
}
