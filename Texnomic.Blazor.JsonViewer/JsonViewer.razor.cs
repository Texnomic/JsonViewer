using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Texnomic.Blazor.JsonViewer;

public partial class JsonViewer : ComponentBase
{
    [Inject] protected IJSRuntime JsRuntime { get; set; }

    public string Id { get; private set; }

    public JsonViewer()
    {
        Id = Guid.NewGuid().ToString().Replace("-", "");
    }

    public ValueTask Render(string json)
    {
        return JsRuntime.InvokeVoidAsync("Texnomic.Blazor.JsonViewer.SetData", Id, json);
    }

    public ValueTask Collapse(string filter)
    {
        return JsRuntime.InvokeVoidAsync("Texnomic.Blazor.JsonViewer.Collapse", Id, filter);
    }

    public ValueTask CollapseAll()
    {
        return Collapse("**");
    }

    public ValueTask Expand(string filter)
    {
        return JsRuntime.InvokeVoidAsync("Texnomic.Blazor.JsonViewer.Expand", Id, filter);
    }

    public ValueTask ExpandAll()
    {
        return Expand("**");
    }

    public ValueTask Filter(string filter)
    {
        return JsRuntime.InvokeVoidAsync("Texnomic.Blazor.JsonViewer.Filter", Id, filter);
    }
}
