#pragma checksum "D:\repo\schooly\iSchool\iSchool\iSchool\Views\Class\GetClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a2454239aff2eca22d09bbe78330684920bbad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_GetClass), @"mvc.1.0.view", @"/Views/Class/GetClass.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2454239aff2eca22d09bbe78330684920bbad3", @"/Views/Class/GetClass.cshtml")]
    public class Views_Class_GetClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\repo\schooly\iSchool\iSchool\iSchool\Views\Class\GetClass.cshtml"
  
    ViewData["Title"] = "GetClass";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<form>
<div class=""row clearfix"" style=""align:center;"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">
            <div class=""header"">
                <h2>
                    Add New Class
                </h2>
            </div>
            <div class=""body"">
                <div class=""row "">
                    <div class=""col-md-4""></div>
                    <div class=""col-md-4"">
                        <div class=""form-group"">
                            <div class=""form-line"">
                                <label for=""classname"">Class Name</label>
                                <input type=""text"" id=""classname"" class=""form-control"">
                            </div>
                        </div>
                    </div>

                </div>
                <div class=""row "">
                    <div class=""col-md-4""></div>
                    <div class=""col-md-4"">
                        <div class=""form-group"">
              ");
            WriteLiteral(@"              <div class=""form-line"">
                                <label for=""fees"">Class fees</label>
                                <input type=""text"" id=""fees"" class=""form-control"">
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <button type=""button"" id=""btnsubmit"" class=""btn btn-primary waves-effect"">Submit</button>
                    <button type=""reset"" id=""btnreset"" class=""btn btn-warning waves-effect"">Reset</button>
                </div>


            </div>
        </div>
    </div>
</div>
</form>
<!-- #END# Multi Column -->
<script>
    $(document).ready(function () {

        $('#btnsubmit').click(function(){
             
            let ClassDTO={
                CName:$('#classname').val(),
                CFees:$('#fees').val(),
            }
             $.ajax({
                    type: 'Post',
                    url: '/Class/PostCla");
            WriteLiteral(@"ss',
                    data: ClassDTO,
                    success: function (resp) {
                        if (resp == true) {
                            showNotification(""success"", ""CLass Registered!"");
                            $(""#btnreset"").click()
                        }
                        else {
                            showNotification(""danger"", ""Registration Failed!"");
                        }
                    },
                });
        })



            //fees entr
        $(""#fees"").keypress(function (e) {
            if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                showNotification(""danger"", ""Input Only Numbers"");
                return false;
            }
            
        })



    })
</script>
");
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
