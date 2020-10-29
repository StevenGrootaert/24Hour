using Data;
using Microsoft.AspNet.Identity;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [Authorize]
    public class CommentController : ApiController
    {
        private CommentServices CreateCommentServices()
        {
            var userId = Guid.Parse(User.Identity.GetUserId()); // shouldn't this be Post Id?? comments are being made to the post... 
            var commentServices = new CommentServices(userId);
            return commentServices;
        }


        //this method is still under review
        /*
        public IHttpActionResult GetAllComments()
        {
            CommentServices commentServices = CreateCommentServices();
            var comments = commentServices.GetPostComments(); 
            return Ok(comments);
        }
         */
    }
}
