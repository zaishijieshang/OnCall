#pragma checksum "D:\OnCallGit\OnCall.Web\Views\MessageBox\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8f419d1ffaf23108fbaa0aaa3c77c303ee1c1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MessageBox_Edit), @"mvc.1.0.view", @"/Views/MessageBox/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MessageBox/Edit.cshtml", typeof(AspNetCore.Views_MessageBox_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8f419d1ffaf23108fbaa0aaa3c77c303ee1c1c", @"/Views/MessageBox/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422c8a2b1f3500844f7cc7ccc36309b400dd057f", @"/Views/_ViewImports.cshtml")]
    public class Views_MessageBox_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\OnCallGit\OnCall.Web\Views\MessageBox\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(24, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(47, 391, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8f419d1ffaf23108fbaa0aaa3c77c303ee1c1c3399", async() => {
                BeginContext(53, 378, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title> Sn.Web </title>
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
            BeginContext(438, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(439, 6884, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8f419d1ffaf23108fbaa0aaa3c77c303ee1c1c4975", async() => {
                BeginContext(445, 67, true);
                WriteLiteral("\n    <div class=\"layui-form\" id=\"dictBox\" style=\"padding: 20px;\">\n\n");
                EndContext();
                BeginContext(850, 225, true);
                WriteLiteral("\n        <div class=\"layui-form-item layui-form-pane \">\n            <label class=\"layui-form-label\">发件人</label>\n            <div class=\"layui-input-inline\" style=\"width:350px\">\n                <input type=\"text\" name=\"Sender\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1075, "\"", 1105, 1);
#line 27 "D:\OnCallGit\OnCall.Web\Views\MessageBox\Edit.cshtml"
WriteAttributeValue("", 1083, ViewBag.LoginUserName, 1083, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1106, 359, true);
                WriteLiteral(@" lay-verify=""required"" placeholder=""请输入发件人""  autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item layui-form-pane  layui-hide"">
            <label class=""layui-form-label"">发送人ID</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""SenderID""");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 1465, "\"", 1494, 1);
#line 34 "D:\OnCallGit\OnCall.Web\Views\MessageBox\Edit.cshtml"
WriteAttributeValue("", 1474, ViewBag.LoginUserID, 1474, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1495, 1632, true);
                WriteLiteral(@"  lay-verify=""required"" placeholder=""请输入发送人ID"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item layui-form-pane "">
            <label class=""layui-form-label"">收件人</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input name=""Receiver"" lay-verify=""required"" value="""" placeholder=""请输入收件人""  autocomplete=""off"" class=""layui-input"">
            </div>
            <button class=""layui-btn layuiadmin-btn-admin"" data-type=""queryUser"" >
                <i class=""layui-icon layui-icon-search layuiadmin-button-btn""></i>
            </button>
        </div>

        <div class=""layui-form-item layui-form-pane  layui-hide"">
            <label class=""layui-form-label"">接收人ID</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""ReceiverID"" lay-verify=""required"" placeholder=""请输入接收人ID"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

 ");
                WriteLiteral(@"       <div class=""layui-form-item layui-form-pane  layui-hide"">
            <label class=""layui-form-label"">发送时间</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""SendTime"" lay-verify=""required"" placeholder=""请输入发送时间"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item layui-form-pane "">
            <label class=""layui-form-label"">创建时间</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""CreateTime"" lay-verify=""required""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3127, "\"", 3150, 1);
#line 65 "D:\OnCallGit\OnCall.Web\Views\MessageBox\Edit.cshtml"
WriteAttributeValue("", 3135, DateTime.Now, 3135, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3151, 1445, true);
                WriteLiteral(@" placeholder=""请输入创建时间"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item layui-form-pane "">
            <label class=""layui-form-label"">标题</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""Title"" lay-verify=""required"" placeholder=""请输入标题"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item layui-form-pane "">
            <label class=""layui-form-label"">内容</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""Content"" lay-verify=""required"" placeholder=""请输入内容"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item layui-form-pane  layui-hide"">
            <label class=""layui-form-label"">1:收件箱 2:发件箱 3:草稿箱</label>
            <div class=""layui-input-inline"" style=""width:350px"">
                <input type=""text"" name=""Ty");
                WriteLiteral(@"pe"" lay-verify=""required"" placeholder=""请输入1:收件箱 2:发件箱 3:草稿箱"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item  layui-form-pane"">
            <label class=""layui-form-label"">状态</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""Status"" lay-verify=""required"" placeholder=""状态"" autocomplete=""off"" class=""layui-input"">
");
                EndContext();
                BeginContext(4732, 2584, true);
                WriteLiteral(@"            </div>
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
        }).extend({
            index: 'lib/index' //主入口模块
        }).use(['index', 'form'], function () {
            var $ = layui.$

                , form = layui.form;

            layer.ready(function () {

      



                //TODO

            });

            //监听提交
            form.on('submit(app-form-submit)', function (data) {
                var field = data.field; //获取提交的字段
                var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引            
                field.Status ");
                WriteLiteral(@"= field.Status == ""on"" ? 1 : 0;
                $.ajax({
                    url: '/MessageBox/CerateOrEdit',
                    type: 'post',
                    dataType: 'json',
                    contentType: 'application/json',
                    data: JSON.stringify(field),
                    timeout: 2000,
                    beforeSend: function (xhr) {
                        //xhr.setRequestHeader(header, token);
                    },
                    success: function (data) {
                        console.log(data);
                        if (data.status) {
                            parent.layui.table.reload('table-page'); //重载表格
                            parent.layer.close(index); //再执行关闭
                        }
                        else {
                            layer.msg(""操作失败. "" + data.message);
                        }
                    },
                    error: function () {
                        layer.msg(""发生错误."");
                    }
                });

");
                WriteLiteral(@"            });

            //var $ = layui.$, form = layui.form, active = {
            //    queryUser: function () { //搜索
            //        layer.open({
            //            type: 2
            //            , title: '搜索'
            //            , content: '/MessageBox/Search'
            //            , area: ['600px', '520px']
            //            //, btn: ['发送', '取消']
            //            , maxmin: true

            //        });
            //    }
            //}
        });
    </script>

");
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
            BeginContext(7323, 9, true);
            WriteLiteral("\n</html>\n");
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
