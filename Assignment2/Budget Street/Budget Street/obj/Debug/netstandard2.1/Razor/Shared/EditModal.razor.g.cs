#pragma checksum "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c1b4b58565877efa02b3daf296e30f8d0bc3830"
// <auto-generated/>
#pragma warning disable 1591
namespace Budget_Street.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Budget_Street;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Budget_Street.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Budget_Street.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\_Imports.razor"
using Budget_Street.Helpers;

#line default
#line hidden
#nullable disable
    public partial class EditModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenText>(0);
            __builder.AddAttribute(1, "TextStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TextStyle>(
#nullable restore
#line 3 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                       TextStyle.Subtitle2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "TagName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TagName>(
#nullable restore
#line 3 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                                                     TagName.H3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Category");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(6);
            __builder.AddAttribute(7, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Class", "w-100");
            __builder.AddAttribute(9, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 5 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                       PersonsCategories.Select(c => c.CategoryName).Distinct()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 6 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                         args => OnChange(args, "DropDown")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                             DropdownValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DropdownValue = __value, DropdownValue))));
            __builder.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => DropdownValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "mt-3");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenText>(18);
            __builder.AddAttribute(19, "TextStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TextStyle>(
#nullable restore
#line 10 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                           TextStyle.Subtitle2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "TagName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TagName>(
#nullable restore
#line 10 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                                                         TagName.H3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(22, "Transaction");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
            __builder.AddAttribute(25, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 11 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                            args => OnChange(args, "TextBox")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "Class", "w-100");
            __builder.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                                                                                          TransactionValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TransactionValue = __value, TransactionValue))));
            __builder.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => TransactionValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "mt-3");
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenText>(35);
            __builder.AddAttribute(36, "TextStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TextStyle>(
#nullable restore
#line 15 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                           TextStyle.Subtitle2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "TagName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TagName>(
#nullable restore
#line 15 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                                                         TagName.H3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(39, "Amount");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenNumeric<double>>(41);
            __builder.AddAttribute(42, "Format", "c");
            __builder.AddAttribute(43, "Placeholder", "Enter or clear value");
            __builder.AddAttribute(44, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, 
#nullable restore
#line 16 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                                                                                                                      args => OnChange(args, "Formatted numeric")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#nullable restore
#line 16 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                                                           CurrencyValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrencyValue = __value, CurrencyValue))));
            __builder.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<double>>>(() => CurrencyValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(50, "<button class=\"btn btn-outline-primary\">Cancel</button>\r\n");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
                                            args => ShowNotification(new NotificationMessage() { Severity = NotificationSeverity.Success, Summary = "Success Summary", Detail = "Success Detail", Duration = 4000 })

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Save");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\EditModal.razor"
       
    [Parameter]
    public Categories PersonsCategories { get; set; }

    [Parameter]
    public string DropdownValue { get; set; }

    [Parameter]
    public string TransactionValue { get; set; }

    [Parameter]
    public double CurrencyValue { get; set; } = 0.0;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Console.WriteLine($"Category Count: {PersonsCategories.Count}");
    }

    public void OnChange(object args, string tag)
    {
    }

    public async Task ShowNotification(NotificationMessage message)
    {
        NotificationService.Notify(message);
        await InvokeAsync(() => { StateHasChanged(); });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591