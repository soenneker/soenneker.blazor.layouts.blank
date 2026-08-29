[![](https://img.shields.io/nuget/v/soenneker.blazor.layouts.blank.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.layouts.blank/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.layouts.blank/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.layouts.blank/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.layouts.blank.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.layouts.blank/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.layouts.blank/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.layouts.blank/actions/workflows/codeql.yml)

# Soenneker.Blazor.Layouts.Blank

A minimal Blazor layout that renders the routed page inside `<div class="page"><main>…</main></div>` without navigation, headers, or other application chrome.

## Installation

```bash
dotnet add package Soenneker.Blazor.Layouts.Blank
```

No service registration is required.

## Use on a page

Add the namespace to `_Imports.razor`:

```razor
@using Soenneker.Blazor.Layouts.Blank
```

Then select it on any routable component:

```razor
@page "/sign-in"
@layout BlankLayout

<h1>Sign in</h1>
```

## Use as the router default

```razor
<Router AppAssembly="@typeof(App).Assembly">
    <Found Context="routeData">
        <RouteView RouteData="@routeData"
                   DefaultLayout="@typeof(BlankLayout)" />
        <FocusOnNavigate RouteData="@routeData" Selector="h1" />
    </Found>
</Router>
```

The package supplies markup only. It does not include CSS for the `page` class or the `main` element, so their spacing, sizing, and background remain under the application's control.
