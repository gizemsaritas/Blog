#pragma checksum "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f00509cb0a0934965fad9a934b920d71015d8e82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BlogWeb.Models.Home.Views_Home_BlogDetail), @"mvc.1.0.view", @"/Views/Home/BlogDetail.cshtml")]
namespace BlogWeb.Models.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\_ViewImports.cshtml"
using BlogWeb.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f00509cb0a0934965fad9a934b920d71015d8e82", @"/Views/Home/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930e6c139e5da37409b51e055ad4ba801dd963af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::BlogWeb.TagHelpers.ImageTagHelper __BlogWeb_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
  
    var comments=(List<CommentListModel>)ViewBag.Comments;
    void GetComments(List<CommentListModel> comments){
        if(comments.Count>0){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
             foreach (var comment in comments){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"media my-3\">\r\n                     <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 356, "\"", 362, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"media-body\">\r\n                        <h5 class=\"mt-0\">");
#nullable restore
#line 10 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
                                    Write(comment.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            ");
#nullable restore
#line 11 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
                       Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <button type=\"button\" class=\"btn bt-sm btn-primary float-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 620, "\"", 668, 5);
            WriteAttributeValue("", 630, "showCommentForm(", 630, 16, true);
#nullable restore
#line 12 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 646, comment.Id, 646, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 657, ",", 657, 1, true);
#nullable restore
#line 12 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 658, Model.Id, 658, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 667, ")", 667, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Cevapla</button> \r\n                            <div");
            BeginWriteAttribute("id", " id=\"", 721, "\"", 749, 2);
            WriteAttributeValue("", 726, "commentBox", 726, 10, true);
#nullable restore
#line 13 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 736, comment.Id, 736, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 14 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
                              
                                GetComments(comment.SubComments);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
             
        }
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Title -->\r\n<h1 class=\"mt-4\"> ");
#nullable restore
#line 25 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n<hr>\r\n\r\n<!-- Date/Time -->\r\n<p>Posted on ");
#nullable restore
#line 29 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
        Write(Model.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<hr>\r\n\r\n<!-- Preview Image -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getblogimage", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f00509cb0a0934965fad9a934b920d71015d8e827691", async() => {
            }
            );
            __BlogWeb_TagHelpers_ImageTagHelper = CreateTagHelper<global::BlogWeb.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__BlogWeb_TagHelpers_ImageTagHelper);
#nullable restore
#line 34 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
__BlogWeb_TagHelpers_ImageTagHelper.Id = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __BlogWeb_TagHelpers_ImageTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
__BlogWeb_TagHelpers_ImageTagHelper.BlogImageType = BlogImageType.BlogDetail;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("blog-image-type", __BlogWeb_TagHelpers_ImageTagHelper.BlogImageType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<hr>\r\n\r\n<!-- Post Content -->\r\n");
#nullable restore
#line 40 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr>\r\n\r\n\r\n<!-- Comments Form -->\r\n<div class=\"card my-4\">\r\n    <h5 class=\"card-header\">Yorum Yaz:</h5>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f00509cb0a0934965fad9a934b920d71015d8e829898", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"BlogId\"");
                BeginWriteAttribute("value", " value=\"", 1595, "\"", 1612, 1);
#nullable restore
#line 50 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
WriteAttributeValue("", 1603, Model.Id, 1603, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
            <input type=""hidden"" name=""ParentCommentId"">
            <div class=""form-group"">
                <input type=""text"" class=""form-control"" name=""AuthorName"" required placeholder=""Adınız..."">
            </div>
            <div class=""form-group"">
                <input type=""email"" class=""form-control"" name=""AuthorEmail"" required placeholder=""Email..."">
            </div>
            <div class=""form-group"">
                <textarea class=""form-control"" name=""Description"" rows=""3"" required placeholder=""Yorumunuz...""></textarea>
            </div>
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 65 "C:\Users\developer04\Desktop\Projects\Blogs\BlogWeb\Views\Home\BlogDetail.cshtml"
  
    GetComments(comments);

#line default
#line hidden
#nullable disable
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script>
        function showCommentForm(id,blogId){
            let html=`<div class=""card my-4""><h5 class=""card-header"">Yorum Yaz:</h5><div class=""card-body""><form method=""POST""> <input type=""hidden"" name=""BlogId"" value=""${blogId}""> <input type=""hidden"" name=""ParentCommentId"" value=""${id}""><div class=""form-group""> <input type=""text"" class=""form-control"" name=""AuthorName"" required placeholder=""Adınız...""></div><div class=""form-group""> <input type=""email"" class=""form-control"" name=""AuthorEmail"" required placeholder=""Email...""></div><div class=""form-group""><textarea class=""form-control"" name=""Description"" rows=""3"" required placeholder=""Yorumunuz...""></textarea></div><button type=""button"" class=""btn btn-warning"" onClick=""hideCommentForm(${id})"">Vazgeç</button> <button type=""submit"" class=""btn btn-primary"">Gönder</button></form></div></div>`;
            $(""#commentBox""+id).html(html);

        }
        function hideCommentForm(id){
            $(""#commentBox""+id).html("""");
        }
        </s");
                WriteLiteral("cript>\r\n    \r\n");
            }
            );
            WriteLiteral("    \r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
