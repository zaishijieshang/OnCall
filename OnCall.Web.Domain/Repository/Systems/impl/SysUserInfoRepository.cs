using OnCall.Web.Domain.Infrastructure.DP;
using OnCall.Web.Domain.Infrastructure.DP.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnCall.Web.Domain.Repository.Systems.impl
{
    public class SysUserInfoRepository : ISysUserInfoRepository
    {
        private readonly DapperDBContext _context;
        public SysUserInfoRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ESysUserInfo>> GetAllAsync()
        {
            return await _context.QueryAsync<ESysUserInfo>("select UserID,UserName,RealName,Pwd,Mobile,Wechat,OpenId,Dept,Position,Status from Sys_UserInfo");
        }

        public async Task<IEnumerable<ESysUserInfo>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param)
        {
            string sql = "select * from(select ROW_NUMBER() over(order by UserID desc)n,UserID,UserName,RealName,Pwd,Mobile,Wechat,OpenId,Dept,Position,Status from Sys_UserInfo where 1=1 {0} ) p where p.n>@p1 and p.n<=@p2";
            sql = string.Format(sql, sWhere);
            param.Add("p1", (PageIndex - 1) * PageSize);
            param.Add("p2", PageIndex * PageSize);
            return await _context.QueryAsync<ESysUserInfo>(sql, param);
        }

        public async Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param)
        {
            string sql = string.Format("select count(1) from Sys_UserInfo where 1=1 {0}", sWhere);
            return await _context.QueryFirstOrDefaultAsync<int>(sql, param);
        }

        public async Task<ESysUserInfo> GetByIDAsync(int UserID)
        {
            string sql = "select UserName,RealName,Pwd,Mobile,Wechat,OpenId,Dept,Position,Status from Sys_UserInfo where UserID=@UserID";
            return await _context.QueryFirstOrDefaultAsync<ESysUserInfo>(sql, new { UserID = UserID });
        }

        public async Task<bool> AddAsync(ESysUserInfo eSysUserInfo)
        {
            string sql = "insert into Sys_UserInfo(UserName,RealName,Pwd,Mobile,Wechat,OpenId,Dept,Position,Status) values(@UserName,@RealName,@Pwd,@Mobile,@Wechat,@OpenId,@Dept,@Position,@Status);select @@Identity;";
            return await _context.ExecuteAsync(sql, eSysUserInfo) > 0;
        }

        public async Task<bool> UpdateAsync(ESysUserInfo eSysUserInfo)
        {
            string sql = "update Sys_UserInfo set UserName=@UserName,RealName=@RealName,Pwd=@Pwd,Mobile=@Mobile,Wechat=@Wechat,OpenId=@OpenId,Dept=@Dept,Position=@Position,Status=@Status where UserID=@UserID;";
            return await _context.ExecuteAsync(sql, eSysUserInfo) > 0;
        }

        public async Task<bool> DeleteAsync(int UserID)
        {
            string sql = "delete from Sys_UserInfo where UserID=@UserID";
            return await _context.ExecuteAsync(sql, new { UserID = UserID }) > 0;
        }

        public async Task<bool> DeletesAsync(string UserIDs)
        {
            string sql = "delete from Sys_UserInfo where UserID in @IDs";
            return await _context.ExecuteAsync(sql, new { IDs = UserIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) }) > 0;
        }

        public (bool, ESysUserInfo) Login(string UserName, string Pwd)
        {
            string sql = "select UserID,UserName,Pwd,Mobile,OpenId,Status from Sys_UserInfo where UserName=@UserName and Pwd=@Pwd";
            ESysUserInfo user = _context.QueryFirstOrDefault<ESysUserInfo>(sql, new { UserName = UserName, Pwd = Pwd });
            return (user != null, user);
        }


    }

}
