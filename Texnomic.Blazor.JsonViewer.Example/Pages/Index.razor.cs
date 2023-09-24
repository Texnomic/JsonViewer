namespace Texnomic.Blazor.JsonViewer.Example.Pages;

public partial class Index
{
    private JsonViewer Instance;

    protected override async Task OnAfterRenderAsync(bool FirstRender)
    {
        if (FirstRender)
        {
            await Instance.Render("{ \"quiz\": { \"sport\": { \"q1\": { \"question\": \"Which one is correct team name in NBA?\", \"options\": [ \"New York Bulls\",\r\n    \"Los Angeles Kings\", \"Golden State Warriros\", \"Huston Rocket\" ], \"answer\": \"Huston Rocket\" } }, \"maths\": { \"q1\": {\r\n    \"question\": \"5 + 7 = ?\", \"options\": [ \"10\", \"11\", \"12\", \"13\" ], \"answer\": \"12\" }, \"q2\": { \"question\": \"12 - 8 = ?\",\r\n    \"options\": [ \"1\", \"2\", \"3\", \"4\" ], \"answer\": \"4\" } } } }");

            await Instance.ExpandAll();
        }
    }
}