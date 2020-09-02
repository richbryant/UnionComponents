using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace UnionComponents.Shared
{
    public class Option<TValue> : ComponentBase
    {
        [Parameter]
        public TValue OptionValue { get; set; }
        public LanguageExt.Option<TValue> optionValue => (LanguageExt.Option<TValue>)OptionValue;

        [Parameter]
        public RenderFragment Some { get; set; }

        [Parameter]
        public RenderFragment None { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddContent(1, optionValue.Match(Some: x => Some, None: () => None));
        }
    }
}