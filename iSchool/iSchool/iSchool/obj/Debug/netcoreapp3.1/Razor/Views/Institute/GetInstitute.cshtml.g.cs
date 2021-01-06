#pragma checksum "D:\repo\schooly\iSchool\iSchool\iSchool\Views\Institute\GetInstitute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b756ec72774d51cb4b0495a6617768f68d027a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Institute_GetInstitute), @"mvc.1.0.view", @"/Views/Institute/GetInstitute.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b756ec72774d51cb4b0495a6617768f68d027a7", @"/Views/Institute/GetInstitute.cshtml")]
    public class Views_Institute_GetInstitute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\repo\schooly\iSchool\iSchool\iSchool\Views\Institute\GetInstitute.cshtml"
  
    ViewData["Title"] = "GetInstitute";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<form>
    <div class=""row clearfix"">
        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
            <div class=""card"">
                <div class=""header"">
                    <h2>
                        Add Institute Info Here
                    </h2>

                </div>
                <div class=""body"">
                    <div class=""row clearfix"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    <label>Institute Name</label>
                                    <input type=""text"" id=""instname"" class=""form-control"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    <label>Phone</la");
            WriteLiteral(@"bel>
                                    <input type=""text"" id=""phone"" class=""form-control"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    <label>Website</label>
                                    <input type=""text"" id=""website"" class=""form-control"">
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""col-md-8"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <div class=""");
            WriteLiteral(@"form-line"">
                                                <label>Address</label>
                                                <input type=""text"" id=""address"" class=""form-control"">
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""col-sm-6"">
                                        <label>Country</label>
                                        <select class=""form-control show-tick"" id=""countryDropDown"">

                                        </select>
                                    </div>

                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <div class=""form-line"">
                                                <label>Tag Line</label>
      ");
            WriteLiteral(@"                                          <input type=""text"" id=""tagline"" class=""form-control"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-3"">
                                        <div class=""form-group"">
                                            <br>
                                            <button type=""button"" class=""btn btn-danger waves-effect""
                                                data-toggle=""modal"" data-target=""#rules"">Rules & Regulations</button>
                                        </div>
                                    </div>
                                    <div class=""col-md-3"">
                                        <div class=""form-group"">
                                            <br>
                                            <button type=""button"" class=""btn btn-success waves-effect""
             ");
            WriteLiteral(@"                                   data-toggle=""modal"" data-target=""#fees"">Fees Particulars</button>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <div class=""col-md-4"">
                                <div class=""form-group"">
                                    <label>Logo</label>
                                    <input type='file' id=""inputFile"" />
                                    <img style=""width:200px;height:200px"" id=""logo"" src=""http://placehold.it/200x200""
                                        alt=""your image"" />
                                </div>
                            </div>
                            <div class=""row"">

                                <button type=""button"" id=""btnsubmit""
                                    class=""btn btn-primary waves-effect"">Submit</button>
                                <button type=""");
            WriteLiteral(@"reset"" id=""btnreset"" class=""btn btn-warning waves-effect"">Reset</button>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</form>
<!-- #END# Multi Column -->

<!-- Fees Particulars -->
<div class=""modal fade"" id=""fees"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""smallModalLabel"">Fee Particulars</h4>
            </div>
            <div class=""modal-body"">

                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>ADMISSION FEE</label>
                        <input type=""text"" id=""admissionfee"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
        ");
            WriteLiteral(@"                <label>REGISTRATION FEE</label>
                        <input type=""text"" id=""regfe"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>TRANSPORT</label>
                        <input type=""text"" id=""transportfee"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>BOOKS</label>
                        <input type=""text"" id=""bookfee"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>FINE</label>
                        <input type=""text"" id=""finefee"" class=""form-control"">
                    </div>
                </div>
            </div>
            <div class=""mo");
            WriteLiteral(@"dal-footer"">
                <button type=""button"" class=""btn btn-link waves-effect"" id=""btnfees"" data-dismiss=""modal"">SAVE
                    CHANGES</button>
                <button type=""button"" class=""btn btn-link waves-effect"" data-dismiss=""modal"">CLOSE</button>
            </div>
        </div>
    </div>
</div>

<!-- Rules & Regulations -->
<div class=""modal fade"" id=""rules"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""smallModalLabel"">Rules & Regulations</h4>
            </div>
            <div class=""modal-body"">
                <textarea rows=""13"" class=""form-control no-resize"" id=""rulesregulations""></textarea>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-link waves-effect"" id=""btnrules"" data-dismiss=""modal"">SAVE
                    CHANGES</button>
      ");
            WriteLiteral(@"          <button type=""button"" class=""btn btn-link waves-effect"" data-dismiss=""modal"">CLOSE</button>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {

        //Image 
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#logo').attr('src', e.target.result);
                }
                reader.readAsDataURL(input.files[0]);
            }
        };

        $(""#inputFile"").change(function () {
            readURL(this);
        });
        var rules;
        var addfee;
        var regfee;
        var transfee;
        var bokfee;
        var finefee;


        $(""#btnrules"").click(function () {
            rules = $(""#rulesregulations"").val()
        });

        $(""#btnfees"").click(function () {
            addfee = $(""#admissionfee"").val()
            regfee = $(""#regfe"")");
            WriteLiteral(@".val()
            transfee = $(""#transportfee"").val()
            bokfee = $(""#bookfee"").val()
            finefee = $(""#finefee"").val()
        });

        $(""#btnsubmit"").click(function () {

            if (($(""#instname"").val() == """") && ($(""#logo"").val() == """") && ($(""#address"").val() == """")) {
                showNotification(""warning"", "" Please Fill all neccessary fields!!"");
            }
            else if (($(""#instname"").val() == """")) {
                showNotification(""warning"", "" Please Provide Institute Name!!"");
            }
            else if (($(""#inputFile"").val() == """")) {
                showNotification(""warning"", "" Please Provide Logo!!"");
            }
            else if (($(""#address"").val() == """")) {
                showNotification(""warning"", "" Please Provide Address!!"");
            }

             else  if( ($(""#countryDropDown"").val()==0) ){
                  showNotification(""warning"","" Please Provide Country!!"");
               } 

            else");
            WriteLiteral(@" {
                var InstituteModel = {
                    Name: $(""#instname"").val(),
                    Phone: $(""#phone"").val(),
                    Website: $(""#website"").val(),
                    Address: $(""#address"").val(),
                    Country: $(""#countryDropDown option:selected"").val(),
                    Logo: $(""#inputFile"").val(),
                    Moto: $(""#tagline"").val(),
                    RulesRegulations: rules,
                    AdmissionFee: addfee,
                    RegistrationFee: regfee,
                    TransportFee: transfee,
                    BooksFee: bokfee,
                    FineFee: finefee,
                };


                $.ajax({
                    type: 'Post',
                    url: '/Institute/PostInstitue',
                    data: InstituteModel,
                    success: function (resp) {
                        if (resp == true) {
                            showNotification(""success"", ""Institute Registered");
            WriteLiteral(@"!"");
                            $(""#btnreset"").click();
                            console.log(InstituteModel.Country);
                        }
                        else {
                            showNotification(""danger"", ""Registration Failed!"");
                        }
                    },
                });
            };

        });



        //Countries List
        $.ajax({
            async: false,
            url: '/General/ListCountries',
            success: function (resp) {
                //console.log(resp);
                var html = """";
                html += ""<option value='0'>Please Slect Country</option>"";
                $(resp).each(function (index, item) {

                    html += ""<option value="" + item.id + "">"" + item.text + ""</option>"";
                });
                $(""#countryDropDown"").append(html);
            },
        });







    });
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
