#pragma checksum "D:\WeiCloud\OnCall\OnCall.Web\Views\MessageBox\Drafts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19951f54a6661335d42f112a7dcd38e35a90a047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MessageBox_Drafts), @"mvc.1.0.view", @"/Views/MessageBox/Drafts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MessageBox/Drafts.cshtml", typeof(AspNetCore.Views_MessageBox_Drafts))]
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
#line 1 "D:\WeiCloud\OnCall\OnCall.Web\Views\_ViewImports.cshtml"
using OnCall.Web;

#line default
#line hidden
#line 2 "D:\WeiCloud\OnCall\OnCall.Web\Views\_ViewImports.cshtml"
using OnCall.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19951f54a6661335d42f112a7dcd38e35a90a047", @"/Views/MessageBox/Drafts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422c8a2b1f3500844f7cc7ccc36309b400dd057f", @"/Views/_ViewImports.cshtml")]
    public class Views_MessageBox_Drafts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\WeiCloud\OnCall\OnCall.Web\Views\MessageBox\Drafts.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(52, 470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19951f54a6661335d42f112a7dcd38e35a90a0473802", async() => {
                BeginContext(58, 457, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Sn.Web</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=0"">
    <link rel=""stylesheet"" href=""/layuiadmin/layui/css/layui.css"" media=""all"">
    <link rel=""stylesheet"" href=""/layuiadmin/style/admin.css"" media=""all"">
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
            BeginContext(522, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(524, 2920, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19951f54a6661335d42f112a7dcd38e35a90a0475465", async() => {
                BeginContext(556, 2881, true);
                WriteLiteral(@"
    <div class=""layui-fluid"">
        <div class=""layui-card"">
            <!--<div class=""layui-form layui-card-header layuiadmin-card-header-auto"">
                                                        <div class=""layui-form-item"">

                                                           <div class=""layui-inline layui-form-pane"">
                                                        <label class=""layui-form-label"">标题</label>
                                                        <div class=""layui-input-block"">
                                                            <input type=""text"" name=""Title"" placeholder=""请输入标题"" autocomplete=""off"" class=""layui-input"">
                                                        </div>
                                                    </div>
            <div class=""layui-inline layui-form-pane"">
                                                        <label class=""layui-form-label"">内容</label>
                                                       ");
                WriteLiteral(@" <div class=""layui-input-block"">
                                                            <input type=""text"" name=""Content"" placeholder=""请输入内容"" autocomplete=""off"" class=""layui-input"">
                                                        </div>
                                                    </div>


                                                            <div class=""layui-inline"">
                                                                <button class=""layui-btn layuiadmin-btn-useradmin"" lay-submit lay-filter=""table-page-search"">
                                                                    <i class=""layui-icon layui-icon-search layuiadmin-button-btn""></i>
                                                                    搜索
                                                                </button>
                                                            </div>
                                                        </div>
                                             ");
                WriteLiteral(@"       </div>-->
            <!--<div class=""layui-card-header"">字典管理</div>-->
            <div class=""layui-card-body"">
                <div class=""layui-btn-group table-operate-btn"" style=""margin-bottom: 10px;"">
                    <button class=""layui-btn layui-btn-sm"" data-type=""addData"">新增</button>
                    <button class=""layui-btn layui-btn-sm"" data-type=""delDatas"">删除</button>
                </div>
                <table class=""layui-hide"" id=""table-page"" lay-filter=""table-page""></table>
                <script type=""text/html"" id=""table-operate-bar"">
                    <a class=""layui-btn layui-btn-xs"" lay-event=""edit"">编辑</a>
                    <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del"">删除</a>
                </script>
            </div>
        </div>
    </div>
");
                EndContext();
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
            EndContext();
            BeginContext(3444, 7653, true);
            WriteLiteral(@"

</html>

<script src=""/layuiadmin/layui/layui.js""></script>
<script>
    layui.config({
        base: '../../../layuiadmin/' //静态资源所在路径
    }).extend({
        index: 'lib/index' //主入口模块
    }).use(['index', 'form', 'table'], function () {
        var admin = layui.admin
            , table = layui.table
            , form = layui.form;
        var index = layer.load(0);

        //监听搜索
        form.on('submit(table-page-search)', function (data) {
            var field = data.field;
            //执行重载
            table.reload('table-page', {
                where: field
            });
        });


        table.render({
            elem: '#table-page'
            , url: '/MessageBox/PageData'
            , loading: true
            , height: 'full-100'
            , where: { type: 3 }//草稿箱
            , size: 'sm'
            , cols: [[
                { type: 'checkbox', fixed: 'left' }
                , { field: 'ID', width: 100, title: '', sort: true, hide: true }
 ");
            WriteLiteral(@"               , { field: 'Sender', width: 100, title: '发件人', sort: true }
                , { field: 'SenderID', width: 100, title: '发送人', sort: true }
                , { field: 'Receiver', width: 100, title: '收件人', sort: true }
                , { field: 'ReceiverID', width: 100, title: '接收人', sort: true }
                , { field: 'SendTime', width: 100, title: '发送时间', sort: true }
                , { field: 'CreateTime', width: 100, title: '创建时间', sort: true }
                , { field: 'Title', width: 100, title: '标题', sort: true }
                , { field: 'Content', width: 100, title: '内容', sort: true }
                , { field: 'Type', width: 100, title: '收件箱发件箱草稿箱', sort: true }
                , { field: 'Status', width: 70, title: '状态', templet: function (d) { if (d.Status == 1) return ""<span style='color:green'>启用</span>""; else return ""<span style='color:red'>禁用</span>""; } }

                , { width: 120, align: 'center', fixed: 'right', toolbar: '#table-operate-bar' }
          ");
            WriteLiteral(@"  ]]
            , page: true
            , done: function (res) {
                $(""[data-field='ID']"").css('display', 'none');
                layer.close(index);
            }
        });

        //监听表格复选框选择
        table.on('checkbox(table-page)', function (obj) {
            console.log(obj)
        });
        //监听工具条
        table.on('tool(table-page)', function (obj) {
            var data = obj.data;
            if (obj.event === 'detail') {
                layer.msg('ID：' + data.id + ' 的查看操作');
            } else if (obj.event === 'del') {
                layer.confirm('确定删除[{0}]吗?'.format(data.ID), function (index) {
                    $.ajax({
                        url: '/MessageBox/Delete',
                        type: 'post',
                        dataType: 'json',
                        data: { ID: data.ID },
                        timeout: 2000,
                        beforeSend: function (xhr) {
                        },
                        success: ");
            WriteLiteral(@"function (data) {
                            if (data.status) {
                                obj.del();
                                layer.close(index);
                            } else {
                                layer.msg(""操作失败. "" + data.message)
                            }
                        },
                        error: function () {
                            layer.msg(""发生错误."")
                        }
                    });

                });
            } else if (obj.event === 'edit') {
                //layer.alert('编辑行：<br>' + JSON.stringify(data))

                layer.open({
                    type: 2
                    , title: '编辑'
                    , content: '/MessageBox/Edit'
                    , area: ['600px', '520px']
                    , btn: ['确定', '取消']
                    , maxmin: true
                    , success: function (layero, index) {
                        debugger;
                        console.log(data);
  ");
            WriteLiteral(@"                      var ic = layero.find('iframe').contents();
                        for (var field in data) {
                            if (field == 'Status') {
                                if (data[field] == 1) {
                                    data[field] = ""on"";
                                    ic.find(""[name='Status']"".format(field)).prop(""checked"", true);
                                } else {
                                    data[field] = ""off"";
                                    ic.find(""[name='Status']"".format(field)).prop(""checked"", false);
                                }
                                layui.render(""checkbox"");
                            }
                            else {
                                ic.find(""[name='{0}']"".format(field)).val(data[field]);
                            }
                        }
                    }
                    , yes: function (index, layero) {
                        var submit = layero.find('");
            WriteLiteral(@"iframe').contents().find(""#app-form-submit"");
                        submit.click();
                    }
                });
            }
        });

        var $ = layui.$, form = layui.form, active = {
            addData: function () { //新增
                layer.open({
                    type: 2
                    , title: '添加'
                    , content: '/MessageBox/Edit'
                    , area: ['600px', '520px']
                    , btn: ['确定', '取消']
                    , maxmin: true
                    , yes: function (index, layero) {
                        var submit = layero.find('iframe').contents().find(""#app-form-submit"");
                        submit.click();
                    }
                });
            }
            , delDatas: function () { //删除
                var checkStatus = table.checkStatus('table-page')
                    , data = checkStatus.data;
                //layer.msg('选中了：' + data.length + ' 个');
                var ids =");
            WriteLiteral(@" [];
                var idNames = [];
                for (var i = 0; i < data.length; i++) {
                    ids.push(data[i].ID);
                    idNames.push(data[i].ID);
                }
                layer.confirm('确定删除[{0}]吗?'.format(idNames.join(',')), function (index) {
                    $.ajax({
                        url: '/MessageBox/Deletes',
                        type: 'POST',
                        dataType: 'json',
                        //contentType: 'application/json',
                        data: { IDs: ids.join(',') },//JSON.stringify(data),
                        timeout: 2000,
                        beforeSend: function (xhr) {
                        },
                        success: function (data) {
                            if (data.status) {
                                layui.table.reload('table-page');
                                layer.close(index);
                            } else {
                                layer.msg(""");
            WriteLiteral(@"操作失败. "" + data.message)
                            }
                        },
                        error: function () {
                            layer.msg(""发生错误."")
                        }
                    });
                });
            }
        };
        $('.table-operate-btn .layui-btn').on('click', function () {
            var type = $(this).data('type');
            active[type] ? active[type].call(this) : '';
        });
    });
</script>
");
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
