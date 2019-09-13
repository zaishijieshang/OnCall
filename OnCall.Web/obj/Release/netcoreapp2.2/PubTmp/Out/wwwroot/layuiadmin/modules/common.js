/**

 @Name：layuiAdmin 公共业务
 @Author：贤心
 @Site：http://www.layui.com/admin/
 @License：LPPL
    
 */

layui.define(function (exports) {
    var $ = layui.$
        , layer = layui.layer
        , laytpl = layui.laytpl
        , setter = layui.setter
        , view = layui.view
        , admin = layui.admin

    //公共业务的逻辑处理可以写在此处，切换任何页面都会执行
    //……



    //退出
    admin.events.logout = function () {
        //执行退出接口
        layer.confirm('确定退出系统吗?', function (index) {
            admin.req({
                url: '/Account/Logout'
                , type: 'get'
                //, data: {}
                , done: function (res) { //这里要说明一下：done 是只有 response 的 code 正常才会执行。而 succese 则是只要 http 为 200 就会执行
                    layer.msg(res.msg, { icon: 6, time: 300 }, function () {
                        admin.exit(function () {
                            location.href = '/';
                        });
                    });
                }
            });
        
        });
    };

    //对外暴露的接口
    exports('common', {});
});