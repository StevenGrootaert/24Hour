using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Models.Posts;

namespace Data
{
    public class CommentServices 
    {
        private readonly Guid _userId; // somthing seems weird here with the userId

        public CommentServices(Guid userId)
        {
            _userId = userId;
        }

        public bool MakeComment(PostCommentOnPost model)
        {
            var entity =
                new Comment()
                {
                    UserId = _userId,
                    CommentId = model.CommentId,
                    Text = model.Text,
                };
            using (var ctx = new ApplicationDbContext()) // should be fixed when identiy model is moved to data layer. 
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GetPostComments> GetPostComments() // should do this by post id?? 
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Comments
                    .Where(e => e.CommentId == e.PostId) // I think I'm finding the comments by postId? 
                    // comment author == user id
                    .Select(
                        e =>
                        new GetPostComments
                        {
                            PostId = e.PostId,
                            Title = e.Title
                        }
                );
                return query.ToArray();
            }
        }

        /*
        public GetCommentReplies GetCommentReplies(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Reply
                    .Single(e => e.)
            }
        }
        */

    }
}
