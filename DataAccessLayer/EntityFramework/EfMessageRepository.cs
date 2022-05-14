using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetItemMessageByWriter(int id)
        {
            using (var db = new Context())
            {
                return  db.Messages.Include(x => x.SenderUser).Where(x => x.MessageId == id).ToList();  
            }
        }

        public List<Message> GetListMessageByWriter(int id)
        {
            using(var c = new Context())
            {
                return c.Messages.Include(x => x.SenderUser).Where(x => x.ReceiverId == id).ToList();
            }
        }
    }
}
