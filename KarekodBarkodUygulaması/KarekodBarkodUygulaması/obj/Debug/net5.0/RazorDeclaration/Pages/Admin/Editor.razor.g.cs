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
#nullable restore
#line 4 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\Editor.razor"
using KarekodBarkodUygulaması.Pages.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/edit/{id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/create")]
    public partial class Editor : OwningComponentBase<IProductsRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\User\Desktop\github\Barkod-Karekod-Uygulamasi_Asp.netMVC\KarekodBarkodUygulaması\KarekodBarkodUygulaması\Pages\Admin\Editor.razor"
        public IProductsRepository Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public int Id { get; set; } = 0;

    public Product product { get; set; } = new Product();

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            product = Repository.Products.FirstOrDefault(p => p.productID == Id);
        }
    }

    public void SaveProduct()
    {
        if (file != null)
        {
            product.productImgUrl = "/img/productImg/" + file.Name;
        }
        if (Id == 0)
        {

            Repository.CreateProducts(product);
        }
        else
        {
            Repository.SaveProducts(product);
        }
        NavManager.NavigateTo("/admin/products");
    }

    IFileListEntry file;
    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            await fileUpload.UploadAsync(file);
        }
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit"; 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591
