using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
       // void CommentUpdate(Comment comment);
       //void CommentDelete(Comment comment);
        List<Comment> GetList(int id);
       //Comment GetById(int id);

    }
}
