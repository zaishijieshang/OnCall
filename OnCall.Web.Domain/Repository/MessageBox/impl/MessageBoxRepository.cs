using System;
using System.Collections.Generic;
using System.Text;

namespace OnCall.Web.Domain.Repository.MessageBox.impl
{
    using System.Threading.Tasks;
    using OnCall.Web.Domain.Infrastructure.DP;
    using OnCall.Web.Domain.Entity;
    public class MessageBoxRepository : IMessageBoxRepository
    {
        private readonly DapperDBContext _context;
        public MessageBoxRepository(DapperDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EMessageBox>> GetAllAsync()
        {
            return await _context.QueryAsync<EMessageBox>("select ID,Sender,SenderID,Receiver,ReceiverID,SendTime,CreateTime,Title,Content,Type,Status from MessageBox");
        }

        public async Task<IEnumerable<EMessageBox>> GetPageAsync(int PageIndex, int PageSize, string sWhere, Dapper.DynamicParameters param)
        {
            string sql = "select * from(select ROW_NUMBER() over(order by ID desc)n,ID,Sender,SenderID,Receiver,ReceiverID,SendTime,CreateTime,Title,Content,Type,Status from MessageBox where 1=1 {0} ) p where p.n>@p1 and p.n<=@p2";
            sql = string.Format(sql, sWhere);
            param.Add("p1", (PageIndex - 1) * PageSize);
            param.Add("p2", PageIndex * PageSize);
            return await _context.QueryAsync<EMessageBox>(sql, param);
        }

        public async Task<int> GetTotalCount(string sWhere, Dapper.DynamicParameters param)
        {
            string sql = string.Format("select count(1) from MessageBox where 1=1 {0}", sWhere);
            return await _context.QueryFirstOrDefaultAsync<int>(sql, param);
        }

        public async Task<EMessageBox> GetByIDAsync(int ID)
        {
            string sql = "select Sender,SenderID,Receiver,ReceiverID,SendTime,CreateTime,Title,Content,Type,Status from MessageBox where ID=@ID";
            return await _context.QueryFirstOrDefaultAsync<EMessageBox>(sql, new { ID = ID });
        }

        public async Task<bool> AddAsync(EMessageBox eMessageBox)
        {
            string sql = "insert into MessageBox(Sender,SenderID,Receiver,ReceiverID,SendTime,CreateTime,Title,Content,Type,Status) values(@Sender,@SenderID,@Receiver,@ReceiverID,@SendTime,@CreateTime,@Title,@Content,@Type,@Status);select @@Identity;";
            return await _context.ExecuteAsync(sql, eMessageBox) > 0;
        }

        public async Task<bool> UpdateAsync(EMessageBox eMessageBox)
        {
            string sql = "update MessageBox set Sender=@Sender,SenderID=@SenderID,Receiver=@Receiver,ReceiverID=@ReceiverID,SendTime=@SendTime,CreateTime=@CreateTime,Title=@Title,Content=@Content,Type=@Type,Status=@Status where ID=@ID;";
            return await _context.ExecuteAsync(sql, eMessageBox) > 0;
        }

        public async Task<bool> DeleteAsync(int ID)
        {
            string sql = "delete from MessageBox where ID=@ID";
            return await _context.ExecuteAsync(sql, new { ID = ID }) > 0;
        }

        public async Task<bool> DeletesAsync(string IDs)
        {
            string sql = "delete from MessageBox where ID in @IDs";
            return await _context.ExecuteAsync(sql, new { IDs = IDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries) }) > 0;
        }
    }


}
