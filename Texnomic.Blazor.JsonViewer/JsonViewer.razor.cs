using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Texnomic.Blazor.JsonViewer
{
    public class JsonViewerBase : ComponentBase
    {
        [Inject]
        protected IJSRuntime JsRuntime { get; set; }

        protected string ID { get; private set; }

        public JsonViewerBase()
        {
            ID = Guid.NewGuid().ToString().Replace("-", "");
        }

        public async ValueTask Render(string Json)
        {
            await JsRuntime.InvokeVoidAsync("Texnomic.Blazor.JsonViewer", $"#{ID}", Json);
        }
    }
}
