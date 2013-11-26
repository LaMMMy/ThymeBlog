﻿using System.Web.Mvc;
using Thyme.Web.Models;
using Thyme.Web.ViewModels;

namespace Thyme.Web.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            using (var repo = new BlogPostRepo())
            {
                return View("Front", new Front_vm { RecentBlogPosts = repo.ListRecentBlogPosts(Helpers.Config.NumPostsFrontPage) });
            }
        }

        public ActionResult ForceRepoRefresh()
        {
            var repo = new BlogPostRepo();
            repo.RefreshRepo();
            return RedirectToAction("Index");
        }

        public ActionResult ViewPost(string slug)
        {
            BlogPost bp;
            using (var repo = new BlogPostRepo())
            {
                bp = repo.GetPost(slug);
            }

            return View(new BlogPost_vm { BlogPost = bp });
        }

    }
}