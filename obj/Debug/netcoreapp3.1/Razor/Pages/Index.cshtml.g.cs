#pragma checksum "C:\Users\sebas\Desktop\Entrance Folder\University\UK Electronic Democracy\UK Electronic Democracy\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098b74cfe4fdeed48ffaa4dfd8e98a79f454b058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UK_Electronic_Democracy.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace UK_Electronic_Democracy.Pages
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
#line 1 "C:\Users\sebas\Desktop\Entrance Folder\University\UK Electronic Democracy\UK Electronic Democracy\Pages\_ViewImports.cshtml"
using UK_Electronic_Democracy;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098b74cfe4fdeed48ffaa4dfd8e98a79f454b058", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458b6530bb3688038e90865543a579add213050d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("main()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sebas\Desktop\Entrance Folder\University\UK Electronic Democracy\UK Electronic Democracy\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098b74cfe4fdeed48ffaa4dfd8e98a79f454b0584043", async() => {
                WriteLiteral(@"
    <title>UK Government General Elections</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>

    <script>

        function main() {
            var newContents = document.getElementById(""logRegBody1"");
            newContents.style.display = ""none"";
            newContents = document.getElementById(""loginOrRegister"");
            newContents.style.display = ""none"";
            newContents = document.getElementById(""citizenCandidateOrParty"");
            newContents.style.display = ""none"";
        }

        //$(""#logRegBody1"").css(""visibilit");
                WriteLiteral(@"y"", ""hidden"");
        //$(""#loginOrRegister"").css(""visibility"", ""hidden"");

        /*window.addEventListener(""load"", TestFunction());

        function TestFunction() {
            document.getElementById(""unconditionalBodyText"").innerHTML = ""Swiggity Swag"";
        }*/

        function changeInfo(clicked_id) {
            //var element = document.getElementById(""rightTab"");
            //element.innerHTML = ""Text changed"";

            var oldContents = document.getElementById(""homeBody"");
            oldContents.style.display = ""none"";
            oldContents = document.getElementById(""logRegBody1"");
            oldContents.style.display = ""none"";
            /*oldContents = document.getElementById(""loginOrRegister"");
            oldContents.style.display = ""none"";*/
            //document.getElementById(""unconditionalBodyText"").innerHTML = ""How un-pogchamp of you, Javascript"";

            if (clicked_id == ""leftTab"") {
                var newContents = document.getElementById(""hom");
                WriteLiteral(@"eBody"");
                newContents.style.display = ""block"";

                //body - unconditional
                document.getElementById(""unconditionalBodyText"").innerHTML = ""Welcome to the UK General Election site. You can register an account which will give you access to voting for your local MP in the next general election. This site also allows you to sign up as a candidate in an election. Below you may view, and search by filtering, all incumbent MPs in relation to their constituency seats."";
            }
            else if (clicked_id == ""centreTab"") {
                //body - unconditional
                document.getElementById(""unconditionalBodyText"").innerHTML = ""Below is a complete list all of the candidates running for your constituency. It also includes any political party affiliations. If there is currently a general election on, you may vote immediately."";
            }
            else if (clicked_id == ""rightTab"") {
                //body - unconditional
                doc");
                WriteLiteral(@"ument.getElementById(""unconditionalBodyText"").innerHTML = ""Election-related information and decisions"";
            }
            else if (clicked_id == ""login"") {
                //body - unconditional
                document.getElementById(""unconditionalBodyText"").innerHTML = ""Here you may login with a pre-existing account. This account may be a regular citizen account, or a collective political party account."";

                //body - loginOrReg
                var newContents = document.getElementById(""logRegBody1"");
                newContents.style.display = ""block"";
                newContents = document.getElementById(""loginDisplay"");
                newContents.style.display = ""block"";
                newContents = document.getElementById(""registerDisplay"");
                newContents.style.display = ""none"";

                //other stuff v
                //newContents = document.getElementById(""citizenCandidateOrParty"");
                //newContents.style.display = ""block"";
  ");
                WriteLiteral(@"          }
            else if (clicked_id == ""register"") {
                //body - unconditional
                document.getElementById(""unconditionalBodyText"").innerHTML = ""Here you may register an account. This account may be a regular citizen account, or a collective political party account."";

                //body - loginOrReg
                var newContents = document.getElementById(""logRegBody1"");
                newContents.style.display = ""block"";
                newContents = document.getElementById(""registerDisplay"");
                newContents.style.display = ""block"";
                newContents = document.getElementById(""loginDisplay"");
                newContents.style.display = ""none"";

                //other stuff v
                //newContents = document.getElementById(""citizenCandidateOrParty"");
                //newContents.style.display = ""block"";
            }

            //Testing stuff
        }

        function loginOrReg(clicked_id) {

            if (");
                WriteLiteral(@"clicked_id == ""login"") {
                document.getElementById(upperBodyTextLogReg).innerHTML = ""Login as a citizen, a candidate, or a political party""
                document.getElementById(""login"").innerHTML = ""Go back"";
                document.getElementById("""").innerHTML = ""Citizen"";
                //document.getElementById("""").innerHTML = ""Candidate"";
                //document.getElementById("""").innerHTML = ""Political Party"";
            }
            else if (clicked_id == ""register"") {
                document.getElementById(upperBodyTextLogReg).innerHTML = ""Register as a citizen, a candidate, or a political party""
                document.getElementById(""login"").innerHTML = ""Go back"";
                document.getElementById("""").innerHTML = ""Citizen"";
                //document.getElementById("""").innerHTML = ""Candidate"";
                //document.getElementById("""").innerHTML = ""Political Party"";
            }

            if (stage1 == true) {

            }
        }

      ");
                WriteLiteral(@"  function searchConstituency() {
            var input = document.getElementById(""userInput"");
            var filter = input.value.toLowerCase();
            var table = document.getElementById(""MPConstituencyTable"")
            tr = table.getElementsByTagName(""tr"");

            var td;
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName(""td"")[0];
                if (td) {
                    var textValue = td.textContent || td.innerText;
                    if (textValue.toLowerCase().indexOf(filter) > -1) {
                        tr[i].style.display = """";
                    }
                    else {
                        tr[i].style.display = ""none"";
                    }
                }
            }
        }

        function citizenCandidateorParty(clicked_id) {
            if (clicked_id == ""citizenLog"") {
                accountType = ""citizen"";
                document.getElementById(""upperBodyTextLog"").innerHTML = ""Loggin");
                WriteLiteral(@"g in as: Citizen"";
            }
            else if (clicked_id == ""partyLog"") {
                accountType = ""party"";
                document.getElementById(""upperBodyTextLog"").innerHTML = ""Logging in as: Political Party"";
            }
            else if (clicked_id == ""adminLog"") {
                accountType = ""admin"";
                document.getElementById(""upperBodyTextLog"").innerHTML = ""Logging in as: Administrator"";
            }
        }

        function saveDetails() {
            //functionality debug
            //var firstName = document.getElementById(""firstNameReg"").value; //gets input value
            //document.getElementById(""emailReg"").value = firstName; //sets input value
        }

        var accountType = new String("""");
        var allAccounts = new Object();

        class account {
            constructor(firstName) {
                var firstName = String("""");
            }
        }

        /*$(window).resize(function () {

        }).resize();");
                WriteLiteral("*/\r\n\r\n    </script>\r\n");
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
            WriteLiteral(@"
<style>
    body {
        color: #f0f0f0;
        background-color: #101010;
    }
    .btn {
        color: #f0f0f0;
        background-color: #202020;
    }
    .btn:hover {
        color: #f0f0f0;
        background-color: #204080;
    }
    /*table, td, th {
        border: 1px solid #f0f0f0;
    }
    table {
        border-collapse: collapse;
        width: 100%;
        overflow: scroll;
    }
    th, td {
        height: 48px;
        padding: 16px;
        color: #f0f0f0;
    }
    th {
        text-align: center;
        background-color: #3060c0;
    }
    td {
        text-align: left;
    }*/
    tr:nth-child(even) {background-color: #183048;}
    tr:nth-child(odd) {background-color: #284058;}

    /*thead, tbody {display: block; }*/

    .tableFormatting {
        overflow-y: auto;
        overflow-x: hidden;
        height: 256px;
    }

    .tableFormatting thead th {
        position: sticky;
        top: 0;
    }

    table {
        borde");
            WriteLiteral(@"r-collapse: collapse;
        width: 100%;
    }

    th, td {
        padding: 8px 16px;
    }

    th {
        background: #38685c;
    }

    /*tbody {
        height: 256px;
        width: 100%;
        overflow-y: scroll;
        overflow-x: hidden;
    }*/

    /*tbody td, thead th {
        width: 20%;
    }*/

    p {
        display: block;
        margin: 2em;
    }

    h3 {
        display: block;
        margin-top: 1em;
        margin-bottom: 0.5em;
    }

    input {
        width: 100%;
        font-size: 16px;
        padding: 12px 20px 12px 20px;
        border: 1px solid #f0f0f0;
        margin-bottom: 0.5em;
    }

    #loginRadio, #registerRadio {
        display: block;
    }

    #submitRegDetails {
        padding: 3px 4px;
        font-size: 20px;
        border-radius: 3px;
    }

    /*#logRegBody1 {
        visibility: hidden;
    }
    #loginOrRegister {
        visibility: hidden;
    }
    #citizenCandidateOrParty {
   ");
            WriteLiteral("     visibility: hidden;\r\n    }*/\r\n\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098b74cfe4fdeed48ffaa4dfd8e98a79f454b05815891", async() => {
                WriteLiteral(@"

    <header>
        <nav class=""navbar navbar-expand-sm bg-dark"">
            <div class=""container-fluid"">
                <div class=""navbar-header"">
                    <a class=""navbar-brand"" id=""leftTab"" onclick=""changeInfo(this.id)"">UK Gov General Elections</a>
                </div>
                <ul class=""nav navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""centreTab"" onclick=""changeInfo(this.id)"">Vote Now</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""rightTab"" onclick=""changeInfo(this.id)"">My Page</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" data-toggle=""dropdown"">Sign In</a>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" id=""login"" onclick=""changeInfo(this.id)"">Login</a>
                           ");
                WriteLiteral(@" <a class=""dropdown-item"" id=""register"" onclick=""changeInfo(this.id)"">Register</a>
                        </div>
                    </li>
                </ul>
            </div>
        </nav>
    </header>

    <div class=""container-fluid"">

        <!--Login/Register-->
        <div class=""row"">
            <div class=""col-sm-10"">
            </div>
            <div class=""col-sm-2"">
                <!--<button type=""button"" class=""btn-block btn""><h5 id=""loginOrRegBtn"" onclick=""changeInfo(this.id)"" class=""text-center"">Login/Register</h5></button>-->
            </div>
        </div>

        <!--Title of Page-->
        <div class=""row"">
            <div class=""col-sm-12"">
                <h1 class=""text-center"">UK Government</h1>
                <h1 class=""text-center"">General Elections</h1>
            </div>
        </div>

        <!--Tabs-->
        <div class=""row"">
            <div class=""col-sm-3"">
                <!--<button type=""button"" class=""btn-block btn""><h2 i");
                WriteLiteral(@"d=""leftTab"" onclick=""changeInfo(this.id)"" class=""text-center"">Home</h2></button>-->
            </div>
            <div class=""col-sm-6"">
                <!--<h2 id=""VN"" class=""text-center"">Vote Now</h2>-->
                <!--<button type=""button"" class=""btn-block btn""><h2 id=""centreTab"" onclick=""changeInfo(this.id)"" class=""text-center"">Vote Now</h2></button>-->
            </div>
            <div class=""col-sm-3"">
                <!--<button type=""button"" class=""btn-block btn""><h2 id=""rightTab"" onclick=""changeInfo(this.id)"" class=""text-center"">My Page</h2></button>-->
            </div>
        </div>

        <!--Body Section - Unconditional-->
        <div class=""row"">
            <div class=""col-sm-12"">
                <p id=""unconditionalBodyText"" class=""text-center"">Welcome to the UK General Election site. You can register an account which will give you access to voting for your local MP in the next general election. This site also allows you to sign up as a candidate in an election. Belo");
                WriteLiteral(@"w you may view, and search by filtering, all incumbent MPs in relation to their constituency seats.</p>
            </div>
        </div>

        <!--Body Section - Home-->
        <div class=""row"" id=""homeBody"">
            <div class=""col-sm-12"">
                <h3 id=""lowerBodyText"" class=""text-left"">Last election results and incumbent government</h3>

                <input type=""text"" id=""userInput"" onkeyup=""searchConstituency()"" placeholder=""Search MPs based on Constituency..."" />

                <div class=""tableFormatting"">
                    <table id=""MPConstituencyTable"">
                        <thead>
                            <tr>
                                <th>Constituency Seat</th>
                                <th>Country</th>
                                <th>Full Name</th>
                                <th>Political Affiliation</th>
                            </tr>
                        </thead>
                        <tbody>
                      ");
                WriteLiteral(@"      <tr>
                                <td>Aldershot</td>
                                <td>England</td>
                                <td>Leo Docherty</td>
                                <td>Conservative and Unionist Party</td>
                            </tr>
                            <tr>
                                <td>Aldridge-Brownhills</td>
                                <td>England</td>
                                <td>Wendy Morton</td>
                                <td>Conservative and Unionist Party</td>
                            </tr>
                            <tr>
                                <td>Altrincham and Sale West</td>
                                <td>England</td>
                                <td>Sir Graham Brady</td>
                                <td>Conservative and Unionist Party</td>
                            </tr>
                            <tr>
                                <td>Amber Valley</td>
                            ");
                WriteLiteral(@"    <td>England</td>
                                <td>Nigel Mills</td>
                                <td>Conservative and Unionist Party</td>
                            </tr>
                            <tr>
                                <td>Arundel and South Downs</td>
                                <td>England</td>
                                <td>Andrew Griffith</td>
                                <td>Conservative and Unionist Party</td>
                            </tr>
                        </tbody>
                    </table>
                </div>

                <!--Head of Government Info-->
                <h4 class=""text-left"">Prime Minister (Head of Government)</h4>

                <!--Secretary of State Info-->
                <h4 class=""text-left"">Secretaries of State</h4>

                <!--Lower House Info-->
                <h4 class=""text-left"">Members of the House of Commons (Lower House of Parliament)</h4>
            </div>
        </div>

    ");
                WriteLiteral("    <!--Body Section - Login/Register-->\r\n        <div class=\"row\" id=\"logRegBody1\">\r\n            <!--<h3 id=\"upperBodyTextLogReg\" class=\"text-left\">Logging in as: Citizen</h3>-->\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098b74cfe4fdeed48ffaa4dfd8e98a79f454b05822871", async() => {
                    WriteLiteral(@"
                    <div id=""loginDisplay"">
                        <h3 id=""upperBodyTextLog"" class=""text-left"">Logging in as: Citizen</h3>
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <button type=""button"" id=""citizenLog"" class=""btn-sm"" onclick=""citizenCandidateorParty(this.id)""><h2 class=""text-center"">Citizen</h2></button>
                            </div>
                            <div class=""col-sm-2"">
                                <button type=""button"" id=""partyLog"" class=""btn-sm"" onclick=""citizenCandidateorParty(this.id)""><h2 class=""text-center"">Party</h2></button>
                            </div>
                            <div class=""col-sm-2"">
                                <button type=""button"" id=""adminLog"" class=""btn-sm"" onclick=""citizenCandidateorParty(this.id)""><h2 class=""text-center"">Admin</h2></button>
                            </div>
                        </div>
                        ");
                    WriteLiteral(@"<label>Email Address:</label>
                        <input type=""email"" class=""form-control"" id=""emailLog"" />
                        <label>Password:</label>
                        <input type=""password"" class=""form-control"" id=""passwordLog"" />
                        <label>Confirm Password:</label>
                        <input type=""password"" class=""form-control"" id=""confirmPasswordLog"" />
                        <button type=""button"" class=""btn-sm""><h2 id=""submitRegDetails"" class=""text-center"">Submit</h2></button>
                    </div>
                    <div id=""registerDisplay"">
                        <h3 id=""upperBodyTextReg"" class=""text-left"">Registering as: Citizen</h3>
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <button type=""button"" id=""citizenReg"" class=""btn-sm"" onclick=""citizenCandidateorParty(this.id)""><h2 class=""text-center"">Citizen</h2></button>
                            </div>
        ");
                    WriteLiteral(@"                    <div class=""col-sm-2"">
                                <button type=""button"" id=""partyReg"" class=""btn-sm"" onclick=""citizenCandidateorParty(this.id)""><h2 class=""text-center"">Party</h2></button>
                            </div>
                            <div class=""col-sm-2"">
                                <button type=""button"" id=""adminReg"" class=""btn-sm"" onclick=""citizenCandidateorParty(this.id)""><h2 class=""text-center"">Admin</h2></button>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <label>First Name:</label>
                                <input class=""form-control"" id=""firstNameReg"" />
                                <label>Email Address:</label>
                                <input type=""email"" class=""form-control"" id=""emailReg"" />
                                <label>Password:</label>
                                <");
                    WriteLiteral(@"input type=""password"" class=""form-control"" id=""passwordReg"" />
                            </div>
                            <div class=""col-sm-6"">
                                <label>Confirm Password:</label>
                                <input type=""password"" class=""form-control"" id=""confirmPasswordReg"" />
                                <label>National Insurance Number:</label>
                                <input class=""form-control"" id=""nationalInsuranceNumberReg"" />
                                <label>Nationalities (WIP):</label>
                                <input class=""form-control"" id=""nationalityReg"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <label>Residential Address:</label>
                                <input class=""form-control"" id=""addressReg"" />
                                <label>Birthday:</label>
        ");
                    WriteLiteral(@"                        <input type=""date"" class=""form-control"" id=""birthdayReg"" />
                                <button type=""button"" class=""btn-sm""><h2 id=""submitRegDetails"" class=""text-center"" onclick=""saveDetails(this.id)"">Submit</h2></button>
                            </div>
                        </div>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n    <!--\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    </div>\r\n        //-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
