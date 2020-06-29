require('@alenaksu/json-viewer');

window.Texnomic =
{
    Blazor:
    {
        JsonViewer: function(ID, Data) {
            $(ID)[0].data = JSON.parse(Data);
        }
    }
}