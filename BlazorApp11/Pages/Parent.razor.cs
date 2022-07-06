using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorApp11.Shared;

namespace BlazorApp11.Pages
{
    public partial class Parent : ComponentBase
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }

        string message;
        ChatSendBox chatSendBox;
        void OnClick()
        {
            JsRuntime.InvokeAsync<object>("alert", new[] { message });
            message = "";
            chatSendBox.FocusAsync();
        }
    }
}
