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

Inside your page create your tabs component with the basic format below. For tabs styles, use the `NavClass` parameter. Anything inside the `TailBlazorTab` automatically maps to the ChildContext and is displayed at the content for the tab. Using the parameter `title` inside the tab let's you name the tab.

```
<TailBlazorTabs NavClass="py-10">
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
        <svg class="text-indigo-500 -ml-0.5 mr-2 h-5 w-5" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor">
        <path d="M2 11a1 1 0 011-1h2a1 1 0 011 1v5a1 1 0 01-1 1H3a1 1 0 01-1-1v-5zM8 7a1 1 0 011-1h2a1 1 0 011 1v9a1 1 0 01-1 1H9a1 1 0 01-1-1V7zM14 4a1 1 0 011-1h2a1 1 0 011 1v12a1 1 0 01-1 1h-2a1 1 0 01-1-1V4z" />
        </svg>
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

On top of being able to use `TitleContent` and `NavClass`, you can also specify `ActiveTabClass` and `DefaultTabClass` to show which tab is active.

```
<TailBlazorTabs NavClass="my-10 border-b border-grey-600 flex space-x-8" 
    ActiveTabClass="border-indigo-500 text-indigo-600 group inline-flex items-center py-4 px-1 border-b-2 font-medium text-sm" 
    DefaultTabClass="border-transparent text-gray-500 hover:text-gray-700 hover:border-gray-300 group inline-flex items-center py-4 px-1 border-b-2 font-medium text-sm">
...
```
