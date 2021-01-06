using Microsoft.AspNetCore.Components;

namespace TailBlazor.Tabs
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
        RenderFragment TitleContent { get; }
        RenderFragment TabContent { get; }
    }
}