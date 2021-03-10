// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DataGridComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using DataGridComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using DataGridComponent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using DataGridComponent.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\_Imports.razor"
using DataGridComponent.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\DataGridComponent\DataGridComponent\Pages\Index.razor"
      

    private DataGridComponent<Employee> grid;
    private List<Employee> listEmployees;
    private List<ColumnDefinition> columnsDefinition;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Initialize();
    }

    private void Initialize()
    {
        if (columnsDefinition == null)
        {
            columnsDefinition = new List<ColumnDefinition>();
            columnsDefinition.AddRange(
                new ColumnDefinition[] {
                new ColumnDefinition { DataField = "Name", Caption = "Name" },
                new ColumnDefinition { DataField = "Title", Caption = "Title" },
                new ColumnDefinition { DataField = "Department", Caption = "Department" },
                new ColumnDefinition { DataField = "EmploymentDate", Caption = "Employee Date", Format = "dd/MM/yyyy", DataType = DataType.DateTime },
                new ColumnDefinition { DataField = "Salary", Caption = "Annual Salary", DataType = DataType.Currency, Alignment = Alignment.Left, Format = "c" },
                }
                );
        }

        if (listEmployees == null)
        {
            listEmployees = new List<Employee>();
            listEmployees.AddRange(
            new Employee[]
            {
                    new Employee
                    {
                        Name = "Rahul",
                        Title = "Developer",
                        Department = "Software Dev",
                        EmploymentDate = DateTime.Now,
                        Salary = 100000,
                    },
                    new Employee
                    {
                        Name = "Rohit",
                        Title = "DBA",
                        Department = "IT",
                        EmploymentDate = DateTime.Now,
                        Salary = 100001,
                    },
                    new Employee
                    {
                        Name = "Deepak",
                        Title = "Developer",
                        Department = "Software Dev",
                        EmploymentDate = DateTime.Now,
                        Salary = 100002,
                    },
                    new Employee
                    {
                        Name = "Phani",
                        Title = "DBA",
                        Department = "IT",
                        EmploymentDate = DateTime.Now,
                        Salary = 100003,
                    },
                    new Employee
                    {
                        Name = "Vivek",
                        Title = "Developer",
                        Department = "Software Dev",
                        EmploymentDate = DateTime.Now,
                        Salary = 100004,
                    },
                    new Employee
                    {
                        Name = "Charan",
                        Title = "DBA",
                        Department = "IT",
                        EmploymentDate = DateTime.Now,
                        Salary = 100005,
                    },
                    new Employee
                    {
                        Name = "Manish",
                        Title = "Developer",
                        Department = "Software Dev",
                        EmploymentDate = DateTime.Now,
                        Salary = 100006,
                    },
                    new Employee
                    {
                        Name = "Rohan",
                        Title = "DBA",
                        Department = "IT",
                        EmploymentDate = DateTime.Now,
                        Salary = 100007,
                    }
            }

        );
        }

    }

    private void PrevPage()
    {
        grid.GoToPrevPage();
    }

    private void NextPage()
    {
        grid.GoToNextPage();
    }


    class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Salary { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
