using Data;
using Models;
using Models.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PostService
    {
        public bool UpdatePost(EditAPost model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var postToUpdate =
                    ctx
                        .Posts
                        .Single(e => e.PostId == model.PostId && e.UserId == _userId);

                postToUpdate.Title = model.Title;
                postToUpdate.Text = model.Text;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
