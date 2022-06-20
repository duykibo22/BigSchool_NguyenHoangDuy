using BigSchool_NguyenHoangDuy.DTOs;
using BigSchool_NguyenHoangDuy.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BigSchool_NguyenHoangDuy.Controllers
{
    public class FollowingsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            using (var context = new ApplicationDbContext())
            {
                var userId = User.Identity.GetUserId();
                if (context.Followings.Any(p => p.FollowerId == userId && p.FollowerId == followingDto.FolloweeId))
                {
                    return BadRequest("Following already exists!");
                }
                else
                {
                    var following = new Following
                    {
                        FollowerId = userId,
                        FolloweeId = followingDto.FolloweeId
                    };
                    context.Followings.Add(following);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }
    }
}