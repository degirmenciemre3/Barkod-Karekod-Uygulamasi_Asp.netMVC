// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KarekodBarkodUygulaması.Pages.Admin
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using KarekodBarkodUygulaması.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/OrderList")]
    public partial class OrderList : OwningComponentBase<IOrderRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\OrderList.razor"
  
    public IOrderRepository Repository => Service;

    public IEnumerable<Order> OrderData { get; set; }
    public IEnumerable<Order> OrderIadeData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        OrderData = await Repository.Orders.Where(p => p.IadeMi == false).ToListAsync();
        OrderIadeData = await Repository.Orders.Where(p => p.IadeMi == true).ToListAsync();
    }



    public string GetDetailsUrl(int id) => $"/admin/order/details/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
