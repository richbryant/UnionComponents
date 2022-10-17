using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace UnionComponents.Shared
{
    public class Conditional : ComponentBase
    {
        [Parameter]
        public RenderFragment True { get; set; }

        [Parameter]
        public RenderFragment False { get; set; }

        [Parameter]
        public bool Condition { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (Condition)
            {
                builder.AddContent(1, true);
            }
            else
            {
                builder.AddContent(1, False);
            }
        }
    }
}