#pragma checksum "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23594d88c1917d47d6bfe831ac726be63adfd174"
// <auto-generated/>
#pragma warning disable 1591
namespace Budget_Street.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    table {\r\n        font-family: arial, sans-serif;\r\n        border-collapse: collapse;\r\n        width: 100%;\r\n    }\r\n\r\n    td, th {\r\n        border: 1px solid #dddddd;\r\n        text-align: left;\r\n        padding: 8px;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenPanel>(1);
            __builder.AddAttribute(2, "AllowCollapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Collapsed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        New Features\r\n    ");
            }
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<div class=\"mt-3\">\r\n            Connecting your bank account allows transactions to be imported for auto tracking.\r\n        </div>\r\n        ");
                __builder2.AddMarkupContent(9, "<div>\r\n            Top screen new transaction button added for tracking expenses more quickly.\r\n        </div>\r\n        ");
                __builder2.AddMarkupContent(10, "<div>\r\n            Both new feature are free to all users.\r\n        </div>\r\n        ");
                __builder2.AddMarkupContent(11, "<div class=\"mt-3\"><a href=\"#\">Walk Through Video</a></div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "mt-3 mb-2");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<Budget>>(16);
            __builder.AddAttribute(17, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 39 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                          PersonsBudgets.Select(b => b.DisplayBudget)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 41 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                            PersonsBudgets.FirstOrDefault().DisplayBudget

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(20, "<a class=\"float-right\" href=\"#\">Connect My Bank</a>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "mt-5 mb-3");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.AddMarkupContent(25, "<div>Monthly Budget: </div>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenNumeric<double>>(26);
            __builder.AddAttribute(27, "Format", "c");
            __builder.AddAttribute(28, "Placeholder", "Enter or clear value");
            __builder.AddAttribute(29, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, 
#nullable restore
#line 51 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                                                                                      args => OnChange(args, "Formatted numeric")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#nullable restore
#line 51 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                           CurrencyValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrencyValue = __value, CurrencyValue))));
            __builder.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<double>>>(() => CurrencyValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n");
            __builder.AddMarkupContent(35, "<div style=\"float: left;\">\r\n    <h4 class=\"mt-3 float-left\">Housing</h4>\r\n</div>\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "mt-3");
            __builder.AddAttribute(38, "style", "float: right;");
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "i");
            __builder.AddAttribute(41, "class", "fa-solid fa-circle-plus fa-2xl");
            __builder.AddAttribute(42, "title", "Add New Budget Item");
            __builder.AddAttribute(43, "style", "color:green;");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                                                                         AddExpense

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n");
            __builder.OpenElement(47, "table");
            __builder.AddAttribute(48, "class", "mb-3");
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.AddMarkupContent(50, "<tr>\r\n        <th>Transaction</th>\r\n        <th>Cost</th>\r\n        <th>Actions</th>\r\n    </tr>\r\n    ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.AddMarkupContent(53, "<td>Rent</td>\r\n        ");
            __builder.AddMarkupContent(54, "<td>$1000</td>\r\n        ");
            __builder.OpenElement(55, "td");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(57);
            __builder.AddAttribute(58, "Text", "Edit");
            __builder.AddAttribute(59, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                              args => AddExpense()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(61);
            __builder.AddAttribute(62, "Text", "Delete");
            __builder.AddAttribute(63, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                args => DialogService.Confirm("Delete Transaction?", "Delete", new ConfirmOptions() { OkButtonText = "Delete", CancelButtonText = "Cancel" })

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n    ");
            __builder.OpenElement(67, "tr");
            __builder.AddAttribute(68, "hidden", 
#nullable restore
#line 76 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                 IsHousing

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.AddMarkupContent(70, "<td>Electricity</td>\r\n        ");
            __builder.AddMarkupContent(71, "<td>$100</td>\r\n        ");
            __builder.OpenElement(72, "td");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(74);
            __builder.AddAttribute(75, "Text", "Edit");
            __builder.AddAttribute(76, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                              args => EditExpense()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(78);
            __builder.AddAttribute(79, "Text", "Delete");
            __builder.AddAttribute(80, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                args => DialogService.Confirm("Delete Transaction?", "Delete", new ConfirmOptions() { OkButtonText = "Delete", CancelButtonText = "Cancel" })

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n    ");
            __builder.OpenElement(84, "tr");
            __builder.AddAttribute(85, "hidden", 
#nullable restore
#line 85 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                  !IsHousing

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.AddMarkupContent(87, "<td>Electricity</td>\r\n        ");
            __builder.AddMarkupContent(88, "<td>$80</td>\r\n        ");
            __builder.OpenElement(89, "td");
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(91);
            __builder.AddAttribute(92, "Text", "Edit");
            __builder.AddAttribute(93, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                              args => EditExpense()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(95);
            __builder.AddAttribute(96, "Text", "Delete");
            __builder.AddAttribute(97, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                args => DialogService.Confirm("Delete Transaction?", "Delete", new ConfirmOptions() { OkButtonText = "Delete", CancelButtonText = "Cancel" })

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(102, "<div style=\"float: left;\">\r\n    <h4 class=\"mt-3 float-left\">Debt</h4>\r\n</div>\r\n");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "mt-3");
            __builder.AddAttribute(105, "style", "float: right;");
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.OpenElement(107, "i");
            __builder.AddAttribute(108, "class", "fa-solid fa-circle-plus fa-2xl");
            __builder.AddAttribute(109, "title", "Add New Budget Item");
            __builder.AddAttribute(110, "style", "color:green;");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                                                                         AddExpense

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\r\n");
            __builder.OpenElement(114, "table");
            __builder.AddMarkupContent(115, "\r\n    ");
            __builder.AddMarkupContent(116, "<tr>\r\n        <th>Transaction</th>\r\n        <th>Cost</th>\r\n        <th>Actions</th>\r\n    </tr>\r\n    ");
            __builder.OpenElement(117, "tr");
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.AddMarkupContent(119, "<td>Credit Card</td>\r\n        ");
            __builder.AddMarkupContent(120, "<td>$200</td>\r\n        ");
            __builder.OpenElement(121, "td");
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(123);
            __builder.AddAttribute(124, "Text", "Edit");
            __builder.AddAttribute(125, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                              args => EditExpense()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(127);
            __builder.AddAttribute(128, "Text", "Delete");
            __builder.AddAttribute(129, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                args => DialogService.Confirm("Delete Transaction?", "Delete", new ConfirmOptions() { OkButtonText = "Delete", CancelButtonText = "Cancel" })

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(130, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n    ");
            __builder.OpenElement(133, "tr");
            __builder.AddAttribute(134, "hidden", 
#nullable restore
#line 118 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                 IsDebt

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(135, "\r\n        ");
            __builder.AddMarkupContent(136, "<td>Car Payment</td>\r\n        ");
            __builder.AddMarkupContent(137, "<td>$100</td>\r\n        ");
            __builder.OpenElement(138, "td");
            __builder.AddMarkupContent(139, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(140);
            __builder.AddAttribute(141, "Text", "Edit");
            __builder.AddAttribute(142, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                              args => EditExpense()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(144);
            __builder.AddAttribute(145, "Text", "Delete");
            __builder.AddAttribute(146, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
                                                args => DeleteTransaction()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(147, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Users\Kenne\git\Oregon_State\CS361\Assignment2\Budget Street\Budget Street\Pages\Index.razor"
      

    private Budgets PersonsBudgets { get; set; } = new Budgets();
    private Categories PersonsCategories { get; set; } = new Categories();

    private double CurrencyValue { get; set; } = 2000.00;

    private bool IsHousing { get; set; }
    private bool IsDebt { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        InitializeBudget();
        InitializeCategories();

        DialogService.OnOpen += Open;
        DialogService.OnClose += Close;
    }

    private void InitializeBudget()
    {
        var budget1 = new Budget()
        {
            BudgetId = 1,
            Year = 2023,
            Month = 1,
            BudgetedIncome = 5000,
            Categories = new List<Category>()
        };

        var budget2 = new Budget()
        {
            BudgetId = 2,
            Year = 2023,
            Month = 2,
            BudgetedIncome = 5000,
            Categories = new List<Category>()
        };

        var budget3 = new Budget()
        {
            BudgetId = 3,
            Year = 2023,
            Month = 3,
            BudgetedIncome = 5000,
            Categories = new List<Category>()
        };

        PersonsBudgets.Add(budget1);
        PersonsBudgets.Add(budget2);
        PersonsBudgets.Add(budget3);
    }

    private void InitializeCategories()
    {
        var category1 = new Category()
        {
            CategoryId = 1,
            CategoryName = "Housing",
            CategoryItems = new List<CategoryItem>()
        };

        var category2 = new Category()
        {
            CategoryId = 2,
            CategoryName = "Transportation",
            CategoryItems = new List<CategoryItem>()
        };

        var category3 = new Category()
        {
            CategoryId = 3,
            CategoryName = "Debt",
            CategoryItems = new List<CategoryItem>()
        };

        PersonsCategories.Add(category1);
        PersonsCategories.Add(category2);
        PersonsCategories.Add(category3);
    }

    public async Task DeleteTransaction()
    {
        await DialogService.Confirm("Delete Transaction?", "Delete", new ConfirmOptions() { OkButtonText = "Delete", CancelButtonText = "Cancel" });
        IsDebt = !IsDebt;
    }

    public async Task AddExpense()
    {
        await DialogService.OpenAsync<ExpenseModal>("Add Expense",
            new Dictionary<string, object>() { { "PersonsCategories", PersonsCategories } },
            new DialogOptions() { Width = "700px", Height = "512px", Resizable = true, Draggable = true });
    }

    public async Task EditExpense()
    {
        await DialogService.OpenAsync<EditModal>("Edit Expense",
            new Dictionary<string, object>() { { "PersonsCategories", PersonsCategories }, { "DropdownValue", "Housing" }, { "TransactionValue", "Electricity"}, { "CurrencyValue", 100.00} },
            new DialogOptions() { Width = "700px", Height = "512px", Resizable = true, Draggable = true });
        IsHousing = !IsHousing;
    }

    public void OnChange(object args, string tag)
    {
    }

    private class CategoryItemTransactions
    {
        public int TransactionId { get; set; }
        public int CategoryItemId { get; set; }
    }

    void Open(string title, Type type, Dictionary<string, object> parameters, DialogOptions options)
    {
        Console.WriteLine("Dialog open");
    }

    void Close(dynamic result)
    {
        Console.WriteLine("Dialog closed");
    }

    public void Dispose()
    {
        // The DialogService is a singleton so it is advisable to unsubscribe.
        DialogService.OnOpen -= Open;
        DialogService.OnClose -= Close;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
