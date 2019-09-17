
select * from 故障事件历史库
select * from 遥信变位事件历史库


select * from 变位信息定义库 where 厂站ID='仰天湖升压站'

[是布尔型]
select * from 故障信息定义库 where 厂站ID='油麻风机'[描述-故障定义信息]

select * from 故障事件当日库 where 厂站ID='油麻风机'--油麻风电  019号机组机组待风

[不是布尔型]
select * from 故障代码库 [故障代码]
select * from 故障信息定义库[描述-故障代码]



select * from 变位信息定义库

select * from 遥信变位事件历史库
select * from 变位信息定义库

厂站ID YXID 值名 状态 时间 等级
油麻升压站

公用测控_DI3_关口计量屏失压记录仪失压告警

复归->动作

2019-05-11 03:00:09.000

1

FanID
FactoryID




0918 
1、ClearDataJob
2、AlarmWebJob
3、配置表
4、收发草稿
5、用户管理
6、报表统计
7、告警查询
8、小程序接口【登录，用户列表，发件箱，收件箱，草稿箱，发送接口/与Web一样(改状态Job去捞)】
9、等级自定义
10、短信测试
11、企业微信推送


报警查询
另开Job统计？
