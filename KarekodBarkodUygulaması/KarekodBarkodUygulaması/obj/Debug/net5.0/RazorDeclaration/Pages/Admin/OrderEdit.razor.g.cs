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
#nullable restore
#line 13 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/order/edit/{id:int}")]
    public partial class OrderEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\OrderEdit.razor"
       
    [Parameter]
    public int Id { set; get; }


    [Inject]
    public IOrderRepository Repository { get; set; }

    public Order Order { get; set; }

    bool busy;
    async Task OnBusyClick()
    {
        busy = true;
        await Task.Delay(1000);
        busy = false;
        NavManager.NavigateTo($"/admin/order/details/{Id}");
    }

    public void OnClick()
    {
        NavManager.NavigateTo($"/admin/order/details/{Id}");
    }

    void OnChangeText(string value)
    {
        Order.KargoNumarasi = value;
        Repository.SaveOrder(Order);
    }

    void OnChangeKargo(bool value)
    {
        Order.KargolandiMi = value;
        Repository.SaveOrder(Order);
    }
    void OnChangeTeslim(bool value)
    {
        Order.TeslimEdildiMi = value;
        Repository.SaveOrder(Order);
    }

    protected override void OnParametersSet()
    {
        Order = Repository.Orders.FirstOrDefault(p => p.OrderID == Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
