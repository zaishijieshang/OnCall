#pragma checksum "D:\OnCallGit\OnCall.Web\Views\Systems\SysUserRole\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "215d48877c82aa6ae0bd7690d74c96832b23d9a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Systems_SysUserRole_Index), @"mvc.1.0.view", @"/Views/Systems/SysUserRole/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Systems/SysUserRole/Index.cshtml", typeof(AspNetCore.Views_Systems_SysUserRole_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"215d48877c82aa6ae0bd7690d74c96832b23d9a2", @"/Views/Systems/SysUserRole/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422c8a2b1f3500844f7cc7ccc36309b400dd057f", @"/Views/_ViewImports.cshtml")]
    public class Views_Systems_SysUserRole_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\OnCallGit\OnCall.Web\Views\Systems\SysUserRole\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(52, 481, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "215d48877c82aa6ae0bd7690d74c96832b23d9a23842", async() => {
                BeginContext(58, 41, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>");
                EndContext();
                BeginContext(100, 16, false);
#line 8 "D:\OnCallGit\OnCall.Web\Views\Systems\SysUserRole\Index.cshtml"
      Write(ViewBag.WebTitle);

#line default
#line hidden
                EndContext();
                BeginContext(116, 410, true);
                WriteLiteral(@"</title>
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
            BeginContext(533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(535, 1508, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "215d48877c82aa6ae0bd7690d74c96832b23d9a25830", async() => {
                BeginContext(567, 1469, true);
                WriteLiteral(@"
    <input id=""RoleID"" type=""hidden"" />
    <div class=""layui-fluid"">
        <div class=""layui-card"">
            <!--<div class=""layui-form layui-card-header layuiadmin-card-header-auto"">
                <div class=""layui-form-item"">



                    <div class=""layui-inline"">
                        <button class=""layui-btn layuiadmin-btn-useradmin"" lay-submit lay-filter=""table-page-search"">
                            <i class=""layui-icon layui-icon-search layuiadmin-button-btn""></i>
                            搜索
                        </button>
                    </div>
                </div>
            </div>-->
            <!--<div class=""layui-card-header"">字典管理</div>-->
            <div class=""layui-card-body"">
                <div class=""layui-btn-group table-operate-btn"" style=""margin-bottom: 10px;"">
                    <button class=""layui-btn layui-btn-sm"" data-type=""addData"">新增</button>
                    <button class=""layui-btn layui-btn-sm"" data-type=""delDatas""");
                WriteLiteral(@">删除</button>
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
            BeginContext(2043, 6632, true);
            WriteLiteral(@"

</html>

<script src=""/layuiadmin/layui/layui.js""></script>
<script>
    layui.config({
        base: '../../../layuiadmin/' //静态资源所在路径
    }).extend({
        index: 'lib/index' //主入口模块
    }).use(['index', 'form', 'table'], function () {
        var $ = layui.$
            , admin = layui.admin
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

        var RoleID = $(""#RoleID"").val();
        table.render({
            elem: '#table-page'
            , url: '/SysUserRole/PageData'
            , loading: true
            , height: 'full-100'
            , size: 'sm'
            , cols: [[
                { type: 'checkbox', fixed: 'left' }
                , { field: 'ID', width: 100, title: ''");
            WriteLiteral(@", sort: true, hide: true }
                , { field: 'RoleID', width: 100, title: '角色', sort: true, hide: true }
                , { field: 'UserID', width: 100, title: '用户', sort: true, hide: true }
                , { field: 'UserName', width: 100, title: '用户名', sort: true }

                , { width: 120, align: 'center', fixed: 'right', toolbar: '#table-operate-bar' }
            ]]
            , page: true
            , where: { RoleID: RoleID }
            , done: function (res) {
                //  $(""[data-field='ID']"").css('display', 'none');
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
          ");
            WriteLiteral(@"      layer.confirm('确定删除[{0}]吗?'.format(data.UserName), function (index) {
                    $.ajax({
                        url: '/SysUserRole/Delete',
                        type: 'post',
                        dataType: 'json',
                        data: { ID: data.ID },
                        timeout: 2000,
                        beforeSend: function (xhr) {
                        },
                        success: function (data) {
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
                //layer.alert('编辑");
            WriteLiteral(@"行：<br>' + JSON.stringify(data))

                layer.open({
                    type: 2
                    , title: '编辑'
                    , content: '/SysUserRole/Edit'
                    , area: ['600px', '520px']
                    , btn: ['确定', '取消']
                    , maxmin: true
                    , success: function (layero, index) {
                        debugger;
                        console.log(data);
                        var ic = layero.find('iframe').contents();
                        for (var field in data) {
                            ic.find(""[name='{0}']"".format(field)).val(data[field]);
                        }
                    }
                    , yes: function (index, layero) {
                        var submit = layero.find('iframe').contents().find(""#app-form-submit"");
                        submit.click();
                    }
                });
            }
        });

        var $ = layui.$, form = layui.form, active = {
   ");
            WriteLiteral(@"         addData: function () { //新增
                layer.open({
                    type: 2
                    , title: '添加'
                    , content: '/SysUserRole/Edit'
                    , area: ['600px', '520px']
                    , btn: ['确定', '取消']
                    , maxmin: true
                    , success: function (layero, index) {
                        debugger;
                        layero.find('iframe').contents().find(""#RoleID"").val($(""#RoleID"").val());
                    }
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
                var ids = [];");
            WriteLiteral(@"
                var idNames = [];
                for (var i = 0; i < data.length; i++) {
                    ids.push(data[i].ID);
                    idNames.push(data[i].UserName);
                }
                layer.confirm('确定删除[{0}]吗?'.format(idNames.join(',')), function (index) {
                    $.ajax({
                        url: '/SysUserRole/Deletes',
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
                                layer.ms");
            WriteLiteral(@"g(""操作失败. "" + data.message)
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
