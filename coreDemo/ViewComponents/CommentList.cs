using coreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName="Eren"
                },
                new UserComment {
                    ID = 2,
                    UserName="Murat"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Beliz"
                }
            };

            return View(commentvalues);
        }
    }
}
