#pragma checksum "/Users/Sam/CLI/BlazorMobile/BlazorMobile/HelloWorld.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70e7d2038c3aedc8e32c32369fbcf943a03e3fac"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMobile
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/_Imports.razor"
using Microsoft.MobileBlazorBindings;

#line default
#line hidden
#line 2 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/_Imports.razor"
using Microsoft.MobileBlazorBindings.Elements;

#line default
#line hidden
#line 3 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/_Imports.razor"
using Xamarin.Essentials;

#line default
#line hidden
#line 4 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/_Imports.razor"
using Xamarin.Forms;

#line default
#line hidden
    public partial class HelloWorld : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.MobileBlazorBindings.Elements.ContentView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    \r\n    ");
                __builder2.OpenComponent<Microsoft.MobileBlazorBindings.Elements.StackLayout>(3);
                __builder2.AddAttribute(4, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Xamarin.Forms.Thickness?>(
#line 3 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/HelloWorld.razor"
                         new Thickness(30)

#line default
#line hidden
                ));
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n\r\n        ");
                    __builder3.OpenComponent<Microsoft.MobileBlazorBindings.Elements.Label>(7);
                    __builder3.AddAttribute(8, "Text", "Hello, World!");
                    __builder3.AddAttribute(9, "FontSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double?>(
#line 6 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/HelloWorld.razor"
                         30

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n\r\n        ");
                    __builder3.OpenComponent<Microsoft.MobileBlazorBindings.Elements.ScrollView>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "\r\n            ");
                        __builder4.OpenComponent<Microsoft.MobileBlazorBindings.Elements.StackLayout>(14);
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(16, "\r\n");
#line 10 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/HelloWorld.razor"
                 foreach (Post eachPost in PostsToBind)
                {

#line default
#line hidden
                            __builder5.AddContent(17, "                    ");
                            __builder5.OpenComponent<BlazorMobile.PostList>(18);
                            __builder5.AddAttribute(19, "PostToDisplay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMobile.Post>(
#line 12 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/HelloWorld.razor"
                                             eachPost

#line default
#line hidden
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(20, "\r\n");
#line 13 "/Users/Sam/CLI/BlazorMobile/BlazorMobile/HelloWorld.razor"
                }

#line default
#line hidden
                            __builder5.AddContent(21, "            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
