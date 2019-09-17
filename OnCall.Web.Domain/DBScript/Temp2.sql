select RealName,Mobile from Sys_RoleAlarmLevel ral
inner join Sys_UserRole ur on ral.RoleID=ur.RoleID
inner join Sys_UserInfo ui on ur.UserID=ur.UserID
where ral.AlarmLevel=1 and ui.Status=1


π‹¿Ì‘±

15012753773