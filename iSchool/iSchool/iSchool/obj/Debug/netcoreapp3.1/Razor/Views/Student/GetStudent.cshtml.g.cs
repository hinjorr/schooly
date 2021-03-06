#pragma checksum "D:\repo\schooly\iSchool\iSchool\iSchool\Views\Student\GetStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c806635533d4050f412d897a422643f46373736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetStudent), @"mvc.1.0.view", @"/Views/Student/GetStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c806635533d4050f412d897a422643f46373736", @"/Views/Student/GetStudent.cshtml")]
    public class Views_Student_GetStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\repo\schooly\iSchool\iSchool\iSchool\Views\Student\GetStudent.cshtml"
  
    ViewData["Title"] = "GetStudent";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<form>
    <div class=""row clearfix"">
        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
            <div class=""card"">
                <div class=""header"">
                    <h2>
                        Add Student Info Here
                    </h2>

                </div>
                <div class=""body"">
                    <div class=""row clearfix"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    <label>Student Name</label>
                                    <input type=""text"" id=""stdname"" class=""form-control"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <div class=""form-line"">
                                    <label>Student Phone</l");
            WriteLiteral(@"abel>
                                    <input type=""text"" id=""stdphone"" class=""form-control"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <label>Class</label>
                            <select class=""form-control show-tick"" id=""classesdropdown"">
                            </select>

                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""col-md-8"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <div class=""form-line"">
                                                <label>Address</label>
                                                <input type=""text"" id=");
            WriteLiteral(@"""stdaddress"" class=""form-control"">
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

                                    <div class=""col-md-5"">
                                        <label>Gender</label>
                                        <div class=""demo-radio-button"">
                                            <input name=""group1"" type=""radio"" id=""male"" value=""male"" checked />
                                            <label for=""male"">Male</label>
                                         ");
            WriteLiteral(@"   <input name=""group1"" type=""radio"" id=""female"" value=""female""/>
                                            <label for=""female"">Female</label>
                                        </div>
                                    </div>
                                    <div class=""col-md-2"">
                                        <div class=""form-group"">
                                            <br>
                                            <button type=""button"" class=""btn btn-info waves-effect"" data-toggle=""modal""
                                                data-target=""#otherinfo"">OTHER INFO</button>
                                        </div>
                                    </div>
                                    <div class=""col-md-2"">
                                        <div class=""form-group"">
                                            <br>
                                            <button type=""button"" class=""btn btn-info waves-effect"" data-toggle=""modal""
     ");
            WriteLiteral(@"                                           data-target=""#fatherinfo"">FATHER INFO</button>
                                        </div>
                                    </div>
                                    <div class=""col-md-2"">
                                        <div class=""form-group"">
                                            <br>
                                            <button type=""button"" class=""btn btn-info waves-effect"" data-toggle=""modal""
                                                data-target=""#motherinfo"">MOTHER INFO</button>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <div class=""col-md-4"">
                                <div class=""form-group"">
                                    <label>Picture</label>
                                    <input type='file' id=""inputFile"" />
                                  ");
            WriteLiteral(@"  <img style=""width:200px;height:200px"" id=""logo"" src=""http://placehold.it/200x200""
                                        alt=""your image"" />
                                </div>
                            </div>
                            <div class=""row"">

                                <button type=""button"" id=""btnsubmit""
                                    class=""btn btn-primary waves-effect"">Submit</button>
                                <button type=""reset"" id=""btnreset"" class=""btn btn-warning waves-effect"">Reset</button>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

<!-- #END# Multi Column -->

<!-- #Others Info -->
<div class=""modal fade"" id=""otherinfo"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""");
            WriteLiteral(@"smallModalLabel"">Other Info (optional)</h4>
            </div>
            <div class=""modal-body"">

                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Date of Birth</label>
                        <input type=""text"" class=""datepicker form-control"" placeholder=""Please choose a date..."" id=""dofb"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Student B Form</label>
                        <input type=""text"" id=""std_bform"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Religion</label>
                        <select class=""form-control show-tick"" id=""religionDropDown"">
                        </select>
                    </div>
                </div>

            </");
            WriteLiteral(@"div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-link waves-effect"" id=""btnother"" data-dismiss=""modal"">SAVE
                    CHANGES</button>
                <button type=""button"" class=""btn btn-link waves-effect"" data-dismiss=""modal"">CLOSE</button>
            </div>
        </div>
    </div>
</div>

<!-- #Father's info -->
<div class=""modal fade"" id=""fatherinfo"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""smallModalLabel"">Father's Info (optional)</h4>
            </div>
            <div class=""modal-body"">

                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Father Name</label>
                        <input type=""text"" id=""fth_name"" class=""form-control"">
                    </div>
                </div>
        ");
            WriteLiteral(@"        <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Father CNIC</label>
                        <input type=""text"" id=""fth_cnic"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Father Phone</label>
                        <input type=""text"" id=""fth_phone"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Father Occupation</label>
                        <input type=""text"" id=""fth_ocupation"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Father Income</label>
                        <input type=""text"" id=""fth_income"" class=");
            WriteLiteral(@"""form-control"">
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-link waves-effect"" id=""btnfather"" data-dismiss=""modal"">SAVE
                    CHANGES</button>
                <button type=""button"" class=""btn btn-link waves-effect"" data-dismiss=""modal"">CLOSE</button>
            </div>
        </div>
    </div>
</div>

<!-- #Mother's info -->
<div class=""modal fade"" id=""motherinfo"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-sm"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""smallModalLabel"">Mother's Info (optional)</h4>
            </div>
            <div class=""modal-body"">

                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Mother Name</label>
                        <input type=""text"" id=""mth_nam");
            WriteLiteral(@"e"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Mother CNIC</label>
                        <input type=""text"" id=""mth_cnic"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Mother Phone</label>
                        <input type=""text"" id=""mth_phone"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>Mother Occupation</label>
                        <input type=""text"" id=""mth_occupation"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""form-line"">
                        <label>M");
            WriteLiteral(@"other Income</label>
                        <input type=""text"" id=""mth_income"" class=""form-control"">
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-link waves-effect"" id=""btnmother"" data-dismiss=""modal"">SAVE
                    CHANGES</button>
                <button type=""button"" class=""btn btn-link waves-effect"" data-dismiss=""modal"">CLOSE</button>
            </div>
        </div>
    </div>
</div>
</form>

<script>
    $(document).ready(function () {

        //Countries List
        $.ajax({
            async: false,
            url: '/General/ListCountries',
            success: function (resp) {
                var html = """";
                html += ""<option value='0'>Please Slect Country</option>"";
                $(resp).each(function (index, item) {

                    html += ""<option value="" + item.countryId + "">"" + item.countryName + ""</option>"";
      ");
            WriteLiteral(@"          });
                $(""#countryDropDown"").append(html);
            },
        });

        //Class List
        $.ajax({
            async: false,
            url: '/General/ListClass',
            success: function (resp) {
                var html = """";
                html += ""<option value='0'>Please Select Class</option>"";
                $(resp).each(function (index, item) {

                    html += ""<option value="" + item.cId + "">"" + item.cName + ""</option>"";
                });
                $(""#classesdropdown"").append(html);
            },
        });

        //Religions List
        $.ajax({
            async: false,
            url: '/General/ListReligions',
            success: function (resp) {
                var html = """";
                html += ""<option value='0'>Please Select Religion</option>"";
                $(resp).each(function (index, item) {

                    html += ""<option value="" + item.religionId + "">"" + item.religion + ""</option");
            WriteLiteral(@">"";
                });
                $(""#religionDropDown"").append(html);
            },
        });

        //Image Preview
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

        
        var dobb=0;
        let studentbform;
        let religionn;
        let fathername;
        let fathercnic;
        let fatherphone;
        let fatheroccu;
        let fatherincome;
        let mothername;
        let mothercnic;
        let motherphone;
        let motheroccu;
        let motherincome;

        $(""#btnother"").click(function(){
            dobb=$('#dofb').val(),
            studentbform= $('#std_bfo");
            WriteLiteral(@"rm').val();
            religionn=$('#religionDropDown').val();     
        });

        $(""#btnfather"").click(function(){
            fathername=$('#fth_name').val();
            fathercnic=$('#fth_cnic').val();
            fatherphone= $('#fth_phone').val();
            fatheroccu=$('#fth_ocupation').val();
            fatherincome= $('#fth_income').val();
        });

        $(""#btnmother"").click(function(){
            mothername=$('#mth_name').val();
            mothercnic= $('#mth_cnic').val();
            motherphone= $('#mth_phone').val();
            motheroccu= $('#mth_occupation').val();
            motherincome=$('#mth_income').val();
        });


        $('#btnsubmit').click(function () {
            let StudentModel = {
                StdName: $('#stdname').val(),
                Class: $('#classesdropdown').val(),
                StdPic: $('#inputFile').val(),
                StdNumber: $('#stdphone').val(),
                Dob: dobb,
                CountryId: ");
            WriteLiteral(@"$('#countryDropDown option:selected').val(),
                Gender: $(""input[name='group1']:checked"").val(),
                Address: $('#stdaddress').val(),
                StdBform:studentbform,
                ReligionId: religionn,
                FatherName: fathername,
                FatherCnic:fathercnic ,
                FatherNumber:fatherphone,
                FatherOccupation: fatheroccu,
                FatherIncome:fatherincome,
                MotherName: mothername,
                MotherCnic:mothercnic,
                MotherOccupation:motheroccu,
                MotherIncome:motherincome ,
                MotherPhone:motherphone
            }
            if(StudentModel.StdName ==""""  && StudentModel.Address =="""" && StudentModel.Country ==0 )
            {
                showNotification(""danger"",""Please fill Fields!!"");
            }
           else if(StudentModel.StdName =="""" )
            {
                showNotification(""warning"",""Please provide student!!"");
  ");
            WriteLiteral(@"          }
            else if(StudentModel.Class ==0 )
            {
                showNotification(""warning"",""Please provide Class!!"");
            }
             else if(StudentModel.Address =="""" )
            {
                showNotification(""warning"",""Please provide Address!!"");
            }
             else if(StudentModel.Country ==0 )
            {
                showNotification(""warning"",""Please provide Country!!"");
            }
            else{
                 $.ajax({
                    url:'/Student/PostStudent',
                    data:StudentModel,
                    success:function(resp){
                    if(resp == true){
                    showNotification(""success"",""Registration Scuccessful!"");
                    $(""#btnreset"").click()
                    }
                    else{
                    showNotification(""danger"",""Registration Field!!"");
                    }
                    }
                    }); 
            }

       ");
            WriteLiteral("    \r\n\r\n        });\r\n\r\n\r\n  // $(\"#countryDropDown\").val(168).trigger(\"Change\");\r\n\r\n    });\r\n</script>");
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
