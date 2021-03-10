using System;
using Microsoft.AspNetCore.Components;

namespace TailBlazor.Tabs
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
        RenderFragment TitleContent { get; }
        RenderFragment TabContent { get; }
        int Id { get; }
        string Title { get; }
        string ActiveClass { get; set; }
        string Class { get; set; }
        void Activate();
    }
}