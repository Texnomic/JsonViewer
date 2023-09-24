namespace Texnomic.Blazor.JsonViewer;

public partial class JsonViewer : ComponentBase, IAsyncDisposable
{
    [Inject]
    public IJSRuntime JsRuntime { get; set; }

    private IJSObjectReference LibraryReference;

    private IJSObjectReference InstanceReference;

    public string Id { get; } = $"TJV{Random.Shared.Next()}";

    protected override async Task OnAfterRenderAsync(bool FirstRender)
    {
        if (FirstRender)
        {
            LibraryReference = await JsRuntime.InvokeAsync<IJSObjectReference>("import", "https://unpkg.com/@alenaksu/json-viewer@2.0.0/dist/json-viewer.bundle.js");

            InstanceReference = await JsRuntime.InvokeAsync<IJSObjectReference>("document.querySelector", $"'#{Id}'");
        }
    }

    public ValueTask Render(string Json)
        => JsRuntime.InvokeVoidAsync("eval", $"document.querySelector('#{Id}').data = {Json};");

    public ValueTask Collapse(string Filter)
        => InstanceReference.InvokeVoidAsync("collapse", Filter);

    public ValueTask CollapseAll()
        => Collapse("**");

    public ValueTask Expand(string Filter)
        => InstanceReference.InvokeVoidAsync("expand", Filter);

    public ValueTask ExpandAll()
        => Expand("**");

    public ValueTask Filter(string Filter)
        => InstanceReference.InvokeVoidAsync("filter", Filter);

    public async ValueTask DisposeAsync()
    {
        if (InstanceReference != null)
            await InstanceReference.DisposeAsync();

        if (InstanceReference != null)
            await LibraryReference.DisposeAsync();
    }
}
