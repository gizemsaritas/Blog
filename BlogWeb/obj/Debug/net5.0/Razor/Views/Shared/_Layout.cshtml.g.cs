#pragma checksum "C:\Users\developer04\Desktop\Projects\Blog\BlogWeb\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd067b7937b24ad1b6e89251240c13688c38bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Shared.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace MyApp.Namespace.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dd067b7937b24ad1b6e89251240c13688c38bab", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edae9f912dfadfa628b3508c3780c3e0ec55c856", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd067b7937b24ad1b6e89251240c13688c38bab2926", async() => {
                WriteLiteral("\r\n\r\n  <meta charset=\"utf-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n  <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 189, "\"", 199, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n  <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 224, "\"", 234, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n  <title>Blog Home - Start Bootstrap Template</title>\r\n\r\n  <!-- Bootstrap core CSS -->\r\n  <link href=\"/css/united.css\" rel=\"stylesheet\">\r\n\r\n  <!-- Custom styles for this template -->\r\n  <link href=\"/css/blog-home.css\" rel=\"stylesheet\">\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd067b7937b24ad1b6e89251240c13688c38bab4666", async() => {
                WriteLiteral(@"
  <!-- Navigation -->
  <nav class=""navbar navbar-expand-lg navbar-dark bg-dark fixed-top"">
    <div class=""container"">
      <a class=""navbar-brand"" href=""#"">Start Bootstrap</a>
      <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive""
        aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
      </button>
      <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
        <ul class=""navbar-nav ml-auto"">
          <li class=""nav-item active"">
            <a class=""nav-link"" href=""#"">Anasayfa
              <span class=""sr-only"">(current)</span>
            </a>
          </li>

        </ul>
      </div>
    </div>
  </nav>

  <!-- Page Content -->
  <div class=""container"">

    <div class=""row"">

      <!-- Blog Entries Column -->
      <div class=""col-md-8"">
        <!-- Blog Post -->
        <div class=""my-4"">");
#nullable restore
#line 51 "C:\Users\developer04\Desktop\Projects\Blog\BlogWeb\Views\Shared\_Layout.cshtml"
                     Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>

      </div>

      <!-- Sidebar Widgets Column -->
      <div class=""col-md-4"">

        <!-- Search Widget -->
        <div class=""card my-4"">
          <h5 class=""card-header"">Search</h5>
          <div class=""card-body"">
            <div class=""input-group"">
              <input type=""text"" class=""form-control"" placeholder=""Search for..."">
              <span class=""input-group-append"">
                <button class=""btn btn-secondary"" type=""button"">Go!</button>
              </span>
            </div>
          </div>
        </div>

        <!-- Categories Widget -->
        <div class=""card my-4"">
          <h5 class=""card-header"">Categories</h5>
            <div class=""list-group"">
              <a class=""list-group-item list-group-item-action d-flex justify-content-between align-items-center"">
                Cras justo odio
                <span class=""badge badge-primary badge-pill"">14</span>
              </a>
              <a class=""list-group-item list-group-i");
                WriteLiteral(@"tem-action d-flex justify-content-between align-items-center"">
                Dapibus ac facilisis in
                <span class=""badge badge-primary badge-pill"">2</span>
              </a>
              <a class=""list-group-item list-group-item-action d-flex justify-content-between align-items-center"">
                Morbi leo risus
                <span class=""badge badge-primary badge-pill"">1</span>
              </a>
            </div>
        </div>

        <!-- Side Widget -->
        <div class=""card my-4"">
          <h5 class=""card-header"">Side Widget</h5>
          <div class=""card-body"">
            You can put anything you want inside of these side widgets. They are easy to use, and feature the new
            Bootstrap 4 card containers!
          </div>
        </div>

      </div>

    </div>
    <!-- /.row -->

  </div>
  <!-- /.container -->

  <!-- Footer -->
  <footer class=""py-5 bg-dark"">
    <div class=""container"">
      <p class=""m-0 text-center text-whi");
                WriteLiteral(@"te"">Copyright &copy; Your Website 2020</p>
    </div>
    <!-- /.container -->
  </footer>

  <!-- Bootstrap core JavaScript -->
  <script src=""/lib/jquery/jquery.min.js""></script>
  <script src=""/lib/twitter-bootstrap/js/bootstrap.bundle.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
