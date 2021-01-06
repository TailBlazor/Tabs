# TailBlazor.Tabs

Blazor tabs using Tailwindcss v2.0+

A base component capable of full customization, including the addition of icons or full control over the tab title and layout. Without passing it anything you'll get very basic styles, however giving it it's base classes and you can do whatever Tailwind is capable of.

![Nuget](https://img.shields.io/nuget/v/TailBlazor.Tabs.svg)

![Demo](screenshot.png)

## Getting Setup

You can install the package via the NuGet package manager just search for TailBlazor.Tabs. You can also install via powershell using the following command.

`Install-Package TailBlazor.Tabs`

Or via the dotnet CLI.

`dotnet add package TailBlazor.Tabs`

### 1. Add Imports

Add line to your \_Imports.razor

```
@using TailBlazor.Tabs
```

### 2. Create Tabs Component

Inside your page create your tabs component with the basic format below. For tabs styles, use the `class` parameter. Anything inside the `TailBlazorTab` automatically maps to the ChildContext and is displayed at the content for the tab. Using the parameter `title` inside the tab let's you name the tab.

```
<TailBlazorTabs class="py-10">
    <TailBlazorTab title="Tab 1 Title">
        ...
    </TailBlazorTab>
    <TailBlazorTab title="Tab 2 Title">
        ...
    </TailBlazorTab>
</TailBlazorTabs>
```

### 3. Using TitleContext and TabContent instead of ChildContent

Using ChildContext is great for about 95% of Tab use cases. However sometimes you want full control over the html inside the button. This is where `TitleContent` comes in.

Instead of using the title parameter, use the `TitleContent` RenderFragment to allow things like stylized text, or icons.

```
...
<TailBlazorTab>
    <TitleContent>
        <TailBlazorHeroIcon Icon=HeroIcon.Beaker Stroke="text-indigo-500" />
        <span>Weather in C</span>
    </TitleContent>
    <TabContent>
        ...
    </TabContent>
</TailBlazorTab>
...
```

Keep in mind if you use the `TitleContent`, you must then also use the `TabContent` in place of the default ChildContent render fragment.

### 4. Additional Styles

On top of being able to use `TitleContent`, you can also specify `ActiveClass` and default `class` to show which tab is active and not. When the tab is active, the `class` parameter is completely replaced by the `ActiveClass` you giving you more control over just adding styles.

```
<TailBlazorTabs class="my-10 border-b border-grey-600 flex space-x-8">
    <TailBlazorTab 
        ActiveClass="border-indigo-500 text-indigo-600 group inline-flex items-center py-4 px-1 border-b-2 font-medium text-sm" 
        Class="border-transparent text-gray-500 hover:text-gray-700 hover:border-gray-300 group inline-flex items-center py-4 px-1 border-b-2 font-medium text-sm">
    ...
...
```
