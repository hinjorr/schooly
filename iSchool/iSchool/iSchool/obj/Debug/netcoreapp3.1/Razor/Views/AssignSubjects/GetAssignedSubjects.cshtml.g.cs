#pragma checksum "D:\repo\schooly\iSchool\iSchool\iSchool\Views\AssignSubjects\GetAssignedSubjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b71886fb484589f230f9f6a5997478d0f1441311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssignSubjects_GetAssignedSubjects), @"mvc.1.0.view", @"/Views/AssignSubjects/GetAssignedSubjects.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b71886fb484589f230f9f6a5997478d0f1441311", @"/Views/AssignSubjects/GetAssignedSubjects.cshtml")]
    public class Views_AssignSubjects_GetAssignedSubjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\repo\schooly\iSchool\iSchool\iSchool\Views\AssignSubjects\GetAssignedSubjects.cshtml"
  
    ViewData["Title"] = "GetAssignedSubjects";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .hide {\r\n        display: none;\r\n    }\r\n</style>\r\n<form");
            BeginWriteAttribute("action", " action=\"", 170, "\"", 179, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""row clearfix"">
        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
            <div class=""card"">
                <div class=""header"">
                    <h2>
                        Assign Subjects
                    </h2>
                </div>
                <div class=""body"">
                    <div class=""row "">
                        <div class=""col-md-4""></div>
                        <div class=""col-md-4"">
                            <label>Select Class</label>
                            <select class=""form-control show-tick"" id=""classesdropdown"">
                            </select>
                        </div>
                    </div>
                    <div id=""kuchBi"">
                        <div class=""row "">
                            <div class=""col-md-2""></div>
                            <div class=""col-md-4"">
                                <label>Select Subject</label>
                                <select class=""form-contro");
            WriteLiteral(@"l show-tick subjectsdropdown""></select>
                            </div>
                            <div class=""col-md-4"">
                                <div class=""form-group"">
                                    <div class=""form-line"">
                                        <label>Marks Weightage </label>
                                        <input type=""text"" class=""form-control marks"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <button type=""button"" id=""btnsubmit"" class=""btn btn-primary waves-effect"">Submit</button>
                        <button type=""reset"" id=""btnreset"" class=""btn btn-warning waves-effect"">Reset</button>
                        <button type=""button"" id=""btntexbox"" class=""btn btn-primary waves-effect"">New textbox</button>
                    </div>
                </d");
            WriteLiteral(@"iv>
            </div>
        </div>
    </div>
</form>
<!-- #END# Multi Column -->


<div class=""row template hide"">
    <div class=""col-md-2""></div>
    <div class=""col-md-4"">
        <label>Select Subject</label>
        <select class=""form-control show-tick subjectsdropdown""></select>
    </div>
    <div class=""col-md-4"">
        <div class=""form-group"">
            <div class=""form-line"">
                <label>Marks Weightage </label>
                <input type=""text"" class=""form-control marks"">
            </div>
        </div>
    </div>
</div>













<script>
    $(document).ready(function () {
        //cloning dropdown
        $(""#btntexbox"").click(function () {
            let clone = $("".template"").clone();
            clone.removeClass(""template"");
            clone.removeClass(""hide"");
            clone.appendTo($(""#kuchBi""));
        })


        //class
        $.ajax({
            async: false,
            url: '/General/ListClass',
");
            WriteLiteral(@"            success: function (resp) {
                let html = '';
                html += ""<option value='0'>Please Select class</option>"";
                $(resp).each(function (index, item) {
                    html += ""<option value="" + item.cId + "">"" + item.cName + ""</option>"";
                });
                $(""#classesdropdown"").append(html);
            },
        })

        //subject
        $.ajax({
            async: false,
            url: '/General/ListSubjects',
            success: function (resp) {
                let html = '';
                html += ""<option value='0'>Please Select subject</option>"";
                $(resp).each(function (index, item) {
                    html += ""<option value="" + item.subjectId + "">"" + item.subjectName + ""</option>"";
                });
                $("".subjectsdropdown"").append(html);
            },
        })

        //submit click 
        $(""#btnsubmit"").click(function () {
            
            let AssignSb");
            WriteLiteral(@"jectsDTO = {
                SubjectId: $("".subjectsdropdown option:selected"").val(),
                CId: $(""#classesdropdown option:selected"").val(),
                MarksWeightage: $("".marks"").val(),
            }
            
            $.ajax({
                url: '/AssignSubjects/PostAssignedSubjects',
                data: AssignSbjectsDTO,
                success: function (resp) {
                    if (resp == true) {
                        showNotification(""success"", ""Subjects Assigned!"");

                        $(""#btnreset"").click()
                    }
                    else {
                        console.log(resp.erroname);
                        showNotification(""danger"", ""Assign Failed!"");
                    }
                },
            })
            
        })

        //makrs entr
        $("".marks"").keypress(function (e) {
            if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                showNotification(""danger");
            WriteLiteral("\", \"Input Only Numbers\");\r\n                return false;\r\n            }\r\n            \r\n        })\r\n\r\n    })\r\n</script>");
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
