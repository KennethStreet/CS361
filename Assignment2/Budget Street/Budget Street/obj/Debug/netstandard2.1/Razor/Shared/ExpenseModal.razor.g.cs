#pragma checksum "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05425e03192e84dbd5f9e42c79fb9d45b8fe7995"
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
    public partial class ExpenseModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenText>(0);
            __builder.AddAttribute(1, "TextStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TextStyle>(
#nullable restore
#line 1 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                       TextStyle.Subtitle2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "TagName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TagName>(
#nullable restore
#line 1 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
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
#line 2 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Class", "w-100");
            __builder.AddAttribute(9, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 3 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                       PersonsCategories.Select(c => c.CategoryName).Distinct()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 4 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                         args => OnChange(args, "DropDown")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "mt-3");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenText>(15);
            __builder.AddAttribute(16, "TextStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TextStyle>(
#nullable restore
#line 7 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                           TextStyle.Subtitle2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "TagName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TagName>(
#nullable restore
#line 7 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                                                         TagName.H3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "Transaction");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(21);
            __builder.AddAttribute(22, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 8 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                            args => OnChange(args, "TextBox")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "Class", "w-100");
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "mt-3");
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenText>(29);
            __builder.AddAttribute(30, "TextStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TextStyle>(
#nullable restore
#line 12 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                           TextStyle.Subtitle2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "TagName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.TagName>(
#nullable restore
#line 12 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                                                         TagName.H3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Amount");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenNumeric<double>>(35);
            __builder.AddAttribute(36, "Format", "c");
            __builder.AddAttribute(37, "Placeholder", "Enter or clear value");
            __builder.AddAttribute(38, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, 
#nullable restore
#line 13 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                                                                                                                 args => OnChange(args, "Formatted numeric")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#nullable restore
#line 13 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
                                                           dblValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dblValue = __value, dblValue))));
            __builder.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<double>>>(() => dblValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n\r\n<br><br><br>\r\n");
            __builder.AddMarkupContent(44, "<button class=\"btn btn-outline-primary\">Cancel</button>\r\n");
            __builder.AddMarkupContent(45, "<button class=\"btn btn-primary\">Save</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Shared\ExpenseModal.razor"
       
    [Parameter]
    public Categories PersonsCategories { get; set; }

    private double dblValue = 0.0;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Console.WriteLine($"Category Count: {PersonsCategories.Count}");
    }

    public void OnChange(object args, string tag)
    {
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591