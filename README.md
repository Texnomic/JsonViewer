![Blazor](https://raw.githubusercontent.com/Texnomic/JsonViewer/master/Logo.png)
## Texnomic.Blazor.JsonViewer

![NuGet](https://img.shields.io/nuget/vpre/Texnomic.Blazor.JsonViewer?logo=NuGet&label=NuGet%20%7C%20Texnomic.Blazor.JsonViewer&logoColor=blue&color=blue)

ASP.NET Core JsonViewer Component for Server-Side Blazor Based-on [Alenaksu's Json-Viewer](https://github.com/alenaksu/json-viewer).

## Installation

```pwsh
PM> Install-Package Texnomic.Blazor.JsonViewer
```

## Setup


1. Reference hCaptcha & NuGet Package JavaScript Files In `Pages/_Host.cshtml` File:

    ```html
    <head>
       <script src="https://code.jquery.com/jquery-3.6.0.min.js" type="text/javascript"></script>
       <script src="_content/Texnomic.Blazor.JsonViewer/scripts/JsonViewer.js" type="text/javascript"></script>
    </head>
    ```

2. Drop-In JsonViewer Component & Bind Element Reference In `Example.razor` File:

    ```html
    @using Texnomic.Blazor.JsonViewer

    <JsonViewer @ref="JsonViewerInstance"></JsonViewer>
    ```

3. Create Backing Element Reference In `Example.razor.cs` File:

    ```csharp
    using Texnomic.Blazor.JsonViewer;

    protected JsonViewer JsonViewerInstance { get; set; }

    protected async ValueTask Example(string Json)
    {
        await JsonViewerInstance.Render(Json);
    }
    ```




## Donations

* [![PayPal](https://img.shields.io/static/v1?logo=PayPal&label=PayPal&message=https://www.paypal.me/texnomic&color=blue)](https://www.paypal.me/texnomic)
