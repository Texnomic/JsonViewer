require('@alenaksu/json-viewer');

function _getViewer(id) {
    let selector = '#' + CSS.escape(id);
    return document.querySelector(selector);
}

window.Texnomic =
{
    Blazor:
    {
        // https://github.com/alenaksu/json-viewer
        JsonViewer:
        {
            SetData: function (id, data) {
                _getViewer(id).data = JSON.parse(data);
            },
            Collapse: function (id, filter) {
                _getViewer(id).collapse(filter);
            },
            Expand: function (id, filter) {
                _getViewer(id).expand(filter);
            },
            Filter: function (id, filter) {
                _getViewer(id).filter(filter);
            },
            // Find: function(id, filter) {
            //     _getViewer(id).data = JSON.parse(data);
            // },
            // FindNext: function(id, filter) {
            //     _getViewer(id).data = JSON.parse(data);
            // },
        }
    }
}