#pragma checksum "D:\OnCallGit\OnCall.Web\Views\Systems\SysKeywords\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e92c69204aa4e711e6e5bfd7f998166e20abcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Systems_SysKeywords_Edit), @"mvc.1.0.view", @"/Views/Systems/SysKeywords/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Systems/SysKeywords/Edit.cshtml", typeof(AspNetCore.Views_Systems_SysKeywords_Edit))]
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
#line 1 "D:\OnCallGit\OnCall.Web\Views\_ViewImports.cshtml"
using OnCall.Web;

#line default
#line hidden
#line 2 "D:\OnCallGit\OnCall.Web\Views\_ViewImports.cshtml"
using OnCall.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e92c69204aa4e711e6e5bfd7f998166e20abcf", @"/Views/Systems/SysKeywords/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422c8a2b1f3500844f7cc7ccc36309b400dd057f", @"/Views/_ViewImports.cshtml")]
    public class Views_Systems_SysKeywords_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "D:\OnCallGit\OnCall.Web\Views\Systems\SysKeywords\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(52, 407, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47e92c69204aa4e711e6e5bfd7f998166e20abcf3477", async() => {
                BeginContext(58, 43, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>");
                EndContext();
                BeginContext(102, 16, false);
#line 8 "D:\OnCallGit\OnCall.Web\Views\Systems\SysKeywords\Edit.cshtml"
      Write(ViewBag.WebTitle);

#line default
#line hidden
                EndContext();
                BeginContext(118, 334, true);
                WriteLiteral(@"</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=0"">
    <link rel=""stylesheet"" href=""/layuiadmin/layui/css/layui.css"" media=""all"">
");
                EndContext();
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
            EndContext();
            BeginContext(459, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(461, 5206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47e92c69204aa4e711e6e5bfd7f998166e20abcf5384", async() => {
                BeginContext(467, 5193, true);
                WriteLiteral(@"
    <div class=""layui-form"" id=""dictBox"" style=""padding: 20px;"">

        <div class=""layui-form-item layui-form-pane layui-hide"">
            <label class=""layui-form-label"">ID</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""ID"" value=""0"" placeholder=""请输入ID"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item layui-form-pane "">
            <label class=""layui-form-label"">关键字</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""Keyword"" lay-verify=""required"" placeholder=""请输入关键字"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item layui-form-pane "">
            <label class=""layui-form-label"">替换值</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""ReplaceValue"" lay-verify=""required"" place");
                WriteLiteral(@"holder=""请输入替换值"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item  layui-form-pane"">
            <label class=""layui-form-label"">状态</label>
            <div class=""layui-input-inline"">
                <input type=""checkbox"" lay-verify=""required"" lay-filter=""status"" name=""Status"" lay-skin=""switch"" lay-text=""启用|禁用"">
            </div>
        </div>



        <div class=""layui-form-item layui-hide"">
            <input type=""button"" lay-submit lay-filter=""app-form-submit"" id=""app-form-submit"" value=""确认添加"">
            <input type=""button"" lay-submit lay-filter=""layuiadmin-app-form-edit"" id=""layuiadmin-app-form-edit"" value=""确认编辑"">
        </div>
    </div>
    <script src=""../../../layuiadmin/layui/layui.js""></script>

    <script>
                                                layui.config({
                                                    base: '../../../layuiadmin/' //静态资源所在路径
                                              ");
                WriteLiteral(@" }).extend({
                                            index: 'lib/index' //主入口模块
                                               }).use(['index', 'form'], function () {
                                                var $ = layui.$

                                                     , form = layui.form;

                                                layer.ready(function () {





                                                   //TODO

                                                });

                                                //监听提交
                                                form.on('submit(app-form-submit)', function(data) {
                                                    var field = data.field; //获取提交的字段
                                                    var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引

                                                     field.Status = field.Status == ""on"" ? 1 : 0;
                                    ");
                WriteLiteral(@"                 $.ajax({
                                                            url: '/SysKeywords/CerateOrEdit',
                                                            type: 'post',
                                                            dataType: 'json',
                                                            contentType: 'application/json',
                                                            data: JSON.stringify(field),
                                                            timeout: 2000,
                                                            beforeSend: function(xhr) {
                                                            //xhr.setRequestHeader(header, token);
                                                       },
                                                            success: function(data) {
                                                            console.log(data);
                                                            if (data.stat");
                WriteLiteral(@"us)
                                                            {
                                                                parent.layui.table.reload('table-page'); //重载表格
                                                                parent.layer.close(index); //再执行关闭
                                                           }
                                                            else
                                                            {
                                                                layer.msg(""操作失败. "" + data.message);
                                                               }
                                                       },
                                                            error: function() {
                                                            layer.msg(""发生错误."");
                                                           }
                                                   });

                                            ");
                WriteLiteral("   });\r\n                                           });\r\n    </script>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(5667, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
